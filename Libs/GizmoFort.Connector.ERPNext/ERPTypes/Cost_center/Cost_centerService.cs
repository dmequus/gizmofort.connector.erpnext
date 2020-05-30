using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cost_center
{
    public class Cost_centerService : SubServiceBase<ERPCost_center>
    {
        public Cost_centerService(ERPNextClient client)
            : base(DocType.Cost_center, client) { }

        protected override ERPCost_center fromERPObject(ERPObject obj)
        {
            return new ERPCost_center(obj);
        }
    }
}