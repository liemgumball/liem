using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DetailForm : Form
    {
        bool updateMode = false;
        public DetailForm()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            SetCbbLSH();
        }
        public DetailForm(SV s)
        {
            InitializeComponent();
            updateMode = true;
            radioButton1.Checked = true;
            SetCbbLSH();
            textBox_MSSV.Text = s.MSSV;
            textBox_MSSV.ReadOnly = true;
            textBox_Name.Text = s.Name;
            comboBox1.SelectedItem = s.LopSH;
            radioButton1.Checked = s.Gender;
            textBox_DTB.Text = s.DTB.ToString();
            checkBox_Anh.Checked = s.Anh;
            checkBox_HocBa.Checked = s.HB;
            checkBox_GDQP.Checked = s.GDQP;
        }
        private void SetCbbLSH()
        {
            foreach (string i in DB.lopSHs)
                comboBox1.Items.Add(i);
        }
        private void button1_Click(object sender, EventArgs e)//Save
        {
            try
            {
                string mssv = textBox_MSSV.Text;
                string name = textBox_Name.Text;
                //string lopSH = comboBox_LopSH.SelectedText;
                string lop = comboBox1.SelectedItem?.ToString();
                bool gender = radioButton1.Checked;
                DateTime ns = dateTimePicker1.Value;
                double dtb = double.Parse(textBox_DTB.Text);
                bool hocba = checkBox_HocBa.Checked;
                bool anh = checkBox_Anh.Checked;
                bool gdqp = checkBox_GDQP.Checked;
                if(mssv != "" && name != "" && lop != null)
                {
                    SV j = new SV(mssv, name, lop, gender, ns, dtb, hocba, anh, gdqp);
                    if (updateMode) 
                    {
                        //MessageBox.Show(MainForm.csdl.db.Find(u => u.MSSV == mssv).Name.ToString());
                        int index = MainForm.csdl.db.IndexOf(MainForm.csdl.db.Find(u => u?.MSSV == mssv));
                        MainForm.csdl.db.Insert(index,j);
                        MainForm.csdl.db.RemoveAt(index+1);
                        Close();
                    }
                    else
                    {
                        MainForm.csdl.db.Add(j);
                        Close();
                    }
                }
                else MessageBox.Show("Cannot save");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
