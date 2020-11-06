using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace CultureExplorer20
{
	/// <summary>
	/// Summary description for AboutForm.
	/// </summary>
	public class AboutForm : System.Windows.Forms.Form
  {
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.Button buttonOK;
    private Label labelDesign;
    private LinkLabel linkAuthor;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AboutForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
      this.labelTitle = new System.Windows.Forms.Label();
      this.labelCopyright = new System.Windows.Forms.Label();
      this.buttonOK = new System.Windows.Forms.Button();
      this.labelDesign = new System.Windows.Forms.Label();
      this.linkAuthor = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // labelTitle
      // 
      resources.ApplyResources(this.labelTitle, "labelTitle");
      this.labelTitle.BackColor = System.Drawing.Color.Transparent;
      this.labelTitle.ForeColor = System.Drawing.Color.White;
      this.labelTitle.Name = "labelTitle";
      // 
      // labelCopyright
      // 
      resources.ApplyResources(this.labelCopyright, "labelCopyright");
      this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
      this.labelCopyright.ForeColor = System.Drawing.Color.White;
      this.labelCopyright.Name = "labelCopyright";
      // 
      // buttonOK
      // 
      resources.ApplyResources(this.buttonOK, "buttonOK");
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
      // 
      // labelDesign
      // 
      resources.ApplyResources(this.labelDesign, "labelDesign");
      this.labelDesign.BackColor = System.Drawing.Color.Transparent;
      this.labelDesign.ForeColor = System.Drawing.Color.White;
      this.labelDesign.Name = "labelDesign";
      // 
      // linkAuthor
      // 
      resources.ApplyResources(this.linkAuthor, "linkAuthor");
      this.linkAuthor.BackColor = System.Drawing.Color.Transparent;
      this.linkAuthor.ForeColor = System.Drawing.Color.White;
      this.linkAuthor.LinkColor = System.Drawing.Color.Blue;
      this.linkAuthor.Name = "linkAuthor";
      this.linkAuthor.TabStop = true;
      this.linkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAuthor_LinkClicked);
      // 
      // AboutForm
      // 
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.linkAuthor);
      this.Controls.Add(this.labelDesign);
      this.Controls.Add(this.buttonOK);
      this.Controls.Add(this.labelCopyright);
      this.Controls.Add(this.labelTitle);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutForm";
      this.ShowInTaskbar = false;
      this.ResumeLayout(false);
      this.PerformLayout();

    }
		#endregion

    private void buttonOK_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void linkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process p = new Process();
      p.StartInfo.FileName = Properties.Resources.EmailInfo;
      p.Start();
    }
	}
}
