namespace TrainingDesktopSystem.Forms
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            menuStrip = new System.Windows.Forms.MenuStrip();
            asistenciaDeEntrenamientsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip = new System.Windows.Forms.StatusStrip();
            toolTip = new System.Windows.Forms.ToolTip(components);
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { asistenciaDeEntrenamientsoToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(1030, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // asistenciaDeEntrenamientsoToolStripMenuItem
            // 
            asistenciaDeEntrenamientsoToolStripMenuItem.Name = "asistenciaDeEntrenamientsoToolStripMenuItem";
            asistenciaDeEntrenamientsoToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            asistenciaDeEntrenamientsoToolStripMenuItem.Text = "Asistencia de Entrenamientos";
            asistenciaDeEntrenamientsoToolStripMenuItem.Click += Btn_AssistanceScan_OnClick;
            // 
            // statusStrip
            // 
            statusStrip.Location = new System.Drawing.Point(0, 591);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(1030, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1030, 613);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "Training System";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem asistenciaDeEntrenamientsoToolStripMenuItem;
    }
}



