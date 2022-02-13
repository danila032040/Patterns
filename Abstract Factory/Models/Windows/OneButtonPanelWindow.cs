using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models.Windows;

public class OneButtonPanelWindow : OneButtonPanel
{
    public OneButtonPanelWindow(string buttonText) : base(buttonText)
    {
    }

    public override void Close()
    {
        base.Close();
        Console.WriteLine("From Window\n");
    }
}
