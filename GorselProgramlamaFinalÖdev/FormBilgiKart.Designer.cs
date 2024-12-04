namespace GorselProgramlamaFinalÖdev
{
    partial class FormBilgiKart
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
            this.pictureBoxKisiResim = new System.Windows.Forms.PictureBox();
            this.pictureBoxUlke = new System.Windows.Forms.PictureBox();
            this.buttonAd = new System.Windows.Forms.Button();
            this.buttonPuan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKisiResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUlke)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKisiResim
            // 
            this.pictureBoxKisiResim.Location = new System.Drawing.Point(18, 16);
            this.pictureBoxKisiResim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxKisiResim.Name = "pictureBoxKisiResim";
            this.pictureBoxKisiResim.Size = new System.Drawing.Size(500, 342);
            this.pictureBoxKisiResim.TabIndex = 0;
            this.pictureBoxKisiResim.TabStop = false;
            // 
            // pictureBoxUlke
            // 
            this.pictureBoxUlke.Location = new System.Drawing.Point(527, 15);
            this.pictureBoxUlke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxUlke.Name = "pictureBoxUlke";
            this.pictureBoxUlke.Size = new System.Drawing.Size(228, 194);
            this.pictureBoxUlke.TabIndex = 1;
            this.pictureBoxUlke.TabStop = false;
            // 
            // buttonAd
            // 
            this.buttonAd.Location = new System.Drawing.Point(528, 218);
            this.buttonAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAd.Name = "buttonAd";
            this.buttonAd.Size = new System.Drawing.Size(227, 61);
            this.buttonAd.TabIndex = 2;
            this.buttonAd.Text = "button1";
            this.buttonAd.UseVisualStyleBackColor = true;
            // 
            // buttonPuan
            // 
            this.buttonPuan.Location = new System.Drawing.Point(528, 298);
            this.buttonPuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPuan.Name = "buttonPuan";
            this.buttonPuan.Size = new System.Drawing.Size(227, 61);
            this.buttonPuan.TabIndex = 3;
            this.buttonPuan.Text = "button2";
            this.buttonPuan.UseVisualStyleBackColor = true;
            // 
            // FormBilgiKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 374);
            this.Controls.Add(this.buttonPuan);
            this.Controls.Add(this.buttonAd);
            this.Controls.Add(this.pictureBoxUlke);
            this.Controls.Add(this.pictureBoxKisiResim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBilgiKart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBilgiKart";
            this.Load += new System.EventHandler(this.FormBilgiKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKisiResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUlke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKisiResim;
        private System.Windows.Forms.PictureBox pictureBoxUlke;
        private System.Windows.Forms.Button buttonAd;
        private System.Windows.Forms.Button buttonPuan;
    }
}