using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_level_priority
{
    public class Service_level_priorityService : SubServiceBase<ERPService_level_priority>
    {
        public Service_level_priorityService(ERPNextClient client)
            : base(DocType.Service_level_priority, client) { }

        protected override ERPService_level_priority fromERPObject(ERPObject obj)
        {
            return new ERPService_level_priority(obj);
        }
    }
}