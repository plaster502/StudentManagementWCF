﻿namespace QLHS
{
    partial class uc_QLKhoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLKhoa));
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.txt_TenKhoa = new System.Windows.Forms.TextBox();
            this.lb_TenKhoa = new System.Windows.Forms.Label();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DsKhoa = new DevExpress.XtraGrid.GridControl();
            this.gv_DsKhoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.pn_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.btn_TimKiem);
            this.pn_Nav.Controls.Add(this.txt_TenKhoa);
            this.pn_Nav.Controls.Add(this.lb_TenKhoa);
            this.pn_Nav.Controls.Add(this.btn_CapNhat);
            this.pn_Nav.Controls.Add(this.txt_MaKhoa);
            this.pn_Nav.Controls.Add(this.label1);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(216, 342);
            this.pn_Nav.TabIndex = 0;
            // 
            // txt_TenKhoa
            // 
            this.txt_TenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenKhoa.Location = new System.Drawing.Point(3, 93);
            this.txt_TenKhoa.Name = "txt_TenKhoa";
            this.txt_TenKhoa.Size = new System.Drawing.Size(207, 26);
            this.txt_TenKhoa.TabIndex = 4;
            // 
            // lb_TenKhoa
            // 
            this.lb_TenKhoa.AutoSize = true;
            this.lb_TenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenKhoa.Location = new System.Drawing.Point(3, 70);
            this.lb_TenKhoa.Name = "lb_TenKhoa";
            this.lb_TenKhoa.Size = new System.Drawing.Size(77, 20);
            this.lb_TenKhoa.TabIndex = 3;
            this.lb_TenKhoa.Text = "Tên Khoa";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(101, 125);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(109, 36);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaKhoa.Location = new System.Drawing.Point(3, 41);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(161, 26);
            this.txt_MaKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // dgv_DsKhoa
            // 
            this.dgv_DsKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgv_DsKhoa.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_DsKhoa.Location = new System.Drawing.Point(216, 0);
            this.dgv_DsKhoa.MainView = this.gv_DsKhoa;
            this.dgv_DsKhoa.Name = "dgv_DsKhoa";
            this.dgv_DsKhoa.Size = new System.Drawing.Size(673, 342);
            this.dgv_DsKhoa.TabIndex = 1;
            this.dgv_DsKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DsKhoa});
            // 
            // gv_DsKhoa
            // 
            this.gv_DsKhoa.GridControl = this.dgv_DsKhoa;
            this.gv_DsKhoa.Name = "gv_DsKhoa";
            this.gv_DsKhoa.OptionsBehavior.ReadOnly = true;
            this.gv_DsKhoa.OptionsCustomization.AllowColumnMoving = false;
            this.gv_DsKhoa.OptionsPrint.AutoWidth = false;
            this.gv_DsKhoa.OptionsView.ColumnAutoWidth = false;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(170, 38);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(40, 36);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Cập nhật";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // uc_QLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DsKhoa);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_QLKhoa";
            this.Size = new System.Drawing.Size(889, 342);
            this.Load += new System.EventHandler(this.uc_QLKhoa_Load);
            this.pn_Nav.ResumeLayout(false);
            this.pn_Nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Nav;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private System.Windows.Forms.TextBox txt_MaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenKhoa;
        private System.Windows.Forms.Label lb_TenKhoa;
        private DevExpress.XtraGrid.GridControl dgv_DsKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DsKhoa;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
    }
}