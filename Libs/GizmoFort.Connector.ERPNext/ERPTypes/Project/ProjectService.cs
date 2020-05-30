using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Project
{
    public class ProjectService : SubServiceBase<ERPProject>
    {
        public ProjectService(ERPNextClient client)
            : base(DocType.Project, client) { }

        protected override ERPProject fromERPObject(ERPObject obj)
        {
            return new ERPProject(obj);
        }
    }
}