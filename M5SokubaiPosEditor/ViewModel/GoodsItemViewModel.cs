using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace M5SokubaiPosEditor;

public class GoodsItemViewModel : BindableBase
{
    public ReactiveProperty<string?> Name { get; }
    public ReactiveProperty<string?> ImagePath { get; }
    public ReactiveProperty<int> Price { get; }
    public ReadOnlyReactiveCollection<UuidValueViewModel> Uuid { get; }

    public GoodsItemViewModel(GoodsItem goodsItem)
    {
        Name = goodsItem.ObserveProperty(item => item.Name).ToReactiveProperty();
        ImagePath = goodsItem.ObserveProperty(item => item.ImagePath).ToReactiveProperty();
        Price = goodsItem.ObserveProperty(item => item.Price).ToReactiveProperty();
        Uuid = goodsItem.Uuid.ToReadOnlyReactiveCollection(item =>
            new UuidValueViewModel(item));
    }
}