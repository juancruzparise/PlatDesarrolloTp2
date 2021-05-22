
namespace TP2
{
    partial class Form_register
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
            this.home_register = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textpassword_register = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textuser_resgister = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_register
            // 
            this.home_register.AutoSize = true;
            this.home_register.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_register.ForeColor = System.Drawing.Color.White;
            this.home_register.Location = new System.Drawing.Point(413, 141);
            this.home_register.Name = "home_register";
            this.home_register.Size = new System.Drawing.Size(107, 37);
            this.home_register.TabIndex = 9;
            this.home_register.Text = "Sign up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(345, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // textpassword_register
            // 
            this.textpassword_register.BackColor = System.Drawing.Color.DimGray;
            this.textpassword_register.ForeColor = System.Drawing.Color.White;
            this.textpassword_register.Location = new System.Drawing.Point(345, 281);
            this.textpassword_register.Name = "textpassword_register";
            this.textpassword_register.Size = new System.Drawing.Size(275, 23);
            this.textpassword_register.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(345, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNI";
            // 
            // textuser_resgister
            // 
            this.textuser_resgister.BackColor = System.Drawing.Color.DimGray;
            this.textuser_resgister.ForeColor = System.Drawing.Color.White;
            this.textuser_resgister.Location = new System.Drawing.Point(345, 226);
            this.textuser_resgister.Name = "textuser_resgister";
            this.textuser_resgister.Size = new System.Drawing.Size(275, 23);
            this.textuser_resgister.TabIndex = 10;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(416, 344);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(116, 37);
            this.button_register.TabIndex = 14;
            this.button_register.Text = "Sign in";
            this.button_register.UseVisualStyleBackColor = true;
            // 
            // button_atras
            // 
            this.button_atras.ForeColor = System.Drawing.Color.Black;
            this.button_atras.Location = new System.Drawing.Point(21, 22);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(94, 43);
            this.button_atras.TabIndex = 15;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpassword_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textuser_resgister);
            this.Controls.Add(this.home_register);
            this.Name = "Form_register";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label home_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpassword_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textuser_resgister;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_atras;
    }
}