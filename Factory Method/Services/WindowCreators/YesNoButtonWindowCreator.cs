using Factory_Method.Models.Windows;

namespace Factory_Method.Services.WindowCreators;

public class YesNoButtonWindowCreator : WindowCreator
{
    public override IWindow CreateWindow() => new YesNoWindow();
}
