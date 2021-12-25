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
                ValidatorHangerParametrs.CheckParametrsValue(_minValue,_maxValue,value);
                _height = value;
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
                ValidatorHangerParametrs.CheckParametrsValue(_minValue, _maxValue, value);
                _length = value;
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
                ValidatorHangerParametrs.CheckParametrsValue(_minValue, _maxValue, value);
                _width = value;
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
                ValidatorHangerParametrs.CheckParametrsValue(_minValue, _maxValue, value);
                _innerRadius = value;
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
                ValidatorHangerParametrs.CheckParametrsValue(_minValue, _maxValue, value);
                _recessRadius = value;
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
                _innerHeight = (value - 10) / 2;
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
                
                _outerRadius = value + 15;
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
                
                _lengthCenterRecess =( value * 3) / 4; ;
            }
        }

    }
}
