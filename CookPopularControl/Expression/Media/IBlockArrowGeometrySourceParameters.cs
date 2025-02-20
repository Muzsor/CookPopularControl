﻿/*
 * Copyright (c) 2021 All Rights Reserved.
 * Description：ICalloutGeometrySourceParameters
 * Author： Chance_写代码的厨子
 * Create Time：2021-06-04 17:22:07
 */
namespace CookPopularControl.Expression
{
    public interface IBlockArrowGeometrySourceParameters : IGeometrySourceParameters
    {
        ArrowOrientation Orientation { get; }

        double ArrowheadAngle { get; }

        double ArrowBodySize { get; }
    }
}
