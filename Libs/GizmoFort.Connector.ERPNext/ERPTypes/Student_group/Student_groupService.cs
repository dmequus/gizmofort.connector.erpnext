using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group
{
    public class Student_groupService : SubServiceBase<ERPStudent_group>
    {
        public Student_groupService(ERPNextClient client)
            : base(DocType.Student_group, client) { }

        protected override ERPStudent_group fromERPObject(ERPObject obj)
        {
            return new ERPStudent_group(obj);
        }
    }
}