﻿using System;

namespace Domain.Enums
{
    [Flags]
    public enum Effects
    {
        Afterburner = 1,
        AsteroidField = 2,
        GasCloud = 4,
        Superfood = 8,
        Shield = 16
    }
}