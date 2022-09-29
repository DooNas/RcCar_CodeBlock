using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RcCar_Controller
{
    public partial class LinkSet : Form
    {
        public static string restUrl = null;
        public LinkSet()
        {
            InitializeComponent();
        }
        private void bt_save_Click(object sender, EventArgs e)
        {
            restUrl = tb_Link.Text;
            this.Close();
        }
    }
}
