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
        /// Константы для построения детали
        /// </summary>
        private const int OneFourth = 4;
        private const int ContinueOneFourth = 10;
        private const int BeginOneSecond = 2;
        private const int ContinueOneSecond = 30;
        private const int HalfRadius = 15;
        private const int PosY1 = 5;
        private const int PosY2 = 10;
        private const int IncreaseHanger = 35;
        private const double WidthBracingPants = 2.5;
        private const int HeightFirst = 22;
        private const int HeightSecond = 12;

        /// <summary>
        /// Метод для построения модели Плечиков
        /// </summary>
        /// <param name="parameters">Параметры Плечиков</param>
        /// <param name="selectedItem">Проверка нужно ли строить крепления для брюк</param>
        public void Assembly(HangerParametrs parameters,bool selectedItem)
        {
            _connector = new KompassConnector();
            _connector.SetNewPart();
            BuildShoulder(parameters);
            BuildHanger(parameters);
            if (selectedItem == true)
            {
                BuildBracingPants(parameters);
            }
        }
        
        /// <summary>
        /// Создает крепеж для вешалки
        /// </summary>
        /// <param name="parameters">Параметры плечиков</param>
        private void BuildHanger(HangerParametrs parameters)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D) sketchDef.BeginEdit();
            
            var y1 = -parameters.InnerHeight - HalfRadius;
            var y2 = -parameters.Height + IncreaseHanger;
            var yFirst = -parameters.InnerHeight - HeightFirst;
            var ySecond = -parameters.InnerHeight - HeightSecond;
            //Внутренняя линия
            SketchHalfHanger(doc2d, 0, y1, -20, yFirst,
                20, y2, 20);
            //Внешняя линия
            SketchHalfHanger(doc2d, 0, -parameters.InnerHeight,
                -IncreaseHanger, ySecond, IncreaseHanger, y2, IncreaseHanger);

            doc2d.ksArcByPoint(27.5, y2, 7.5, 20, y2,
                35, y2, -1, 1);
            doc2d.ksLineSeg(0, y1, 0, -parameters.InnerHeight, 1);
            sketchDef.EndEdit();
            CreateExtrusion(sketchDef, parameters.Width, true);
        }

        /// <summary>
        /// Строит эскиз для вешалки
        /// </summary>
        /// <param name="doc2d">Эскиз на котором будет строиться</param>
        /// <param name="x1">Первая точка по x</param>
        /// <param name="y1">Первая точка по y</param>
        /// <param name="x2">Вторая точка по x</param>
        /// <param name="y2">Вторая точка по y</param>
        /// <param name="x3">Третья точка по x</param>
        /// <param name="y3">Третья точка по y</param>
        /// <param name="rad">Радиус окружности</param>
        private void SketchHalfHanger(ksDocument2D doc2d,int x1, int y1, int x2,
            int y2, int x3,int y3,int rad)
        {
            doc2d.ksLineSeg(x1, y1, x2, y2, 1);
            doc2d.ksLineSeg(x2, y2, x2, y3, 1);
            doc2d.ksArcByPoint(x1, y3, rad, x2, y3, x3, y3, 1, 1);
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
            
            var commonLength = parameters.Length / BeginOneSecond;
            var lengthFirst = parameters.Length / BeginOneSecond - ContinueOneSecond;
            var lengthSecond = parameters.Length / BeginOneSecond - HalfRadius;
            var radiusFirst = -parameters.OuterRadius - HalfRadius;
            var radiusSecond = -parameters.InnerRadius * BeginOneSecond - HalfRadius;
            var radiusThird = -parameters.OuterRadius - HalfRadius;
            var radiusFourth = -parameters.OuterRadius * BeginOneSecond;
            var height = -parameters.InnerHeight - HalfRadius;

            //Внутренняя линия
            SketchHalf(doc2d, lengthFirst, -parameters.OuterRadius,
                parameters.InnerRadius, commonLength, -HalfRadius, lengthSecond,
                radiusFirst, radiusSecond, -parameters.InnerHeight);
            //Внешняя линия
            SketchHalf(doc2d, lengthFirst, -parameters.OuterRadius,
                parameters.OuterRadius, commonLength, 0, commonLength,
                radiusThird, radiusFourth, height);

            doc2d.ksEndObj();
            doc2d.ksSymmetryObj(groupID, 0, 0, 0, -HalfRadius, "1");
            sketchDef.EndEdit();
            CreateExtrusion(sketchDef,parameters.Width,true);
        }

        /// <summary>
        /// Строить эскиз для плечей
        /// </summary>
        /// <param name="doc2d">Эскиз на котором будет строолиться</param>
        /// <param name="xc">Центр окружности по x</param>
        /// <param name="yc">Центр окружности по y</param>
        /// <param name="radius">Радиус оркужности</param>
        /// <param name="x1">Первая точка по x</param>
        /// <param name="y1">Первая точка по y</param>
        /// <param name="x2">Вторая точка по x</param>
        /// <param name="y2">Вторая точка по y</param>
        /// <param name="y3">Третья точка по y</param>
        /// <param name="height">Высота плечей</param>
        private void SketchHalf(ksDocument2D doc2d, int xc, int yc, int radius, int x1,
            int y1, int x2, int y2, int y3, int height)
        {
            doc2d.ksLineSeg(xc, y1, 0, y1, 1);
            doc2d.ksArcByPoint(xc, yc, radius, xc, y1, x1, yc, -1, 1);
            doc2d.ksArcByPoint(xc, yc, radius, x2, yc, xc, y2, -1, 1);
            doc2d.ksLineSeg(xc, y3, 0, height, 1);
        }

        /// <summary>
        /// Строит крепления для брюк
        /// </summary>
        /// <param name="parameters">Параметры плечиков</param>
        private void BuildBracingPants(HangerParametrs parameters)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            var groupId = doc2d.ksNewGroup(0);
            
            var lengthBegin = parameters.Length / OneFourth;
            var lengthFirst = (parameters.Length / OneFourth) + ContinueOneFourth;
            var lengthSecond = parameters.LengthCenterRecess - PosY1;
            var lengthThird = parameters.LengthCenterRecess - WidthBracingPants;
            SketchBracingPants(doc2d, PosY1, lengthFirst, lengthSecond,
                lengthBegin, PosY2, 10);
            SketchBracingPants(doc2d, PosY2, lengthFirst, lengthSecond,
                lengthBegin, PosY1, PosY1);

            doc2d.ksLineSeg(lengthBegin, 0, lengthBegin + PosY1, 0, 1);

            doc2d.ksArcByPoint(lengthSecond, PosY1, PosY1, lengthSecond,
                PosY2, parameters.LengthCenterRecess, 
                PosY1, -1, 1);
            doc2d.ksArcByPoint(lengthThird, PosY1, 2.5,
                parameters.LengthCenterRecess, PosY1, lengthSecond,
                PosY1, -1, 1);

            doc2d.ksEndObj();
            doc2d.ksSymmetryObj(groupId, 0, 0, 0, -HalfRadius, "1");
            sketchDef.EndEdit();
            CreateExtrusion(sketchDef, parameters.Width, true);
        }

        /// <summary>
        /// Метод для создания эскиза держателей для брюк
        /// </summary>
        /// <param name="doc2d">Эскиз на котором будет строолиться</param>
        /// <param name="posY1">Первая позицая по y</param>
        /// <param name="lengthFirst">Первая точка по оси x от длины</param>
        /// <param name="lengthSecond">Вторая точка по оси x от длины</param>
        /// <param name="lengthBegin">Начало точки по оси от длины</param>
        /// <param name="posY2">Вторая позиция по y</param>
        /// <param name="rad1">Радиус окружности</param>
        private void SketchBracingPants(ksDocument2D doc2d,int posY1,int lengthFirst,
            int lengthSecond,int lengthBegin,int posY2,int rad1)
        {
            doc2d.ksLineSeg(lengthFirst, posY1, lengthSecond, posY1, 1);
            doc2d.ksArcByPoint(lengthFirst, 0, rad1, lengthBegin, 0,
                lengthFirst, posY2, -1, 1);
        }
        
        /// <summary>
        /// Метод для выполнения выдавливания
        /// </summary>
        /// <param name="sketchDef">Эскиз по которому будет
        /// производиться выдавливание</param>
        /// <param name="length">Расстояние выдавливания</param>
        /// <param name="side">Направление выдавливания</param>
        private void CreateExtrusion(ksSketchDefinition sketchDef,
            double length, bool side = true)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossExtrusion;
            var extrusionEntity = (ksEntity)_connector.Part.
                NewEntity((short)type);
            var extrusionDef = (ksBossExtrusionDefinition)
                extrusionEntity.GetDefinition();
            extrusionDef.SetSideParam(side, (short)End_Type.etBlind, length);

            extrusionDef.SetSketch(sketchDef);

            extrusionEntity.Create();
        }

        /// <summary>
        /// Метод для создания эскиза на выбранной плоскости
        /// </summary>
        /// <param name="planeType">Плоскость эскиза</param>
        /// <returns> Возвращает созданный эскиз</returns>
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