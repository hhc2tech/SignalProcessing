namespace SignalProcessingForms
{
  partial class SignalProcessingForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      this.chartWaves = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.waveSettingsControl = new SignalProcessingForms.WaveSettingsControl();
      ((System.ComponentModel.ISupportInitialize)(this.chartWaves)).BeginInit();
      this.SuspendLayout();
      // 
      // chartWaves
      // 
      this.chartWaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      chartArea2.Name = "ChartArea1";
      this.chartWaves.ChartAreas.Add(chartArea2);
      this.chartWaves.DataSource = this.chartWaves.Series;
      legend2.Name = "Legend1";
      this.chartWaves.Legends.Add(legend2);
      this.chartWaves.Location = new System.Drawing.Point(-2, -1);
      this.chartWaves.Name = "chartWaves";
      this.chartWaves.Size = new System.Drawing.Size(765, 313);
      this.chartWaves.TabIndex = 0;
      this.chartWaves.Text = "chart1";
      // 
      // waveSettingsControl
      // 
      this.waveSettingsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.waveSettingsControl.Location = new System.Drawing.Point(770, 1);
      this.waveSettingsControl.Name = "waveSettingsControl";
      this.waveSettingsControl.Size = new System.Drawing.Size(264, 257);
      this.waveSettingsControl.TabIndex = 1;
      // 
      // SignalProcessingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1041, 480);
      this.Controls.Add(this.waveSettingsControl);
      this.Controls.Add(this.chartWaves);
      this.Name = "SignalProcessingForm";
      this.Text = "Signal Processing";
      ((System.ComponentModel.ISupportInitialize)(this.chartWaves)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chartWaves;
    private WaveSettingsControl waveSettingsControl;
  }
}

