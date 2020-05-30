using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_update
{
    public class Project_updateService : SubServiceBase<ERPProject_update>
    {
        public Project_updateService(ERPNextClient client)
            : base(DocType.Project_update, client) { }

        protected override ERPProject_update fromERPObject(ERPObject obj)
        {
            return new ERPProject_update(obj);
        }
    }
}