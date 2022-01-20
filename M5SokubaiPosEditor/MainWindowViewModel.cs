using Prism.Mvvm;

namespace M5SokubaiPosEditor;

public class MainWindowViewModel : BindableBase
{
    private static MainModel mainModel;
    
    static MainWindowViewModel()
    {
        mainModel = new MainModel();
    }
}