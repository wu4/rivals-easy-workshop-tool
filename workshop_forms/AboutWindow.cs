using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workshop_forms
{
  public partial class AboutWindow : Form
  {
    public AboutWindow()
    {
      InitializeComponent();
    }

    private void AboutWindow_Click(object sender, EventArgs e)
    {
      var a = (AboutWindow)sender;
      a.Close();
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        this.Capture = true;
    }

    private void AboutWindow_MouseCaptureChanged(object sender, EventArgs e)
    {
      this.Close();
      /*
      if (!this.Capture)
      {
          if (!this.RectangleToScreen(this.DisplayRectangle).Contains(Cursor.Position))
          {
              this.Close();
          }
          else
          {
              this.Capture = true;
          }
      }
      */

    }

    private void AboutWindow_KeyPress(object sender, KeyPressEventArgs e)
    {
      var a = (AboutWindow)sender;
      a.Close();
    }

        /*

        protected override void MouseCaptureChanged(EventArgs e)
        {

            base.MouseCaptureChanged(e);
        }
        */
    }
}
