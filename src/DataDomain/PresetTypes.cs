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
  public static class PresetTypes
  {
    public static ObservableCollection<TypeItem> GetPresetTypeList()
    {
      return new ObservableCollection<TypeItem>(new[]
      {
        new TypeItem("file", "Files"),
        new TypeItem("image", "Images"),
        new TypeItem("video", "Videos"),
        new TypeItem("gif", "Gifs")
      });
    }
  }
}
