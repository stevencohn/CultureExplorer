using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace CultureExplorer20
{
  public class CultureExplorerLabel : Label
  {
    private ZoomForm zoomForm;
    
    public CultureExplorerLabel()
    {
      this.Cursor = Cursors.Hand;
      zoomForm    = null;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);

      if (MouseButtons.Left == e.Button)
      {
        try
        {
          zoomForm = new ZoomForm(this, this.Text);
          zoomForm.Show(this);
          zoomForm.Location = ComputeZoomLocation(zoomForm.Size);
        }
        catch
        {
          zoomForm = null;
        }
      }
      else if (MouseButtons.Right == e.Button)
      {
        ContextMenuStrip menuStrip = new ContextMenuStrip();
        menuStrip.Items.Add(Properties.Resources.CopyMenu, null, OnCopyMenuClick);
        this.ContextMenuStrip = menuStrip;
      }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);
      if (null != zoomForm)
      {
        zoomForm.Close();
        zoomForm = null;
      }
    }

    private void OnCopyMenuClick(object sender, System.EventArgs e)
    {
      Clipboard.Clear();
      Clipboard.SetText(this.Text);
    }

    private Point ComputeZoomLocation(Size zoomSize)
    {
      Point basePoint      = this.Parent.PointToScreen(this.Location);
      int WidthAdjustment  = (zoomSize.Width - this.Width) / 2;
      int HeightAdjustment = (zoomSize.Height - this.Height) / 2;
      Point adjustedPoint  = new Point(basePoint.X - WidthAdjustment, basePoint.Y - HeightAdjustment);

      // TODO: make sure this stays within screen bounds (if possible)
      return adjustedPoint;
    }
  }
}
