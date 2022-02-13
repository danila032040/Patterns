using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models.Windows;

public class OneButtonPanelMac : OneButtonPanel
{
    public OneButtonPanelMac(string buttonText) : base(buttonText)
    {
    }
    public override void Close()
    {
        base.Close();
        Console.WriteLine("From Mac\n");
    }
}
