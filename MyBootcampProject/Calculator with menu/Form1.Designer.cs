
namespace Calculator_with_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNameMenu = new System.Windows.Forms.Label();
            this.lblLinkCalculator = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNameMenu
            // 
            this.lblNameMenu.AutoSize = true;
            this.lblNameMenu.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameMenu.Location = new System.Drawing.Point(14, 38);
            this.lblNameMenu.Name = "lblNameMenu";
            this.lblNameMenu.Size = new System.Drawing.Size(647, 65);
            this.lblNameMenu.TabIndex = 0;
            this.lblNameMenu.Text = "Добро Пожаловать!";
            // 
            // lblLinkCalculator
            // 
            this.lblLinkCalculator.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblLinkCalculator.AutoSize = true;
            this.lblLinkCalculator.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkCalculator.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblLinkCalculator.Location = new System.Drawing.Point(189, 155);
            this.lblLinkCalculator.Name = "lblLinkCalculator";
            this.lblLinkCalculator.Size = new System.Drawing.Size(272, 46);
            this.lblLinkCalculator.TabIndex = 1;
            this.lblLinkCalculator.TabStop = true;
            this.lblLinkCalculator.Text = "Калькулятор";
            this.lblLinkCalculator.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblLinkCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCalculator_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(667, 293);
            this.Controls.Add(this.lblLinkCalculator);
            this.Controls.Add(this.lblNameMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню проекта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameMenu;
        private System.Windows.Forms.LinkLabel lblLinkCalculator;
    }
}

