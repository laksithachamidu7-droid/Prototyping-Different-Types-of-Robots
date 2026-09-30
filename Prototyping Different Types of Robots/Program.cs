using System;

public abstract class Robot
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }

    public abstract Robot Clone();

    public void Display()
    {
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
        Console.WriteLine("Software Version: " + SoftwareVersion);
    }
}

public class ServiceRobot : Robot
{
    public string ServiceTask { get; set; }

    public override Robot Clone()
    {
        return (ServiceRobot)this.MemberwiseClone();
    }
}

public class IndustrialRobot : Robot
{
    public string IndustrialTask { get; set; }

    public override Robot Clone()
    {
        return (IndustrialRobot)this.MemberwiseClone();
    }
}

public class EntertainmentRobot : Robot
{
    public string EntertainmentFeature { get; set; }

    public override Robot Clone()
    {
        return (EntertainmentRobot)this.MemberwiseClone();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ServiceRobot serviceRobot = new ServiceRobot
        {
            ModelName = "ServiceBot X1",
            BatteryCapacity = 10,
            SoftwareVersion = "1.0",
            ServiceTask = "Healthcare Assistance"
        };

        ServiceRobot clonedServiceRobot = (ServiceRobot)serviceRobot.Clone();
        clonedServiceRobot.BatteryCapacity = 12;
        clonedServiceRobot.SoftwareVersion = "1.1";

        Console.WriteLine("Service Robot");
        clonedServiceRobot.Display();
        Console.WriteLine("Task: " + clonedServiceRobot.ServiceTask);
        Console.WriteLine();

        IndustrialRobot industrialRobot = new IndustrialRobot
        {
            ModelName = "IndustrialBot X2",
            BatteryCapacity = 15,
            SoftwareVersion = "2.0",
            IndustrialTask = "Welding"
        };

        IndustrialRobot clonedIndustrialRobot = (IndustrialRobot)industrialRobot.Clone();
        clonedIndustrialRobot.BatteryCapacity = 18;
        clonedIndustrialRobot.SoftwareVersion = "2.1";

        Console.WriteLine("Industrial Robot");
        clonedIndustrialRobot.Display();
        Console.WriteLine("Task: " + clonedIndustrialRobot.IndustrialTask);
        Console.WriteLine();

        EntertainmentRobot entertainmentRobot = new EntertainmentRobot
        {
            ModelName = "EntertainmentBot X3",
            BatteryCapacity = 8,
            SoftwareVersion = "3.0",
            EntertainmentFeature = "Interactive Dancing"
        };

        EntertainmentRobot clonedEntertainmentRobot = (EntertainmentRobot)entertainmentRobot.Clone();
        clonedEntertainmentRobot.BatteryCapacity = 10;
        clonedEntertainmentRobot.SoftwareVersion = "3.1";

        Console.WriteLine("Entertainment Robot");
        clonedEntertainmentRobot.Display();
        Console.WriteLine("Feature: " + clonedEntertainmentRobot.EntertainmentFeature);
    }
}