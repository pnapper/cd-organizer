using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Album
  {
    private string _title;
    private int _id;
    private static List<Album> _instances = new List<Album> {};

    public Album(string title)
    {
      _title = title;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Album> GetAll()
    {
      return _instances;
    }
    public static Album Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
