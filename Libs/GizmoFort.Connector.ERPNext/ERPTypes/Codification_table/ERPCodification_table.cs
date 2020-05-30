using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Codification_table
{
    public class ERPCodification_table : ERPNextObjectBase
    {
        public ERPCodification_table() : this(new ERPObject(DocType.Codification_table)) { }
        public ERPCodification_table(ERPObject obj) : base(obj) { }

        public static ERPCodification_table Create(string medicalcode)

        {
            ERPCodification_table obj = new ERPCodification_table();
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