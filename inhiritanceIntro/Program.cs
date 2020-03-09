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

            var myRam = new Ram ();
            var myCessna = new Cessna ();

            myBike.Drive ();
            myTesla.Drive ();
            myRam.Drive ();
            myCessna.Drive ();
        }
    }
}