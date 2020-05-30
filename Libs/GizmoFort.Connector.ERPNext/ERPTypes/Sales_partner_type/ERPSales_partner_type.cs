using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_partner_type
{
    public class ERPSales_partner_type : ERPNextObjectBase
    {
        public ERPSales_partner_type() : this(new ERPObject(DocType.Sales_partner_type)) { }
        public ERPSales_partner_type(ERPObject obj) : base(obj) { }

        public static ERPSales_partner_type Create(string salespartnertype)

        {
            ERPSales_partner_type obj = new ERPSales_partner_type();
            obj.sales_partner_type = salespartnertype;
            return obj;
        }

        public string sales_partner_type
        {
            get { return data.sales_partner_type; }
            set
            {
                data.sales_partner_type = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}