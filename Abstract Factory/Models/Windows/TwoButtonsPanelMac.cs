namespace Abstract_Factory.Models.Windows;

public class TwoButtonsPanelMac : TwoButtonsPanel
{
    public TwoButtonsPanelMac(string leftButtonText, string rightButtonText) : base(leftButtonText, rightButtonText)
    {
    }

    public override void Close()
    {
        base.Close();
        Console.WriteLine("From Mac\n");
    }
}
