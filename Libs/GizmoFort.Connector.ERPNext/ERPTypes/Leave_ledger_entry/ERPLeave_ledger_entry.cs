using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_ledger_entry
{
    public class ERPLeave_ledger_entry : ERPNextObjectBase
    {
        public ERPLeave_ledger_entry() : this(new ERPObject(DocType.Leave_ledger_entry)) { }
        public ERPLeave_ledger_entry(ERPObject obj) : base(obj) { }

        public static ERPLeave_ledger_entry Create(string employee)

        {
            ERPLeave_ledger_entry obj = new ERPLeave_ledger_entry();
            obj.employee = employee;
            return obj;
        }

        public string employee
        {
            get { return data.employee; }
            set
            {
                data.employee = value;
                data.name = value;
            }

        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string leave_type
        {
            get { return data.leave_type; }
            set { data.leave_type = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string transaction_type
        {
            get { return data.transaction_type; }
            set { data.transaction_type = value; }
        }

        public string transaction_name
        {
            get { return data.transaction_name; }
            set { data.transaction_name = value; }
        }

        private double _leaves = 0.0;
        public double leaves
        {
            get { return data._leaves; }
            set { data._leaves = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        private int _is_carry_forward = 0;
        public int is_carry_forward
        {
            get { return data._is_carry_forward; }
            set { data._is_carry_forward = value; }
        }

        private int _is_expired = 0;
        public int is_expired
        {
            get { return data._is_expired; }
            set { data._is_expired = value; }
        }

        private int _is_lwp = 0;
        public int is_lwp
        {
            get { return data._is_lwp; }
            set { data._is_lwp = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }


    }

    //Enums go here

}