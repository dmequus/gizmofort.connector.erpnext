using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Monthly_distribution
{
    public class Monthly_distributionService : SubServiceBase<ERPMonthly_distribution>
    {
        public Monthly_distributionService(ERPNextClient client)
            : base(DocType.Monthly_distribution, client) { }

        protected override ERPMonthly_distribution fromERPObject(ERPObject obj)
        {
            return new ERPMonthly_distribution(obj);
        }
    }
}