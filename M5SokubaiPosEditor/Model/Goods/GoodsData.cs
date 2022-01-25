using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Prism.Mvvm;

namespace M5SokubaiPosEditor;

public class GoodsData : BindableBase
{
    [JsonProperty(PropertyName = "goods")]
    public ObservableCollection<GoodsItem> Goods { get; set; }

    public GoodsData()
    {
        Goods = new ObservableCollection<GoodsItem>();
    }

    public static GoodsData? Deserialize(string jsonString)
    {
        return JsonConvert.DeserializeObject<GoodsData>(jsonString);
    }

    public string Serialize()
    {
        return JsonConvert.SerializeObject(this);
    }
}