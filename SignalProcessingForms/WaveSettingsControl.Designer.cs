﻿namespace SignalProcessingForms
{
  partial class WaveSettingsControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.generateBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.freqEditor = new System.Windows.Forms.NumericUpDown();
      this.clearBtn = new System.Windows.Forms.Button();
      this.amplitudeEditor = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.maxTimeEditor = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.samplesNumberEditor = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.sampleRateEditor = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.freqEditor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.amplitudeEditor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.maxTimeEditor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.samplesNumberEditor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sampleRateEditor)).BeginInit();
      this.SuspendLayout();
      // 
      // generateBtn
      // 
      this.generateBtn.Location = new System.Drawing.Point(134, 229);
      this.generateBtn.Name = "generateBtn";
      this.generateBtn.Size = new System.Drawing.Size(75, 23);
      this.generateBtn.TabIndex = 0;
      this.generateBtn.Text = "Generate";
      this.generateBtn.UseVisualStyleBackColor = true;
      this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(97, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Freq:";
      // 
      // freqEditor
      // 
      this.freqEditor.Location = new System.Drawing.Point(128, 22);
      this.freqEditor.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.freqEditor.Name = "freqEditor";
      this.freqEditor.Size = new System.Drawing.Size(120, 20);
      this.freqEditor.TabIndex = 2;
      this.freqEditor.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
      // 
      // clearBtn
      // 
      this.clearBtn.Location = new System.Drawing.Point(53, 229);
      this.clearBtn.Name = "clearBtn";
      this.clearBtn.Size = new System.Drawing.Size(75, 23);
      this.clearBtn.TabIndex = 3;
      this.clearBtn.Text = "Clear";
      this.clearBtn.UseVisualStyleBackColor = true;
      this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
      // 
      // magnitudeEditor
      // 
      this.amplitudeEditor.Location = new System.Drawing.Point(128, 59);
      this.amplitudeEditor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.amplitudeEditor.Name = "magnitudeEditor";
      this.amplitudeEditor.Size = new System.Drawing.Size(120, 20);
      this.amplitudeEditor.TabIndex = 5;
      this.amplitudeEditor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(68, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Amplitude:";
      // 
      // maxTimeEditor
      // 
      this.maxTimeEditor.Location = new System.Drawing.Point(126, 164);
      this.maxTimeEditor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.maxTimeEditor.Name = "maxTimeEditor";
      this.maxTimeEditor.Size = new System.Drawing.Size(120, 20);
      this.maxTimeEditor.TabIndex = 7;
      this.maxTimeEditor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.maxTimeEditor.Visible = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(50, 166);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Max Time [ms]:";
      this.label3.Visible = false;
      // 
      // samplesNumberEditor
      // 
      this.samplesNumberEditor.Location = new System.Drawing.Point(127, 93);
      this.samplesNumberEditor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.samplesNumberEditor.Name = "samplesNumberEditor";
      this.samplesNumberEditor.Size = new System.Drawing.Size(120, 20);
      this.samplesNumberEditor.TabIndex = 9;
      this.samplesNumberEditor.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 95);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Samples Number:";
      // 
      // sampleRateEditor
      // 
      this.sampleRateEditor.Location = new System.Drawing.Point(126, 127);
      this.sampleRateEditor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.sampleRateEditor.Name = "sampleRateEditor";
      this.sampleRateEditor.Size = new System.Drawing.Size(120, 20);
      this.sampleRateEditor.TabIndex = 11;
      this.sampleRateEditor.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(35, 129);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(79, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Sampling Rate:";
      // 
      // WaveSettingsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.sampleRateEditor);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.samplesNumberEditor);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.maxTimeEditor);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.amplitudeEditor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.clearBtn);
      this.Controls.Add(this.freqEditor);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.generateBtn);
      this.Name = "WaveSettingsControl";
      this.Size = new System.Drawing.Size(276, 257);
      ((System.ComponentModel.ISupportInitialize)(this.freqEditor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.amplitudeEditor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.maxTimeEditor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.samplesNumberEditor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sampleRateEditor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button generateBtn;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown freqEditor;
    private System.Windows.Forms.Button clearBtn;
    private System.Windows.Forms.NumericUpDown amplitudeEditor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown maxTimeEditor;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown samplesNumberEditor;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown sampleRateEditor;
    private System.Windows.Forms.Label label5;
  }
}
