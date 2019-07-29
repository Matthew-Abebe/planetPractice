using System;
using System.Collections.Generic;

namespace planetsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> planetList = new List<string>() { "Mercury", "Venus" };

            List<string> lastPlanetList = new List<string>() { "Jupiter", "Saturn" }; // Added Jupiter and Saturn

            planetList.AddRange(lastPlanetList); // Added 'lastPlanetList' to end of List

            planetList.Add("Uranus"); // Added Uranus
            planetList.Add("Neptune"); // Added Neptune


            planetList.Insert( 2, "Earth" ); // Insert "Earth" to position 2
            planetList.Insert( 3, "Mars" ); // Insert "Mars" to position 3

            planetList.Add( "No." ); // Added Pluto ... not


             List<string> rockyPlanets = planetList.GetRange(0, 4); // Defined new list 'rockyPlanets' based off exisiting 'planetList'

             rockyPlanets.ForEach(roc => Console.WriteLine(roc)); // ForEach loop over 'rockyPlanets'

             planetList.RemoveAt( 8 ); // Removed planet at position 8

            planetList.ForEach(pla => Console.WriteLine(pla)); // ForEach loop over 'planetList'
        }

    }
}
