﻿using System;

namespace PropertyFinder.Presenter
{
  public class SearchTextChangedEventArgs : EventArgs
  {
    public string Text { get; private set; }

    public SearchTextChangedEventArgs(string text)
    {
      Text = text;
    }
  }
}
