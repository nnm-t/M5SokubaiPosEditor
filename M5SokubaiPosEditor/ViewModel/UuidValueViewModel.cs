using Prism.Mvvm;
using Reactive.Bindings;

namespace M5SokubaiPosEditor;

public class UuidValueViewModel : BindableBase
{
    public ReactiveProperty<byte> Value { get; }
    
    public UuidValueViewModel(byte value)
    {
        Value = new ReactiveProperty<byte>(value);
    }
}