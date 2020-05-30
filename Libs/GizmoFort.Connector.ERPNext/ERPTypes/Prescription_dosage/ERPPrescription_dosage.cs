using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Prescription_dosage
{
    public class ERPPrescription_dosage : ERPNextObjectBase
    {
        public ERPPrescription_dosage() : this(new ERPObject(DocType.Prescription_dosage)) { }
        public ERPPrescription_dosage(ERPObject obj) : base(obj) { }

        public static ERPPrescription_dosage Create(string dosage, string dosagestrength)

        {
            ERPPrescription_dosage obj = new ERPPrescription_dosage();
            obj.dosage = dosage;
            obj.dosage_strength = dosagestrength;
            return obj;
        }

        public string dosage
        {
            get { return data.dosage; }
            set
            {
                data.dosage = value;
                data.name = value;
            }

        }

        public string dosage_strength
        {
            get { return data.dosage_strength; }
            set { data.dosage_strength = value; }
        }


    }

    //Enums go here

}