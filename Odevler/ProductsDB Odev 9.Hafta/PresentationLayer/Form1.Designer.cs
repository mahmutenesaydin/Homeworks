namespace PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpcrud = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.btnonceki = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.grpcrud.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grpcrud
            // 
            this.grpcrud.Controls.Add(this.btnsonraki);
            this.grpcrud.Controls.Add(this.btnonceki);
            this.grpcrud.Controls.Add(this.btnClear);
            this.grpcrud.Controls.Add(this.btnList);
            this.grpcrud.Controls.Add(this.btnDelete);
            this.grpcrud.Controls.Add(this.btnUpdate);
            this.grpcrud.Controls.Add(this.btnInsert);
            this.grpcrud.Controls.Add(this.txtstock);
            this.grpcrud.Controls.Add(this.txtprice);
            this.grpcrud.Controls.Add(this.txtname);
            this.grpcrud.Controls.Add(this.txtid);
            this.grpcrud.Controls.Add(this.label4);
            this.grpcrud.Controls.Add(this.label3);
            this.grpcrud.Controls.Add(this.label2);
            this.grpcrud.Controls.Add(this.label1);
            this.grpcrud.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpcrud.Location = new System.Drawing.Point(1, 2);
            this.grpcrud.Name = "grpcrud";
            this.grpcrud.Size = new System.Drawing.Size(566, 267);
            this.grpcrud.TabIndex = 1;
            this.grpcrud.TabStop = false;
            this.grpcrud.Text = "CRUD";
            this.grpcrud.Enter += new System.EventHandler(this.grpcrud_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(234, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(234, 147);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(99, 35);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(234, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(234, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(234, 21);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 35);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(94, 176);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 27);
            this.txtstock.TabIndex = 4;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(94, 126);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 27);
            this.txtprice.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(94, 80);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 27);
            this.txtname.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 27);
            this.txtid.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // btnsonraki
            // 
            this.btnsonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsonraki.BackgroundImage")));
            this.btnsonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsonraki.Location = new System.Drawing.Point(396, 209);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(79, 51);
            this.btnsonraki.TabIndex = 4;
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // btnonceki
            // 
            this.btnonceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnonceki.BackgroundImage")));
            this.btnonceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnonceki.Location = new System.Drawing.Point(481, 209);
            this.btnonceki.Name = "btnonceki";
            this.btnonceki.Size = new System.Drawing.Size(79, 51);
            this.btnonceki.TabIndex = 7;
            this.btnonceki.UseVisualStyleBackColor = true;
            this.btnonceki.Click += new System.EventHandler(this.btnonceki_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvproducts);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(5, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 275);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // dgvproducts
            // 
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproducts.Location = new System.Drawing.Point(3, 23);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.Size = new System.Drawing.Size(562, 249);
            this.dgvproducts.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpcrud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpcrud.ResumeLayout(false);
            this.grpcrud.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpcrud;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Button btnonceki;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvproducts;
    }
}

