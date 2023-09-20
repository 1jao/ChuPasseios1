namespace Chu_Passeios
{
    partial class Form2
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
            this.btmforms2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmforms2
            // 
            this.btmforms2.BackColor = System.Drawing.Color.White;
            this.btmforms2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmforms2.Location = new System.Drawing.Point(330, 258);
            this.btmforms2.Name = "btmforms2";
            this.btmforms2.Size = new System.Drawing.Size(188, 23);
            this.btmforms2.TabIndex = 0;
            this.btmforms2.Text = "Realizar compra";
            this.btmforms2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chu_Passeios.Properties.Resources.Captura_de_tela_2023_09_20_113548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmforms2);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmforms2;
    }
}