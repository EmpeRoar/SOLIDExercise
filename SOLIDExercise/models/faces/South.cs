﻿using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.faces
{
    public class South : IFace
    {
        public IFace Left { get; set; }
        public IFace Right { get; set; }
    }
}
