﻿using System;

namespace OpenWeatherMap.Standard.Models
{
    /// <summary>
    /// wind model
    /// </summary>
    [Serializable]
    public class Wind : BaseModel
    {
        private float speed, gust;
        private int deg;

        /// <summary>
        /// wind speed
        /// </summary>
        public float Speed
        {
            get => speed;
            set => SetProperty(ref speed, value);
        }

        /// <summary>
        /// wind degree
        /// </summary>
        public int Degree
        {
            get => deg;
            set => SetProperty(ref deg, value);
        }
        
        /// <summary>
        /// gust
        /// </summary>
        public float Gust
        {
            get => gust;
            set => SetProperty(ref gust, value);
        }
    }

}
