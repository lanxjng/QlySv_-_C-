namespace QuanLySinhVien
{
    partial class Form1
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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diemk1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diemk2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remove = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.txtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDk1 = new System.Windows.Forms.TextBox();
            this.txtDk2 = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Maso,
            this.Hoten,
            this.Ngaysinh,
            this.Diemk1,
            this.Diemk2,
            this.DTB});
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(205, 263);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(706, 173);
            this.ListView1.TabIndex = 27;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView1_ItemSelectionChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 100;
            // 
            // Maso
            // 
            this.Maso.Text = "Ma so";
            this.Maso.Width = 100;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Ho ten";
            this.Hoten.Width = 100;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Text = "Ngay sinh";
            this.Ngaysinh.Width = 100;
            // 
            // Diemk1
            // 
            this.Diemk1.Text = "Diem ki 1";
            this.Diemk1.Width = 100;
            // 
            // Diemk2
            // 
            this.Diemk2.Text = "Diem ki 2";
            this.Diemk2.Width = 100;
            // 
            // DTB
            // 
            this.DTB.Text = "Diem TB";
            this.DTB.Width = 100;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(773, 177);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 26;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(773, 119);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 25;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(442, 118);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.txtNgaysinh.TabIndex = 23;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(442, 82);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(100, 20);
            this.txtHoten.TabIndex = 22;
            // 
            // txtDk1
            // 
            this.txtDk1.Location = new System.Drawing.Point(442, 174);
            this.txtDk1.Name = "txtDk1";
            this.txtDk1.Size = new System.Drawing.Size(100, 20);
            this.txtDk1.TabIndex = 21;
            // 
            // txtDk2
            // 
            this.txtDk2.Location = new System.Drawing.Point(442, 223);
            this.txtDk2.Name = "txtDk2";
            this.txtDk2.Size = new System.Drawing.Size(100, 20);
            this.txtDk2.TabIndex = 20;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(442, 37);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(100, 20);
            this.txtMasv.TabIndex = 19;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(202, 230);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Diem ki2";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(202, 177);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Diem ki1";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(202, 134);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Ngay sinh";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(202, 82);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Hoten";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(202, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Masv";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(773, 37);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 28;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 448);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtDk1);
            this.Controls.Add(this.txtDk2);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader STT;
        internal System.Windows.Forms.ColumnHeader Maso;
        internal System.Windows.Forms.ColumnHeader Hoten;
        internal System.Windows.Forms.ColumnHeader Ngaysinh;
        internal System.Windows.Forms.ColumnHeader Diemk1;
        internal System.Windows.Forms.ColumnHeader Diemk2;
        internal System.Windows.Forms.ColumnHeader DTB;
        internal System.Windows.Forms.Button Remove;
        internal System.Windows.Forms.Button Update;
        internal System.Windows.Forms.DateTimePicker txtNgaysinh;
        internal System.Windows.Forms.TextBox txtHoten;
        internal System.Windows.Forms.TextBox txtDk1;
        internal System.Windows.Forms.TextBox txtDk2;
        internal System.Windows.Forms.TextBox txtMasv;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Add;
    }
}

