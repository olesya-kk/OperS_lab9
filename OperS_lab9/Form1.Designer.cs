namespace OperS_lab9
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
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxKeys = new System.Windows.Forms.ListBox();
            this.textBoxValueName = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.comboBoxRegistryRoot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(33, 40);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(108, 60);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "считать";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(33, 125);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(108, 60);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Записать";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(48, 205);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 55);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxKeys
            // 
            this.listBoxKeys.FormattingEnabled = true;
            this.listBoxKeys.ItemHeight = 16;
            this.listBoxKeys.Location = new System.Drawing.Point(48, 337);
            this.listBoxKeys.Name = "listBoxKeys";
            this.listBoxKeys.Size = new System.Drawing.Size(120, 84);
            this.listBoxKeys.TabIndex = 3;
            // 
            // textBoxValueName
            // 
            this.textBoxValueName.Location = new System.Drawing.Point(216, 52);
            this.textBoxValueName.Name = "textBoxValueName";
            this.textBoxValueName.Size = new System.Drawing.Size(100, 22);
            this.textBoxValueName.TabIndex = 4;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(216, 100);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue.TabIndex = 5;
            // 
            // comboBoxRegistryRoot
            // 
            this.comboBoxRegistryRoot.FormattingEnabled = true;
            this.comboBoxRegistryRoot.Location = new System.Drawing.Point(412, 49);
            this.comboBoxRegistryRoot.Name = "comboBoxRegistryRoot";
            this.comboBoxRegistryRoot.Size = new System.Drawing.Size(296, 24);
            this.comboBoxRegistryRoot.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxRegistryRoot);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxValueName);
            this.Controls.Add(this.listBoxKeys);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxKeys;
        private System.Windows.Forms.TextBox textBoxValueName;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.ComboBox comboBoxRegistryRoot;
    }
}

