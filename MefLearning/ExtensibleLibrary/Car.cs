using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleLibrary
{
    [Export]
    public class Car
    {
        [Import]
        public BodyType BodyType { get; set; }

        [Import]
        public TransmissionType TransmissionType { get; set; }
    }
     
    public class NonExportedCar
    {
        [Import]
        public BodyType BodyType { get; set; }

        [Import]
        public TransmissionType TransmissionType { get; set; }
    }

    public class BodyType
    {
        
    }

    [Export(typeof(BodyType))]
    public class FourDoor : BodyType
    {
        
    }

    public class TransmissionType
    {
        
    }

    [Export(typeof(TransmissionType))]
    public class Automatic : TransmissionType
    {

    }
}
