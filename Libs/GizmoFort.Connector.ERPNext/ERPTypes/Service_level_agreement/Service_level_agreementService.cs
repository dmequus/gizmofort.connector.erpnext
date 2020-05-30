using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_level_agreement
{
    public class Service_level_agreementService : SubServiceBase<ERPService_level_agreement>
    {
        public Service_level_agreementService(ERPNextClient client)
            : base(DocType.Service_level_agreement, client) { }

        protected override ERPService_level_agreement fromERPObject(ERPObject obj)
        {
            return new ERPService_level_agreement(obj);
        }
    }
}