namespace Practicum6_Task2_WF
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.buttonGetRes = new System.Windows.Forms.Button();
            this.richTextBoxRes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите последовательность:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(180, 10);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(199, 20);
            this.textBoxArea.TabIndex = 1;
            // 
            // buttonGetRes
            // 
            this.buttonGetRes.Location = new System.Drawing.Point(16, 43);
            this.buttonGetRes.Name = "buttonGetRes";
            this.buttonGetRes.Size = new System.Drawing.Size(363, 35);
            this.buttonGetRes.TabIndex = 2;
            this.buttonGetRes.Text = "Вычислить";
            this.buttonGetRes.UseVisualStyleBackColor = true;
            this.buttonGetRes.Click += new System.EventHandler(this.buttonGetRes_Click);
            // 
            // richTextBoxRes
            // 
            this.richTextBoxRes.Location = new System.Drawing.Point(16, 85);
            this.richTextBoxRes.Name = "richTextBoxRes";
            this.richTextBoxRes.ReadOnly = true;
            this.richTextBoxRes.Size = new System.Drawing.Size(363, 127);
            this.richTextBoxRes.TabIndex = 3;
            this.richTextBoxRes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 224);
            this.Controls.Add(this.richTextBoxRes);
            this.Controls.Add(this.buttonGetRes);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Практикум 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Button buttonGetRes;
        private System.Windows.Forms.RichTextBox richTextBoxRes;
    }
}

