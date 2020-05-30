using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter_symptom
{
    public class ERPPatient_encounter_symptom : ERPNextObjectBase
    {
        public ERPPatient_encounter_symptom() : this(new ERPObject(DocType.Patient_encounter_symptom)) { }
        public ERPPatient_encounter_symptom(ERPObject obj) : base(obj) { }

        public static ERPPatient_encounter_symptom Create(string complaint)

        {
            ERPPatient_encounter_symptom obj = new ERPPatient_encounter_symptom();
            obj.complaint = complaint;
            return obj;
        }

        public string complaint
        {
            get { return data.complaint; }
            set
            {
                data.complaint = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}