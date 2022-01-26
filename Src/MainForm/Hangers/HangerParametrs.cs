using System;
using System.Collections.Generic;

namespace Hangers
{
    /// <summary>
    /// Класс создания данных Hangers
    /// </summary>
    public class HangerParametrs
    {
        /// <summary>
        /// Поле высоты
        /// </summary>
        private int _height;

        /// <summary>
        /// Поле длины
        /// </summary>
        private int _length;

        /// <summary>
        /// Поле ширины
        /// </summary>
        private int _width;

        /// <summary>
        /// Поле внутреннего радиуса
        /// </summary>
        private int _innerRadius;

        /// <summary>
        /// Поле наружного радиуса
        /// </summary>
        private int _outerRadius;

        /// <summary>
        /// Поле Внутренней высоты
        /// </summary>
        private int _innerHeight;

        /// <summary>
        /// Поле Радиуса выемки
        /// </summary>
        private int _recessRadius;

        /// <summary>
        /// Поле Длины от центра до выемки 
        /// </summary>
        private int _lengthCenterRecess;

        /// <summary>
        /// Словарь для хранения ошибок ввода
        /// </summary>
        public Dictionary<HangerParametersType, string> ErrorsDictionary { get; }
            = new Dictionary<HangerParametersType, string>();

        /// <summary>
        /// Поле минимальной величины
        /// </summary>
        private int _minValue;

        /// <summary>
        /// Поле максимальной величины
        /// </summary>
        private int _maxValue;

        /// <summary>
        /// Чтение и запись высоты плечиков
        /// </summary>
        public int Height
        {
            get => _height;
            set
            {
                _minValue = 200;
                _maxValue = 230;
                SetValue(ref _height, value,
                    _minValue, _maxValue, HangerParametersType.Height);
            }

        }

        /// <summary>
        /// Чтение и запись длины плечиков
        /// </summary>
        public int Length
        {
            get => _length;
            set
            {
                _minValue = 390;
                _maxValue = 470;
                SetValue(ref _length, value,
                    _minValue, _maxValue, HangerParametersType.Length);
            }
        }

        /// <summary>
        /// Чтение и запись ширины плечиков
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                _minValue = 4;
                _maxValue = 6;
                SetValue(ref _width, value,
                    _minValue, _maxValue, HangerParametersType.Width);
            }
        }

        /// <summary>
        /// Чтение и запись внутреннего радиуса плечиков
        /// </summary>
        public int InnerRadius
        {
            get => _innerRadius;
            set
            {
                _minValue = 15;
                _maxValue = 20;
                SetValue(ref _innerRadius, value,
                    _minValue, _maxValue, HangerParametersType.InnerRadius);
            }
        }

        /// <summary>
        /// Чтение и запись радиуса выемок плечиков
        /// </summary>
        public int RecessRadius
        {
            get => _recessRadius;
            set
            {
                _minValue = 3;
                _maxValue = 4;
                SetValue(ref _recessRadius, value,
                    _minValue, _maxValue, HangerParametersType.RecessRadius);
            }
        }

        /// <summary>
        /// Чтение и запись внутренней высоты плечиков
        /// </summary>
        public int InnerHeight
        {
            get => _innerHeight;
            set
            {
                _minValue = 95;
                _maxValue = 110;
                SetValue(ref _innerHeight, (value-10)/2,
                    _minValue, _maxValue, HangerParametersType.InnerHeight);
            } 
        }

        /// <summary>
        /// Чтение и запись наружного раидуса плечиков
        /// </summary>
        public int OuterRadius
        {
            get => _outerRadius;
            set
            {
                
                _minValue = 30;
                _maxValue = 35;
                SetValue(ref _outerRadius, value+15,
                    _minValue, _maxValue, HangerParametersType.OuterRadius);
            }
        }

        /// <summary>
        /// Чтение и запись длины от центра до выемок плечиков
        /// </summary>
        public int LengthCenterRecess
        {
            get => _lengthCenterRecess;
            set
            {
                _minValue = 130;
                _maxValue = 157;
                SetValue(ref _lengthCenterRecess,value/3,
                    _minValue,_maxValue,HangerParametersType.LengthCenterRecess);
            }
        }

        /// <summary>
        /// Метод устанавливающий значение по ссылке
        /// </summary>
        /// <param name="property">ссылка на значение</param>
        /// <param name="value">устанавливаемое значение</param>
        /// <param name="minValue">минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="type">Тип параметра</param>
        public void SetValue(ref int property, int value,
            int minValue, int maxValue, HangerParametersType type)
        {
            try
            {

                ValidatorHangerParametrs.CheckParametrsValue(minValue, maxValue,
                    value, type);
                property = value;
            }
            catch (Exception ex)
            {
                ErrorsDictionary.Add(type,
                    ex.Message);
            }
        }

    }
}
