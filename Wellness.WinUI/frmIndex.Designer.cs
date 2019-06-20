namespace Wellness.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clanarinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaClanarinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviTreningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menadzmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviRadnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isplataRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.izvjestavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clanarinaToolStripMenuItem,
            this.treningToolStripMenuItem,
            this.menadzmentToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // clanarinaToolStripMenuItem
            // 
            this.clanarinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.novaClanarinaToolStripMenuItem});
            this.clanarinaToolStripMenuItem.Name = "clanarinaToolStripMenuItem";
            this.clanarinaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.clanarinaToolStripMenuItem.Text = "Clanarina";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.PregledToolStripMenuItem_Click);
            // 
            // novaClanarinaToolStripMenuItem
            // 
            this.novaClanarinaToolStripMenuItem.Name = "novaClanarinaToolStripMenuItem";
            this.novaClanarinaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.novaClanarinaToolStripMenuItem.Text = "Nova clanarina";
            this.novaClanarinaToolStripMenuItem.Click += new System.EventHandler(this.NovaClanarinaToolStripMenuItem_Click);
            // 
            // treningToolStripMenuItem
            // 
            this.treningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem1,
            this.noviTreningToolStripMenuItem});
            this.treningToolStripMenuItem.Name = "treningToolStripMenuItem";
            this.treningToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.treningToolStripMenuItem.Text = "Trening";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.PregledToolStripMenuItem1_Click);
            // 
            // noviTreningToolStripMenuItem
            // 
            this.noviTreningToolStripMenuItem.Name = "noviTreningToolStripMenuItem";
            this.noviTreningToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.noviTreningToolStripMenuItem.Text = "Novi trening";
            this.noviTreningToolStripMenuItem.Click += new System.EventHandler(this.NoviTreningToolStripMenuItem_Click);
            // 
            // menadzmentToolStripMenuItem
            // 
            this.menadzmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem2,
            this.noviRadnikToolStripMenuItem,
            this.isplataRadnikaToolStripMenuItem,
            this.izvjestavanjeToolStripMenuItem});
            this.menadzmentToolStripMenuItem.Name = "menadzmentToolStripMenuItem";
            this.menadzmentToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.menadzmentToolStripMenuItem.Text = "Menadzment";
            // 
            // pregledToolStripMenuItem2
            // 
            this.pregledToolStripMenuItem2.Name = "pregledToolStripMenuItem2";
            this.pregledToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.pregledToolStripMenuItem2.Text = "Pregled";
            this.pregledToolStripMenuItem2.Click += new System.EventHandler(this.PregledToolStripMenuItem2_Click);
            // 
            // noviRadnikToolStripMenuItem
            // 
            this.noviRadnikToolStripMenuItem.Name = "noviRadnikToolStripMenuItem";
            this.noviRadnikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noviRadnikToolStripMenuItem.Text = "Novi radnik";
            this.noviRadnikToolStripMenuItem.Click += new System.EventHandler(this.NoviRadnikToolStripMenuItem_Click);
            // 
            // isplataRadnikaToolStripMenuItem
            // 
            this.isplataRadnikaToolStripMenuItem.Name = "isplataRadnikaToolStripMenuItem";
            this.isplataRadnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.isplataRadnikaToolStripMenuItem.Text = "Isplata radnika";
            this.isplataRadnikaToolStripMenuItem.Click += new System.EventHandler(this.IsplataRadnikaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // izvjestavanjeToolStripMenuItem
            // 
            this.izvjestavanjeToolStripMenuItem.Name = "izvjestavanjeToolStripMenuItem";
            this.izvjestavanjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izvjestavanjeToolStripMenuItem.Text = "Izvjestavanje";
            this.izvjestavanjeToolStripMenuItem.Click += new System.EventHandler(this.IzvjestavanjeToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem clanarinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaClanarinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noviTreningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menadzmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviRadnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem isplataRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestavanjeToolStripMenuItem;
    }
}



