namespace Chu_Passeios
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btmenter = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PASSWORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btmenter
            // 
            this.btmenter.Location = new System.Drawing.Point(59, 342);
            this.btmenter.Name = "btmenter";
            this.btmenter.Size = new System.Drawing.Size(100, 33);
            this.btmenter.TabIndex = 0;
            this.btmenter.Text = "ENTRAR";
            this.btmenter.UseVisualStyleBackColor = true;
            this.btmenter.Click += new System.EventHandler(this.btmenter_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblname.Location = new System.Drawing.Point(55, 173);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(63, 19);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "NOME:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Transparent;
            this.lblemail.Location = new System.Drawing.Point(56, 227);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(69, 19);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "E-MAIL:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblpassword.Location = new System.Drawing.Point(55, 278);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(72, 19);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "SENHA:";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 300);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME,
            this.EMAIL,
            this.PASSWORD});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(308, 107);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chu_Passeios.Properties.Resources.Captura_de_tela_2023_09_20_103715;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btmenter);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmenter;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader EMAIL;
        private System.Windows.Forms.ColumnHeader PASSWORD;
    }
}

