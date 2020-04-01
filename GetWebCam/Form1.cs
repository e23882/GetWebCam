using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.GPU;

namespace GetWebCam
{
    public partial class Form1 : Form
    {
        #region Declarations
        private Capture cap = null;
        #endregion

        #region Memberfunction
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cap = new Capture(0);
            Application.Idle += new EventHandler(Applica_Idle);
        }

        private void Applica_Idle(object sender, EventArgs e)
        {
            #region 取得視訊render到UI
            Image<Bgr, Byte> frame = cap.QueryFrame();
            pictureBox1.Image = frame.ToBitmap();
            #endregion
        }
        #endregion
    }
}
