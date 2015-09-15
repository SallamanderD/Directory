namespace WindowsFormsApplication1
{
    partial class TitleForm
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
            this.inputPass = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.logoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPass
            // 
            this.inputPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPass.Location = new System.Drawing.Point(474, 444);
            this.inputPass.Name = "inputPass";
            this.inputPass.PasswordChar = '*';
            this.inputPass.Size = new System.Drawing.Size(150, 31);
            this.inputPass.TabIndex = 1;
            this.inputPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(379, 449);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(71, 20);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Пароль:";
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongLabel.Location = new System.Drawing.Point(367, 498);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(291, 20);
            this.wrongLabel.TabIndex = 3;
            this.wrongLabel.Text = "Введенный пароль недействителен!";
            this.wrongLabel.Visible = false;
            // 
            // logoPB
            // 
            this.logoPB.Image = global::WindowsFormsApplication1.Properties.Resources.interpol_logo;
            this.logoPB.Location = new System.Drawing.Point(319, 29);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(389, 326);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 0;
            this.logoPB.TabStop = false;
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 527);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.logoPB);
            this.Name = "TitleForm";
            this.Text = "Title_Form";
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label wrongLabel;
    }
}