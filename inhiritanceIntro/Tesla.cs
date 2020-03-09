using System;

namespace inhiritanceIntro {
  public class Tesla : Vehicle { // Electric car
    public double BatteryKWh { get; set; }
    public void ChargeBattery () { }

    public override void Drive () {
      Console.WriteLine ("Pew Pew!");
    }
  }
}