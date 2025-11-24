using MessagePackNotFound.UserControlsLib;

namespace MessagePackNotFound.App;


public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Use some stuff from the UserControlsLib (which also does MessagePack serialization)
        View.AddSomeView(this);
    }
}