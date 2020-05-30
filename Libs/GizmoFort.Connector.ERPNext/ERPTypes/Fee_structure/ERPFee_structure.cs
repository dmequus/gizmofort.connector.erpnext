using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_structure
{
    public class ERPFee_structure : ERPNextObjectBase
    {
        public ERPFee_structure() : this(new ERPObject(DocType.Fee_structure)) { }
        public ERPFee_structure(ERPObject obj) : base(obj) { }

        public static ERPFee_structure Create(string program, string components, string receivableaccount)

        {
            ERPFee_structure obj = new ERPFee_structure();
            obj.program = program;
            obj.components = components;
            obj.receivable_account = receivableaccount;
            return obj;
        }

        public string program
        {
            get { return data.program; }
            set
            {
                data.program = value;
                data.name = value;
            }

        }

        public string components
        {
            get { return data.components; }
            set { data.components = value; }
        }

        public string receivable_account
        {
            get { return data.receivable_account; }
            set { data.receivable_account = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string student_category
        {
            get { return data.student_category; }
            set { data.student_category = value; }
        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        private double _total_amount = 0.0;
        public double total_amount
        {
            get { return data._total_amount; }
            set { data._total_amount = value; }
        }

        public string income_account
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}