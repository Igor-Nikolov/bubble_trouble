﻿namespace Bubble_Trouble
{
    partial class Pause
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
            this.SuspendLayout();
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bubble_Trouble.Properties.Resources.pause;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.MaximizeBox = false;
            this.Name = "Pause";
            this.Text = "Pause";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pause_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pause_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}