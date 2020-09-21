using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            pb1.Value = 31;
        }

        private void mc_DateChanged(object sender, DateRangeEventArgs e)
        {
            pb1.Value = mc.SelectionRange.Start.Day;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (mc.Visible == true)
                mc.Visible = false;
            else if (mc.Visible == false)
                mc.Visible = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Xcoord.Text = e.X.ToString();
            Ycoord.Text = e.Y.ToString();
        }

        private void cbXYcoord_CheckedChanged(object sender, EventArgs e)
        {
            if (Xcoord.Visible == true)
                Xcoord.Visible = false;
            else if (Xcoord.Visible == false)
                Xcoord.Visible = true;

            if (Ycoord.Visible == true)
                Ycoord.Visible = false;
            else if (Ycoord.Visible == false)
                Ycoord.Visible = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIndex.Text = checkedListBox1.SelectedIndex.ToString();
            //lbText.Text = checkedListBox1.SelectedItem.ToString();
        }

        private void cBoxС_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedIndex = cBox1.SelectedIndex;
            checkedListBox1.Items[cBox1.SelectedIndex] = tBox1.Text;
        }

        private void tBoxlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cBoxlist.Items.Add(tBoxlist.Text);
            }
        }

        private void cBoxlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(cBoxlist.SelectedItem.ToString());
        }

        private void checkedListBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkedListBox1.SelectedItem);
        }

        private void rbenable_CheckedChanged(object sender, EventArgs e)
        {
            nud.Enabled = true;
        }

        private void rbneenable_CheckedChanged(object sender, EventArgs e)
        {
            nud.Enabled = false;
        }

        private void picBox_MouseClick(object sender, MouseEventArgs e)
        {
            //  picBox.Image = Image.FromFile("E:\Chikibamboni.jpg");
        }



        private void btadd_Click(object sender, EventArgs e)
        {
            var namesurname = new string[] { tBoxName.Text, tBoxSurname.Text };
            var namesurname1 = new ListViewItem(namesurname);
            listView1.Items.Add(namesurname1);
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            rTBox.Text = nud.Value.ToString();
        }
    }
}
