namespace JogoTermoHeros.JogoPrincipal
{
    partial class jogoPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bTNpLAY = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.bTNpLAY);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 460);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Showcard Gothic", 15.25F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(11, 337);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(17, 116);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "EXIT";
            // 
            // bTNpLAY
            // 
            this.bTNpLAY.BackColor = System.Drawing.Color.Transparent;
            this.bTNpLAY.BackgroundImage = global::JogoTermoHeros.Properties.Resources.PLAY;
            this.bTNpLAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTNpLAY.Image = global::JogoTermoHeros.Properties.Resources.PLAY;
            this.bTNpLAY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bTNpLAY.Location = new System.Drawing.Point(-1, -2);
            this.bTNpLAY.Name = "bTNpLAY";
            this.bTNpLAY.Size = new System.Drawing.Size(48, 42);
            this.bTNpLAY.TabIndex = 1;
            this.bTNpLAY.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::JogoTermoHeros.Properties.Resources.Pause;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStop.Image = global::JogoTermoHeros.Properties.Resources.Pause;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStop.Location = new System.Drawing.Point(-2, 145);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 42);
            this.btnStop.TabIndex = 2;
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Showcard Gothic", 15.25F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(11, 184);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(17, 116);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "STOP";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 15.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(11, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(17, 112);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "P L A Y";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::JogoTermoHeros.Properties.Resources.EXIT;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExit.Location = new System.Drawing.Point(-2, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // jogoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoTermoHeros.Properties.Resources.temaJogoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Name = "jogoPrincipal";
            this.Text = "JogoPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button bTNpLAY;
    }
}