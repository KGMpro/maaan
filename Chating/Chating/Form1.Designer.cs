namespace Chating
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterButton = new System.Windows.Forms.Button();
            this.PassLab = new System.Windows.Forms.Label();
            this.LogLab = new System.Windows.Forms.Label();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.LoginTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.Color.Black;
            this.EnterButton.Location = new System.Drawing.Point(93, 187);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(100, 23);
            this.EnterButton.TabIndex = 9;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PassLab
            // 
            this.PassLab.AutoSize = true;
            this.PassLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLab.ForeColor = System.Drawing.Color.Black;
            this.PassLab.Location = new System.Drawing.Point(93, 118);
            this.PassLab.Name = "PassLab";
            this.PassLab.Size = new System.Drawing.Size(68, 16);
            this.PassLab.TabIndex = 8;
            this.PassLab.Text = "Password";
            // 
            // LogLab
            // 
            this.LogLab.AutoSize = true;
            this.LogLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLab.ForeColor = System.Drawing.Color.Black;
            this.LogLab.Location = new System.Drawing.Point(93, 52);
            this.LogLab.Name = "LogLab";
            this.LogLab.Size = new System.Drawing.Size(41, 16);
            this.LogLab.TabIndex = 7;
            this.LogLab.Text = "Login";
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTBox.Location = new System.Drawing.Point(93, 137);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTBox.TabIndex = 6;
            // 
            // LoginTBox
            // 
            this.LoginTBox.ForeColor = System.Drawing.Color.Black;
            this.LoginTBox.Location = new System.Drawing.Point(93, 71);
            this.LoginTBox.Name = "LoginTBox";
            this.LoginTBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PassLab);
            this.Controls.Add(this.LogLab);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.LoginTBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label PassLab;
        private System.Windows.Forms.Label LogLab;
        private System.Windows.Forms.TextBox PasswordTBox;
        private System.Windows.Forms.TextBox LoginTBox;
    }
}

