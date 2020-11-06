using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CultureExplorer20
{
  public partial class ZoomForm : Form
  {
    public ZoomForm(Control parentControl, string text)
    {
      InitializeComponent();
      this.BackColor       = parentControl.BackColor;
      this.ForeColor       = parentControl.ForeColor;
      ZoomText.Text        = text;
      ZoomText.RightToLeft = (null == parentControl) ? RightToLeft.No : parentControl.RightToLeft;
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
      // paint 1 pixel width border around the control
      e.Graphics.DrawRectangle(SystemPens.ActiveBorder, new Rectangle(this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1));
    }
  }
}