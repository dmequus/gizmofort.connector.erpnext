using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_category
{
    public class ERPEmployee_tax_exemption_category : ERPNextObjectBase
    {
        public ERPEmployee_tax_exemption_category() : this(new ERPObject(DocType.Employee_tax_exemption_category)) { }
        public ERPEmployee_tax_exemption_category(ERPObject obj) : base(obj) { }

        public static ERPEmployee_tax_exemption_category Create(double maxamount, long isactive)

        {
            ERPEmployee_tax_exemption_category obj = new ERPEmployee_tax_exemption_category();
            obj.max_amount = maxamount;
            obj.is_active = isactive;
            return obj;
        }

        public double max_amount
        {
            get { return data.max_amount; }
            set { data.max_amount = value; }
        }

        public long is_active
        {
            get { return data.is_active; }
            set { data.is_active = value; }
        }


    }

    //Enums go here

}