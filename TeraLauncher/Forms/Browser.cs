﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public class WebBrowserDemo
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
    {
        toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
        toolStripProgressBar1.Value = (int)e.CurrentProgress;
    }

    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
        toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;

    }
}
partial class Form1
{
    private void InitializeComponent()
    {
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        this.webBrowser1 = new System.Windows.Forms.WebBrowser();
        this.statusStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // statusStrip1
        // 
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.toolStripProgressBar1});
        this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
        this.statusStrip1.Location = new System.Drawing.Point(0, 488);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(695, 22);
        this.statusStrip1.TabIndex = 0;
        this.statusStrip1.Text = "statusStrip1";
        // 
        // toolStripProgressBar1
        // 
        this.toolStripProgressBar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
        this.toolStripProgressBar1.Name = "toolStripProgressBar1";
        this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
        this.toolStripProgressBar1.Text = "toolStripProgressBar1";
        // 
        // webBrowser1
        // 
        this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.webBrowser1.Location = new System.Drawing.Point(0, 0);
        this.webBrowser1.Name = "webBrowser1";
        this.webBrowser1.Size = new System.Drawing.Size(695, 488);
        this.webBrowser1.Url = new System.Uri("http://www.java2s.com", System.UriKind.Absolute);
        this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
        this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(695, 510);
        this.Controls.Add(this.webBrowser1);
        this.Controls.Add(this.statusStrip1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.statusStrip1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    private System.Windows.Forms.WebBrowser webBrowser1;
}