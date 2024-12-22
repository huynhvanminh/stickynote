
namespace stickynotes
{
    partial class StickyNotes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNotes));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            newToolStripButton = new System.Windows.Forms.ToolStripButton();
            closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            menuToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            colorButton1 = new System.Windows.Forms.ToolStripMenuItem();
            colorButton2 = new System.Windows.Forms.ToolStripMenuItem();
            colorButton3 = new System.Windows.Forms.ToolStripMenuItem();
            colorButton4 = new System.Windows.Forms.ToolStripMenuItem();
            colorButton5 = new System.Windows.Forms.ToolStripMenuItem();
            openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip2 = new System.Windows.Forms.ToolStrip();
            boldButton = new System.Windows.Forms.ToolStripButton();
            italicButton = new System.Windows.Forms.ToolStripButton();
            underlineButton = new System.Windows.Forms.ToolStripButton();
            strikeButton = new System.Windows.Forms.ToolStripButton();
            bulletButton = new System.Windows.Forms.ToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.Color.FromArgb(255, 250, 166);
            toolStrip1.CanOverflow = false;
            toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripButton, closeToolStripButton, menuToolStripButton });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            toolStrip1.Size = new System.Drawing.Size(403, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.MouseDown += ToolStrip1_MouseDown;
            // 
            // newToolStripButton
            // 
            newToolStripButton.AutoSize = false;
            newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            newToolStripButton.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            newToolStripButton.Image = (System.Drawing.Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            newToolStripButton.Margin = new System.Windows.Forms.Padding(0);
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new System.Drawing.Size(33, 33);
            newToolStripButton.Text = "+";
            newToolStripButton.ToolTipText = "New";
            newToolStripButton.Click += NewToolStripButton_Clicked;
            // 
            // closeToolStripButton
            // 
            closeToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            closeToolStripButton.AutoSize = false;
            closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            closeToolStripButton.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            closeToolStripButton.Image = (System.Drawing.Image)resources.GetObject("closeToolStripButton.Image");
            closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            closeToolStripButton.Margin = new System.Windows.Forms.Padding(0);
            closeToolStripButton.Name = "closeToolStripButton";
            closeToolStripButton.Size = new System.Drawing.Size(33, 33);
            closeToolStripButton.Text = "✕";
            closeToolStripButton.ToolTipText = "Close";
            closeToolStripButton.Click += CloseToolStripButton_Clicked;
            // 
            // menuToolStripButton
            // 
            menuToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            menuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            menuToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { colorButton1, colorButton2, colorButton3, colorButton4, colorButton5, openMenuItem });
            menuToolStripButton.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuToolStripButton.Image = (System.Drawing.Image)resources.GetObject("menuToolStripButton.Image");
            menuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            menuToolStripButton.Margin = new System.Windows.Forms.Padding(0);
            menuToolStripButton.Name = "menuToolStripButton";
            menuToolStripButton.ShowDropDownArrow = false;
            menuToolStripButton.Size = new System.Drawing.Size(67, 33);
            menuToolStripButton.Text = "···";
            menuToolStripButton.ToolTipText = "Menu";
            // 
            // colorButton1
            // 
            colorButton1.BackColor = System.Drawing.Color.FromArgb(176, 204, 235);
            colorButton1.Name = "colorButton1";
            colorButton1.Size = new System.Drawing.Size(166, 32);
            colorButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            colorButton1.Click += ColorButton1_Clicked;
            // 
            // colorButton2
            // 
            colorButton2.BackColor = System.Drawing.Color.FromArgb(250, 185, 190);
            colorButton2.Name = "colorButton2";
            colorButton2.Size = new System.Drawing.Size(166, 32);
            colorButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            colorButton2.Click += ColorButton2_Clicked;
            // 
            // colorButton3
            // 
            colorButton3.BackColor = System.Drawing.Color.FromArgb(255, 250, 166);
            colorButton3.Name = "colorButton3";
            colorButton3.Size = new System.Drawing.Size(166, 32);
            colorButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            colorButton3.Click += ColorButton3_Clicked;
            // 
            // colorButton4
            // 
            colorButton4.BackColor = System.Drawing.Color.FromArgb(115, 201, 195);
            colorButton4.Name = "colorButton4";
            colorButton4.Size = new System.Drawing.Size(166, 32);
            colorButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            colorButton4.Click += ColorButton4_Clicked;
            // 
            // colorButton5
            // 
            colorButton5.BackColor = System.Drawing.Color.FromArgb(207, 227, 216);
            colorButton5.Name = "colorButton5";
            colorButton5.Size = new System.Drawing.Size(166, 32);
            colorButton5.Click += ColorButton5_Clicked;
            // 
            // openMenuItem
            // 
            openMenuItem.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new System.Drawing.Size(166, 32);
            openMenuItem.Text = "Open";
            openMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(225, 26);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = System.Drawing.Color.FromArgb(255, 250, 166);
            toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { boldButton, italicButton, underlineButton, strikeButton, bulletButton });
            toolStrip2.Location = new System.Drawing.Point(0, 217);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new System.Drawing.Size(403, 36);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // boldButton
            // 
            boldButton.AutoSize = false;
            boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            boldButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            boldButton.Image = (System.Drawing.Image)resources.GetObject("boldButton.Image");
            boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            boldButton.Margin = new System.Windows.Forms.Padding(6, 1, 4, 2);
            boldButton.Name = "boldButton";
            boldButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            boldButton.Size = new System.Drawing.Size(33, 33);
            boldButton.Text = "B";
            boldButton.ToolTipText = "Bold";
            boldButton.Click += BoldButton_Clicked;
            // 
            // italicButton
            // 
            italicButton.AutoSize = false;
            italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            italicButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            italicButton.Image = (System.Drawing.Image)resources.GetObject("italicButton.Image");
            italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            italicButton.Margin = new System.Windows.Forms.Padding(2, 1, 4, 2);
            italicButton.Name = "italicButton";
            italicButton.Size = new System.Drawing.Size(33, 33);
            italicButton.Text = "I";
            italicButton.ToolTipText = "Italic";
            italicButton.Click += ItalicButton_Clicked;
            // 
            // underlineButton
            // 
            underlineButton.AutoSize = false;
            underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            underlineButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            underlineButton.Image = (System.Drawing.Image)resources.GetObject("underlineButton.Image");
            underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            underlineButton.Margin = new System.Windows.Forms.Padding(4, 1, 2, 2);
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new System.Drawing.Size(33, 33);
            underlineButton.Text = "U";
            underlineButton.ToolTipText = "Underline";
            underlineButton.Click += UnderlineButton_Clicked;
            // 
            // strikeButton
            // 
            strikeButton.AutoSize = false;
            strikeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            strikeButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            strikeButton.Image = (System.Drawing.Image)resources.GetObject("strikeButton.Image");
            strikeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            strikeButton.Margin = new System.Windows.Forms.Padding(2, 1, 4, 2);
            strikeButton.Name = "strikeButton";
            strikeButton.Size = new System.Drawing.Size(33, 33);
            strikeButton.Text = "S";
            strikeButton.ToolTipText = "Strikethrough";
            strikeButton.Click += StrikeButton_Clicked;
            // 
            // bulletButton
            // 
            bulletButton.AutoSize = false;
            bulletButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            bulletButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bulletButton.Image = (System.Drawing.Image)resources.GetObject("bulletButton.Image");
            bulletButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            bulletButton.Margin = new System.Windows.Forms.Padding(2, 0, 1, 2);
            bulletButton.Name = "bulletButton";
            bulletButton.Size = new System.Drawing.Size(33, 33);
            bulletButton.Text = "⠸☰";
            bulletButton.ToolTipText = "Toggle Bullets";
            bulletButton.Click += BulletButton_Clicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 33);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(5, 5, 2, 5);
            panel1.Size = new System.Drawing.Size(403, 184);
            panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(5, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            richTextBox1.Size = new System.Drawing.Size(396, 174);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // StickyNotes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(1F, 2F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 250, 166);
            ClientSize = new System.Drawing.Size(403, 253);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Font = new System.Drawing.Font("Lucida Console", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(0);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(250, 200);
            Name = "StickyNotes";
            ShowIcon = false;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton menuToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripButton strikeButton;
        private System.Windows.Forms.ToolStripButton bulletButton;
        private System.Windows.Forms.ToolStripMenuItem colorButton1;
        private System.Windows.Forms.ToolStripMenuItem colorButton2;
        private System.Windows.Forms.ToolStripMenuItem colorButton3;
        private System.Windows.Forms.ToolStripMenuItem colorButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem colorButton5;
    }
}

