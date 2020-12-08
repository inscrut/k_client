
namespace K_Client
{
    partial class Form_Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(63, 34);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(155, 20);
            this.textBox_email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "e-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Авторизация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(63, 60);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(155, 20);
            this.textBox_pass.TabIndex = 4;
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(15, 86);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 23);
            this.button_enter.TabIndex = 5;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Не зарегистрированы?";
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(15, 147);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(89, 23);
            this.button_reg.TabIndex = 7;
            this.button_reg.Text = "Регистрация";
            this.button_reg.UseVisualStyleBackColor = true;
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 185);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Auth";
            this.ShowIcon = false;
            this.Text = "KClient Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reg;
    }
}

