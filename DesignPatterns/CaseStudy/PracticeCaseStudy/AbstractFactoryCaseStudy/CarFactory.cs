﻿using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryCaseStudy.Program;
namespace AbstractFactoryCaseStudy
{
    public interface CarFactory
    {
        void MakeMicroCar(Location location, CarType carType);
        void MakeMiniCar(Location location, CarType carType);
        void MakeLuxuryCar(Location location, CarType carType);
    }
}
