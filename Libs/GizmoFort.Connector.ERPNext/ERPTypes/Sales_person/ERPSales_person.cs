using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_person
{
    public class ERPSales_person : ERPNextObjectBase
    {
        public ERPSales_person() : this(new ERPObject(DocType.Sales_person)) { }
        public ERPSales_person(ERPObject obj) : base(obj) { }

        public static ERPSales_person Create(string salespersonname, long isgroup)

        {
            ERPSales_person obj = new ERPSales_person();
            obj.sales_person_name = salespersonname;
            obj.is_group = isgroup;
            return obj;
        }

        public string sales_person_name
        {
            get { return data.sales_person_name; }
            set
            {
                data.sales_person_name = value;
                data.name = value;
            }

        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public string parent_sales_person
        {
            get { return data.parent_sales_person; }
            set { data.parent_sales_person = value; }
        }

        public string commission_rate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = value; }
        }

        public long enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public int lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        public int rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string targets
        {
            get { return data.targets; }
            set { data.targets = value; }
        }


    }

    //Enums go here

}