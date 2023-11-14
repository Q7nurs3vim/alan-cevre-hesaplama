namespace yarıcap_alan_hesaplama_1575
{
    partial class Form1
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
            lblYaricap = new Label();
            lblCevre = new Label();
            lblAlan = new Label();
            txtYaricap = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblYaricap
            // 
            lblYaricap.AutoSize = true;
            lblYaricap.Location = new Point(26, 25);
            lblYaricap.Name = "lblYaricap";
            lblYaricap.Size = new Size(73, 20);
            lblYaricap.TabIndex = 0;
            lblYaricap.Text = "YARIÇAP :";
            // 
            // lblCevre
            // 
            lblCevre.AutoSize = true;
            lblCevre.Location = new Point(26, 92);
            lblCevre.Name = "lblCevre";
            lblCevre.Size = new Size(59, 20);
            lblCevre.TabIndex = 1;
            lblCevre.Text = "ÇEVRE :";
            // 
            // lblAlan
            // 
            lblAlan.AutoSize = true;
            lblAlan.Location = new Point(26, 169);
            lblAlan.Name = "lblAlan";
            lblAlan.Size = new Size(54, 20);
            lblAlan.TabIndex = 2;
            lblAlan.Text = "ALAN :";
            // 
            // txtYaricap
            // 
            txtYaricap.Location = new Point(131, 22);
            txtYaricap.Name = "txtYaricap";
            txtYaricap.Size = new Size(125, 27);
            txtYaricap.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Location = new Point(275, 22);
            button1.Name = "button1";
            button1.Size = new Size(128, 27);
            button1.TabIndex = 4;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(422, 215);
            Controls.Add(button1);
            Controls.Add(txtYaricap);
            Controls.Add(lblAlan);
            Controls.Add(lblCevre);
            Controls.Add(lblYaricap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYaricap;
        private Label lblCevre;
        private Label lblAlan;
        private TextBox txtYaricap;
        private Button button1;
    }
}