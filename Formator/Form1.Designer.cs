namespace Formator
{
    partial class Formator
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
            this.typographRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convertTextButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typographRichTextBox
            // 
            this.typographRichTextBox.BackColor = System.Drawing.Color.Black;
            this.typographRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.typographRichTextBox.ForeColor = System.Drawing.Color.White;
            this.typographRichTextBox.Location = new System.Drawing.Point(110, 108);
            this.typographRichTextBox.Name = "typographRichTextBox";
            this.typographRichTextBox.Size = new System.Drawing.Size(532, 242);
            this.typographRichTextBox.TabIndex = 0;
            this.typographRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст, который хотите преобразовать";
            // 
            // convertTextButton
            // 
            this.convertTextButton.BackColor = System.Drawing.Color.Black;
            this.convertTextButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertTextButton.ForeColor = System.Drawing.Color.White;
            this.convertTextButton.Location = new System.Drawing.Point(280, 371);
            this.convertTextButton.Name = "convertTextButton";
            this.convertTextButton.Size = new System.Drawing.Size(192, 64);
            this.convertTextButton.TabIndex = 2;
            this.convertTextButton.Text = "Преобразовать";
            this.convertTextButton.UseVisualStyleBackColor = false;
            this.convertTextButton.Click += new System.EventHandler(this.convertTextButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Black;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Location = new System.Drawing.Point(654, 389);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(134, 63);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Formator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.convertTextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typographRichTextBox);
            this.MaximizeBox = false;
            this.Name = "Formator";
            this.Text = "Formator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox typographRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertTextButton;
        private System.Windows.Forms.Button aboutButton;
    }
}

