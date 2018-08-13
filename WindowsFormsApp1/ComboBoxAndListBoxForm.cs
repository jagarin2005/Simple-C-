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
    public partial class ComboBoxAndListBoxForm : Form
    {
        public ComboBoxAndListBoxForm()
        {
            InitializeComponent();
        }

        private void ComboBoxAndListBoxForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Visual Basic");
            listBox1.Items.Add("Visual C#");
            listBox1.Items.Add("ASP.NET");
            listBox1.Items.Add("Xamarin");
            listBox1.SelectedIndex = 0;

            comboBox1.Items.Add("Visual Basic");
            comboBox1.Items.Add("Visual C#");
            comboBox1.Items.Add("ASP.NET");
            comboBox1.Items.Add("Xamarin");
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddListTextBox(listBox1, textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveListBox(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllList(listBox1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddListTextBox(listBox1, textBox1);
            }
        }

        public void AddListTextBox(ListBox lb, TextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text.Trim()))
            {
                lb.Items.Add(txt.Text.Trim());
                txt.Text = "";
                txt.Focus();
            }
        }

        public void RemoveListBox(ListBox lb)
        {
            if (lb.SelectedIndex != -1)
            {
                lb.Items.RemoveAt(lb.SelectedIndex);
            }
        }

        public void ClearAllList(ListBox lb)
        {
            if (MessageBox.Show("Are you sure to clear all list?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lb.Items.Clear();
            }
        }
    }
}
