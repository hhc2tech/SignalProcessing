using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System;
using System.Collections.Generic;

namespace Generator
{
  public class FourierCalculator
  {
    public static List<Tuple<double, double>> Forward(List<Tuple<double, double>> values)
    {
      Complex32[] samples = new Complex32[values.Count];
      for (int i = 0; i< values.Count; i++)
      {
        samples[i] = new Complex32((float)values[i].Item2, 0);
      }

      Fourier.Forward(samples, FourierOptions.NoScaling);

      List<Tuple<double, double>> res = new List<Tuple<double, double>>();
      for (int i = 0; i < samples.Length; i++)
      {
        var value = new Tuple<double, double>((double)samples[i].Real, (double)samples[i].Imaginary);
        res.Add(value);
      }

      return res;

    }
  }
}
