﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// 2-Tuple of float (System.Single)
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vec2f : IVec
    {
        /// <summary>
        /// The value of the first component of this object.
        /// </summary>
        public float Item1;
        /// <summary>
        /// The value of the second component of this object.
        /// </summary>
        public float Item2;

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        public Vec2f(float item1, float item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }

    /// <summary>
    /// 3-Tuple of float (System.Single)
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vec3f : IVec
    {
        /// <summary>
        /// The value of the first component of this object.
        /// </summary>
        public float Item1;
        /// <summary>
        /// The value of the second component of this object.
        /// </summary>
        public float Item2;
        /// <summary>
        /// The value of the third component of this object.
        /// </summary>
        public float Item3;

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        public Vec3f(float item1, float item2, float item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }

    /// <summary>
    /// 4-Tuple of float (System.Single)
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vec4f : IVec
    {
        /// <summary>
        /// The value of the first component of this object.
        /// </summary>
        public float Item1;

        /// <summary>
        /// The value of the second component of this object.
        /// </summary>
        public float Item2;

        /// <summary>
        /// The value of the third component of this object.
        /// </summary>
        public float Item3;

        /// <summary>
        /// The value of the fourth component of this object.
        /// </summary>
        public float Item4;

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <param name="item4"></param>
        public Vec4f(float item1, float item2, float item3, float item4)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }
    }

    /// <summary>
    /// 6-Tuple of float (System.Single)
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vec6f : IVec
    {
        /// <summary>
        /// The value of the first component of this object.
        /// </summary>
        public float Item1;

        /// <summary>
        /// The value of the second component of this object.
        /// </summary>
        public float Item2;

        /// <summary>
        /// The value of the third component of this object.
        /// </summary>
        public float Item3;

        /// <summary>
        /// The value of the fourth component of this object.
        /// </summary>
        public float Item4;

        /// <summary>
        /// The value of the fifth component of this object.
        /// </summary>
        public float Item5;

        /// <summary>
        /// The value of the sixth component of this object.
        /// </summary>
        public float Item6;

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <param name="item4"></param>
        /// <param name="item5"></param>
        /// <param name="item6"></param>
        public Vec6f(float item1, float item2, float item3, float item4, float item5, float item6)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
        }
    }
}
