using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Antibiotic
{
    public class ERPAntibiotic : ERPNextObjectBase
    {
        public ERPAntibiotic() : this(new ERPObject(DocType.Antibiotic)) { }
        public ERPAntibiotic(ERPObject obj) : base(obj) { }

        public static ERPAntibiotic Create(string antibioticname)

        {
            ERPAntibiotic obj = new ERPAntibiotic();
            obj.antibiotic_name = antibioticname;
            return obj;
        }

        public string antibiotic_name
        {
            get { return data.antibiotic_name; }
            set
            {
                data.antibiotic_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}