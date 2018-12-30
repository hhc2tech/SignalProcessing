using System;
using System.Collections.Generic;

namespace Generator
{
  public class WaveSetup
  {
    private double freq = 50;
    private int numberOfSamples = 256;
    private double maxTime = 1;
    private double magnitude = 1;

    public double Frequency { get => freq; set => freq = value; }
    public int NumberOfSamples { get => numberOfSamples; set => numberOfSamples = value; }
    public double MaxTime { get => maxTime; set => maxTime = value; }
    public double Magnitude { get => magnitude; set => magnitude = value; }
  }

  public class Waves
  {
    public static List<Tuple<double, double>> Generate(WaveSetup setup)
    {
      var result = new List<Tuple<double, double>>();

      for (int i = 0; i < setup.NumberOfSamples; i++)
      {
        var time = i * setup.MaxTime / setup.NumberOfSamples;
        var value = new Tuple<double, double>(time, setup.Magnitude* Math.Sin(2 * Math.PI * setup.Frequency * time));
        result.Add(value);
      }
      return result;
    }

    public static List<Tuple<double, double>> Generate(double freq = 50, double magnitude = 1, int numberOfSamples = 256, double maxTime = .1f)
    {
      var setup = new WaveSetup();
      setup.Frequency = freq;
      setup.NumberOfSamples = numberOfSamples;
      setup.MaxTime = maxTime;
      setup.Magnitude = magnitude;
      return Generate(setup);
    }
  }
}
