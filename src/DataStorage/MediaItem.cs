using System;
using System.Collections.Generic;
using System.Text;

namespace NekoBoiNick.MediaArchiveTool.DataStorage
{
  public enum MediaType {
    file,
    image,
    video,
    gif
  }

  public class MediaItem
  {
    public long ID
    {
      get;
      set;
    }

    public MediaType MediaType
    {
      get;
      set;
    }
    public string FileName
    {
      get;
      set;
    }

    public string FileData
    {
      get;
      set;
    }

    public DateTime LastModified
    {
      get;
      set;
    }

    public DateTime FirstAdded
    {
      get;
      set;
    }

    public List<String> Tags
    {
      get;
      set;
    }
  }
}
