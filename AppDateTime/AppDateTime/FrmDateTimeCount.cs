using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppDateTime
{
    public partial class FrmDateTimeCount : Form
    {
        public FrmDateTimeCount()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                DtpJamSampai.Value = DtpJamBerangkat.Value.AddSeconds((double)NudLamaPerjalanan.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHitung2_Click(object sender, EventArgs e)
        {
            try
            {
                NudLamaPerjalanan2.Value = (decimal)(DtpJamSampai2.Value - DtpJamBerangkat2.Value).TotalSeconds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
