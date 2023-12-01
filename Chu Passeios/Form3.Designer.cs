namespace Chu_Passeios
{
    partial class Form3
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.ListView();
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PASSWORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btmdel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 281);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblpassword.Location = new System.Drawing.Point(88, 195);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(72, 19);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "SENHA:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Transparent;
            this.lblemail.Location = new System.Drawing.Point(102, 136);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(69, 19);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "E-MAIL:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblname.Location = new System.Drawing.Point(88, 66);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(63, 19);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "NOME:";
            // 
            // Table
            // 
            this.Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NAME,
            this.EMAIL,
            this.PASSWORD});
            this.Table.FullRowSelect = true;
            this.Table.HideSelection = false;
            this.Table.Location = new System.Drawing.Point(289, 78);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(308, 100);
            this.Table.TabIndex = 17;
            this.Table.UseCompatibleStateImageBehavior = false;
            this.Table.View = System.Windows.Forms.View.Details;
            this.Table.SelectedIndexChanged += new System.EventHandler(this.Table_SelectedIndexChanged);
            this.Table.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDoubleClick);
            // 
            // NAME
            // 
            this.NAME.Text = "NAME";
            // 
            // EMAIL
            // 
            this.EMAIL.Text = "EMAIL";
            // 
            // PASSWORD
            // 
            this.PASSWORD.Text = "PASSWORD";
            // 
            // btmdel
            // 
            this.btmdel.Location = new System.Drawing.Point(198, 336);
            this.btmdel.Name = "btmdel";
            this.btmdel.Size = new System.Drawing.Size(79, 33);
            this.btmdel.TabIndex = 18;
            this.btmdel.Text = "delete";
            this.btmdel.UseVisualStyleBackColor = true;
            this.btmdel.Click += new System.EventHandler(this.btmdel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(92, 336);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 33);
            this.btnedit.TabIndex = 19;
            this.btnedit.Text = "editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btmdel);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Name = "Form3";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListView Table;

        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader EMAIL;
        private System.Windows.Forms.ColumnHeader PASSWORD;
        private System.Windows.Forms.Button btmdel;
        private System.Windows.Forms.Button btnedit;
    }
}