using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Diagnosis
{
    public class ERPDiagnosis : ERPNextObjectBase
    {
        public ERPDiagnosis() : this(new ERPObject(DocType.Diagnosis)) { }
        public ERPDiagnosis(ERPObject obj) : base(obj) { }

        public static ERPDiagnosis Create(string diagnosis)

        {
            ERPDiagnosis obj = new ERPDiagnosis();
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