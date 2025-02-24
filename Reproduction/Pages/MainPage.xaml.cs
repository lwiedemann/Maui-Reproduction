﻿using Reproduction.Pages;

namespace Reproduction;

public partial class MainPage
{
    private int _count;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;

        CounterBtn.Text = _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
        
        Navigation.PushAsync(new ReproductionPage(), true);
    }
}