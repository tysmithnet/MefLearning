﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleLibrary.Food
{
    [Export(typeof(Protein))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Steak : Protein
    {

    }
}
