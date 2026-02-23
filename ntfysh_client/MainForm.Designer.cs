
namespace ntfysh_client
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            subscribeNewTopic = new System.Windows.Forms.Button();
            removeSelectedTopics = new System.Windows.Forms.Button();
            无订阅的主题 = new System.Windows.Forms.ListBox();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            trayContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            showControlWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ntfyshWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            trayContextMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // subscribeNewTopic
            // 
            subscribeNewTopic.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            subscribeNewTopic.Location = new System.Drawing.Point(332, 402);
            subscribeNewTopic.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            subscribeNewTopic.Name = "subscribeNewTopic";
            subscribeNewTopic.Size = new System.Drawing.Size(295, 43);
            subscribeNewTopic.TabIndex = 2;
            subscribeNewTopic.Text = "订阅新主题(Topic)";
            subscribeNewTopic.UseVisualStyleBackColor = true;
            subscribeNewTopic.Click += subscribeNewTopic_Click;
            // 
            // removeSelectedTopics
            // 
            removeSelectedTopics.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            removeSelectedTopics.Enabled = false;
            removeSelectedTopics.Location = new System.Drawing.Point(20, 402);
            removeSelectedTopics.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            removeSelectedTopics.Name = "removeSelectedTopics";
            removeSelectedTopics.Size = new System.Drawing.Size(295, 43);
            removeSelectedTopics.TabIndex = 0;
            removeSelectedTopics.Text = "移除选择的主题";
            removeSelectedTopics.UseVisualStyleBackColor = true;
            removeSelectedTopics.Click += removeSelectedTopics_Click;
            // 
            // 无订阅的主题
            // 
            无订阅的主题.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            无订阅的主题.FormattingEnabled = true;
            无订阅的主题.ItemHeight = 24;
            无订阅的主题.Location = new System.Drawing.Point(20, 74);
            无订阅的主题.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            无订阅的主题.Name = "无订阅的主题";
            无订阅的主题.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            无订阅的主题.Size = new System.Drawing.Size(604, 316);
            无订阅的主题.TabIndex = 3;
            无订阅的主题.Click += notificationTopics_Click;
            无订阅的主题.SelectedIndexChanged += notificationTopics_SelectedIndexChanged;
            无订阅的主题.SelectedValueChanged += notificationTopics_SelectedValueChanged;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = trayContextMenu;
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "ntfy.sh";
            notifyIcon.Visible = true;
            notifyIcon.Click += notifyIcon_Click;
            // 
            // trayContextMenu
            // 
            trayContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showControlWindowToolStripMenuItem, exitToolStripMenuItem });
            trayContextMenu.Name = "trayContextMenu";
            trayContextMenu.Size = new System.Drawing.Size(273, 68);
            // 
            // showControlWindowToolStripMenuItem
            // 
            showControlWindowToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("showControlWindowToolStripMenuItem.Image");
            showControlWindowToolStripMenuItem.Name = "showControlWindowToolStripMenuItem";
            showControlWindowToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            showControlWindowToolStripMenuItem.Text = "Show control window";
            showControlWindowToolStripMenuItem.Click += showControlWindowToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.White;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(647, 34);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem1, settingsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            fileToolStripMenuItem.Text = "系统";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("exitToolStripMenuItem1.Image");
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new System.Drawing.Size(146, 34);
            exitToolStripMenuItem1.Text = "退出";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("settingsToolStripMenuItem.Image");
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            settingsToolStripMenuItem.Text = "设置";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ntfyshWebsiteToolStripMenuItem, toolStripMenuItem1, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            helpToolStripMenuItem.Text = "帮助";
            // 
            // ntfyshWebsiteToolStripMenuItem
            // 
            ntfyshWebsiteToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ntfyshWebsiteToolStripMenuItem.Image");
            ntfyshWebsiteToolStripMenuItem.Name = "ntfyshWebsiteToolStripMenuItem";
            ntfyshWebsiteToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            ntfyshWebsiteToolStripMenuItem.Text = "打开网页ntfy.sh";
            ntfyshWebsiteToolStripMenuItem.Click += ntfyshWebsiteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            aboutToolStripMenuItem.Text = "关于";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 43);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 24);
            label1.TabIndex = 1;
            label1.Text = "已订阅通知主题：";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(647, 461);
            Controls.Add(menuStrip1);
            Controls.Add(无订阅的主题);
            Controls.Add(removeSelectedTopics);
            Controls.Add(subscribeNewTopic);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ntfy pusher";
            FormClosing += MainForm_FormClosing;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            trayContextMenu.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button subscribeNewTopic;
        private System.Windows.Forms.Button removeSelectedTopics;
        private System.Windows.Forms.ListBox 无订阅的主题;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showControlWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ntfyshWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

