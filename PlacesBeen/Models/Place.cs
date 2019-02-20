using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    private string _cityName;
    private string _duration;
    private string _companion;

    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName, string duration, string companion)
    {
      _cityName = cityName;
      _duration = duration;
      _companion = companion;
      _instances.Add(this);
    }
    public string GetCity()
    {
      return _cityName;
    }
    public void SetCity(string newCityName)
    {
      _cityName = newCityName;
    }
    public string GetDuration()
    {
      return _duration;
    }
    public void SetDuration(string newDuration)
    {
      _duration = newDuration;
    }
    public string GetCompanion()
    {
      return _companion;
    }
    public void SetCompanion(string newCompanion)
    {
      _companion = newCompanion;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
