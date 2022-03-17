namespace Lesson8_SeriousTask
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
            this.labelOnLoad = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьТекстБелымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOnLoad
            // 
            this.labelOnLoad.AutoSize = true;
            this.labelOnLoad.Location = new System.Drawing.Point(12, 58);
            this.labelOnLoad.Name = "labelOnLoad";
            this.labelOnLoad.Size = new System.Drawing.Size(44, 16);
            this.labelOnLoad.TabIndex = 0;
            this.labelOnLoad.Text = "label1";
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(281, 55);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(103, 23);
            this.btnRed.TabIndex = 1;
            this.btnRed.Text = "Красный";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(390, 55);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(103, 23);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Зеленый";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(499, 55);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(170, 23);
            this.btnWhite.TabIndex = 3;
            this.btnWhite.Text = "Сделать текст белым";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qsToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.сделатьТекстБелымToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qsToolStripMenuItem
            // 
            this.qsToolStripMenuItem.Name = "qsToolStripMenuItem";
            this.qsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.qsToolStripMenuItem.Text = "Красный";
            this.qsToolStripMenuItem.Click += new System.EventHandler(this.qsToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // сделатьТекстБелымToolStripMenuItem
            // 
            this.сделатьТекстБелымToolStripMenuItem.Name = "сделатьТекстБелымToolStripMenuItem";
            this.сделатьТекстБелымToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.сделатьТекстБелымToolStripMenuItem.Text = "Сделать текст белым";
            this.сделатьТекстБелымToolStripMenuItem.Click += new System.EventHandler(this.сделатьТекстБелымToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.labelOnLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOnLoad;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьТекстБелымToolStripMenuItem;
    }
}

