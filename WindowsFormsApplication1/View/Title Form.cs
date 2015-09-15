using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TitleForm : Form
    {
        public static TitleForm Title;
        MainForm MainForm = new MainForm();
        
        public TitleForm()
        {
            Title = this;
            InitializeComponent();
        }

       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (Authorization.LogIn(inputPass.Text))
                {
                    wrongLabel.Visible = false;
                    this.Hide();
                    MainForm.Show();
                }
                else
                {
                    wrongLabel.Visible = true;
                }
            }
        }
    }
}
