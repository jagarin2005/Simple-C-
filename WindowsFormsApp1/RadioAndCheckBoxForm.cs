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
    public partial class RadioAndCheckBoxForm : Form
    {
        public RadioAndCheckBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            RadioButton radioButtons = groupBox1.Controls.OfType<RadioButton>()
                                                .FirstOrDefault(n => n.Checked);
            List<CheckBox> checkBoxs = groupBox2.Controls.OfType<CheckBox>()
                                                .Reverse()
                                                .ToList();

            switch (radioButtons.Name)
            {
                case "radioButton1":
                    str += "R1";
                    break;
                case "radioButton2":
                    str += "R2";
                    break;
                case "radioButton3":
                    str += "R3";
                    break;
                default:
                    str += "No Radio Selected";
                    break;
            }

            str += Environment.NewLine;

            foreach (var chkBox in checkBoxs)
            {
                if (chkBox.Checked)
                {
                    switch (chkBox.Name)
                    {
                        case "checkBox1":
                            str += "CB1 ";
                            break;
                        case "checkBox2":
                            str += "CB2 ";
                            break;
                        case "checkBox3":
                            str += "CB3";
                            break;
                        default:
                            str += "No Checkbox Selected";
                            break;
                    }
                }
            }

            MessageBox.Show(str, "User Selected");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
