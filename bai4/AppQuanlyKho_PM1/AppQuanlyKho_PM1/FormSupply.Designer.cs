﻿namespace AppQuanlyKho_PM1
{
    partial class FormSupply
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dtgvSupply = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxUnitName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSupplyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSupplyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIDold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSupply)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdd.Location = new System.Drawing.Point(11, 342);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(325, 23);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonExit.Location = new System.Drawing.Point(1083, 422);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(69, 23);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1008, 422);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(69, 23);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Xóa ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(933, 422);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(69, 23);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dtgvSupply
            // 
            this.dtgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSupply.Location = new System.Drawing.Point(359, 59);
            this.dtgvSupply.Name = "dtgvSupply";
            this.dtgvSupply.Size = new System.Drawing.Size(793, 357);
            this.dtgvSupply.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxBarCode);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(11, 293);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(328, 33);
            this.panel7.TabIndex = 23;
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarCode.Location = new System.Drawing.Point(106, 4);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(219, 22);
            this.textBoxBarCode.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bar Code:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxQRCode);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(11, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 33);
            this.panel5.TabIndex = 24;
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQRCode.Location = new System.Drawing.Point(106, 4);
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.Size = new System.Drawing.Size(219, 22);
            this.textBoxQRCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "QR Code:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxSupplierName);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(11, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 33);
            this.panel4.TabIndex = 25;
            // 
            // comboBoxSupplierName
            // 
            this.comboBoxSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupplierName.FormattingEnabled = true;
            this.comboBoxSupplierName.Location = new System.Drawing.Point(106, 4);
            this.comboBoxSupplierName.Name = "comboBoxSupplierName";
            this.comboBoxSupplierName.Size = new System.Drawing.Size(219, 24);
            this.comboBoxSupplierName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxUnitName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(11, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 33);
            this.panel3.TabIndex = 26;
            // 
            // comboBoxUnitName
            // 
            this.comboBoxUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnitName.FormattingEnabled = true;
            this.comboBoxUnitName.Location = new System.Drawing.Point(106, 4);
            this.comboBoxUnitName.Name = "comboBoxUnitName";
            this.comboBoxUnitName.Size = new System.Drawing.Size(219, 24);
            this.comboBoxUnitName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Vật tư";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSupplyName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 33);
            this.panel2.TabIndex = 22;
            // 
            // textBoxSupplyName
            // 
            this.textBoxSupplyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplyName.Location = new System.Drawing.Point(106, 4);
            this.textBoxSupplyName.Name = "textBoxSupplyName";
            this.textBoxSupplyName.Size = new System.Drawing.Size(219, 22);
            this.textBoxSupplyName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSupplyID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 33);
            this.panel1.TabIndex = 21;
            // 
            // textBoxSupplyID
            // 
            this.textBoxSupplyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplyID.Location = new System.Drawing.Point(106, 4);
            this.textBoxSupplyID.Name = "textBoxSupplyID";
            this.textBoxSupplyID.Size = new System.Drawing.Size(219, 22);
            this.textBoxSupplyID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vật tư:";
            // 
            // labelIDold
            // 
            this.labelIDold.AutoSize = true;
            this.labelIDold.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelIDold.Location = new System.Drawing.Point(11, 59);
            this.labelIDold.Name = "labelIDold";
            this.labelIDold.Size = new System.Drawing.Size(50, 13);
            this.labelIDold.TabIndex = 33;
            this.labelIDold.Text = "loading...";
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1171, 456);
            this.Controls.Add(this.labelIDold);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dtgvSupply);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSupply";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSupply)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dtgvSupply;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxQRCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxSupplierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxUnitName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSupplyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSupplyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIDold;
    }
}