using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh5
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToTal_Text(object sender, EventArgs e)
        {

        }
        public class Utilities
        {
            public static void Reset(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Click(object sender, EventArgs e)
        {

        }

        private void SuDung_Text(object sender, EventArgs e)
        {

        }

        private void Nhap_Text(object sender, EventArgs e)
        {

        }

        private void DaSuDung_Text(object sender, EventArgs e)
        {

        }

        private void VAT_Text(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Utilities.Reset(this);
        }

       

        private void VAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void VAT_Click(object sender, EventArgs e)
        {

        }

        private void Old_Click(object sender, EventArgs e)
        {

        }

        float a,b, c, sum, vat;
        bool a_succeed, b_succeed;
        private void TinhTien_Click(object sender, EventArgs e)
        {
            a_succeed = float.TryParse(OldText.Text, out a);

            b_succeed = float.TryParse(NewText.Text, out b);

            if (b < 0 || a < 0 || a_succeed == false || b_succeed == false)
            {
                Error_Menu errorbox = new Error_Menu();
                errorbox.Show();
            }                
            else c = b - a;
            if (c < 0) c = 0;
            Subtracted_Text.Text = c.ToString();
            if (c <= 100 && c > 0)
            {
                sum = c * 1418;
            }
            else if (c <= 150)
            {
                sum = c * 1622;
            }
            else if (c <= 200)
            {
                sum = c * 2044;
            }
            else if (c <= 300)
            {
                sum = c * 2210;
            }
            else if (c <= 400)
            {
                sum = c * 2361;

            }
            else if (c >= 401)
            {
                sum = c * 2420;
            }
            ToTalText.Text = sum.ToString();
            vat = (sum * 110) / 100;
            VAT.Text = vat.ToString();
        }
    }
}
