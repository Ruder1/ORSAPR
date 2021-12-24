using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangers
{
    /// <summary>
    /// Статический класс для проверки ввода данных
    /// </summary>
    public class ValidatorHangerParametrs
    {
        /// <summary>
        /// Статический метод, выполняет проверку введенных данных на въождение в диапазон
        /// </summary>
        /// <param name="minValue">Минимальное значение диапазона</param>
        /// <param name="maxValue">Максимальное значение диапазона</param>
        /// <param name="value">Значение для проверки</param>
        public static void CheckParametrsValue(int minValue, int maxValue, int value)
        {
            if ( value < minValue || maxValue < value)
            {
                throw new ArgumentException
                ("The value is not in the range" + minValue + " - " + maxValue);
            }
        }
    }
}
