namespace Справочник_ВУЗов
{
    partial class Справочники
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SPRAV = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SPRAV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(173, 72);
            this.panel1.MinimumSize = new System.Drawing.Size(173, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 41);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Города";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SPRAV
            // 
            this.SPRAV.BackColor = System.Drawing.Color.SteelBlue;
            this.SPRAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPRAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SPRAV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SPRAV.Image = global::Справочник_ВУЗов.Properties.Resources.Expand_Arrow_20px;
            this.SPRAV.Location = new System.Drawing.Point(0, 0);
            this.SPRAV.Name = "SPRAV";
            this.SPRAV.Size = new System.Drawing.Size(173, 41);
            this.SPRAV.TabIndex = 0;
            this.SPRAV.Text = "СПРАВОЧНИКИ";
            this.SPRAV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SPRAV.UseVisualStyleBackColor = false;
            this.SPRAV.Click += new System.EventHandler(this.SPRAV_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Справочники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 80);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Справочники";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочники";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SPRAV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}