using System;

namespace ExamPreparationKinddaThing.Device;

 class Thermostat : Device
 {
     private double temperature;

     public double Temperature
     {
         get => temperature;
         set =>
             temperature = 
                value is > -100 and < 100
                 ? value
                 : throw new Exception();
     }
     
     public Thermostat(string name, bool isOn, double temperature)
         : base(name, isOn)
             => Temperature = temperature;
     
     public override string ToString()
        => $"{base.ToString()}, {Temperature}";

     public override string GetType()
         => "Thermostat";
 }