using System.ComponentModel.Composition;

namespace ExtensibleLibrary
{
    [Export]
    public class Junk
    {
        [Import(typeof(string))]
        public string SomeString { get; set; }
    }

    [Export]
    public class EmptyBottle
    {
        [Export(typeof(string))]
        public string Lable { get; set; }
    }

    [Export]
    public class PillBottle
    {
        [Export(typeof(string))]
        public string MedicationName { get; set; }
    }

    [Export]
    public class JunkWithNoProblem
    {
        [Import(typeof(object))]
        public object SomeObject { get; set; }
    }

    [Export]
    public class EmptyJar
    {
        [Export(typeof(object))]
        public object ExportedObject { get; set; }
    }


    public class EmptyCan
    {
        [Export(typeof(object))]
        public string Wrapper { get; set; }
    }
}