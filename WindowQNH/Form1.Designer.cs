namespace WindowQNH
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblOrario = new System.Windows.Forms.Label();
            this.lblQNH = new System.Windows.Forms.Label();
            this.lblTransition = new System.Windows.Forms.Label();
            this.lblFixedQNH = new System.Windows.Forms.Label();
            this.lblFixedTL = new System.Windows.Forms.Label();
            this.orologio = new System.Windows.Forms.Timer(this.components);
            this.btnImpostazioni = new System.Windows.Forms.Button();
            this.refreshQNH = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOrario
            // 
            this.lblOrario.AutoSize = true;
            this.lblOrario.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrario.Location = new System.Drawing.Point(49, 9);
            this.lblOrario.Name = "lblOrario";
            this.lblOrario.Size = new System.Drawing.Size(114, 23);
            this.lblOrario.TabIndex = 0;
            this.lblOrario.Text = "00:00:00";
            this.lblOrario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQNH
            // 
            this.lblQNH.AutoSize = true;
            this.lblQNH.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQNH.Location = new System.Drawing.Point(255, 8);
            this.lblQNH.Name = "lblQNH";
            this.lblQNH.Size = new System.Drawing.Size(62, 23);
            this.lblQNH.TabIndex = 1;
            this.lblQNH.Text = "////";
            // 
            // lblTransition
            // 
            this.lblTransition.AutoSize = true;
            this.lblTransition.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransition.Location = new System.Drawing.Point(389, 8);
            this.lblTransition.Name = "lblTransition";
            this.lblTransition.Size = new System.Drawing.Size(36, 23);
            this.lblTransition.TabIndex = 2;
            this.lblTransition.Text = "//";
            // 
            // lblFixedQNH
            // 
            this.lblFixedQNH.AutoSize = true;
            this.lblFixedQNH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFixedQNH.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedQNH.ForeColor = System.Drawing.SystemColors.Info;
            this.lblFixedQNH.Location = new System.Drawing.Point(181, 4);
            this.lblFixedQNH.Name = "lblFixedQNH";
            this.lblFixedQNH.Size = new System.Drawing.Size(68, 27);
            this.lblFixedQNH.TabIndex = 3;
            this.lblFixedQNH.Text = "QNH:";
            this.lblFixedQNH.Click += new System.EventHandler(this.lblFixedQNH_Click);
            // 
            // lblFixedTL
            // 
            this.lblFixedTL.AutoSize = true;
            this.lblFixedTL.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedTL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblFixedTL.Location = new System.Drawing.Point(337, 5);
            this.lblFixedTL.Name = "lblFixedTL";
            this.lblFixedTL.Size = new System.Drawing.Size(54, 27);
            this.lblFixedTL.TabIndex = 4;
            this.lblFixedTL.Text = "TL:";
            // 
            // orologio
            // 
            this.orologio.Enabled = true;
            this.orologio.Interval = 1;
            this.orologio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImpostazioni.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpostazioni.Location = new System.Drawing.Point(3, 7);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Size = new System.Drawing.Size(40, 23);
            this.btnImpostazioni.TabIndex = 5;
            this.btnImpostazioni.Text = "GET";
            this.btnImpostazioni.UseVisualStyleBackColor = false;
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // refreshQNH
            // 
            this.refreshQNH.Enabled = true;
            this.refreshQNH.Interval = 30000;
            this.refreshQNH.Tick += new System.EventHandler(this.refreshQNH_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(448, 39);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Sienna;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 327;
            this.lineShape2.X2 = 327;
            this.lineShape2.Y1 = 0;
            this.lineShape2.Y2 = 38;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Sienna;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 172;
            this.lineShape1.X2 = 172;
            this.lineShape1.Y1 = 1;
            this.lineShape1.Y2 = 39;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(14, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(448, 39);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnImpostazioni);
            this.Controls.Add(this.lblFixedTL);
            this.Controls.Add(this.lblFixedQNH);
            this.Controls.Add(this.lblTransition);
            this.Controls.Add(this.lblQNH);
            this.Controls.Add(this.lblOrario);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Radar Weather Strip";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrario;
        private System.Windows.Forms.Label lblQNH;
        private System.Windows.Forms.Label lblTransition;
        private System.Windows.Forms.Label lblFixedQNH;
        private System.Windows.Forms.Label lblFixedTL;
        private System.Windows.Forms.Timer orologio;
        private System.Windows.Forms.Button btnImpostazioni;
        private System.Windows.Forms.Timer refreshQNH;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

