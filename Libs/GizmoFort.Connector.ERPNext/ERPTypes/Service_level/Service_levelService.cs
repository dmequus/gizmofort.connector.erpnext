using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_level
{
    public class Service_levelService : SubServiceBase<ERPService_level>
    {
        public Service_levelService(ERPNextClient client)
            : base(DocType.Service_level, client) { }

        protected override ERPService_level fromERPObject(ERPObject obj)
        {
            return new ERPService_level(obj);
        }
    }
}