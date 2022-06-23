using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Data;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;

namespace NekoBoiNick.MediaArchiveTool.DataDomain
{
  public class MainWindowViewModel : ViewModelBase
  {
    public MainWindowViewModel()
    {
      TypeItems = PresetTypes.GetPresetTypeList();

      _typeItemsView = CollectionViewSource.GetDefaultView(TypeItems);
      _typeItemsView.Filter = TypeItemsFilter;
    }

    public ObservableCollection<TypeItem> TypeItems { get; }
    public ObservableCollection<NotificationItem> NotificationItems { get; }

    private readonly ICollectionView _typeItemsView;
    private TypeItem? _selectedItem;
    private int _selectedIndex;
    private string? _searchKeyword;

    public string? SearchKeyword
    {
      get => _searchKeyword;
      set
      {
        if (SetProperty(ref _searchKeyword, value))
        {
          _typeItemsView.Refresh();
        }
      }
    }

    public TypeItem? SelectedItem
    {
      get => _selectedItem;
      set => SetProperty(ref _selectedItem, value);
    }

    public int SelectedIndex
    {
      get => _selectedIndex;
      set => SetProperty(ref _selectedIndex, value);
    }

    private bool TypeItemsFilter(object obj)
    {
      return string.IsNullOrWhiteSpace(_searchKeyword)
             || (obj is TypeItem item
             && item.DisplayName.ToLower().Contains(_searchKeyword!.ToLower()));
    }
  }
}
