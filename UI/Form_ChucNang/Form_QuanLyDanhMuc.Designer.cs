﻿namespace UI.Form_ChucNang
{
    partial class Form_QuanLyDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyDanhMuc));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelQuanLyDM = new System.Windows.Forms.Panel();
            this.tbSoNgayThue = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhiTreHan = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhiThue = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.tbTenDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaSoNgayThue = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaPhiTreHan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaPhiThue = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiTreHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panelQuanLyDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoNgayThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiTreHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDanhMuc.Properties)).BeginInit();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.panelQuanLyDM);
            this.groupControl1.Location = new System.Drawing.Point(3, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(608, 266);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông Tin Danh Mục";
            // 
            // panelQuanLyDM
            // 
            this.panelQuanLyDM.Controls.Add(this.tbSoNgayThue);
            this.panelQuanLyDM.Controls.Add(this.label3);
            this.panelQuanLyDM.Controls.Add(this.tbPhiTreHan);
            this.panelQuanLyDM.Controls.Add(this.label4);
            this.panelQuanLyDM.Controls.Add(this.tbPhiThue);
            this.panelQuanLyDM.Controls.Add(this.label5);
            this.panelQuanLyDM.Controls.Add(this.tbIdDanhMuc);
            this.panelQuanLyDM.Controls.Add(this.tbTenDanhMuc);
            this.panelQuanLyDM.Controls.Add(this.label1);
            this.panelQuanLyDM.Controls.Add(this.label2);
            this.panelQuanLyDM.Location = new System.Drawing.Point(24, 44);
            this.panelQuanLyDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQuanLyDM.Name = "panelQuanLyDM";
            this.panelQuanLyDM.Size = new System.Drawing.Size(498, 217);
            this.panelQuanLyDM.TabIndex = 53;
            // 
            // tbSoNgayThue
            // 
            this.tbSoNgayThue.Enabled = false;
            this.tbSoNgayThue.Location = new System.Drawing.Point(194, 181);
            this.tbSoNgayThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoNgayThue.Name = "tbSoNgayThue";
            this.tbSoNgayThue.Size = new System.Drawing.Size(292, 22);
            this.tbSoNgayThue.TabIndex = 1005;
            this.tbSoNgayThue.EditValueChanged += new System.EventHandler(this.tbSoNgayThue_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(80, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 1004;
            this.label3.Text = "Số Ngày Thuê:";
            // 
            // tbPhiTreHan
            // 
            this.tbPhiTreHan.Enabled = false;
            this.tbPhiTreHan.Location = new System.Drawing.Point(194, 143);
            this.tbPhiTreHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhiTreHan.Name = "tbPhiTreHan";
            this.tbPhiTreHan.Size = new System.Drawing.Size(292, 22);
            this.tbPhiTreHan.TabIndex = 1002;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(91, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1003;
            this.label4.Text = "Phí Trễ Hạn:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPhiThue
            // 
            this.tbPhiThue.Enabled = false;
            this.tbPhiThue.Location = new System.Drawing.Point(194, 102);
            this.tbPhiThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhiThue.Name = "tbPhiThue";
            this.tbPhiThue.Size = new System.Drawing.Size(292, 22);
            this.tbPhiThue.TabIndex = 1000;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(113, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Phí Thuê:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbIdDanhMuc
            // 
            this.tbIdDanhMuc.Enabled = false;
            this.tbIdDanhMuc.Location = new System.Drawing.Point(194, 21);
            this.tbIdDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdDanhMuc.Name = "tbIdDanhMuc";
            this.tbIdDanhMuc.Size = new System.Drawing.Size(292, 22);
            this.tbIdDanhMuc.TabIndex = 999;
            // 
            // tbTenDanhMuc
            // 
            this.tbTenDanhMuc.Enabled = false;
            this.tbTenDanhMuc.Location = new System.Drawing.Point(194, 60);
            this.tbTenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenDanhMuc.Name = "tbTenDanhMuc";
            this.tbTenDanhMuc.Size = new System.Drawing.Size(292, 22);
            this.tbTenDanhMuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Danh mục:";
            this.label1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Danh mục:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btn_Huy);
            this.panelThaoTac.Controls.Add(this.btn_SuaSoNgayThue);
            this.panelThaoTac.Controls.Add(this.btn_SuaPhiTreHan);
            this.panelThaoTac.Controls.Add(this.btn_SuaPhiThue);
            this.panelThaoTac.Controls.Add(this.btnLuu);
            this.panelThaoTac.Location = new System.Drawing.Point(8, 28);
            this.panelThaoTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(594, 230);
            this.panelThaoTac.TabIndex = 3;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.Enabled = false;
            this.btn_Huy.Location = new System.Drawing.Point(385, 128);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(180, 87);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_SuaSoNgayThue
            // 
            this.btn_SuaSoNgayThue.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_SuaSoNgayThue.Appearance.Options.UseFont = true;
            this.btn_SuaSoNgayThue.Location = new System.Drawing.Point(26, 161);
            this.btn_SuaSoNgayThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SuaSoNgayThue.Name = "btn_SuaSoNgayThue";
            this.btn_SuaSoNgayThue.Size = new System.Drawing.Size(257, 54);
            this.btn_SuaSoNgayThue.TabIndex = 6;
            this.btn_SuaSoNgayThue.Text = "Sửa Số Ngày Thuê";
            this.btn_SuaSoNgayThue.Click += new System.EventHandler(this.btn_SuaSoNgayThue_Click);
            // 
            // btn_SuaPhiTreHan
            // 
            this.btn_SuaPhiTreHan.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_SuaPhiTreHan.Appearance.Options.UseFont = true;
            this.btn_SuaPhiTreHan.Location = new System.Drawing.Point(26, 87);
            this.btn_SuaPhiTreHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SuaPhiTreHan.Name = "btn_SuaPhiTreHan";
            this.btn_SuaPhiTreHan.Size = new System.Drawing.Size(257, 54);
            this.btn_SuaPhiTreHan.TabIndex = 5;
            this.btn_SuaPhiTreHan.Text = "Sửa Phí Trễ Hạn";
            this.btn_SuaPhiTreHan.Click += new System.EventHandler(this.btn_SuaPhiTreHan_Click);
            // 
            // btn_SuaPhiThue
            // 
            this.btn_SuaPhiThue.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_SuaPhiThue.Appearance.Options.UseFont = true;
            this.btn_SuaPhiThue.Location = new System.Drawing.Point(26, 16);
            this.btn_SuaPhiThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SuaPhiThue.Name = "btn_SuaPhiThue";
            this.btn_SuaPhiThue.Size = new System.Drawing.Size(257, 54);
            this.btn_SuaPhiThue.TabIndex = 4;
            this.btn_SuaPhiThue.Text = "Sửa Phí Thuê";
            this.btn_SuaPhiThue.Click += new System.EventHandler(this.btn_SuaPhiThue_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(385, 16);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 87);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDanhMuc,
            this.TenDanhMuc,
            this.PhiThue,
            this.PhiTreHan,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(618, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 539);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdDanhMuc
            // 
            this.IdDanhMuc.DataPropertyName = "IdDanhMuc";
            this.IdDanhMuc.FillWeight = 95.84665F;
            this.IdDanhMuc.HeaderText = "ID Danh Mục";
            this.IdDanhMuc.Name = "IdDanhMuc";
            this.IdDanhMuc.ReadOnly = true;
            this.IdDanhMuc.Width = 120;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.FillWeight = 54.96075F;
            this.TenDanhMuc.HeaderText = "Tên Danh Mục";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            // 
            // PhiThue
            // 
            this.PhiThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhiThue.DataPropertyName = "PhiThue";
            this.PhiThue.FillWeight = 186.4927F;
            this.PhiThue.HeaderText = "Phí Thuê";
            this.PhiThue.Name = "PhiThue";
            this.PhiThue.ReadOnly = true;
            // 
            // PhiTreHan
            // 
            this.PhiTreHan.DataPropertyName = "PhiTreHan";
            this.PhiTreHan.FillWeight = 48.86432F;
            this.PhiTreHan.HeaderText = "Phí Trễ Hạn";
            this.PhiTreHan.Name = "PhiTreHan";
            this.PhiTreHan.ReadOnly = true;
            this.PhiTreHan.Width = 120;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "SoNgayThue";
            this.Column1.FillWeight = 113.8356F;
            this.Column1.HeaderText = "Số Ngày Thuê";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl2.Controls.Add(this.panelThaoTac);
            this.groupControl2.Location = new System.Drawing.Point(3, 274);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(608, 266);
            this.groupControl2.TabIndex = 54;
            this.groupControl2.Text = "Thao Tác";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // Form_QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 546);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_QuanLyDanhMuc";
            this.Text = "Quản Lý Danh Mục";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QuanLyDanhMuc_FormClosed);
            this.Load += new System.EventHandler(this.Form_QuanLyDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panelQuanLyDM.ResumeLayout(false);
            this.panelQuanLyDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoNgayThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiTreHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDanhMuc.Properties)).EndInit();
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panelQuanLyDM;
        private DevExpress.XtraEditors.TextEdit tbIdDanhMuc;
        private DevExpress.XtraEditors.TextEdit tbTenDanhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit tbPhiThue;
        private DevExpress.XtraEditors.TextEdit tbPhiTreHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiTreHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevExpress.XtraEditors.TextEdit tbSoNgayThue;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_SuaSoNgayThue;
        private DevExpress.XtraEditors.SimpleButton btn_SuaPhiTreHan;
        private DevExpress.XtraEditors.SimpleButton btn_SuaPhiThue;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}