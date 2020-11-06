namespace CultureExplorer20
{
  partial class ZoomForm
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
      this.ZoomText = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // ZoomText
      // 
      this.ZoomText.AutoSize = true;
      this.ZoomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ZoomText.Location = new System.Drawing.Point(12, 10);
      this.ZoomText.Name = "ZoomText";
      this.ZoomText.Size = new System.Drawing.Size(31, 44);
      this.ZoomText.TabIndex = 0;
      this.ZoomText.Text = ".";
      this.ZoomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ZoomForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.Info;
      this.ClientSize = new System.Drawing.Size(55, 63);
      this.ControlBox = false;
      this.Controls.Add(this.ZoomText);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "ZoomForm";
      this.Opacity = 0.8;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "ZoomForm";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label ZoomText;
  }
}