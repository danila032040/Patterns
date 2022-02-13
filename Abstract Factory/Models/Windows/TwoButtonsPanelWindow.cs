namespace Abstract_Factory.Models.Windows;

public class TwoButtonsPanelWindow : TwoButtonsPanel
{
    public TwoButtonsPanelWindow(string leftButtonText, string rightButtonText) : base(leftButtonText, rightButtonText)
    {
    }

    public override void Close()
    {
        base.Close();
        Console.WriteLine("From Window\n");
    }
}
