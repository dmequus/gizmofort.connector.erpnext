using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Task_depends_on
{
    public class Task_depends_onService : SubServiceBase<ERPTask_depends_on>
    {
        public Task_depends_onService(ERPNextClient client)
            : base(DocType.Task_depends_on, client) { }

        protected override ERPTask_depends_on fromERPObject(ERPObject obj)
        {
            return new ERPTask_depends_on(obj);
        }
    }
}