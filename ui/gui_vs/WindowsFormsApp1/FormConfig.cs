using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            checkHospital.Checked = PowerModel.checkHospital;
            checkPolideportivo.Checked = PowerModel.checkPolideportivo;
            checkCasas.Checked = PowerModel.checkCasas;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkHospital_CheckedChanged(object sender, EventArgs e)
        {
            if(checkHospital.Checked)
            {
                PowerModel.Consumo += 1000;
            }
            else
            {
                PowerModel.Consumo -= 1000;
            }
            PowerModel.checkHospital = checkHospital.Checked;
            label1.Text =PowerModel.Consumo.ToString();
        }

        private void checkPolideportivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPolideportivo.Checked)
            {
                PowerModel.Consumo += 1000;
            }
            else
            {
                PowerModel.Consumo -= 1000;
                
            }
            PowerModel.checkPolideportivo = checkPolideportivo.Checked;
            label1.Text = PowerModel.Consumo.ToString();
        }

        private void checkCasas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCasas.Checked)
            {
                PowerModel.Consumo += 1000;
            }
            else
            {
                PowerModel.Consumo -= 1000;
            }
            PowerModel.checkCasas = checkCasas.Checked;
            label1.Text = PowerModel.Consumo.ToString();
        }
    }
}
