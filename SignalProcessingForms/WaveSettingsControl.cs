using Generator;
using System;
using System.Windows.Forms;

namespace SignalProcessingForms
{
  public partial class WaveSettingsControl : UserControl
  {
    public event EventHandler<GenericEventArgs<WaveSetup>> Generate;
    public event EventHandler Clear;

    public WaveSetup WaveSetup { get; private set; }

    public WaveSettingsControl()
    {
      InitializeComponent();

      this.WaveSetup = new WaveSetup();
    }

    private void generateBtn_Click(object sender, EventArgs e)
    {
      if (Generate != null)
      {
        this.WaveSetup.Frequency = (double)this.freqEditor.Value;
        this.WaveSetup.Amplitude = (double)this.amplitudeEditor.Value;
        this.WaveSetup.NumberOfSamples = (int)this.samplesNumberEditor.Value;
        this.WaveSetup.SampleRate = (int)this.sampleRateEditor.Value;
        this.WaveSetup.MaxTime = (double)this.maxTimeEditor.Value/1000;

        Generate(this, new GenericEventArgs<WaveSetup>(WaveSetup));
      }
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      if (Clear != null)
        Clear(this, EventArgs.Empty);
    }
  }
}
