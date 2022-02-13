using Abstract_Factory.Models.Windows;

namespace Abstract_Factory.Services.Factories;

internal interface IPanelsFactory
{
    OneButtonPanel CreateOneButtonPanel(string buttonText);
    TwoButtonsPanel CreateTwoButtonsPanel(string leftButtonText, string rightButtonText);
}
