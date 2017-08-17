using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Cars
{
    [Export(typeof(BodyType))]
    public class FourDoor : BodyType
    {
        
    }
}