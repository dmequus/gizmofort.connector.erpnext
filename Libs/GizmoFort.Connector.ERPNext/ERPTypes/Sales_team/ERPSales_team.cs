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

        public double allocated_percentage
        {
            get { return data.allocated_percentage; }
            set { data.allocated_percentage = value; }
        }

        public double allocated_amount
        {
            get { return data.allocated_amount; }
            set { data.allocated_amount = value; }
        }

        public string commission_rate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = value; }
        }

        public double incentives
        {
            get { return data.incentives; }
            set { data.incentives = value; }
        }


    }

    //Enums go here

}