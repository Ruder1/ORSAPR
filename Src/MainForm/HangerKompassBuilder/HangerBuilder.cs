using HangerKompassBuilder;
using Kompas6Constants3D;
using Kompas6API5;
using Hangers;

namespace HangerKompassBuilder
{
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
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();

            doc2d.ksLineSeg(parameters.Length/2, 0, -parameters.Length/2, 0, 1);
            doc2d.ksLineSeg(parameters.Length / 2-15, -15, -parameters.Length / 2 + 15, -15, 1);

            //Линии в левую сторону
            doc2d.ksLineSeg(parameters.Length / 2 - 15, -15, parameters.Length / 2 - 15, -55,1);
            doc2d.ksLineSeg(parameters.Length / 2, 0, parameters.Length / 2, -65, 1);

            doc2d.ksLineSeg(parameters.Length / 2-15, -55, 0, -parameters.InnerHeight, 1);
            doc2d.ksLineSeg(parameters.Length / 2, -65, 0, -parameters.InnerHeight-15, 1);

            //Линии в правую сторону
            doc2d.ksLineSeg(-parameters.Length / 2 + 15, -15, -parameters.Length / 2 + 15, -55, 1);
            doc2d.ksLineSeg(-parameters.Length / 2, 0, -parameters.Length / 2, -65, 1);

            doc2d.ksLineSeg(-parameters.Length / 2 + 15, -55, 0, -parameters.InnerHeight, 1); 
            doc2d.ksLineSeg(-parameters.Length / 2, -65, 0, -parameters.InnerHeight - 15, 1);

            sketchDef.EndEdit();
            //CreateExtrusion(sketchDef,parameters.Width,true);
        }

        private void BuildHanger(HangerParametrs parametrs)
        {

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

            extrusionDef.SetSideParam(side,
                (short)End_Type.etBlind, lenght);
            extrusionDef.directionType = side ?
                (short)Direction_Type.dtNormal :
                (short)Direction_Type.dtReverse;
            extrusionDef.SetThinParam(thin,
                (short)Direction_Type.dtNormal, 0.5, 1);
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