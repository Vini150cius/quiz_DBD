namespace QuizDBD
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.TitlePage = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRaking = new System.Windows.Forms.Button();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitlePage
            // 
            resources.ApplyResources(this.TitlePage, "TitlePage");
            this.TitlePage.BackColor = System.Drawing.Color.Transparent;
            this.TitlePage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitlePage.Name = "TitlePage";
            this.TitlePage.Click += new System.EventHandler(this.TitlePage_Click);
            // 
            // btnIniciar
            // 
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnRaking
            // 
            resources.ApplyResources(this.btnRaking, "btnRaking");
            this.btnRaking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(103)))), ((int)(((byte)(9)))));
            this.btnRaking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaking.FlatAppearance.BorderSize = 0;
            this.btnRaking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRaking.Name = "btnRaking";
            this.btnRaking.UseVisualStyleBackColor = false;
            // 
            // linkPerfil
            // 
            this.linkPerfil.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkPerfil, "linkPerfil");
            this.linkPerfil.BackColor = System.Drawing.Color.Transparent;
            this.linkPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.linkPerfil.LinkColor = System.Drawing.Color.White;
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.TabStop = true;
            this.linkPerfil.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // HomeScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.linkPerfil);
            this.Controls.Add(this.btnRaking);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.TitlePage);
            this.Name = "HomeScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitlePage;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnRaking;
        private System.Windows.Forms.LinkLabel linkPerfil;
    }
}