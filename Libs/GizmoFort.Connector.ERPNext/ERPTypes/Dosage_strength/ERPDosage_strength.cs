using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Dosage_strength
{
    public class ERPDosage_strength : ERPNextObjectBase
    {
        public ERPDosage_strength() : this(new ERPObject(DocType.Dosage_strength)) { }
        public ERPDosage_strength(ERPObject obj) : base(obj) { }

        public static ERPDosage_strength Create(double strength, string strengthtime)

        {
            ERPDosage_strength obj = new ERPDosage_strength();
            obj.strength = strength;
            obj.strength_time = strengthtime;
            return obj;
        }

        public double strength
        {
            get { return data.strength; }
            set { data.strength = value; }
        }

        public string strength_time
        {
            get { return data.strength_time; }
            set { data.strength_time = value; }
        }


    }

    //Enums go here

}