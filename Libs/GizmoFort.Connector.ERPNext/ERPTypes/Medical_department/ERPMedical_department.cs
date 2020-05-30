using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Medical_department
{
    public class ERPMedical_department : ERPNextObjectBase
    {
        public ERPMedical_department() : this(new ERPObject(DocType.Medical_department)) { }
        public ERPMedical_department(ERPObject obj) : base(obj) { }

        public static ERPMedical_department Create(string department)

        {
            ERPMedical_department obj = new ERPMedical_department();
            obj.department = department;
            return obj;
        }

        public string department
        {
            get { return data.department; }
            set
            {
                data.department = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}