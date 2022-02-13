namespace Abstract_Factory.Models.Windows;

public abstract class TwoButtonsPanel : IPanel
{
    private string _leftButtonText;
    private string _rightButtonText;

    protected TwoButtonsPanel(string leftButtonText, string rightButtonText)
    {
        _leftButtonText = leftButtonText;
        _rightButtonText = rightButtonText;
    }

    public virtual void Close()
    {
        Console.WriteLine($"{_leftButtonText}{_rightButtonText}ButtonsWindow closed");
    }

    public virtual void Show()
    {
        Console.WriteLine($"{_leftButtonText}{_rightButtonText}ButtonsWindow showed");
    }
}
