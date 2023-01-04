using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace hotel_app.Custom_Toolbox
{
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        None
    }

    public partial class ProgressBarCustom : UserControl
    {
        //private Color channelColor - Color.Ligh

        public ProgressBarCustom()
        {
            InitializeComponent();
        }
    }
}
