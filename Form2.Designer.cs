
namespace Cricket
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.TeamResistrasion = new System.Windows.Forms.Button();
            this.Teams = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.Tournaments = new System.Windows.Forms.Button();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SlidingPanel.Controls.Add(this.Tournaments);
            this.SlidingPanel.Controls.Add(this.About);
            this.SlidingPanel.Controls.Add(this.User);
            this.SlidingPanel.Controls.Add(this.TeamResistrasion);
            this.SlidingPanel.Controls.Add(this.Teams);
            this.SlidingPanel.Controls.Add(this.button1);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(166, 534);
            this.SlidingPanel.TabIndex = 0;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Image = global::Cricket.Properties.Resources.about;
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.Location = new System.Drawing.Point(0, 195);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(163, 39);
            this.About.TabIndex = 6;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Image = global::Cricket.Properties.Resources.user;
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Location = new System.Drawing.Point(0, 156);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(163, 39);
            this.User.TabIndex = 4;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = false;
            // 
            // TeamResistrasion
            // 
            this.TeamResistrasion.BackColor = System.Drawing.Color.Transparent;
            this.TeamResistrasion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamResistrasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamResistrasion.Image = global::Cricket.Properties.Resources.registration;
            this.TeamResistrasion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TeamResistrasion.Location = new System.Drawing.Point(0, 39);
            this.TeamResistrasion.Name = "TeamResistrasion";
            this.TeamResistrasion.Size = new System.Drawing.Size(163, 39);
            this.TeamResistrasion.TabIndex = 3;
            this.TeamResistrasion.Text = "TeamRegistrasion";
            this.TeamResistrasion.UseVisualStyleBackColor = false;
            // 
            // Teams
            // 
            this.Teams.BackColor = System.Drawing.Color.Transparent;
            this.Teams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teams.Image = global::Cricket.Properties.Resources.team;
            this.Teams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Teams.Location = new System.Drawing.Point(0, 78);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(163, 39);
            this.Teams.TabIndex = 2;
            this.Teams.Text = "Teams";
            this.Teams.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Cricket.Properties.Resources.arrow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // Tournaments
            // 
            this.Tournaments.BackColor = System.Drawing.Color.Transparent;
            this.Tournaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tournaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tournaments.Image = global::Cricket.Properties.Resources.vs;
            this.Tournaments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tournaments.Location = new System.Drawing.Point(0, 117);
            this.Tournaments.Name = "Tournaments";
            this.Tournaments.Size = new System.Drawing.Size(163, 39);
            this.Tournaments.TabIndex = 3;
            this.Tournaments.Text = "Tournaments";
            this.Tournaments.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 534);
            this.Controls.Add(this.SlidingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Button TeamResistrasion;
        private System.Windows.Forms.Button Teams;
        private System.Windows.Forms.Button Tournaments;
    }
}