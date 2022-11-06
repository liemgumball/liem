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
    public partial class MainForm : Form
    {
        public static DB csdl;
        public MainForm()
        {
            InitializeComponent();
            csdl = new DB();
            SetDataGrid();
            SetCbbSort();
            SetCBBLSH();
        }
        private void SetCBBLSH()
        {
            cbbLSH.Items.Add("All");
            cbbLSH.SelectedItem = "All";
            foreach (string i in DB.lopSHs)
            {
                cbbLSH.Items.Add(i);
            }
        }
        private void SetDataGrid(string s = "All", string sortBy = "MSSV")
        {
            List<SV> li = new List<SV>();
            foreach (SV i in csdl.db)
            {
                if (s == "All") li.Add(i);
                else if (i.LopSH == s) li.Add(i);
            }
            SortSV(li, sortBy);
            dataGridView1.DataSource = li;
        }
        private void SetCbbSort()
        {
            foreach (string i in DB.sortModes)
                comboBox1.Items.Add(i);
            comboBox1.SelectedItem = comboBox1.Items[0].ToString();
        }
        private void SortSV(List<SV> li, string sortBy)
        {
            switch (sortBy)
            {
                case "MSSV":
                    li.Sort(delegate (SV x, SV y)
                    {
                        return x.MSSV.CompareTo(y.MSSV);
                    });
                    break;
                case "Name":
                    li.Sort(delegate (SV x, SV y)
                    {
                        return x.Name.CompareTo(y.Name);
                    });
                    break;
                case "Diem":
                    li.Sort(delegate (SV x, SV y)
                    {
                        return y.DTB.CompareTo(x.DTB);
                    });
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)//search
        {
            List<SV> li = new List<SV>();
            string LSH = cbbLSH.SelectedItem?.ToString();
            string Text = textBox1.Text;
            if(LSH != "All")
            {
                foreach (SV i in csdl.db)
                {
                    if(i.LopSH == LSH && (i.MSSV.Contains(Text)
                        || i.Name.Contains(Text))) li.Add(i);
                }
            } else
            {
                foreach(SV i in csdl.db)
                {
                    if (i.MSSV.Contains(Text)
                       || i.Name.Contains(Text)) li.Add(i);
                }
            }
            dataGridView1.DataSource = li;
        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            int count = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (count != 1) return;
            foreach (SV i in csdl.db)
                if (i.MSSV == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    DetailForm f = new DetailForm(i);
                    f.Show();
                }
        }
        private void button2_Click(object sender, EventArgs e)//add
        {
            DetailForm f = new DetailForm();
            f.Show();
        }

        private void cbbLSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbLSH.SelectedItem != null)
            SetDataGrid(cbbLSH.SelectedItem?.ToString(), comboBox1.SelectedItem?.ToString());
        }

        private void button4_Click(object sender, EventArgs e)//Del
        {
            int count = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (count <= 0) return;
            for (int j = 0; j < count; j++)
            {
                foreach (SV i in csdl.db)
                {
                    if (i.MSSV == dataGridView1.SelectedRows[j].Cells[0].Value.ToString())
                    {
                        csdl.db.Remove(i);
                        break;
                    }
                }
            }
            SetDataGrid(cbbLSH.SelectedItem?.ToString(), comboBox1.SelectedItem?.ToString());
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Gender")
            {
                if(e.Value != null)
                {
                    try
                    {
                        string stringValue = e.Value?.ToString();
                        //MessageBox.Show(stringValue);
                        if (stringValue == "true")
                            stringValue = "Male";
                        else stringValue = "Female";
                        //e.Value = stringValue.ToString();
                        //e.FormattingApplied = true;
                    }
                    catch (FormatException)
                    {
                        e.FormattingApplied = false;
                    }
                }
            } 
        }

        private void button6_Click(object sender, EventArgs e)//refresh
        {
            SetDataGrid(cbbLSH.SelectedItem?.ToString(), comboBox1.SelectedItem?.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDataGrid(cbbLSH.SelectedItem?.ToString(), comboBox1.SelectedItem?.ToString());
        }
    }
}
