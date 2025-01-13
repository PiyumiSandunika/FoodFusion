namespace DesktopApplication
{
    partial class AdminAddProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminAddProducts_imageView = new System.Windows.Forms.PictureBox();
            this.adminAddProducts_clearBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddProducts_deleteBtn = new System.Windows.Forms.Button();
            this.adminAddProducts_importBtn = new System.Windows.Forms.Button();
            this.adminAddProducts_updateBtn = new System.Windows.Forms.Button();
            this.adminAddProducts_addBtn = new System.Windows.Forms.Button();
            this.adminAddProducts_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminAddProducts_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminAddProducts_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adminAddProducts_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminAddProducts_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminAddProducts_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 399);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1122, 317);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Products";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.adminAddProducts_imageView);
            this.panel1.Controls.Add(this.adminAddProducts_clearBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.adminAddProducts_deleteBtn);
            this.panel1.Controls.Add(this.adminAddProducts_importBtn);
            this.panel1.Controls.Add(this.adminAddProducts_updateBtn);
            this.panel1.Controls.Add(this.adminAddProducts_addBtn);
            this.panel1.Controls.Add(this.adminAddProducts_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.adminAddProducts_price);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.adminAddProducts_stock);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.adminAddProducts_type);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.adminAddProducts_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adminAddProducts_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 291);
            this.panel1.TabIndex = 3;
            // 
            // adminAddProducts_imageView
            // 
            this.adminAddProducts_imageView.BackColor = System.Drawing.Color.Silver;
            this.adminAddProducts_imageView.Location = new System.Drawing.Point(1025, 32);
            this.adminAddProducts_imageView.Name = "adminAddProducts_imageView";
            this.adminAddProducts_imageView.Size = new System.Drawing.Size(108, 122);
            this.adminAddProducts_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddProducts_imageView.TabIndex = 19;
            this.adminAddProducts_imageView.TabStop = false;
            // 
            // adminAddProducts_clearBtn
            // 
            this.adminAddProducts_clearBtn.BackColor = System.Drawing.Color.Teal;
            this.adminAddProducts_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_clearBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_clearBtn.Location = new System.Drawing.Point(699, 213);
            this.adminAddProducts_clearBtn.Name = "adminAddProducts_clearBtn";
            this.adminAddProducts_clearBtn.Size = new System.Drawing.Size(132, 51);
            this.adminAddProducts_clearBtn.TabIndex = 17;
            this.adminAddProducts_clearBtn.Text = "CLEAR";
            this.adminAddProducts_clearBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_clearBtn.Click += new System.EventHandler(this.adminAddProducts_clearBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1025, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 122);
            this.panel3.TabIndex = 0;
            // 
            // adminAddProducts_deleteBtn
            // 
            this.adminAddProducts_deleteBtn.BackColor = System.Drawing.Color.Teal;
            this.adminAddProducts_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_deleteBtn.Location = new System.Drawing.Point(525, 213);
            this.adminAddProducts_deleteBtn.Name = "adminAddProducts_deleteBtn";
            this.adminAddProducts_deleteBtn.Size = new System.Drawing.Size(132, 51);
            this.adminAddProducts_deleteBtn.TabIndex = 16;
            this.adminAddProducts_deleteBtn.Text = "DELETE";
            this.adminAddProducts_deleteBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_deleteBtn.Click += new System.EventHandler(this.adminAddProducts_deleteBtn_Click);
            // 
            // adminAddProducts_importBtn
            // 
            this.adminAddProducts_importBtn.BackColor = System.Drawing.Color.Teal;
            this.adminAddProducts_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_importBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_importBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_importBtn.Location = new System.Drawing.Point(1025, 165);
            this.adminAddProducts_importBtn.Name = "adminAddProducts_importBtn";
            this.adminAddProducts_importBtn.Size = new System.Drawing.Size(108, 39);
            this.adminAddProducts_importBtn.TabIndex = 18;
            this.adminAddProducts_importBtn.Text = "Import";
            this.adminAddProducts_importBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_importBtn.Click += new System.EventHandler(this.adminAddProducts_importBtn_Click);
            // 
            // adminAddProducts_updateBtn
            // 
            this.adminAddProducts_updateBtn.BackColor = System.Drawing.Color.Teal;
            this.adminAddProducts_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_updateBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_updateBtn.Location = new System.Drawing.Point(349, 213);
            this.adminAddProducts_updateBtn.Name = "adminAddProducts_updateBtn";
            this.adminAddProducts_updateBtn.Size = new System.Drawing.Size(132, 51);
            this.adminAddProducts_updateBtn.TabIndex = 15;
            this.adminAddProducts_updateBtn.Text = "UPDATE";
            this.adminAddProducts_updateBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_updateBtn.Click += new System.EventHandler(this.adminAddProducts_updateBtn_Click);
            // 
            // adminAddProducts_addBtn
            // 
            this.adminAddProducts_addBtn.BackColor = System.Drawing.Color.Teal;
            this.adminAddProducts_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_addBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_addBtn.Location = new System.Drawing.Point(175, 213);
            this.adminAddProducts_addBtn.Name = "adminAddProducts_addBtn";
            this.adminAddProducts_addBtn.Size = new System.Drawing.Size(132, 51);
            this.adminAddProducts_addBtn.TabIndex = 14;
            this.adminAddProducts_addBtn.Text = "ADD";
            this.adminAddProducts_addBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_addBtn.Click += new System.EventHandler(this.adminAddProducts_addBtn_Click);
            // 
            // adminAddProducts_status
            // 
            this.adminAddProducts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_status.FormattingEnabled = true;
            this.adminAddProducts_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.adminAddProducts_status.Location = new System.Drawing.Point(629, 140);
            this.adminAddProducts_status.Name = "adminAddProducts_status";
            this.adminAddProducts_status.Size = new System.Drawing.Size(216, 37);
            this.adminAddProducts_status.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Status:";
            // 
            // adminAddProducts_price
            // 
            this.adminAddProducts_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminAddProducts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_price.Location = new System.Drawing.Point(629, 89);
            this.adminAddProducts_price.Name = "adminAddProducts_price";
            this.adminAddProducts_price.Size = new System.Drawing.Size(216, 30);
            this.adminAddProducts_price.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price ($):";
            // 
            // adminAddProducts_stock
            // 
            this.adminAddProducts_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminAddProducts_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_stock.Location = new System.Drawing.Point(629, 34);
            this.adminAddProducts_stock.Name = "adminAddProducts_stock";
            this.adminAddProducts_stock.Size = new System.Drawing.Size(216, 30);
            this.adminAddProducts_stock.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(552, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Stock:";
            // 
            // adminAddProducts_type
            // 
            this.adminAddProducts_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_type.FormattingEnabled = true;
            this.adminAddProducts_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.adminAddProducts_type.Location = new System.Drawing.Point(178, 140);
            this.adminAddProducts_type.Name = "adminAddProducts_type";
            this.adminAddProducts_type.Size = new System.Drawing.Size(216, 37);
            this.adminAddProducts_type.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type:";
            // 
            // adminAddProducts_name
            // 
            this.adminAddProducts_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminAddProducts_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_name.Location = new System.Drawing.Point(178, 89);
            this.adminAddProducts_name.Name = "adminAddProducts_name";
            this.adminAddProducts_name.Size = new System.Drawing.Size(216, 30);
            this.adminAddProducts_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name:";
            // 
            // adminAddProducts_id
            // 
            this.adminAddProducts_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminAddProducts_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_id.Location = new System.Drawing.Point(178, 34);
            this.adminAddProducts_id.Name = "adminAddProducts_id";
            this.adminAddProducts_id.Size = new System.Drawing.Size(216, 30);
            this.adminAddProducts_id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1197, 745);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox adminAddProducts_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminAddProducts_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox adminAddProducts_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminAddProducts_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminAddProducts_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox adminAddProducts_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adminAddProducts_importBtn;
        private System.Windows.Forms.PictureBox adminAddProducts_imageView;
        private System.Windows.Forms.Button adminAddProducts_clearBtn;
        private System.Windows.Forms.Button adminAddProducts_deleteBtn;
        private System.Windows.Forms.Button adminAddProducts_updateBtn;
        private System.Windows.Forms.Button adminAddProducts_addBtn;
    }
}
