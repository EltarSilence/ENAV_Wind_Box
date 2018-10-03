namespace WindowQNH
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
            this.lblFixedICAOdC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtICAOdC = new System.Windows.Forms.TextBox();
            this.txtTranAlt = new System.Windows.Forms.TextBox();
            this.btnConfermaDati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFixedICAOdC
            // 
            this.lblFixedICAOdC.AutoSize = true;
            this.lblFixedICAOdC.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedICAOdC.Location = new System.Drawing.Point(12, 9);
            this.lblFixedICAOdC.Name = "lblFixedICAOdC";
            this.lblFixedICAOdC.Size = new System.Drawing.Size(65, 22);
            this.lblFixedICAOdC.TabIndex = 0;
            this.lblFixedICAOdC.Text = "ICAO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TA:";
            // 
            // txtICAOdC
            // 
            this.txtICAOdC.Location = new System.Drawing.Point(83, 11);
            this.txtICAOdC.Name = "txtICAOdC";
            this.txtICAOdC.Size = new System.Drawing.Size(100, 20);
            this.txtICAOdC.TabIndex = 2;
            // 
            // txtTranAlt
            // 
            this.txtTranAlt.Location = new System.Drawing.Point(83, 42);
            this.txtTranAlt.Name = "txtTranAlt";
            this.txtTranAlt.Size = new System.Drawing.Size(100, 20);
            this.txtTranAlt.TabIndex = 3;
            // 
            // btnConfermaDati
            // 
            this.btnConfermaDati.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfermaDati.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfermaDati.Location = new System.Drawing.Point(62, 68);
            this.btnConfermaDati.Name = "btnConfermaDati";
            this.btnConfermaDati.Size = new System.Drawing.Size(77, 32);
            this.btnConfermaDati.TabIndex = 4;
            this.btnConfermaDati.Text = "OK";
            this.btnConfermaDati.UseVisualStyleBackColor = true;
            this.btnConfermaDati.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(203, 101);
            this.Controls.Add(this.btnConfermaDati);
            this.Controls.Add(this.txtTranAlt);
            this.Controls.Add(this.txtICAOdC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFixedICAOdC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFixedICAOdC;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtICAOdC;
        public System.Windows.Forms.TextBox txtTranAlt;
        private System.Windows.Forms.Button btnConfermaDati;
    }
}