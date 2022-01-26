using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangers
{
    /// <summary>
    /// Перечесление параметров проектируемой модели плечиков для одежды
    /// </summary>
    public enum HangerParametersType
    {
        /// <summary>
        /// Высота модели плечиков
        /// </summary>
        Height,

        /// <summary>
        /// Длина модели плечиков
        /// </summary>
        Length,

        /// <summary>
        /// Ширина модели плечиков
        /// </summary>
        Width,

        /// <summary>
        /// Внутренний радиус модели плечиков
        /// </summary>
        InnerRadius,

        /// <summary>
        /// Радиус выемки модели плечиков
        /// </summary>
        RecessRadius,

        /// <summary>
        /// Внутренняя высота модели плечиков
        /// </summary>
        InnerHeight,

        /// <summary>
        /// Внешний радиус модели плечиков
        /// </summary>
        OuterRadius,

        /// <summary>
        /// Длина от центра до выемок модели плечиков
        /// </summary>
        LengthCenterRecess
    }
}
