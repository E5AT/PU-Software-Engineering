using System;

namespace ExamPreparationKinddaThing.Device;

class Lamp : Device
{
    private string color;

    public string Color
    {
        get => color;
        set =>
            color =
                string.IsNullOrEmpty(value)
                    ? value
                    : throw new Exception();
    }
    
    public Lamp(string name,bool isOn, string color)
        : base(name, isOn)
            => Color = color;

    public override string GetInfo() =>
        $"{base.GetInfo()}, {Color}";

    public override string GetType() =>
        "Lamp";
}