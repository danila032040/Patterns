using Abstract_Factory.Models.Windows;

namespace Abstract_Factory.Services.Factories;

public class WindowPanelsFactory : IPanelsFactory
{
    public OneButtonPanel CreateOneButtonPanel(string buttonText) => 
        new OneButtonPanelWindow(buttonText);

    public TwoButtonsPanel CreateTwoButtonsPanel(string leftButtonText, string rightButtonText) => 
        new TwoButtonsPanelWindow(leftButtonText, rightButtonText);
}
