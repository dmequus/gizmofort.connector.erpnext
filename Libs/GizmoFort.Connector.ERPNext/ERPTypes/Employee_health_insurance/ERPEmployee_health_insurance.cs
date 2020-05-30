using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_health_insurance
{
    public class ERPEmployee_health_insurance : ERPNextObjectBase
    {
        public ERPEmployee_health_insurance() : this(new ERPObject(DocType.Employee_health_insurance)) { }
        public ERPEmployee_health_insurance(ERPObject obj) : base(obj) { }

        public static ERPEmployee_health_insurance Create(string healthinsurancename)

        {
            ERPEmployee_health_insurance obj = new ERPEmployee_health_insurance();
            obj.health_insurance_name = healthinsurancename;
            return obj;
        }

        public string health_insurance_name
        {
            get { return data.health_insurance_name; }
            set
            {
                data.health_insurance_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}