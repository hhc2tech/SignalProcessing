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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      this.chartWaves = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chartSplitContainer = new System.Windows.Forms.SplitContainer();
      this.chartFFTOutputs = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.waveSettingsControl = new SignalProcessingForms.WaveSettingsControl();
      ((System.ComponentModel.ISupportInitialize)(this.chartWaves)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartSplitContainer)).BeginInit();
      this.chartSplitContainer.Panel1.SuspendLayout();
      this.chartSplitContainer.Panel2.SuspendLayout();
      this.chartSplitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartFFTOutputs)).BeginInit();
      this.SuspendLayout();
      // 
      // chartWaves
      // 
      chartArea1.Name = "ChartArea1";
      this.chartWaves.ChartAreas.Add(chartArea1);
      this.chartWaves.DataSource = this.chartWaves.Series;
      this.chartWaves.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.Name = "Legend1";
      this.chartWaves.Legends.Add(legend1);
      this.chartWaves.Location = new System.Drawing.Point(0, 0);
      this.chartWaves.Name = "chartWaves";
      this.chartWaves.Size = new System.Drawing.Size(764, 271);
      this.chartWaves.TabIndex = 0;
      this.chartWaves.Text = "chart1";
      // 
      // chartSplitContainer
      // 
      this.chartSplitContainer.Location = new System.Drawing.Point(12, 12);
      this.chartSplitContainer.Name = "chartSplitContainer";
      this.chartSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // chartSplitContainer.Panel1
      // 
      this.chartSplitContainer.Panel1.Controls.Add(this.chartWaves);
      // 
      // chartSplitContainer.Panel2
      // 
      this.chartSplitContainer.Panel2.Controls.Add(this.chartFFTOutputs);
      this.chartSplitContainer.Size = new System.Drawing.Size(764, 554);
      this.chartSplitContainer.SplitterDistance = 271;
      this.chartSplitContainer.TabIndex = 2;
      // 
      // chartFFTOutputs
      // 
      chartArea2.Name = "ChartArea1";
      this.chartFFTOutputs.ChartAreas.Add(chartArea2);
      this.chartFFTOutputs.DataSource = this.chartFFTOutputs.Series;
      this.chartFFTOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
      legend2.Name = "Legend1";
      this.chartFFTOutputs.Legends.Add(legend2);
      this.chartFFTOutputs.Location = new System.Drawing.Point(0, 0);
      this.chartFFTOutputs.Name = "chartFFTOutputs";
      this.chartFFTOutputs.Size = new System.Drawing.Size(764, 279);
      this.chartFFTOutputs.TabIndex = 1;
      this.chartFFTOutputs.Text = "chart1";
      // 
      // waveSettingsControl
      // 
      this.waveSettingsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.waveSettingsControl.Location = new System.Drawing.Point(782, 12);
      this.waveSettingsControl.Name = "waveSettingsControl";
      this.waveSettingsControl.Size = new System.Drawing.Size(264, 257);
      this.waveSettingsControl.TabIndex = 1;
      // 
      // SignalProcessingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1041, 578);
      this.Controls.Add(this.chartSplitContainer);
      this.Controls.Add(this.waveSettingsControl);
      this.Name = "SignalProcessingForm";
      this.Text = "Signal Processing";
      ((System.ComponentModel.ISupportInitialize)(this.chartWaves)).EndInit();
      this.chartSplitContainer.Panel1.ResumeLayout(false);
      this.chartSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chartSplitContainer)).EndInit();
      this.chartSplitContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chartFFTOutputs)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chartWaves;
    private WaveSettingsControl waveSettingsControl;
    private System.Windows.Forms.SplitContainer chartSplitContainer;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartFFTOutputs;
  }
}

