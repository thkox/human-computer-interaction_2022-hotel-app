using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Forms.Functions
{
    public partial class FacilitiesForm : Form
    {
        public FacilitiesForm()
        {
            InitializeComponent();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\Hotel-app-Documentation.chm", HelpNavigator.TopicId, "29");
        }
    }
}
