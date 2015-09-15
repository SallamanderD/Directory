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
    
    public partial class AddCriminal : Form
    {
        public Criminal criminal;
        

        public AddCriminal()
        {            
            InitializeComponent();                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                criminal = new Criminal(nameText.Text, surnameText.Text, bornDateText.Text, 
                    nicknameText.Text, lastBusyText.Text, heightText.Text, colorEyeText.Text, 
                    colorHairText.Text, nowAdressText.Text, citizenText.Text, featuresText.Text, groupText.Text);
                this.DialogResult = DialogResult.OK;    
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }                           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bornDataPicker_ValueChanged(object sender, EventArgs e)
        {
            bornDateText.Text = bornDataPicker.Value.ToShortDateString();
        }
    }
}
