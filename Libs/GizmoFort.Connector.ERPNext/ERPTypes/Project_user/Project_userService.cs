using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_user
{
    public class Project_userService : SubServiceBase<ERPProject_user>
    {
        public Project_userService(ERPNextClient client)
            : base(DocType.Project_user, client) { }

        protected override ERPProject_user fromERPObject(ERPObject obj)
        {
            return new ERPProject_user(obj);
        }
    }
}