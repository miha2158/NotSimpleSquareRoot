using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotSimpleSquareRoot
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent ( )
        {
            this.LangPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EnglishLang = new System.Windows.Forms.Button();
            this.SpanishLang = new System.Windows.Forms.Button();
            this.ChineseLang = new System.Windows.Forms.Button();
            this.RussianLang = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LangControl = new System.Windows.Forms.TabPage();
            this.Panel1 = new System.Windows.Forms.TabPage();
            this.ResultCalc1 = new System.Windows.Forms.Button();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Result1 = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.TabPage();
            this.ResultCalc2 = new System.Windows.Forms.Button();
            this.Result2 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.LangPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.LangControl.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LangPanel
            // 
            this.LangPanel.AutoSize = true;
            this.LangPanel.ColumnCount = 2;
            this.LangPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LangPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LangPanel.Controls.Add(this.EnglishLang, 0, 0);
            this.LangPanel.Controls.Add(this.SpanishLang, 0, 1);
            this.LangPanel.Controls.Add(this.ChineseLang, 1, 0);
            this.LangPanel.Controls.Add(this.RussianLang, 1, 1);
            this.LangPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LangPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LangPanel.Location = new System.Drawing.Point(0, 0);
            this.LangPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LangPanel.Name = "LangPanel";
            this.LangPanel.RowCount = 2;
            this.LangPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LangPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LangPanel.Size = new System.Drawing.Size(732, 377);
            this.LangPanel.TabIndex = 0;
            this.LangPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LangPanel_Paint);
            // 
            // EnglishLang
            // 
            this.EnglishLang.AutoSize = true;
            this.EnglishLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnglishLang.Location = new System.Drawing.Point(0, 0);
            this.EnglishLang.Margin = new System.Windows.Forms.Padding(0);
            this.EnglishLang.Name = "EnglishLang";
            this.EnglishLang.Size = new System.Drawing.Size(366, 188);
            this.EnglishLang.TabIndex = 0;
            this.EnglishLang.Text = "English";
            this.EnglishLang.UseVisualStyleBackColor = true;
            this.EnglishLang.Click += new System.EventHandler(this.EnglishLang_Click);
            // 
            // SpanishLang
            // 
            this.SpanishLang.AutoSize = true;
            this.SpanishLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpanishLang.Location = new System.Drawing.Point(0, 188);
            this.SpanishLang.Margin = new System.Windows.Forms.Padding(0);
            this.SpanishLang.Name = "SpanishLang";
            this.SpanishLang.Size = new System.Drawing.Size(366, 189);
            this.SpanishLang.TabIndex = 2;
            this.SpanishLang.Text = "Español";
            this.SpanishLang.UseVisualStyleBackColor = true;
            this.SpanishLang.Click += new System.EventHandler(this.SpanishLang_Click);
            // 
            // ChineseLang
            // 
            this.ChineseLang.AutoSize = true;
            this.ChineseLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChineseLang.Font = new System.Drawing.Font("Microsoft MHei", 36F);
            this.ChineseLang.Location = new System.Drawing.Point(366, 0);
            this.ChineseLang.Margin = new System.Windows.Forms.Padding(0);
            this.ChineseLang.Name = "ChineseLang";
            this.ChineseLang.Size = new System.Drawing.Size(366, 188);
            this.ChineseLang.TabIndex = 1;
            this.ChineseLang.Text = "漢語";
            this.ChineseLang.UseVisualStyleBackColor = true;
            this.ChineseLang.Click += new System.EventHandler(this.ChineseLang_Click);
            // 
            // RussianLang
            // 
            this.RussianLang.AutoSize = true;
            this.RussianLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RussianLang.Location = new System.Drawing.Point(366, 188);
            this.RussianLang.Margin = new System.Windows.Forms.Padding(0);
            this.RussianLang.Name = "RussianLang";
            this.RussianLang.Size = new System.Drawing.Size(366, 189);
            this.RussianLang.TabIndex = 3;
            this.RussianLang.Text = "Русский";
            this.RussianLang.UseVisualStyleBackColor = true;
            this.RussianLang.Click += new System.EventHandler(this.RussianLang_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.LangControl);
            this.tabControl1.Controls.Add(this.Panel1);
            this.tabControl1.Controls.Add(this.Panel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 420);
            this.tabControl1.TabIndex = 2;
            // 
            // LangControl
            // 
            this.LangControl.Controls.Add(this.LangPanel);
            this.LangControl.Font = new System.Drawing.Font("Arial", 29F);
            this.LangControl.Location = new System.Drawing.Point(4, 39);
            this.LangControl.Margin = new System.Windows.Forms.Padding(0);
            this.LangControl.Name = "LangControl";
            this.LangControl.Size = new System.Drawing.Size(732, 377);
            this.LangControl.TabIndex = 0;
            this.LangControl.Text = " ";
            this.LangControl.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.ResultCalc1);
            this.Panel1.Controls.Add(this.Input1);
            this.Panel1.Controls.Add(this.Result1);
            this.Panel1.Location = new System.Drawing.Point(4, 39);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(732, 377);
            this.Panel1.TabIndex = 1;
            this.Panel1.Text = " ";
            this.Panel1.UseVisualStyleBackColor = true;
            // 
            // ResultCalc1
            // 
            this.ResultCalc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultCalc1.Location = new System.Drawing.Point(0, 170);
            this.ResultCalc1.Margin = new System.Windows.Forms.Padding(0);
            this.ResultCalc1.Name = "ResultCalc1";
            this.ResultCalc1.Size = new System.Drawing.Size(732, 37);
            this.ResultCalc1.TabIndex = 2;
            this.ResultCalc1.Text = " ";
            this.ResultCalc1.UseVisualStyleBackColor = true;
            this.ResultCalc1.Click += new System.EventHandler(this.ResultCalc1_Click);
            // 
            // Input1
            // 
            this.Input1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Input1.Location = new System.Drawing.Point(0, 0);
            this.Input1.Margin = new System.Windows.Forms.Padding(0);
            this.Input1.Multiline = true;
            this.Input1.Name = "Input1";
            this.Input1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input1.Size = new System.Drawing.Size(732, 170);
            this.Input1.TabIndex = 1;
            // 
            // Result1
            // 
            this.Result1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result1.Location = new System.Drawing.Point(0, 207);
            this.Result1.Margin = new System.Windows.Forms.Padding(0);
            this.Result1.Multiline = true;
            this.Result1.Name = "Result1";
            this.Result1.ReadOnly = true;
            this.Result1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result1.Size = new System.Drawing.Size(732, 170);
            this.Result1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.ResultCalc2);
            this.Panel2.Controls.Add(this.Result2);
            this.Panel2.Controls.Add(this.Input2);
            this.Panel2.Location = new System.Drawing.Point(4, 39);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(732, 377);
            this.Panel2.TabIndex = 2;
            this.Panel2.Text = " ";
            this.Panel2.UseVisualStyleBackColor = true;
            // 
            // ResultCalc2
            // 
            this.ResultCalc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultCalc2.Location = new System.Drawing.Point(0, 170);
            this.ResultCalc2.Margin = new System.Windows.Forms.Padding(0);
            this.ResultCalc2.Name = "ResultCalc2";
            this.ResultCalc2.Size = new System.Drawing.Size(732, 37);
            this.ResultCalc2.TabIndex = 4;
            this.ResultCalc2.Text = " ";
            this.ResultCalc2.UseVisualStyleBackColor = true;
            this.ResultCalc2.Click += new System.EventHandler(this.ResultCalc2_Click);
            // 
            // Result2
            // 
            this.Result2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result2.Location = new System.Drawing.Point(0, 207);
            this.Result2.Margin = new System.Windows.Forms.Padding(0);
            this.Result2.Multiline = true;
            this.Result2.Name = "Result2";
            this.Result2.ReadOnly = true;
            this.Result2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result2.Size = new System.Drawing.Size(732, 170);
            this.Result2.TabIndex = 3;
            // 
            // Input2
            // 
            this.Input2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Input2.Location = new System.Drawing.Point(0, 0);
            this.Input2.Margin = new System.Windows.Forms.Padding(0);
            this.Input2.Multiline = true;
            this.Input2.Name = "Input2";
            this.Input2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input2.Size = new System.Drawing.Size(732, 170);
            this.Input2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 420);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "Form1";
            this.Text = "SimpleSqrt";
            this.LangPanel.ResumeLayout(false);
            this.LangPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.LangControl.ResumeLayout(false);
            this.LangControl.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel LangPanel;
        private System.Windows.Forms.Button EnglishLang;
        private System.Windows.Forms.Button RussianLang;
        private System.Windows.Forms.Button SpanishLang;
        private System.Windows.Forms.Button ChineseLang;
        private TabControl tabControl1;
        private TabPage LangControl;
        private TabPage Panel1;
        private TabPage Panel2;
        private TextBox Input1;
        private TextBox Result1;
        private Button ResultCalc1;
        private Button ResultCalc2;
        private TextBox Result2;
        private TextBox Input2;
    }
}

