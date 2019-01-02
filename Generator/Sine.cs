using MathNet.Numerics.IntegralTransforms;
using System;
using System.Collections.Generic;

namespace Generator
{
  public class WaveSetup
  {
    private double freq = 50;
    private int numberOfSamples = 1000;
    private int sampleRate = 2000;
    private double maxTime = 1;
    private double amplitude = 1;

    public double Frequency { get => freq; set => freq = value; }
    public int NumberOfSamples { get => numberOfSamples; set => numberOfSamples = value; }
    public double MaxTime { get => maxTime; set => maxTime = value; }
    public double Amplitude { get => amplitude; set => amplitude = value; }
    public int SampleRate { get => sampleRate; set => sampleRate = value; }
  }

  public class Waves
  {
    /// <summary>Create a Sine wave.</summary>
    /// <param name="length">The number of samples to generate.</param>
    /// <param name="samplingRate">Samples per time unit (Hz). Must be larger than twice the frequency to satisfy the Nyquist criterion.</param>
    /// <param name="frequency">Frequency in periods per time unit (Hz).</param>
    /// <param name="amplitude">The maximal reached peak.</param>
    public static double[] Generate(int length, double samplingRate, double frequency, double amplitude)
    {
      if (length < 0)
        throw new ArgumentOutOfRangeException(nameof (length));

      double[] numArray = new double[length];

      double num = frequency / samplingRate * (2.0 * Math.PI);
      for (int index = 0; index < numArray.Length; ++index)
        numArray[index] =  amplitude * Math.Sin( (double) index * num);
      return numArray;
    }

    public static double[] Generate(WaveSetup setup)
    {
      var sin = Generate(setup.NumberOfSamples, setup.SampleRate, setup.Frequency, setup.Amplitude);
      return sin;
    }

    public static double[] GenerateByFourierLib(WaveSetup setup)
    {
      var sin = MathNet.Numerics.Generate.Sinusoidal(setup.NumberOfSamples, setup.SampleRate, setup.Frequency, setup.Amplitude);
      return sin;
    }

    
  }
}
