//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using System;

namespace Challenges
{
    public class Program22
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Usu� nieu�ywany parametr", Justification = "�adne prze�adowanie metody �FootballPoints� nie pobiera nast�puj�cej liczby argument�w: 3")]
        public static int FootballPoints(int wins, int draws, int losses) => wins * 3 + draws;
    }
}