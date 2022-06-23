using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace NekoBoiNick.MediaArchiveTool.DataStorage
{
  public class Tools
  {
    static async Task GenerateTable()
    {
      var connection = new SqliteConnection("Data Source=MediaData.db");
      connection.Open();

      var createCommand = connection.CreateCommand();
      createCommand.CommandText =
      @"CREATE TABLE data (
          'id' INTEGER,
	         'mediaType' TEXT NOT NULL DEFAULT 'file' CHECK(mediaType IN('file', 'image', 'video', 'gif')) COLLATE NOCASE,
          'fileName' TEXT NOT NULL DEFAULT 'unknown',
          'fileData' BLOB DEFAULT NULL COLLATE BINARY,
          'lastModified' NUMERIC DEFAULT 0,
          'firstAdded' NUMERIC DEFAULT 0,
          'tags' INTEGER DEFAULT NULL,
          PRIMARY KEY('ID' AUTOINCREMENT)
          FOREIGN KEY('tags') REFERENCES _tags('id')
        );
        CREATE TABLE _tags (
          'id' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
          'name' TEXT
        );
      ";
      createCommand.ExecuteNonQuery();
    }
  }
}
