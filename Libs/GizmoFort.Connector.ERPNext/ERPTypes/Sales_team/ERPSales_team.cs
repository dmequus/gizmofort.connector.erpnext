using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_team
{
    public class ERPSales_team : ERPNextObjectBase
    {
        public ERPSales_team() : this(new ERPObject(DocType.Sales_team)) { }
        public ERPSales_team(ERPObject obj) : base(obj) { }

        public static ERPSales_team Create(string salesperson, string contactno, double allocatedpercentage, double allocatedamount, string commissionrate, double incentives)

        {
            ERPSales_team obj = new ERPSales_team();
            obj.sales_person = salesperson;
            obj.contact_no = contactno;
            obj.allocated_percentage = allocatedpercentage;
            obj.allocated_amount = allocatedamount;
            obj.commission_rate = commissionrate;
            obj.incentives = incentives;
            return obj;
        }

        public string sales_person
        {
            get { return data.sales_person; }
            set
            {
                data.sales_person = value;
                data.name = value;
            }

        }

        public string contact_no
        {
            get { return data.contact_no; }
            set { data.contact_no = value; }
        }

        private double _allocated_percentage = 0.0;
        public double allocated_percentage
        {
            get { return data._allocated_percentage; }
            set { data._allocated_percentage = value; }
        }

        private double _allocated_amount = 0.0;
        public double allocated_amount
        {
            get { return data._allocated_amount; }
            set { data._allocated_amount = value; }
        }

        public string commission_rate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = value; }
        }

        private double _incentives = 0.0;
        public double incentives
        {
            get { return data._incentives; }
            set { data._incentives = value; }
        }


    }

    //Enums go here

}