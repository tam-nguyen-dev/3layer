namespace GUI
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
            this.btn_xem = new System.Windows.Forms.Button();
            this.dtgvds = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtngsinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txthedt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(37, 391);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 0;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // dtgvds
            // 
            this.dtgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvds.Location = new System.Drawing.Point(13, 13);
            this.dtgvds.Name = "dtgvds";
            this.dtgvds.RowHeadersWidth = 51;
            this.dtgvds.RowTemplate.Height = 24;
            this.dtgvds.Size = new System.Drawing.Size(793, 357);
            this.dtgvds.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(536, 391);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(185, 391);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(349, 391);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "maSV";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(946, 24);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(125, 22);
            this.txtmasv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "hoten";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(946, 75);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(125, 22);
            this.txthoten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ngaysinh";
            // 
            // txtngsinh
            // 
            this.txtngsinh.Location = new System.Drawing.Point(946, 131);
            this.txtngsinh.Name = "txtngsinh";
            this.txtngsinh.Size = new System.Drawing.Size(125, 22);
            this.txtngsinh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "khoa";
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(946, 189);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(125, 22);
            this.txtkhoa.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "hedaotao";
            // 
            // txthedt
            // 
            this.txthedt.Location = new System.Drawing.Point(946, 325);
            this.txthedt.Name = "txthedt";
            this.txthedt.Size = new System.Drawing.Size(125, 22);
            this.txthedt.TabIndex = 3;
            this.txthedt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "lop";
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(946, 254);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(125, 22);
            this.txtlop.TabIndex = 3;
            this.txtlop.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 437);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthedt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtngsinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvds);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.DataGridView dtgvds;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtngsinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthedt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlop;
    }
}

