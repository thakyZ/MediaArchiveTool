using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using NekoBoiNick.MediaArchiveTool.DataDomain;

namespace NekoBoiNick.MediaArchiveTool.DataDomain
{
  public class TagItem : ListItem
  {
    public TagItem(string name, string displayName) : base(name, displayName)
    {
    }
  }
}
