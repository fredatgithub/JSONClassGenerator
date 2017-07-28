using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xamasoft.JsonClassGenerator.UI
{
  public partial class FrmAbout : Form
  {
    public FrmAbout()
    {
      InitializeComponent();
#if !APPSERVICES
      btnSendFeedback.Visible = false;
      btnCheckUpdates.Visible = false;
#endif
      this.Font = SystemFonts.MessageBoxFont;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.xamasoft.com/json-class-generator");
    }

    private void frmAbout_Load(object sender, EventArgs e)
    {
      lblVersion.Text = string.Format(lblVersion.Text, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
    }

    private void btnSendFeedback_Click(object sender, EventArgs e)
    {
#if APPSERVICES
            Program.appServices.ShowFeedbackForm(this);
#endif
    }

    private void btnCheckUpdates_Click(object sender, EventArgs e)
    {
#if APPSERVICES
            Program.appServices.UpdateChecker.ManualUpdatesCheck(this);
#endif
    }
  }
}