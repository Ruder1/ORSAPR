using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hangers;



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

        private Hanger _hanger = new Hanger();

        public Hanger Hanger
        {
            get
            {
                return _hanger;
            }

            set
            {

            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {

        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(HeightTextBox.Text, out int result))
            {
                if (result >= 200 && result <= 230)
                {
                    Hanger.Height = result;
                    HeightTextBox.BackColor = _correctBackColor;
                    InnerHeightSize(result);
                }
                else
                {
                    HeightTextBox.BackColor = _incorrectBackColor;
                }
            }
            else
            {
                HeightTextBox.BackColor = _incorrectBackColor;
            }

        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LengthTextBox.Text, out int result))
            {
                if (result >= 390 && result <= 470)
                {
                    Hanger.Length = result;
                    LengthTextBox.BackColor = _correctBackColor;
                    LengthCenterRecessSize(result);
                }
                else
                {
                    LengthTextBox.BackColor = _incorrectBackColor;
                }
            }
            else
            {
                LengthTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(WidthTextBox.Text, out int result))
            {
                if (result >= 4 && result <= 6)
                {
                    Hanger.Width = result;
                    WidthTextBox.BackColor = _correctBackColor;
                }
                else
                {
                    WidthTextBox.BackColor = _incorrectBackColor;
                }
            }
            else
            {
                WidthTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void InnerRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(InnerRadiusTextBox.Text, out int result))
            {
                if (result >= 15 && result <= 25)
                {
                    Hanger.InnerRadius = result;
                    InnerRadiusTextBox.BackColor = _correctBackColor;
                    OuterRadiusSize(result);
                }
                else
                {
                    InnerRadiusTextBox.BackColor = _incorrectBackColor;
                }
            }
            else
            {
                InnerRadiusTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void RecessRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RecessRadiusTextBox.Text, out int result))
            {
                if (result >= 3 && result <= 4)
                {
                    Hanger.RecessRadius = result;
                    RecessRadiusTextBox.BackColor = _correctBackColor;
                }
                else
                {
                    RecessRadiusTextBox.BackColor = _incorrectBackColor;
                }
            }
            else
            {
                RecessRadiusTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void OuterRadiusSize(int innerRadius)
        {
            Hanger.OuterRadius = innerRadius + 10;
            OuterRadiusTextBox.BackColor = _correctBackColor;
            OuterRadiusTextBox.Text = Hanger.OuterRadius.ToString();
        }

        private void InnerHeightSize(int height)
        {
            Hanger.InnerHeight = (height - 10) / 2;
            InnerHeightTextBox.BackColor = _correctBackColor;
            InnerHeightTextBox.Text = Hanger.InnerHeight.ToString();
        }

        private void LengthCenterRecessSize(int length)
        {
            Hanger.LengthCenterRecess = (length * 3) / 4;
            LengthCenterRecessTextBox.BackColor = _correctBackColor;
            LengthCenterRecessTextBox.Text = Hanger.LengthCenterRecess.ToString();
        }
    }
}
