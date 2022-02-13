using Abstract_Factory.Models.Windows;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Services.Factories;

internal class MacPanelsFactory : IPanelsFactory
{
    public OneButtonPanel CreateOneButtonPanel(string buttonText) => new OneButtonPanelMac(buttonText);

    public TwoButtonsPanel CreateTwoButtonsPanel(string leftButtonText, string rightButtonText) => new TwoButtonsPanelMac(leftButtonText, rightButtonText);
}
