
namespace K_Client
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed); //close app

            this.listBox_groups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_messages = new System.Windows.Forms.TextBox();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_go_to_tusur = new System.Windows.Forms.Button();
            this.button_go_to_lk = new System.Windows.Forms.Button();
            this.button_go_to_portal = new System.Windows.Forms.Button();
            this.button_app_share = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_groups
            // 
            this.listBox_groups.FormattingEnabled = true;
            this.listBox_groups.Location = new System.Drawing.Point(12, 25);
            this.listBox_groups.Name = "listBox_groups";
            this.listBox_groups.Size = new System.Drawing.Size(120, 407);
            this.listBox_groups.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сообщения";
            // 
            // textBox_messages
            // 
            this.textBox_messages.Location = new System.Drawing.Point(138, 25);
            this.textBox_messages.Multiline = true;
            this.textBox_messages.Name = "textBox_messages";
            this.textBox_messages.Size = new System.Drawing.Size(586, 277);
            this.textBox_messages.TabIndex = 3;
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(138, 308);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(485, 95);
            this.textBox_msg.TabIndex = 4;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(629, 308);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(95, 95);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // button_go_to_tusur
            // 
            this.button_go_to_tusur.Location = new System.Drawing.Point(138, 409);
            this.button_go_to_tusur.Name = "button_go_to_tusur";
            this.button_go_to_tusur.Size = new System.Drawing.Size(75, 23);
            this.button_go_to_tusur.TabIndex = 6;
            this.button_go_to_tusur.Text = "ТУСУР";
            this.button_go_to_tusur.UseVisualStyleBackColor = true;
            // 
            // button_go_to_lk
            // 
            this.button_go_to_lk.Location = new System.Drawing.Point(219, 409);
            this.button_go_to_lk.Name = "button_go_to_lk";
            this.button_go_to_lk.Size = new System.Drawing.Size(75, 23);
            this.button_go_to_lk.TabIndex = 7;
            this.button_go_to_lk.Text = "ЛК";
            this.button_go_to_lk.UseVisualStyleBackColor = true;
            // 
            // button_go_to_portal
            // 
            this.button_go_to_portal.Location = new System.Drawing.Point(300, 409);
            this.button_go_to_portal.Name = "button_go_to_portal";
            this.button_go_to_portal.Size = new System.Drawing.Size(75, 23);
            this.button_go_to_portal.TabIndex = 8;
            this.button_go_to_portal.Text = "Портал";
            this.button_go_to_portal.UseVisualStyleBackColor = true;
            // 
            // button_app_share
            // 
            this.button_app_share.Location = new System.Drawing.Point(629, 409);
            this.button_app_share.Name = "button_app_share";
            this.button_app_share.Size = new System.Drawing.Size(95, 23);
            this.button_app_share.TabIndex = 9;
            this.button_app_share.Text = "Приложение";
            this.button_app_share.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 443);
            this.Controls.Add(this.button_app_share);
            this.Controls.Add(this.button_go_to_portal);
            this.Controls.Add(this.button_go_to_lk);
            this.Controls.Add(this.button_go_to_tusur);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.textBox_messages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_groups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "KClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_groups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_messages;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_go_to_tusur;
        private System.Windows.Forms.Button button_go_to_lk;
        private System.Windows.Forms.Button button_go_to_portal;
        private System.Windows.Forms.Button button_app_share;
    }
}