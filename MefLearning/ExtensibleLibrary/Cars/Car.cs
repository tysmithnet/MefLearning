using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Cars
{
    [Export]
    public class Car
    {
        [Import]
        public BodyType BodyType { get; set; }

        [Import]
        public Transmission Transmission { get; set; }
    }
}
