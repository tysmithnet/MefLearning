using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Cars
{
    [Export(typeof(Transmission))]
    public class Automatic : Transmission
    {

    }
}