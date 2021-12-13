using HangerKompassBuilder;
using Kompas6Constants3D;
using Kompas6API5;
using Hangers;

namespace HangerKompassBuilder
{
    /// <summary>
    /// Класс для построения готовой модели плечиков
    /// </summary>
    public class HangerBuilder
    {
        /// <summary>
        /// Объект класса KompasWrapper
        /// </summary>
        private KompassConnector _connector;

        /// <summary>
        /// Метод для построения модели Плечиков
        /// </summary>
        /// <param name="parameters">Параметры Плечиков</param>
        public void Assembly(HangerParametrs parameters)
        {
            _connector = new KompassConnector();
            _connector.GetNewPart();
            BuildShoulder(parameters);
            BuildHanger(parameters);
        }

        /// <summary>
        /// Создает вешалку
        /// </summary>
        /// <param name="parametrs">Параметры плечиков</param>
        private void BuildHanger(HangerParametrs parameters)
        {
            //TODO: RSDN
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            //TODO: Дубли построения линий
            //TODO: To const
            //Внутренняя линия
            doc2d.ksLineSeg(0, -parameters.InnerHeight - 15, -20, -parameters.InnerHeight - 22, 1);
            doc2d.ksLineSeg(-20, -parameters.InnerHeight - 22, -20, -parameters.Height + 35, 1);
            doc2d.ksArcByPoint(0, -parameters.Height + 35, parameters.InnerRadius + 5, -20, -parameters.Height + 35, 20,
                -parameters.Height + 35, 1, 1);
            //Внешняя линия
            doc2d.ksLineSeg(0, -parameters.InnerHeight, -35, -parameters.InnerHeight - 12, 1);
            doc2d.ksLineSeg(-35, -parameters.InnerHeight - 12, -35, -parameters.Height + 35, 1);
            doc2d.ksArcByPoint(0, -parameters.Height + 35, parameters.OuterRadius + 5, -35, -parameters.Height + 35, 35,
                -parameters.Height + 35, 1, 1);

            doc2d.ksArcByPoint(27.5, -parameters.Height + 35, 7.5, 20, -parameters.Height + 35, 35,
                -parameters.Height + 35, -1, 1);
            doc2d.ksLineSeg(0, -parameters.InnerHeight - 15, 0, -parameters.InnerHeight, 1);
            sketchDef.EndEdit();
            CreateExtrusion(sketchDef, parameters.Width, true);
        }
        
        /// <summary>
        /// Создает плечи из параметров
        /// </summary>
        /// <param name="parameters">параметры плечиков</param>
        private void BuildShoulder(HangerParametrs parameters)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            var groupID = doc2d.ksNewGroup(0);
            //Внутренняя линия
            doc2d.ksLineSeg(parameters.Length / 2 - 30, -15, 0, -15, 1);
            doc2d.ksArcByPoint(parameters.Length / 2 - 30, -parameters.OuterRadius, parameters.InnerRadius,
                parameters.Length / 2 - 30, -15, parameters.Length / 2,
                -parameters.OuterRadius, -1, 1);

            doc2d.ksArcByPoint(parameters.Length / 2 - 30, -parameters.OuterRadius, parameters.InnerRadius,
                parameters.Length / 2 - 15, -parameters.OuterRadius,
                parameters.Length / 2 - 30, -parameters.OuterRadius - 15, -1, 1);
            doc2d.ksLineSeg(parameters.Length / 2 - 30, -parameters.InnerRadius - parameters.InnerRadius - 15,
                0, -parameters.InnerHeight, 1);
            //Внешняя линия
            doc2d.ksLineSeg(parameters.Length / 2 - 30, 0, 0, 0, 1);
            doc2d.ksArcByPoint(parameters.Length / 2 - 30, -parameters.OuterRadius, parameters.OuterRadius,
                parameters.Length / 2 - 30,
                0, parameters.Length / 2, -parameters.OuterRadius, -1, 1);
            doc2d.ksArcByPoint(parameters.Length / 2 - 30, -parameters.OuterRadius, parameters.OuterRadius,
                parameters.Length / 2, -parameters.OuterRadius, parameters.Length / 2 - 30,
                -parameters.OuterRadius - 30, -1, 1);
            doc2d.ksLineSeg(parameters.Length / 2 - 30, -parameters.OuterRadius - parameters.OuterRadius, 0,
                -parameters.InnerHeight - 15, 1);
            doc2d.ksEndObj();
            doc2d.ksSymmetryObj(groupID, 0, 0, 0, -15, "1");
            
            sketchDef.EndEdit();
            CreateExtrusion(sketchDef,parameters.Width,true);
        }

        /// <summary>
        /// Метод для выполнения выдавливания
        /// </summary>
        /// <param name="sketchDef">Эскиз по которому будет
        /// производиться выдавливание</param>
        /// <param name="lenght">Расстояние выдавливания</param>
        /// <param name="side">Направление выдавливания</param>
        private void CreateExtrusion(ksSketchDefinition sketchDef,
            double lenght, bool side = true, bool thin = true)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossExtrusion;
            var extrusionEntity = (ksEntity)_connector.Part.
                NewEntity((short)type);
            var extrusionDef = (ksBossExtrusionDefinition)
                extrusionEntity.GetDefinition();
            extrusionDef.SetSideParam(side, (short)End_Type.etBlind, lenght);

            //extrusionDef.directionType = side ? (short)Direction_Type.dtNormal : (short)Direction_Type.dtReverse;

            //extrusionDef.SetThinParam(thin, (short)Direction_Type.dtNormal, 0.5, 1);

            extrusionDef.SetSketch(sketchDef);

            extrusionEntity.Create();
        }

        /// <summary>
        /// Метод для создания эскиза на выбранной плоскости
        /// </summary>
        /// <param name="planeType">Плоскость эскиза</param>
        /// <returns></returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType)
        {
            var plane = (ksEntity)_connector.Part.
                GetDefaultEntity((short)planeType);
            var sketch = (ksEntity)_connector.Part.
                NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition ksSketch = (ksSketchDefinition)sketch.
                GetDefinition();

            ksSketch.SetPlane(plane);
            sketch.Create();

            return ksSketch;
        }
    }
}