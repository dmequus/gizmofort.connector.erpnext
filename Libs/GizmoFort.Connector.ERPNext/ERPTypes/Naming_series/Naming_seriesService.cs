using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Naming_series
{
    public class Naming_seriesService : SubServiceBase<ERPNaming_series>
    {
        public Naming_seriesService(ERPNextClient client)
            : base(DocType.Naming_series, client) { }

        protected override ERPNaming_series fromERPObject(ERPObject obj)
        {
            return new ERPNaming_series(obj);
        }
    }
}