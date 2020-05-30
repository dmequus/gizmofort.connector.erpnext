using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_category
{
    public class ERPEmployee_tax_exemption_category : ERPNextObjectBase
    {
        public ERPEmployee_tax_exemption_category() : this(new ERPObject(DocType.Employee_tax_exemption_category)) { }
        public ERPEmployee_tax_exemption_category(ERPObject obj) : base(obj) { }

        public static ERPEmployee_tax_exemption_category Create(double maxamount, int isactive)

        {
            ERPEmployee_tax_exemption_category obj = new ERPEmployee_tax_exemption_category();
            obj.max_amount = maxamount;
            obj.is_active = isactive;
            return obj;
        }

        private double _max_amount = 0.0;
        public double max_amount
        {
            get { return data._max_amount; }
            set { data._max_amount = value; }
        }

        private int _is_active = 0;
        public int is_active
        {
            get { return data._is_active; }
            set { data._is_active = value; }
        }


    }

    //Enums go here

}