using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_admission_program
{
    public class Student_admission_programService : SubServiceBase<ERPStudent_admission_program>
    {
        public Student_admission_programService(ERPNextClient client)
            : base(DocType.Student_admission_program, client) { }

        protected override ERPStudent_admission_program fromERPObject(ERPObject obj)
        {
            return new ERPStudent_admission_program(obj);
        }
    }
}