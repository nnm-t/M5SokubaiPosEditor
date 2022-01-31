using Reactive.Bindings;

namespace M5SokubaiPosEditor;

public class GoodsDataViewModel
{
    public ReadOnlyReactiveCollection<GoodsItemViewModel> Goods { get; }

    public GoodsDataViewModel(GoodsData goodsData)
    {
        Goods = goodsData.Goods.ToReadOnlyReactiveCollection(item => new GoodsItemViewModel(item));
    }
}