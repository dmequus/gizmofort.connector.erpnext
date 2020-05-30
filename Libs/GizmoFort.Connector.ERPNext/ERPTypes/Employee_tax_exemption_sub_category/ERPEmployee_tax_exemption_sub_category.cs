using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_sub_category
{
    public class ERPEmployee_tax_exemption_sub_category : ERPNextObjectBase
    {
        public ERPEmployee_tax_exemption_sub_category() : this(new ERPObject(DocType.Employee_tax_exemption_sub_category)) { }
        public ERPEmployee_tax_exemption_sub_category(ERPObject obj) : base(obj) { }

        public static ERPEmployee_tax_exemption_sub_category Create(string exemptioncategory, double maxamount, long isactive)

        {
            ERPEmployee_tax_exemption_sub_category obj = new ERPEmployee_tax_exemption_sub_category();
            obj.exemption_category = exemptioncategory;
            obj.max_amount = maxamount;
            obj.is_active = isactive;
            return obj;
        }

        public string exemption_category
        {
            get { return data.exemption_category; }
            set
            {
                data.exemption_category = value;
                data.name = value;
            }

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