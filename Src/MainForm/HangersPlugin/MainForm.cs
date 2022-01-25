using System;
using System.Collections.Generic;
using System.Drawing;
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

        /// <summary>
        /// Словарь содержащий пары (Тип параметра, Текст бокс)
        /// </summary>
        private readonly Dictionary<HangerParametersType, TextBox> _textBoxesDictionary;

        public MainForm()
        {
            InitializeComponent();

            _textBoxesDictionary = new Dictionary<HangerParametersType, TextBox>
            {
                { HangerParametersType.Height, HeightTextBox },
                { HangerParametersType.Length, LengthTextBox },
                { HangerParametersType.Width, WidthTextBox },
                { HangerParametersType.InnerRadius, InnerRadiusTextBox },
                { HangerParametersType.RecessRadius, RecessRadiusTextBox },
                { HangerParametersType.InnerHeight, InnerHeightTextBox },
                { HangerParametersType.OuterRadius, OuterRadiusTextBox },
                { HangerParametersType.LengthCenterRecess, LengthCenterRecessTextBox }
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

        //TODO: XML +
        /// <summary>
        /// Обработчик события нажатие на кнопку Build
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                InnerHeightTextBox.Text = HeightTextBox.Text;
                _hangerParametrs.InnerHeight = IntParse(InnerHeightTextBox);
                 InnerHeightTextBox.Text = _hangerParametrs.InnerHeight.ToString();

                 OuterRadiusTextBox.Text = InnerRadiusTextBox.Text;
                _hangerParametrs.OuterRadius = IntParse(OuterRadiusTextBox);
                OuterRadiusTextBox.Text = _hangerParametrs.OuterRadius.ToString();

                LengthCenterRecessTextBox.Text = LengthTextBox.Text;
                _hangerParametrs.LengthCenterRecess = IntParse(LengthCenterRecessTextBox);
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
                        //TODO:? (Неправильное использование nameTextBox+"TextBox") +
                        _textBoxesDictionary[param].BackColor = _incorrectBackColor;
                    }

                    InfoLabel.Visible = true;
                    MessageBox.Show(message, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InfoLabel.Visible = false;
                    var builder = new HangerBuilder();
                    builder.Assembly(_hangerParametrs, BuildBracingCheckBox.Checked);
                }
                
            }
            catch (ArgumentException ex)
            {
                InfoLabel.Visible = true;
                MessageBox.Show(ex.Message, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
