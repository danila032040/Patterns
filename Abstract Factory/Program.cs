// See https://aka.ms/new-console-template for more information
using Abstract_Factory.Models.Windows;
using Abstract_Factory.Services.Factories;

Console.WriteLine("Hello, World!");

IPanelsFactory macF = new MacPanelsFactory();
IPanelsFactory windowF = new WindowPanelsFactory();

IPanel macOne = macF.CreateOneButtonPanel("One");
IPanel macTwo = macF.CreateTwoButtonsPanel("One", "Two");

IPanel windowOne = windowF.CreateOneButtonPanel("One");
IPanel windowTwo = windowF.CreateTwoButtonsPanel("One", "Two");

macOne.Show();
macOne.Close();

macTwo.Close();

windowOne.Close();
windowTwo.Close();