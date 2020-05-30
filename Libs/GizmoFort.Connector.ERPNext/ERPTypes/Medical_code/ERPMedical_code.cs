using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Medical_code
{
    public class ERPMedical_code : ERPNextObjectBase
    {
        public ERPMedical_code() : this(new ERPObject(DocType.Medical_code)) { }
        public ERPMedical_code(ERPObject obj) : base(obj) { }

        public static ERPMedical_code Create(string medicalcodestandard, string code, string description)

        {
            ERPMedical_code obj = new ERPMedical_code();
            obj.medical_code_standard = medicalcodestandard;
            obj.code = code;
            obj.description = description;
            return obj;
        }

        public string medical_code_standard
        {
            get { return data.medical_code_standard; }
            set
            {
                data.medical_code_standard = value;
                data.name = value;
            }

        }

        public string code
        {
            get { return data.code; }
            set { data.code = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}