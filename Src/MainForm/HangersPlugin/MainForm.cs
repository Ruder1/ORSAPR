using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangersPlugin
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Цвет не правильного ввода значений
        /// </summary>
        private readonly Color _incorrectBackColor = Color.LightSalmon;

        /// <summary>
        /// Цвет правильного ввода значений
        /// </summary>
        private readonly Color _correctBackColor = Color.White;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {

        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
