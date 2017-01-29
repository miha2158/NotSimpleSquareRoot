using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSimpleSquareRoot
{
    public partial class Form1: Form
    {
        public Form1 ( )
        {
            InitializeComponent( );
            foreach (TabPage tab in tabControl1.TabPages)
                tab.Text = TabNames[tab.TabIndex, SelectedLang];
        }

        #region Language Interface 1

        private void LangPanel_Paint (object sender, PaintEventArgs e)
        {

        }

        private int SelectedLang = 0;

        private readonly string[,] TabNames =
        {
            { "English", "中文", "Español", "Русский" },
            { "Square Root of a Number","数字的平方根","Raíz Cuadrada de un Número","Квадратный Корень Числа" },
            { "Trigonometry","三角学","Trigonometría","Тригонометрия" }
        };

        #endregion

        #region Language Interface 2

        private readonly string[] 

        private void EnglishLang_Click (object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            SelectedLang = 0;
            foreach (TabPage tab in tabControl1.TabPages)
                tab.Text = TabNames[tab.TabIndex, SelectedLang];

        }

        private void ChineseLang_Click (object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            SelectedLang = 1;
            foreach (TabPage tab in tabControl1.TabPages)
                tab.Text = TabNames[tab.TabIndex, SelectedLang];

        }

        private void SpanishLang_Click (object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            SelectedLang = 2;
            foreach (TabPage tab in tabControl1.TabPages)
                tab.Text = TabNames[tab.TabIndex, SelectedLang];

        }

        private void RussianLang_Click (object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            SelectedLang = 3;
            foreach (TabPage tab in tabControl1.TabPages)
                tab.Text = TabNames[tab.TabIndex, SelectedLang];

            LangControl.Text = TabNames[0,SelectedLang];

        }

        #endregion

        private void ResultCalc1_Click (object sender, EventArgs e)
        {

        }

        private void ResultCalc2_Click (object sender, EventArgs e)
        {

        }
    }
}
