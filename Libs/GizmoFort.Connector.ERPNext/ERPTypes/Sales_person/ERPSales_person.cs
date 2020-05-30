using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_person
{
    public class ERPSales_person : ERPNextObjectBase
    {
        public ERPSales_person() : this(new ERPObject(DocType.Sales_person)) { }
        public ERPSales_person(ERPObject obj) : base(obj) { }

        public static ERPSales_person Create(string salespersonname, int isgroup)

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

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
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

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
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

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
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