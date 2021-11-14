namespace Hangers
{
    /// <summary>
    /// Класс создания данных Hangers
    /// </summary>
    public class Hanger
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
        /// Чтение и запись высоты плечиков
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }

        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                _innerRadius = value;
            }
        }

        public int OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                _outerRadius = value;
            }
        }

        public int InnerHeight
        {
            get
            {
                return _innerHeight;
            }
            set
            {
                _innerHeight = value;
            }
        }

        public int RecessRadius
        {
            get
            {
                return _recessRadius;
            }
            set
            {
                _recessRadius = value;
            }
        }

        public int LengthCenterRecess
        {
            get
            {
                return _lengthCenterRecess;
            }
            set
            {
                _lengthCenterRecess = value;
            }
        }

    }
}
