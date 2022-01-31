using System.IO;
using Microsoft.Win32;
using Prism.Mvvm;

namespace M5SokubaiPosEditor;

public class MainModel : BindableBase
{
    private const string DialogFilter = "JavaScript Object Notation (.json)|*.json|すべてのファイル (*.*)|*.*";

    private readonly OpenFileDialog openFileDialog = new OpenFileDialog
    {
        Filter = DialogFilter,
        FilterIndex = 1
    };

    private readonly SaveFileDialog saveFileDialog = new SaveFileDialog
    {
        Filter = DialogFilter,
        FilterIndex = 1
    };

    private GoodsData? goodsData = new GoodsData();

    public GoodsData? GoodsData
    {
        get => goodsData;
        set => SetProperty(ref goodsData, value);
    }

    public async void OpenFile()
    {
        bool? dialogResult = openFileDialog.ShowDialog();

        if (dialogResult != true)
        {
            return;
        }

        using var sr = new StreamReader(openFileDialog.SafeFileName);
        
        string jsonText = await sr.ReadToEndAsync();
        GoodsData = GoodsData.Deserialize(jsonText);
    }

    public async void SaveFile()
    {
        if (GoodsData == null)
        {
            return;
        }
        
        bool? dialogResult = saveFileDialog.ShowDialog();

        if (dialogResult != true)
        {
            return;
        }

        await using var sw = new StreamWriter(saveFileDialog.SafeFileName);

        string jsonText = GoodsData!.Serialize();
        await sw.WriteAsync(jsonText);
    }
}