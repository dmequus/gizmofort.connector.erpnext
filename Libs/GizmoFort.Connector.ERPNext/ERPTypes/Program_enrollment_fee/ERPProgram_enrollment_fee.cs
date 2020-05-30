using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_fee
{
    public class ERPProgram_enrollment_fee : ERPNextObjectBase
    {
        public ERPProgram_enrollment_fee() : this(new ERPObject(DocType.Program_enrollment_fee)) { }
        public ERPProgram_enrollment_fee(ERPObject obj) : base(obj) { }

        public static ERPProgram_enrollment_fee Create(string academicterm, string feestructure, string duedate, double amount)

        {
            ERPProgram_enrollment_fee obj = new ERPProgram_enrollment_fee();
            obj.academic_term = academicterm;
            obj.fee_structure = feestructure;
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

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }


    }

    //Enums go here

}