using System.Reactive.Linq;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace M5SokubaiPosEditor;

public class GoodsDataViewModel
{
    public ReadOnlyReactiveCollection<GoodsItemViewModel> Goods { get; }

    public GoodsDataViewModel(GoodsData goodsData)
    {
        Goods = goodsData.Goods.ToReadOnlyReactiveCollection(item => new GoodsItemViewModel(item));
    }
}