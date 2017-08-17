using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Cars
{
    public class NonExportedCar
    {
        [Import]
        public BodyType BodyType { get; set; }

        [Import]
        public Transmission Transmission { get; set; }
    }
}