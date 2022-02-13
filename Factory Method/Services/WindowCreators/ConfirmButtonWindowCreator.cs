using Factory_Method.Models.Windows;

namespace Factory_Method.Services.WindowCreators;

public class ConfirmButtonWindowCreator : WindowCreator
{
    public override IWindow CreateWindow() => new OneButtonWindow("confirm");
}
