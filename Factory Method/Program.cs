// See https://aka.ms/new-console-template for more information
using Factory_Method.Models.Windows;
using Factory_Method.Services.WindowCreators;

WindowCreator wr = new ConfirmButtonWindowCreator();
IWindow window = wr.CreateWindow();

window.Show();
window.Close();