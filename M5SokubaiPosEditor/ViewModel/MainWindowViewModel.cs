using System.Reactive.Linq;
using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace M5SokubaiPosEditor;

public class MainWindowViewModel : BindableBase
{
    private static readonly MainModel mainModel;
    
    static MainWindowViewModel()
    {
        mainModel = new MainModel();
    }
    
    public ReactiveProperty<GoodsDataViewModel?> GoodsData { get; }

    public MainWindowViewModel()
    {
        GoodsData = mainModel.ObserveProperty(m => m.GoodsData).Select(data => new GoodsDataViewModel(data)).ToReactiveProperty();
    }
}