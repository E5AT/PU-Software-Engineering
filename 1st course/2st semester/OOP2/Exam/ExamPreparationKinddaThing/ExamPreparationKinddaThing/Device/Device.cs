using System;

namespace ExamPreparationKinddaThing.Device;

abstract class Device
{
    private string name;

    public string Name
    {
        get => name;
        set =>
            name =
                !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new Exception();
    }

    public bool isOn { get; set; }
    
    public Device(string name ,bool isOn) =>
        (Name, this.isOn) = (name, isOn);

    public virtual string GetInfo() =>
        $"{Name}, {(isOn? "ON":"OFF")}";

    public abstract string GetType();
}