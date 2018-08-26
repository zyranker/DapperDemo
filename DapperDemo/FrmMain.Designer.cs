namespace DapperDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPersonList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmlDeletel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetPerById = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboProv = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnGetPerByLastName = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrderByAge = new System.Windows.Forms.Button();
            this.btnGroupByAge = new System.Windows.Forms.Button();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Birthday,
            this.Age,
            this.Email,
            this.IpAddress});
            this.dgvPersonList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonList.Location = new System.Drawing.Point(14, 17);
            this.dgvPersonList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.RowTemplate.Height = 23;
            this.dgvPersonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonList.Size = new System.Drawing.Size(700, 414);
            this.dgvPersonList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlDeletel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmlDeletel
            // 
            this.tsmlDeletel.Name = "tsmlDeletel";
            this.tsmlDeletel.Size = new System.Drawing.Size(100, 22);
            this.tsmlDeletel.Text = "删除";
            this.tsmlDeletel.Click += new System.EventHandler(this.tsmlDeletel_Click);
            // 
            // btnGetPerById
            // 
            this.btnGetPerById.Location = new System.Drawing.Point(242, 29);
            this.btnGetPerById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetPerById.Name = "btnGetPerById";
            this.btnGetPerById.Size = new System.Drawing.Size(95, 23);
            this.btnGetPerById.TabIndex = 1;
            this.btnGetPerById.Text = "根据Id查询";
            this.btnGetPerById.UseVisualStyleBackColor = true;
            this.btnGetPerById.Click += new System.EventHandler(this.btnGetPerById_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboAge);
            this.groupBox1.Controls.Add(this.cboProv);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.btnGetPerByLastName);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnGroupByAge);
            this.groupBox1.Controls.Add(this.btnOrderByAge);
            this.groupBox1.Controls.Add(this.btnGetPerById);
            this.groupBox1.Location = new System.Drawing.Point(14, 439);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(700, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dapper操作";
            // 
            // cboProv
            // 
            this.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProv.FormattingEnabled = true;
            this.cboProv.Location = new System.Drawing.Point(6, 59);
            this.cboProv.Name = "cboProv";
            this.cboProv.Size = new System.Drawing.Size(230, 25);
            this.cboProv.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(147, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(363, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(230, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // btnGetPerByLastName
            // 
            this.btnGetPerByLastName.Location = new System.Drawing.Point(599, 29);
            this.btnGetPerByLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetPerByLastName.Name = "btnGetPerByLastName";
            this.btnGetPerByLastName.Size = new System.Drawing.Size(95, 23);
            this.btnGetPerByLastName.TabIndex = 1;
            this.btnGetPerByLastName.Text = "根据姓氏查询";
            this.btnGetPerByLastName.UseVisualStyleBackColor = true;
            this.btnGetPerByLastName.Click += new System.EventHandler(this.btnGetPerByLastName_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(6, 29);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(77, 23);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "显示全部";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "名字";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 80;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "姓氏";
            this.LastName.Name = "LastName";
            this.LastName.Width = 80;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生年月";
            this.Birthday.Name = "Birthday";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.Width = 40;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "电子邮件";
            this.Email.Name = "Email";
            // 
            // IpAddress
            // 
            this.IpAddress.DataPropertyName = "IpAddress";
            this.IpAddress.HeaderText = "IP地址";
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Width = 120;
            // 
            // btnOrderByAge
            // 
            this.btnOrderByAge.Location = new System.Drawing.Point(242, 59);
            this.btnOrderByAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrderByAge.Name = "btnOrderByAge";
            this.btnOrderByAge.Size = new System.Drawing.Size(95, 23);
            this.btnOrderByAge.TabIndex = 1;
            this.btnOrderByAge.Text = "根据年龄排序";
            this.btnOrderByAge.UseVisualStyleBackColor = true;
            this.btnOrderByAge.Click += new System.EventHandler(this.btnOrderByAge_Click);
            // 
            // btnGroupByAge
            // 
            this.btnGroupByAge.Location = new System.Drawing.Point(599, 61);
            this.btnGroupByAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroupByAge.Name = "btnGroupByAge";
            this.btnGroupByAge.Size = new System.Drawing.Size(95, 23);
            this.btnGroupByAge.TabIndex = 1;
            this.btnGroupByAge.Text = "根据年龄分组";
            this.btnGroupByAge.UseVisualStyleBackColor = true;
            this.btnGroupByAge.Click += new System.EventHandler(this.btnGroupByAge_Click);
            // 
            // cboAge
            // 
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(363, 59);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(230, 25);
            this.cboAge.TabIndex = 4;
            this.cboAge.SelectedIndexChanged += new System.EventHandler(this.cboAge_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPersonList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dapper操作";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.Button btnGetPerById;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnGetPerByLastName;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmlDeletel;
        private System.Windows.Forms.ComboBox cboProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddress;
        private System.Windows.Forms.Button btnOrderByAge;
        private System.Windows.Forms.Button btnGroupByAge;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.Timer timer1;
    }
}

