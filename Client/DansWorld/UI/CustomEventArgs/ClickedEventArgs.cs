﻿using Microsoft.Xna.Framework;
using System;

namespace DansWorld.GameClient.UI.CustomEventArgs
{
    public class ClickedEventArgs : EventArgs
    {
        public Point Location;
        public ClickedEventArgs(Point location)
        {
            Location = location;
        }
    }
}
