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

        private Dictionary<TextBox, HangerParametersType> _textBoxesDictionary;

        public MainForm()
        {
            InitializeComponent();
            _textBoxesDictionary = new Dictionary<TextBox, HangerParametersType>
            {
                {HeightTextBox, HangerParametersType.Height},
                {LengthTextBox,HangerParametersType.Length},
                {WidthTextBox,HangerParametersType.Width},
                {InnerHeightTextBox,HangerParametersType.InnerHeight},
                {InnerRadiusTextBox,HangerParametersType.InnerRadius},
                {OuterRadiusTextBox,HangerParametersType.OuterRadius},
                {RecessRadiusTextBox,HangerParametersType.RecessRadius},
                {LengthCenterRecessTextBox,HangerParametersType.LengthCenterRecess}
            };
        }

        /// <summary>
        /// Переводит string в int
        /// </summary>
        /// <param name="textBox">Текст бокс необходимый для перевода типа данных</param>
        /// <returns>Возвращает  тип данных int преобразованный из string</returns>
        private int IntParse(TextBox textBox)
        {
            try
            {
                int temp = Int32.Parse(textBox.Text);
                textBox.BackColor = _correctBackColor;
                return temp;
            }
            catch
            {
                textBox.BackColor = _incorrectBackColor;
                throw new ArgumentException("Value must consist only digits");
            }
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {

                _hangerParametrs.ErrorsDictionary.Clear();
                _hangerParametrs.Height = IntParse(HeightTextBox);
                _hangerParametrs.Width = IntParse(WidthTextBox);
                _hangerParametrs.Length = IntParse(LengthTextBox);
                _hangerParametrs.InnerRadius = IntParse(InnerRadiusTextBox);
                _hangerParametrs.RecessRadius = IntParse(RecessRadiusTextBox);
                _hangerParametrs.InnerHeight = IntParse(HeightTextBox);
                 InnerHeightTextBox.Text = _hangerParametrs.InnerHeight.ToString();
                _hangerParametrs.OuterRadius = IntParse(InnerRadiusTextBox);
                OuterRadiusTextBox.Text = _hangerParametrs.OuterRadius.ToString();
                _hangerParametrs.LengthCenterRecess = IntParse(LengthTextBox);
                LengthCenterRecessTextBox.Text = _hangerParametrs.LengthCenterRecess.ToString();


                if (_hangerParametrs.ErrorsDictionary.Count != 0)
                {
                    string message = null;
                    foreach (var param in
                        _hangerParametrs.ErrorsDictionary.Keys)
                    {
                        message +=
                            _hangerParametrs.ErrorsDictionary[param]
                            + "\n";
                        string textboxname = param.ToString();
                        TextBox textBox =
                            Controls.Find(textboxname + "TextBox", false)[0]
                                as TextBox;
                        textBox.BackColor = _incorrectBackColor;
                    }
                    InfoLabel.Visible = true;
                    MessageBox.Show(
                        message,
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    InfoLabel.Visible = false;
                    foreach (var textBox in _textBoxesDictionary)
                    {
                        textBox.Key.BackColor = _correctBackColor;
                    }
                }
                var builder = new HangerBuilder();
                builder.Assembly(_hangerParametrs, BuildBracingCheckBox.Checked);
            }
            catch (ArgumentException ex)
            {
                InfoLabel.Visible = true;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
