using Factory_Method.Models.Windows;

namespace Factory_Method.Services.WindowCreators;

public abstract class WindowCreator
{
    public abstract IWindow CreateWindow();
}
