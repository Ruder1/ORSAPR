using System;
using System.Runtime.InteropServices;
using HangerKompassBuilder.Service;
using Kompas6API5;
using Kompas6Constants3D;

namespace HangerKompassBuilder
{
    /// <summary>
    /// Класс для подключения компас 3D
    /// </summary>
    internal class KompassConnector
    {
        //TODO: RSDN
        /// <summary>
        /// Объект интерфейса _kompasObject для взимодействия с Kompas 3D
        /// </summary>
        public KompasObject _kompasObject { get; }

        //TODO: RSDN
        /// <summary>
        /// Объект интерфейса KsPart для взимодействия с компонентом Kompas 3D
        /// </summary>
        public ksPart _part { get; set; }

        /// <summary>
        /// Конструктор класса, выполняет запуск Kompas 3D
        /// </summary>
        public KompassConnector()
        {
            var progId = "KOMPAS.Application.5";
            try
            {
                _kompasObject = (KompasObject)Marshal2.GetActiveObject(progId);
            }
            catch (COMException)
            {
                _kompasObject = (KompasObject)Activator.
                    CreateInstance(Type.GetTypeFromProgID(progId));
            }

            _kompasObject.Visible = true;
            _kompasObject.ActivateControllerAPI();
        }

        //TODO: naming
        /// <summary>
        /// Метод для создания нового компонента в Kompas 3D.
        /// </summary>
        public void GetNewPart()
        {
            var ksDoc = (ksDocument3D)_kompasObject.Document3D();
            ksDoc.Create(false, true);
            _part = (ksPart)ksDoc.GetPart((short)Part_Type.pTop_Part);
        }
    }
}
