
namespace TP2
{
    partial class Form_change_password
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
            this.button_change_password = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_current_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.home_change_password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_new_password = new System.Windows.Forms.TextBox();
            this.button_atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_change_password
            // 
            this.button_change_password.Location = new System.Drawing.Point(427, 351);
            this.button_change_password.Name = "button_change_password";
            this.button_change_password.Size = new System.Drawing.Size(116, 37);
            this.button_change_password.TabIndex = 20;
            this.button_change_password.Text = "Change";
            this.button_change_password.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(344, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current password";
            // 
            // text_current_password
            // 
            this.text_current_password.BackColor = System.Drawing.Color.DimGray;
            this.text_current_password.ForeColor = System.Drawing.Color.White;
            this.text_current_password.Location = new System.Drawing.Point(344, 246);
            this.text_current_password.Name = "text_current_password";
            this.text_current_password.Size = new System.Drawing.Size(275, 23);
            this.text_current_password.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "DNI";
            // 
            // text_dni
            // 
            this.text_dni.BackColor = System.Drawing.Color.DimGray;
            this.text_dni.ForeColor = System.Drawing.Color.White;
            this.text_dni.Location = new System.Drawing.Point(344, 193);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(275, 23);
            this.text_dni.TabIndex = 16;
            // 
            // home_change_password
            // 
            this.home_change_password.AutoSize = true;
            this.home_change_password.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_change_password.ForeColor = System.Drawing.Color.White;
            this.home_change_password.Location = new System.Drawing.Point(375, 107);
            this.home_change_password.Name = "home_change_password";
            this.home_change_password.Size = new System.Drawing.Size(228, 37);
            this.home_change_password.TabIndex = 15;
            this.home_change_password.Text = "Change password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(345, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "New password";
            // 
            // text_new_password
            // 
            this.text_new_password.BackColor = System.Drawing.Color.DimGray;
            this.text_new_password.ForeColor = System.Drawing.Color.White;
            this.text_new_password.Location = new System.Drawing.Point(344, 305);
            this.text_new_password.Name = "text_new_password";
            this.text_new_password.Size = new System.Drawing.Size(275, 23);
            this.text_new_password.TabIndex = 21;
            // 
            // button_atras
            // 
            this.button_atras.ForeColor = System.Drawing.Color.Black;
            this.button_atras.Location = new System.Drawing.Point(22, 22);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(98, 45);
            this.button_atras.TabIndex = 23;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            // 
            // Form_change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_new_password);
            this.Controls.Add(this.button_change_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_current_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.home_change_password);
            this.Name = "Form_change_password";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_change_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_current_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_dni;
        private System.Windows.Forms.Label home_change_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_new_password;
        private System.Windows.Forms.Button button_atras;
    }
}