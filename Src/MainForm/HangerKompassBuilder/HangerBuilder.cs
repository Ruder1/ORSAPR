﻿using HangerKompassBuilder;
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

            //TODO: to const
            var y1 = -parameters.InnerHeight - 15;
            var y2 = -parameters.Height + 35;
            var heightFirst = -parameters.InnerHeight - 22;
            var heightSecond = -parameters.InnerHeight - 12;
            //Внутренняя линия
            SketchHalfHanger(doc2d, 0, y1, -20, heightFirst,
                20, y2, 20);
            //Внешняя линия
            SketchHalfHanger(doc2d, 0, -parameters.InnerHeight,
                -35, heightSecond, 35, y2, 35);

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

            //TODO: to const
            var commonLength = parameters.Length / 2;
            var lengthFirst = parameters.Length / 2 - 30;
            var lengthSecond = parameters.Length / 2 - 15;
            var radiusFirst = -parameters.OuterRadius - 15;
            var radiusSecond = -parameters.InnerRadius * 2 - 15;
            var radiusThird = -parameters.OuterRadius - 30;
            var radiusFourth = -parameters.OuterRadius * 2;
            var height = -parameters.InnerHeight - 15;

            //Внутренняя линия
            SketchHalf(doc2d, lengthFirst, -parameters.OuterRadius,
                parameters.InnerRadius, commonLength, -15, lengthSecond,
                radiusFirst, radiusSecond, -parameters.InnerHeight);
            //Внешняя линия
            SketchHalf(doc2d, lengthFirst, -parameters.OuterRadius,
                parameters.OuterRadius, commonLength, 0, commonLength,
                radiusThird, radiusFourth, height);

            doc2d.ksEndObj();
            doc2d.ksSymmetryObj(groupID, 0, 0, 0, -15, "1");
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

            //TODO: to const
            var lengthBegin = parameters.Length / 4;
            var lengthFirst = (parameters.Length / 4) + 10;
            var lengthSecond = parameters.LengthCenterRecess - 5;
            var lengthThird = parameters.LengthCenterRecess - 2.5;
            var posY1 = 5;
            var posY2 = 10;
            SketchBracingPants(doc2d, posY1, lengthFirst, lengthSecond,
                lengthBegin, posY2, 10);
            SketchBracingPants(doc2d, posY2, lengthFirst, lengthSecond,
                lengthBegin, posY1,5);

            doc2d.ksLineSeg(lengthBegin, 0, lengthBegin + 5, 0, 1);

            doc2d.ksArcByPoint(lengthSecond, posY1, 5, lengthSecond,
                posY2, parameters.LengthCenterRecess, 
                posY1, -1, 1);
            doc2d.ksArcByPoint(lengthThird, posY1, 2.5,
                parameters.LengthCenterRecess, posY1, lengthSecond,
                posY1, -1, 1);

            doc2d.ksEndObj();
            doc2d.ksSymmetryObj(groupId, 0, 0, 0, -15, "1");
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