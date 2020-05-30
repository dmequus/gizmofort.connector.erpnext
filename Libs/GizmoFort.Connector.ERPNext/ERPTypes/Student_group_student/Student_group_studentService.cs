using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_student
{
    public class Student_group_studentService : SubServiceBase<ERPStudent_group_student>
    {
        public Student_group_studentService(ERPNextClient client)
            : base(DocType.Student_group_student, client) { }

        protected override ERPStudent_group_student fromERPObject(ERPObject obj)
        {
            return new ERPStudent_group_student(obj);
        }
    }
}