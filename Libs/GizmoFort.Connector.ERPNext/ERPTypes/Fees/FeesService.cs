using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fees
{
    public class FeesService : SubServiceBase<ERPFees>
    {
        public FeesService(ERPNextClient client)
            : base(DocType.Fees, client) { }

        protected override ERPFees fromERPObject(ERPObject obj)
        {
            return new ERPFees(obj);
        }
    }
}