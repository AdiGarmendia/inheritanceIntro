using System;

namespace inhiritanceIntro {
    class Program {
        static void Main (string[] args) {
            var myBike = new Zero ();

            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;

            var myTesla = new Tesla ();
            myTesla.MainColor = "Silver";
            myTesla.MaxOccupancy = 6;
        }
    }
}