
namespace Twenty_One
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
            this.die1 = new System.Windows.Forms.PictureBox();
            this.die2 = new System.Windows.Forms.PictureBox();
            this.rollBtn = new System.Windows.Forms.Button();
            this.againBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).BeginInit();
            this.SuspendLayout();
            // 
            // die1
            // 
            this.die1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die1.Image = global::Twenty_One.Properties.Resources.one;
            this.die1.Location = new System.Drawing.Point(48, 256);
            this.die1.MaximumSize = new System.Drawing.Size(100, 100);
            this.die1.MinimumSize = new System.Drawing.Size(100, 100);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(100, 100);
            this.die1.TabIndex = 0;
            this.die1.TabStop = false;
            // 
            // die2
            // 
            this.die2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die2.Image = global::Twenty_One.Properties.Resources.one;
            this.die2.ImageLocation = "";
            this.die2.Location = new System.Drawing.Point(200, 256);
            this.die2.MaximumSize = new System.Drawing.Size(100, 100);
            this.die2.MinimumSize = new System.Drawing.Size(100, 100);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(100, 100);
            this.die2.TabIndex = 1;
            this.die2.TabStop = false;
            // 
            // rollBtn
            // 
            this.rollBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBtn.Location = new System.Drawing.Point(16, 368);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(88, 56);
            this.rollBtn.TabIndex = 2;
            this.rollBtn.Text = "ROLL!";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // againBtn
            // 
            this.againBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.againBtn.Location = new System.Drawing.Point(136, 368);
            this.againBtn.Name = "againBtn";
            this.againBtn.Size = new System.Drawing.Size(80, 56);
            this.againBtn.TabIndex = 3;
            this.againBtn.Text = "Play Again";
            this.againBtn.UseVisualStyleBackColor = true;
            this.againBtn.Click += new System.EventHandler(this.againBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(256, 368);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(91, 56);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(352, 144);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Rules:\r\n\r\nRoll the dice to try to total 21 exactly.  Roll 2 dice until your total" +
    " is 15, then roll 1 die until you have hit 21, or gone over.  You win if you tot" +
    "al exactly 21.\r\n";
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtBox.Location = new System.Drawing.Point(144, 176);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.ReadOnly = true;
            this.totalTxtBox.Size = new System.Drawing.Size(64, 50);
            this.totalTxtBox.TabIndex = 6;
            this.totalTxtBox.Text = "0";
            this.totalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(160, 160);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(31, 13);
            this.totalLbl.TabIndex = 7;
            this.totalLbl.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(366, 445);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.againBtn);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Name = "Form1";
            this.Text = "Twenty One";
            ((System.ComponentModel.ISupportInitialize)(this.die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox die1;
        private System.Windows.Forms.PictureBox die2;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Button againBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.Label totalLbl;
    }
}

