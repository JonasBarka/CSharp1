﻿namespace MinaPrylar;

public class Car
{
    private string _brand;
    private string _color;
    public Car(string brand, string color)
    {
        _brand = brand;
        _color = color;
    }
    public string GetBrand() => _brand;
    public string GetColor() => _color;
}