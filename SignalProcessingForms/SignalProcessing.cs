using Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SignalProcessingForms
{
  public partial class SignalProcessingForm : Form
  {
    int maxFreq = 0;

    public SignalProcessingForm()
    {
      InitializeComponent();

      waveSettingsControl.Generate += (object sender, GenericEventArgs<Generator.WaveSetup> e) =>
      {
        var wave = Waves.Generate(e.Parameter);
        if (maxFreq < e.Parameter.Frequency)
          maxFreq = (int)e.Parameter.Frequency;


        BindWaves(wave, e.Parameter);
        BindFFTOutput(wave, e.Parameter);
      };

      waveSettingsControl.Clear += (object sender, EventArgs e) =>
      {
        chartWaves.Series.Clear();
        chartFFTOutputs.Series.Clear();
        maxFreq = 0;
      };
    }

    private void BindWaves(List<Tuple<double, double>> wave, Generator.WaveSetup setup)
    {
      var series = new Series("Series " + (chartWaves.Series.Count + 1));
      series.ChartType = SeriesChartType.Line;
      chartWaves.Series.Add(series);

      for(var i=0; i <wave.Count/5; i++)// Count/5 draw only part
      {
        var time = 1.0 / setup.SampleRate * i;
        chartWaves.Series[series.Name].Points.AddXY(time, wave[i].Item2);
      }
    }

    private void BindFFTOutput(List<Tuple<double, double>> wave, Generator.WaveSetup setup)
    {
      var fftResult = FourierCalculator.Forward(wave);

      var series = new Series("Freq " + (chartFFTOutputs.Series.Count + 1));
      //series.ChartType = SeriesChartType.Line;
      chartFFTOutputs.Series.Add(series);
      var numSample = fftResult.Count;

      for (int i=0; i<= maxFreq+1; i++)// 
      {
        var val = fftResult[i];
        var powR = Math.Pow(val.Item1, 2);
        var powI = Math.Pow(val.Item2, 2);
        var abs = Math.Abs(Math.Sqrt(powR + powI));
        double mag = (2.0 / numSample) * abs;

        double hzInSample = setup.SampleRate / numSample;
        chartFFTOutputs.Series[series.Name].Points.AddXY(i* hzInSample, mag);
      }
    }
  }
}
