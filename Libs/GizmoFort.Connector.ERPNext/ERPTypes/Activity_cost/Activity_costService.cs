using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Activity_cost
{
    public class Activity_costService : SubServiceBase<ERPActivity_cost>
    {
        public Activity_costService(ERPNextClient client)
            : base(DocType.Activity_cost, client) { }

        protected override ERPActivity_cost fromERPObject(ERPObject obj)
        {
            return new ERPActivity_cost(obj);
        }
    }
}