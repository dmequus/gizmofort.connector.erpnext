using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule_program
{
    public class ERPFee_schedule_program : ERPNextObjectBase
    {
        public ERPFee_schedule_program() : this(new ERPObject(DocType.Fee_schedule_program)) { }
        public ERPFee_schedule_program(ERPObject obj) : base(obj) { }

        public static ERPFee_schedule_program Create(string program, string studentbatch, string totalstudents)

        {
            ERPFee_schedule_program obj = new ERPFee_schedule_program();
            obj.program = program;
            obj.student_batch = studentbatch;
            obj.total_students = totalstudents;
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

        public string student_batch
        {
            get { return data.student_batch; }
            set { data.student_batch = value; }
        }

        public string total_students
        {
            get { return data.total_students; }
            set { data.total_students = value; }
        }


    }

    //Enums go here

}