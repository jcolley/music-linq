using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            // //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // var results = from Artist in Artists where Artist.Hometown.Contains("Mount Vernon") select Artist;
            // foreach(var artist in results){
            //     Console.WriteLine(artist.ArtistName);
            // }

            // //Who is the youngest artist in our collection of artists?
            // var youngest = Artists.OrderBy(x => x.Age).FirstOrDefault();
            // System.Console.WriteLine(youngest.ArtistName+" Age:"+ youngest.Age);

            // //Display all artists with 'William' somewhere in their real name
            // var people = from Artist in Artists where Artist.RealName.Contains("William") select Artist;
            // foreach(var artist in people){
            //     Console.WriteLine(artist.ArtistName);
            // }

            //Display all groups with names less than 8 characters in length
            // var shortNames = from Artist in Artists where Artist.ArtistName.Length < 8 select Artist;
            // foreach(var artist in shortNames){
            //     Console.WriteLine(artist.ArtistName);
            // }

            //Display the 3 oldest artist from Atlanta
            var oldestArtists = Artists.OrderByDescending(x => x.Age).Take(3);
            foreach(var artist in oldestArtists){
                Console.WriteLine(artist.ArtistName+" Age:"+ artist.Age);
            }
        }
    }
}
