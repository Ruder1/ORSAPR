using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanger
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

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                
            }

        }

    }
}
