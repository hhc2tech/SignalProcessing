﻿using Generator;
using System;
using System.Windows.Forms;

namespace SignalProcessingForms
{
  public partial class WaveSettingsControl : UserControl
  {
    public event EventHandler Generate;
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
        this.WaveSetup.Magnitude = (double)this.magnitudeEditor.Value;
        this.WaveSetup.NumberOfSamples = (int)this.samplesNumberEditor.Value;
        this.WaveSetup.MaxTime = (double)this.maxTimeEditor.Value/1000;

        Generate(this, EventArgs.Empty);
      }
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      if (Clear != null)
        Clear(this, EventArgs.Empty);
    }
  }
}
