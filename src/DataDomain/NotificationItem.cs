using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using NekoBoiNick.MediaArchiveTool.DataDomain;

namespace NekoBoiNick.MediaArchiveTool.DataDomain
{
  public enum NotificationType
  {
    Critical,
    Error,
    Warning,
    Info,
    Debug,
    Trace
  }

  public class NotificationItem : INotifyPropertyChanged
  {
    private NotificationType _type;
    private string _text;

    public NotificationItem(NotificationType type, string text)
    {
      _type = type;
      Text  = text;
    }

    public NotificationType Type
    {
      get { return _type; }
      set
      {
        _type = value;
        OnPropertyChanged();
      }
    }

    public string Text
    {
      get { return _text; }
      set
      {
        _text = value;
        OnPropertyChanged();
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
