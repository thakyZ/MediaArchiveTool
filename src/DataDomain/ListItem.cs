using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace NekoBoiNick.MediaArchiveTool.DataDomain
{
  public class ListItem : ViewModelBase
  {
    private string _name;
    private string _displayName;
    private ScrollBarVisibility _horizontalScrollBarVisibilityRequirement;
    private ScrollBarVisibility _verticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto;
    private Thickness _marginRequirement = new Thickness(16);

    public ListItem(string name, string displayName)
    {
      _name = name;
      _displayName = displayName;
    }

    public string Name { get { return _name; } }

    public string DisplayName
    {
      get { return _displayName; }
      set { SetProperty(ref _displayName, value); }
    }

    public ScrollBarVisibility HorizontalScrollBarVisibilityRequirement
    {
      get { return _horizontalScrollBarVisibilityRequirement; }
      set { SetProperty(ref _horizontalScrollBarVisibilityRequirement, value); }
    }

    public ScrollBarVisibility VerticalScrollBarVisibilityRequirement
    {
      get { return _verticalScrollBarVisibilityRequirement; }
      set { SetProperty(ref _verticalScrollBarVisibilityRequirement, value); }
    }

    public Thickness MarginRequirement
    {
      get { return _marginRequirement; }
      set { SetProperty(ref _marginRequirement, value); }
    }
  }
}
