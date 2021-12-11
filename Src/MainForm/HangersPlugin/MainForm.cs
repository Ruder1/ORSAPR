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

        /// <summary>
        /// Поле параметров плечиков
        /// </summary>
        private HangerParametrs _hangerParametrs = new HangerParametrs();

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
               try
               {
                    _hangerParametrs.Height = result;
                    HeightTextBox.BackColor = _correctBackColor;
                    InnerHeightSize(result);
               }
               catch
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
                try 
                {
                    _hangerParametrs.Length = result;
                    LengthTextBox.BackColor = _correctBackColor;
                    LengthCenterRecessSize(result);
                }
                catch
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
                try
                {
                    _hangerParametrs.Width = result;
                    WidthTextBox.BackColor = _correctBackColor;
                }
                catch
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
                try
                {
                    _hangerParametrs.InnerRadius = result;
                    InnerRadiusTextBox.BackColor = _correctBackColor;
                    OuterRadiusSize(result);
                }
                catch
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
                try
                {
                    _hangerParametrs.RecessRadius = result;
                    RecessRadiusTextBox.BackColor = _correctBackColor;
                }
                catch
                {
                    RecessRadiusTextBox.BackColor = _incorrectBackColor;
                }
            }
            else
            {
                RecessRadiusTextBox.BackColor = _incorrectBackColor;
            }
        }

        /// <summary>
        /// Метод расчета наружного радиуса по зависимости
        /// </summary>
        /// <param name="innerRadius">Внутренний радиус</param>
        private void OuterRadiusSize(int innerRadius)
        {
            _hangerParametrs.OuterRadius = innerRadius + 10;
            OuterRadiusTextBox.BackColor = _correctBackColor;
            OuterRadiusTextBox.Text = _hangerParametrs.OuterRadius.ToString();
        }

        /// <summary>
        /// Метод расчета внутренней высоты плечиков по зависимости
        /// </summary>
        /// <param name="height">Высота плечиков</param>
        private void InnerHeightSize(int height)
        {
            _hangerParametrs.InnerHeight = (height - 10) / 2;
            InnerHeightTextBox.BackColor = _correctBackColor;
            InnerHeightTextBox.Text = _hangerParametrs.InnerHeight.ToString();
        }

        /// <summary>
        /// Метод для расчета расположение выемок от центра
        /// </summary>
        /// <param name="length">Длина плечиков</param>
        private void LengthCenterRecessSize(int length)
        {
            _hangerParametrs.LengthCenterRecess = (length * 3) / 4;
            LengthCenterRecessTextBox.BackColor = _correctBackColor;
            LengthCenterRecessTextBox.Text = _hangerParametrs.LengthCenterRecess.ToString();
        }
    }
}
