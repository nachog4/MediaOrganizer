using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaOrganizer
{
    public partial class DateDiffCalculator : Form
    {
        public DateDiffCalculator()
        {
            InitializeComponent();
        }

        private void DateDiffCalculator_Load(object sender, EventArgs e)
        {
            dtp_initialDate.Format = DateTimePickerFormat.Custom;
            dtp_initialDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtp_realDate.Format = DateTimePickerFormat.Custom;
            dtp_realDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void cmd_calculate_Click(object sender, EventArgs e)
        {
            txt_result.Text = Math.Round((dtp_realDate.Value - dtp_initialDate.Value).TotalSeconds).ToString();
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
            int diff;
            if (!String.IsNullOrEmpty(txt_result.Text) && Int32.TryParse(txt_result.Text, out diff))
            {
                lbl_testDate.Text = dtp_initialDate.Value.AddSeconds(diff).ToString();
            }
        }
    }
}
