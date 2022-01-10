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
using HangerKompassBuilder;


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
            try
            {
                _hangerParametrs.Height = IntParse(HeightTextBox);
                _hangerParametrs.Width = IntParse(WidthTextBox);
                _hangerParametrs.Length = IntParse(LengthTextBox);
                _hangerParametrs.InnerRadius = IntParse(InnerRadiusTextBox);
                _hangerParametrs.RecessRadius = IntParse(RecessRadiusTextBox);
                _hangerParametrs.InnerHeight = IntParse(HeightTextBox);
                _hangerParametrs.OuterRadius = IntParse(InnerRadiusTextBox);
                _hangerParametrs.LengthCenterRecess = IntParse(LengthTextBox);
                var builder = new HangerBuilder();
                builder.Assembly(_hangerParametrs, BuildBracingCheckBox.Checked);
            }
            catch(Exception)
            {
                MessageBox.Show("Some values aren't in range","Warning",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Переводит string в int
        /// </summary>
        /// <param name="textBox">Текст бокс необходимый для перевода типа данных</param>
        /// <returns>Возвращает  тип данных int преобразованный из string</returns>
        private int IntParse(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int result))
            {
                return result;
            }

            throw new ArgumentException("the value must consist of digits");
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = IntParse(HeightTextBox);
                _hangerParametrs.Height = result;
                HeightTextBox.BackColor = _correctBackColor;
                _hangerParametrs.InnerHeight=result;
                InnerHeightTextBox.BackColor = _correctBackColor;
                InnerHeightTextBox.Text = _hangerParametrs.InnerHeight.ToString();
            }
            catch
            {
                HeightTextBox.BackColor = _incorrectBackColor;
                InnerHeightTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = IntParse(LengthTextBox);
                _hangerParametrs.Length = result;
                LengthTextBox.BackColor = _correctBackColor;
                _hangerParametrs.LengthCenterRecess=result;
                LengthCenterRecessTextBox.BackColor = _correctBackColor;
                LengthCenterRecessTextBox.Text = _hangerParametrs.LengthCenterRecess.ToString();
            }
            catch
            {
                LengthTextBox.BackColor = _incorrectBackColor;
                LengthCenterRecessTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = IntParse(WidthTextBox);
                _hangerParametrs.Width = result;
                WidthTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                WidthTextBox.BackColor = _incorrectBackColor;
            }

        }

        private void InnerRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = IntParse(InnerRadiusTextBox);
                _hangerParametrs.InnerRadius = result;
                InnerRadiusTextBox.BackColor = _correctBackColor;
                _hangerParametrs.OuterRadius=result;
                OuterRadiusTextBox.BackColor = _correctBackColor;
                OuterRadiusTextBox.Text = _hangerParametrs.OuterRadius.ToString();
            }
            catch
            {
                InnerRadiusTextBox.BackColor = _incorrectBackColor;
                OuterRadiusTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void RecessRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var result = IntParse(RecessRadiusTextBox);
                _hangerParametrs.RecessRadius = result;
                RecessRadiusTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                RecessRadiusTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var hanger = new HangerParametrs()
            {
                Height = 200,
                Length = 390,
                Width = 5,
                InnerHeight = 200,
                InnerRadius = 15,
                LengthCenterRecess = 390,
                OuterRadius = 15,
                RecessRadius = 3
            };
            for (var i = 0; i < 100; i++)
            {
                var builder = new HangerBuilder();
                builder.Assembly(hanger, true);
            }
        }
    }
}
