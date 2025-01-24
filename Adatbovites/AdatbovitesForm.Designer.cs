namespace Adatbovites
{
    partial class AdatbovitesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxOrszag = new TextBox();
            label1 = new Label();
            btnMentes = new Button();
            label2 = new Label();
            tbxTerulet = new TextBox();
            label3 = new Label();
            tbxNepesseg = new TextBox();
            label4 = new Label();
            tbxFovaros = new TextBox();
            label5 = new Label();
            tbxFvLakossag = new TextBox();
            label6 = new Label();
            btnKilepes = new Button();
            lblUzenet = new Label();
            SuspendLayout();
            // 
            // tbxOrszag
            // 
            tbxOrszag.Location = new Point(225, 133);
            tbxOrszag.Name = "tbxOrszag";
            tbxOrszag.Size = new Size(230, 36);
            tbxOrszag.TabIndex = 0;
            tbxOrszag.Text = "Chile";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(460, 101);
            label1.TabIndex = 1;
            label1.Text = "Új ország felvétele";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMentes
            // 
            btnMentes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMentes.Location = new Point(26, 568);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(181, 56);
            btnMentes.TabIndex = 5;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 136);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 1;
            label2.Text = "Ország:";
            // 
            // tbxTerulet
            // 
            tbxTerulet.Location = new Point(225, 192);
            tbxTerulet.Name = "tbxTerulet";
            tbxTerulet.Size = new Size(230, 36);
            tbxTerulet.TabIndex = 1;
            tbxTerulet.Text = "756950";
            tbxTerulet.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 195);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 1;
            label3.Text = "Terület:";
            // 
            // tbxNepesseg
            // 
            tbxNepesseg.Location = new Point(225, 251);
            tbxNepesseg.Name = "tbxNepesseg";
            tbxNepesseg.Size = new Size(230, 36);
            tbxNepesseg.TabIndex = 2;
            tbxNepesseg.Text = "19458000";
            tbxNepesseg.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 254);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 1;
            label4.Text = "Népesség:";
            // 
            // tbxFovaros
            // 
            tbxFovaros.Location = new Point(225, 310);
            tbxFovaros.Name = "tbxFovaros";
            tbxFovaros.Size = new Size(230, 36);
            tbxFovaros.TabIndex = 3;
            tbxFovaros.Text = "Santiago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 313);
            label5.Name = "label5";
            label5.Size = new Size(94, 30);
            label5.TabIndex = 1;
            label5.Text = "Főváros:";
            // 
            // tbxFvLakossag
            // 
            tbxFvLakossag.Location = new Point(225, 369);
            tbxFvLakossag.Name = "tbxFvLakossag";
            tbxFvLakossag.Size = new Size(230, 36);
            tbxFvLakossag.TabIndex = 4;
            tbxFvLakossag.Text = "6257516";
            tbxFvLakossag.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 373);
            label6.Name = "label6";
            label6.Size = new Size(193, 30);
            label6.TabIndex = 1;
            label6.Text = "Főváros lakossága:";
            // 
            // btnKilepes
            // 
            btnKilepes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnKilepes.Location = new Point(274, 568);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(181, 56);
            btnKilepes.TabIndex = 6;
            btnKilepes.Text = "Kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // lblUzenet
            // 
            lblUzenet.Font = new Font("Segoe UI", 16F);
            lblUzenet.Location = new Point(12, 408);
            lblUzenet.Name = "lblUzenet";
            lblUzenet.Size = new Size(460, 157);
            lblUzenet.TabIndex = 1;
            lblUzenet.Text = "Kérem adja meg az adatokat!";
            lblUzenet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdatbovitesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 661);
            Controls.Add(btnKilepes);
            Controls.Add(btnMentes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblUzenet);
            Controls.Add(label1);
            Controls.Add(tbxFvLakossag);
            Controls.Add(tbxFovaros);
            Controls.Add(tbxNepesseg);
            Controls.Add(tbxTerulet);
            Controls.Add(tbxOrszag);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AdatbovitesForm";
            Text = "Új ország felvétele";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxOrszag;
        private Label label1;
        private Button btnMentes;
        private Label label2;
        private TextBox tbxTerulet;
        private Label label3;
        private TextBox tbxNepesseg;
        private Label label4;
        private TextBox tbxFovaros;
        private Label label5;
        private TextBox tbxFvLakossag;
        private Label label6;
        private Button btnKilepes;
        private Label lblUzenet;
    }
}
