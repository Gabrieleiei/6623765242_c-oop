using System;

namespace MauiAppCSharpBasic.Classes;

public class Car
{
    public string Model ;
    public string Color;
    public double Speed;
    public double Fuel;
    public double TotalMile;
    public double UseFuelRate; // xxx liter per mile

    public Car(string model, double speed , double fuel )
    {
        this.Model = model;
        this.Speed = speed;
        this.Fuel = fuel;
        this.TotalMile = 0; // กำหนดค่าเริ่มต้น
        this.UseFuelRate = 0; // กำหนดค่าเริ่มต้น
    }



    public void Run(double mile)
    {
        //this.TotalDistance = this.TotalMile+mile;
        this.TotalMile += mile; //เพิ่มระยะทาง
        var use_fuel_liter = mile * this.UseFuelRate ; //คำนวณเชื้อเพลิงที่ใช้
        this.Fuel = this.Fuel -= use_fuel_liter; //ลดเชื้อเพลิง
    }

    public uint TimeUseForRun(double mile)
    {
        var timeuse = mile/Speed;
        this.Run(mile);
        return Convert.ToUInt32(timeuse);
    }

    public string ShowInfo()
    {
        var info = $"MOdel :{ this.Model } \nTotal Mile:{ this.TotalMile } \nfuel : { this.Fuel }";
        return info;
    }
}