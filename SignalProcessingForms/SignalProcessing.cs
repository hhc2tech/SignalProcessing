using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SignalProcessingForms
{
  public partial class SignalProcessingForm : Form
  {
    public SignalProcessingForm()
    {
      InitializeComponent();

      waveSettingsControl.Generate += (object sender, EventArgs e) =>
      {
        var wave = Generator.Waves.Generate(waveSettingsControl.WaveSetup);

        var series = new Series("Series " + (chartWaves.Series.Count + 1));
        series.ChartType = SeriesChartType.Line;
        chartWaves.Series.Add(series);

        foreach (var value in wave)
        {
          chartWaves.Series[series.Name].Points.AddXY(value.Item1, value.Item2);
        }
      };

      waveSettingsControl.Clear += (object sender, EventArgs e) =>
      {
        chartWaves.Series.Clear();
      };
    }

  }
}
