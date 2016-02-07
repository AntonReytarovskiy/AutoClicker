namespace AutoClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numeric_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_time = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_time)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_count
            // 
            this.numeric_count.Location = new System.Drawing.Point(71, 35);
            this.numeric_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_count.Name = "numeric_count";
            this.numeric_count.Size = new System.Drawing.Size(120, 20);
            this.numeric_count.TabIndex = 0;
            this.numeric_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count";
            // 
            // numeric_time
            // 
            this.numeric_time.Location = new System.Drawing.Point(71, 85);
            this.numeric_time.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_time.Name = "numeric_time";
            this.numeric_time.Size = new System.Drawing.Size(120, 20);
            this.numeric_time.TabIndex = 0;
            this.numeric_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(80, 139);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(83, 20);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 185);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_time);
            this.Controls.Add(this.numeric_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto clicker";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer;
    }
}

