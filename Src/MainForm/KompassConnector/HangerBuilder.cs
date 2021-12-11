using Kompas6Constants3D;
using Kompas6API5;
using Hangers;

namespace HangerKompasBuilder
{
    class HangerBuilder
    {
        /// <summary>
        /// Объект класса KompasWrapper
        /// </summary>
        private KompassConnector _connector;

        /// <summary>
        /// Метод для постоения модели Колбы Вюрца
        /// </summary>
        /// <param name="parameters">Параметры колбы</param>
        public void Assembly(HangerParametrs parameters)
        {
            _connector = new KompassConnector();
            _connector.GetNewPart();

        }
    }
}
