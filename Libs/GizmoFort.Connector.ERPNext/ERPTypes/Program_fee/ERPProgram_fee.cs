using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_fee
{
    public class ERPProgram_fee : ERPNextObjectBase
    {
        public ERPProgram_fee() : this(new ERPObject(DocType.Program_fee)) { }
        public ERPProgram_fee(ERPObject obj) : base(obj) { }

        public static ERPProgram_fee Create(string academicterm, string feestructure, string studentcategory, string duedate, double amount)

        {
            ERPProgram_fee obj = new ERPProgram_fee();
            obj.academic_term = academicterm;
            obj.fee_structure = feestructure;
            obj.student_category = studentcategory;
            obj.due_date = duedate;
            obj.amount = amount;
            return obj;
        }

        public string academic_term
        {
            get { return data.academic_term; }
            set
            {
                data.academic_term = value;
                data.name = value;
            }

        }

        public string fee_structure
        {
            get { return data.fee_structure; }
            set { data.fee_structure = value; }
        }

        public string student_category
        {
            get { return data.student_category; }
            set { data.student_category = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }


    }

    //Enums go here

}