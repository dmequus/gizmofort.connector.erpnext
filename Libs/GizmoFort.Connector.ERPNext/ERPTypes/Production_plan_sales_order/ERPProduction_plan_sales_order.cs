using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_sales_order
{
    public class ERPProduction_plan_sales_order : ERPNextObjectBase
    {
        public ERPProduction_plan_sales_order() : this(new ERPObject(DocType.Production_plan_sales_order)) { }
        public ERPProduction_plan_sales_order(ERPObject obj) : base(obj) { }

        public static ERPProduction_plan_sales_order Create(string salesorder, string salesorderdate, string customer, double grandtotal)

        {
            ERPProduction_plan_sales_order obj = new ERPProduction_plan_sales_order();
            obj.sales_order = salesorder;
            obj.sales_order_date = salesorderdate;
            obj.customer = customer;
            obj.grand_total = grandtotal;
            return obj;
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set
            {
                data.sales_order = value;
                data.name = value;
            }

        }

        public string sales_order_date
        {
            get { return data.sales_order_date; }
            set { data.sales_order_date = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public double grand_total
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }


    }

    //Enums go here

}