using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesBeen.Models;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_True()
    {
      Place newPlace = new Place("Miami");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCity_ReturnsCity_String()
    {
      string city = "Miami";
      Place newPlace = new Place(city);
      string result = newPlace.GetCity();
      Assert.AreEqual(city, result);
    }

    [TestMethod]
    public void SetCity_SetsCity_String()
    {
      string city = "Miami";
      Place newPlace = new Place(city);
      string updatedCity = "Juneau";
      newPlace.SetCity(updatedCity);
      string result = newPlace.GetCity();
      Assert.AreEqual(updatedCity, result);
    }

    [TestMethod]
    public void GetAll_ReturnsList_PlaceList()
    {
      string city1 = "Miami";
      string city2 = "Juneau";
      Place newPlace1 = new Place(city1);
      Place newPlace2 = new Place(city2);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
