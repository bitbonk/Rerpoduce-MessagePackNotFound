using System.Windows;
using MessagePackNotFound.CommonLib;

namespace MessagePackNotFound.UserControlsLib;

public static class View
{
    public static void AddSomeView(Window parent)
    {
        parent.Content = new SomeView
        {
            DataContext = new SomeViewModel()
        };
    }
}