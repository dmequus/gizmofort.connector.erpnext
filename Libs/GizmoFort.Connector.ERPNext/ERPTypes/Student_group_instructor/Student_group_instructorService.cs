using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_instructor
{
    public class Student_group_instructorService : SubServiceBase<ERPStudent_group_instructor>
    {
        public Student_group_instructorService(ERPNextClient client)
            : base(DocType.Student_group_instructor, client) { }

        protected override ERPStudent_group_instructor fromERPObject(ERPObject obj)
        {
            return new ERPStudent_group_instructor(obj);
        }
    }
}