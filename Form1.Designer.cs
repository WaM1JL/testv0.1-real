namespace Test {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.richTextBoxQue = new System.Windows.Forms.RichTextBox();
            this.radioButtonAns1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAns2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAns3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAns4 = new System.Windows.Forms.RadioButton();
            this.loadTestButton = new System.Windows.Forms.Button();
            this.enterAnsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxQue
            // 
            this.richTextBoxQue.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxQue.Name = "richTextBoxQue";
            this.richTextBoxQue.ReadOnly = true;
            this.richTextBoxQue.Size = new System.Drawing.Size(769, 129);
            this.richTextBoxQue.TabIndex = 0;
            this.richTextBoxQue.Text = "";
            // 
            // radioButtonAns1
            // 
            this.radioButtonAns1.AutoSize = true;
            this.radioButtonAns1.Location = new System.Drawing.Point(28, 177);
            this.radioButtonAns1.Name = "radioButtonAns1";
            this.radioButtonAns1.Size = new System.Drawing.Size(14, 13);
            this.radioButtonAns1.TabIndex = 1;
            this.radioButtonAns1.TabStop = true;
            this.radioButtonAns1.UseVisualStyleBackColor = true;
            this.radioButtonAns1.CheckedChanged += new System.EventHandler(this.radioButtonAns1_CheckedChanged);
            // 
            // radioButtonAns2
            // 
            this.radioButtonAns2.AutoSize = true;
            this.radioButtonAns2.Location = new System.Drawing.Point(28, 196);
            this.radioButtonAns2.Name = "radioButtonAns2";
            this.radioButtonAns2.Size = new System.Drawing.Size(14, 13);
            this.radioButtonAns2.TabIndex = 2;
            this.radioButtonAns2.TabStop = true;
            this.radioButtonAns2.UseVisualStyleBackColor = true;
            this.radioButtonAns2.CheckedChanged += new System.EventHandler(this.radioButtonAns2_CheckedChanged);
            // 
            // radioButtonAns3
            // 
            this.radioButtonAns3.AutoSize = true;
            this.radioButtonAns3.Location = new System.Drawing.Point(28, 219);
            this.radioButtonAns3.Name = "radioButtonAns3";
            this.radioButtonAns3.Size = new System.Drawing.Size(14, 13);
            this.radioButtonAns3.TabIndex = 3;
            this.radioButtonAns3.TabStop = true;
            this.radioButtonAns3.UseVisualStyleBackColor = true;
            this.radioButtonAns3.CheckedChanged += new System.EventHandler(this.radioButtonAns3_CheckedChanged);
            // 
            // radioButtonAns4
            // 
            this.radioButtonAns4.AutoSize = true;
            this.radioButtonAns4.Location = new System.Drawing.Point(28, 242);
            this.radioButtonAns4.Name = "radioButtonAns4";
            this.radioButtonAns4.Size = new System.Drawing.Size(14, 13);
            this.radioButtonAns4.TabIndex = 4;
            this.radioButtonAns4.TabStop = true;
            this.radioButtonAns4.UseVisualStyleBackColor = true;
            this.radioButtonAns4.CheckedChanged += new System.EventHandler(this.radioButtonAns4_CheckedChanged);
            // 
            // loadTestButton
            // 
            this.loadTestButton.Location = new System.Drawing.Point(256, 274);
            this.loadTestButton.Name = "loadTestButton";
            this.loadTestButton.Size = new System.Drawing.Size(272, 61);
            this.loadTestButton.TabIndex = 5;
            this.loadTestButton.Text = "Загрузить тест";
            this.loadTestButton.UseVisualStyleBackColor = true;
            this.loadTestButton.Click += new System.EventHandler(this.loadTestButton_Click);
            // 
            // enterAnsButton
            // 
            this.enterAnsButton.Location = new System.Drawing.Point(256, 362);
            this.enterAnsButton.Name = "enterAnsButton";
            this.enterAnsButton.Size = new System.Drawing.Size(272, 61);
            this.enterAnsButton.TabIndex = 6;
            this.enterAnsButton.Text = "Ответить на вопрос";
            this.enterAnsButton.UseVisualStyleBackColor = true;
            this.enterAnsButton.Click += new System.EventHandler(this.enterAnsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 447);
            this.Controls.Add(this.enterAnsButton);
            this.Controls.Add(this.loadTestButton);
            this.Controls.Add(this.radioButtonAns4);
            this.Controls.Add(this.radioButtonAns3);
            this.Controls.Add(this.radioButtonAns2);
            this.Controls.Add(this.radioButtonAns1);
            this.Controls.Add(this.richTextBoxQue);
            this.Name = "Form1";
            this.Text = "Тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQue;
        private System.Windows.Forms.RadioButton radioButtonAns1;
        private System.Windows.Forms.RadioButton radioButtonAns2;
        private System.Windows.Forms.RadioButton radioButtonAns3;
        private System.Windows.Forms.RadioButton radioButtonAns4;
        private System.Windows.Forms.Button loadTestButton;
        private System.Windows.Forms.Button enterAnsButton;
    }
}

