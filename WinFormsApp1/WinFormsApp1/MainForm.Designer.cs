namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopSHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hBDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gDQPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lop sinh hoat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 202);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 202);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 20);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 202);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 20);
            this.button4.TabIndex = 5;
            this.button4.Text = "Del";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 202);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 20);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sort";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(91, 5);
            this.cbbLSH.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(129, 23);
            this.cbbLSH.TabIndex = 7;
            this.cbbLSH.SelectedIndexChanged += new System.EventHandler(this.cbbLSH_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 202);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dbBindingSource1
            // 
            this.dbBindingSource1.DataMember = "db";
            this.dbBindingSource1.DataSource = this.dBBindingSource;
            // 
            // dBBindingSource
            // 
            this.dBBindingSource.DataSource = typeof(WinFormsApp1.DB);
            // 
            // dBBindingSource2
            // 
            this.dBBindingSource2.DataSource = typeof(WinFormsApp1.DB);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSSVDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lopSHDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.nSDataGridViewTextBoxColumn,
            this.dTBDataGridViewTextBoxColumn,
            this.hBDataGridViewCheckBoxColumn,
            this.anhDataGridViewCheckBoxColumn,
            this.gDQPDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.dbBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(498, 165);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            this.mSSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lopSHDataGridViewTextBoxColumn
            // 
            this.lopSHDataGridViewTextBoxColumn.DataPropertyName = "LopSH";
            this.lopSHDataGridViewTextBoxColumn.HeaderText = "LopSH";
            this.lopSHDataGridViewTextBoxColumn.Name = "lopSHDataGridViewTextBoxColumn";
            this.lopSHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            this.genderDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nSDataGridViewTextBoxColumn
            // 
            this.nSDataGridViewTextBoxColumn.DataPropertyName = "NS";
            this.nSDataGridViewTextBoxColumn.HeaderText = "NS";
            this.nSDataGridViewTextBoxColumn.Name = "nSDataGridViewTextBoxColumn";
            this.nSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTBDataGridViewTextBoxColumn
            // 
            this.dTBDataGridViewTextBoxColumn.DataPropertyName = "DTB";
            this.dTBDataGridViewTextBoxColumn.HeaderText = "DTB";
            this.dTBDataGridViewTextBoxColumn.Name = "dTBDataGridViewTextBoxColumn";
            this.dTBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hBDataGridViewCheckBoxColumn
            // 
            this.hBDataGridViewCheckBoxColumn.DataPropertyName = "HB";
            this.hBDataGridViewCheckBoxColumn.HeaderText = "HB";
            this.hBDataGridViewCheckBoxColumn.Name = "hBDataGridViewCheckBoxColumn";
            this.hBDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // anhDataGridViewCheckBoxColumn
            // 
            this.anhDataGridViewCheckBoxColumn.DataPropertyName = "Anh";
            this.anhDataGridViewCheckBoxColumn.HeaderText = "Anh";
            this.anhDataGridViewCheckBoxColumn.Name = "anhDataGridViewCheckBoxColumn";
            this.anhDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // gDQPDataGridViewCheckBoxColumn
            // 
            this.gDQPDataGridViewCheckBoxColumn.DataPropertyName = "GDQP";
            this.gDQPDataGridViewCheckBoxColumn.HeaderText = "GDQP";
            this.gDQPDataGridViewCheckBoxColumn.Name = "gDQPDataGridViewCheckBoxColumn";
            this.gDQPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 239);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox cbbLSH;
        private ComboBox comboBox1;
        private BindingSource dbBindingSource1;
        private BindingSource dBBindingSource;
        private BindingSource dBBindingSource2;
        private DataGridView dataGridView1;
        private Button button6;
        private DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lopSHDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dTBDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hBDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn anhDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn gDQPDataGridViewCheckBoxColumn;
    }
}