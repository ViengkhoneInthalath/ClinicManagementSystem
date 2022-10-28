namespace CMS
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.left_panel = new System.Windows.Forms.Panel();
            this.backBtnPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.backBtnPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Navy;
            this.leftPanel.Controls.Add(this.left_panel);
            this.leftPanel.Controls.Add(this.backBtnPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(240, 624);
            this.leftPanel.TabIndex = 0;
            // 
            // left_panel
            // 
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_panel.Location = new System.Drawing.Point(0, 51);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(240, 573);
            this.left_panel.TabIndex = 2;
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Controls.Add(this.backBtn);
            this.backBtnPanel.Controls.Add(this.label1);
            this.backBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backBtnPanel.Location = new System.Drawing.Point(0, 0);
            this.backBtnPanel.Name = "backBtnPanel";
            this.backBtnPanel.Size = new System.Drawing.Size(240, 51);
            this.backBtnPanel.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = global::CMS.Properties.Resources._12;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 51);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernamePanel
            // 
            this.usernamePanel.Controls.Add(this.label2);
            this.usernamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernamePanel.Location = new System.Drawing.Point(0, 0);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(781, 51);
            this.usernamePanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.right_panel);
            this.rightPanel.Controls.Add(this.usernamePanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(240, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(781, 624);
            this.rightPanel.TabIndex = 1;
            // 
            // right_panel
            // 
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.Location = new System.Drawing.Point(0, 51);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(781, 573);
            this.right_panel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = " ...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 624);
            this.ControlBox = false;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sample";
            this.leftPanel.ResumeLayout(false);
            this.backBtnPanel.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel leftPanel;
        protected System.Windows.Forms.Panel backBtnPanel;
        protected System.Windows.Forms.Panel usernamePanel;
        protected System.Windows.Forms.Panel rightPanel;
        protected System.Windows.Forms.Panel left_panel;
        protected System.Windows.Forms.Panel right_panel;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button backBtn;
        protected System.Windows.Forms.Label label2;
    }
}

