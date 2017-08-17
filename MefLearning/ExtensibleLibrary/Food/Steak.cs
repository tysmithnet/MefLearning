using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleLibrary.Food
{
    [Export(typeof(Protein))]
    public class Steak : Protein
    {

    }
}
