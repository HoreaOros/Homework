﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class RegularBall : Ball
    {
        public RegularBall(float radius, Position position, Color color, Direction direction)
        {
            base(radius, position, color, direction);
        }
    }
}