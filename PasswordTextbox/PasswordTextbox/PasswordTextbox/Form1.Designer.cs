namespace PasswordTextbox
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
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new PasswordTextbox.PasswordTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAlternate = new System.Windows.Forms.Button();
            this.passwordFrenchTextBox1 = new PasswordTextbox.PasswordFrenchTextBox();
            this.SuspendLayout();
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.Location = new System.Drawing.Point(64, 181);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(229, 30);
            this.btnShowPassword.TabIndex = 1;
            this.btnShowPassword.Text = "Show Password";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 66);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.BackColor = System.Drawing.Color.Bisque;
            this.passwordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox1.Location = new System.Drawing.Point(64, 139);
            this.passwordTextBox1.MaxLength = 8;
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(229, 23);
            this.passwordTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conventional Password Textbox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Custom Password Textbox";
            // 
            // btnShowAlternate
            // 
            this.btnShowAlternate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAlternate.Location = new System.Drawing.Point(64, 285);
            this.btnShowAlternate.Name = "btnShowAlternate";
            this.btnShowAlternate.Size = new System.Drawing.Size(229, 30);
            this.btnShowAlternate.TabIndex = 1;
            this.btnShowAlternate.Text = "Show Password";
            this.btnShowAlternate.UseVisualStyleBackColor = true;
            this.btnShowAlternate.Click += new System.EventHandler(this.ShowPassword);
            // 
            // passwordFrenchTextBox1
            // 
            this.passwordFrenchTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordFrenchTextBox1.Location = new System.Drawing.Point(64, 237);
            this.passwordFrenchTextBox1.Name = "passwordFrenchTextBox1";
            this.passwordFrenchTextBox1.Size = new System.Drawing.Size(229, 23);
            this.passwordFrenchTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 336);
            this.Controls.Add(this.passwordFrenchTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShowAlternate);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.passwordTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Preview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PasswordTextBox passwordTextBox1;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowAlternate;
        private PasswordFrenchTextBox passwordFrenchTextBox1;
    }
}

