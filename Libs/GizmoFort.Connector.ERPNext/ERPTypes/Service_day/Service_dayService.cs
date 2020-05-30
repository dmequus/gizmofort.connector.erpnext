using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_day
{
    public class Service_dayService : SubServiceBase<ERPService_day>
    {
        public Service_dayService(ERPNextClient client)
            : base(DocType.Service_day, client) { }

        protected override ERPService_day fromERPObject(ERPObject obj)
        {
            return new ERPService_day(obj);
        }
    }
}