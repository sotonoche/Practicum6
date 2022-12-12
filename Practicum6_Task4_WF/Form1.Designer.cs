namespace Practicum6_Task4_WF
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
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVector = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxArea = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размерность ступенчатого массива:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(257, 12);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите последовательность эл-тов массива:";
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(257, 46);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(120, 20);
            this.textBoxArray.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите последовательность эл-тов вектора:";
            // 
            // textBoxVector
            // 
            this.textBoxVector.Location = new System.Drawing.Point(257, 79);
            this.textBoxVector.Name = "textBoxVector";
            this.textBoxVector.Size = new System.Drawing.Size(120, 20);
            this.textBoxVector.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxArea
            // 
            this.richTextBoxArea.Location = new System.Drawing.Point(15, 147);
            this.richTextBoxArea.Name = "richTextBoxArea";
            this.richTextBoxArea.ReadOnly = true;
            this.richTextBoxArea.Size = new System.Drawing.Size(362, 181);
            this.richTextBoxArea.TabIndex = 7;
            this.richTextBoxArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 340);
            this.Controls.Add(this.richTextBoxArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxVector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Практикум 6";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxArea;
    }
}

