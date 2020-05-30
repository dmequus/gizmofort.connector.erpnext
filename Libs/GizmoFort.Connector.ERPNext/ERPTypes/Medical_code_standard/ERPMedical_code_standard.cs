using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Medical_code_standard
{
    public class ERPMedical_code_standard : ERPNextObjectBase
    {
        public ERPMedical_code_standard() : this(new ERPObject(DocType.Medical_code_standard)) { }
        public ERPMedical_code_standard(ERPObject obj) : base(obj) { }

        public static ERPMedical_code_standard Create(string medicalcode)

        {
            ERPMedical_code_standard obj = new ERPMedical_code_standard();
            obj.medical_code = medicalcode;
            return obj;
        }

        public string medical_code
        {
            get { return data.medical_code; }
            set
            {
                data.medical_code = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}