using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CultureExplorer20
{
  public  class CultureExplorerListView : ListView
  {
    private ZoomForm zoomForm;
    private string CopyString;
    
    public CultureExplorerListView()
    {
      this.Cursor = Cursors.Hand;
      zoomForm    = null;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);

      ListViewItem item = this.GetItemAt(e.X, e.Y);
      if (null != item)
      {
        string ItemString = GetItemStringList(item);

        if (MouseButtons.Left == e.Button)
        {
          zoomForm = new ZoomForm(this, ItemString);
          zoomForm.Show(this);
          zoomForm.Location = ComputeZoomLocation(zoomForm.Size, item.Bounds);
        }
        else if (MouseButtons.Right == e.Button)
        {
          CopyString = ItemString;
          ContextMenuStrip menuStrip = new ContextMenuStrip();
          menuStrip.Items.Add(Properties.Resources.CopyMenu, null, OnCopyMenuClick);
          this.ContextMenuStrip = menuStrip;
        }
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
      Clipboard.SetText(CopyString);
    }

    private Point ComputeZoomLocation(Size zoomSize, Rectangle itemBounds)
    {
      Point basePoint = this.Parent.PointToScreen(new Point(itemBounds.X, itemBounds.Y));
      int WidthAdjustment = (zoomSize.Width - this.Width) / 2;
      int HeightAdjustment = (zoomSize.Height - this.Height) / 2;
      Point adjustedPoint = new Point(basePoint.X - WidthAdjustment, basePoint.Y - HeightAdjustment);

      // TODO: make sure this stays within screen bounds (if possible)
      return adjustedPoint;
    }

    private string GetItemStringList(ListViewItem item)
    {
      StringBuilder sb = new StringBuilder(item.Text);
      for (int i = 1; i < item.SubItems.Count; i++)
      {
        sb.Append(" | ");
        sb.Append(item.SubItems[i].Text);
      }

      return sb.ToString();      
    }
  }
}
