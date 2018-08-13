using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioAndCheckboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxAndListboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radioAndCheckboxToolStripMenuItem,
            this.checkboxAndListboxToolStripMenuItem});
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.simpleToolStripMenuItem.Text = "Simple";
            // 
            // radioAndCheckboxToolStripMenuItem
            // 
            this.radioAndCheckboxToolStripMenuItem.Name = "radioAndCheckboxToolStripMenuItem";
            this.radioAndCheckboxToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.radioAndCheckboxToolStripMenuItem.Text = "Radio And Checkbox";
            this.radioAndCheckboxToolStripMenuItem.Click += new System.EventHandler(this.radioAndCheckboxToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("4815_KwangMD_Catthai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(61, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello World\r\nWelcome to Simple\r\nWindows Form App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkboxAndListboxToolStripMenuItem
            // 
            this.checkboxAndListboxToolStripMenuItem.Name = "checkboxAndListboxToolStripMenuItem";
            this.checkboxAndListboxToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.checkboxAndListboxToolStripMenuItem.Text = "ComboBox And Listbox";
            this.checkboxAndListboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxAndListboxToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Simple Form App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioAndCheckboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form radioAndCheckbox = new RadioAndCheckBoxForm();
            radioAndCheckbox.Show();
        }

        private void checkboxAndListboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form comboboxAndListbox = new ComboBoxAndListBoxForm();
            comboboxAndListbox.Show();
        }
    }
}
