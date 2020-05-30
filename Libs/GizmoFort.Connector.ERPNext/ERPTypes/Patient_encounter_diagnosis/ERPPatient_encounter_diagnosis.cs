using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter_diagnosis
{
    public class ERPPatient_encounter_diagnosis : ERPNextObjectBase
    {
        public ERPPatient_encounter_diagnosis() : this(new ERPObject(DocType.Patient_encounter_diagnosis)) { }
        public ERPPatient_encounter_diagnosis(ERPObject obj) : base(obj) { }

        public static ERPPatient_encounter_diagnosis Create(string diagnosis)

        {
            ERPPatient_encounter_diagnosis obj = new ERPPatient_encounter_diagnosis();
            obj.diagnosis = diagnosis;
            return obj;
        }

        public string diagnosis
        {
            get { return data.diagnosis; }
            set
            {
                data.diagnosis = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}