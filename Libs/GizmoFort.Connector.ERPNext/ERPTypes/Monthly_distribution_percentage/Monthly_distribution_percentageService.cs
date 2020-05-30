using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Monthly_distribution_percentage
{
    public class Monthly_distribution_percentageService : SubServiceBase<ERPMonthly_distribution_percentage>
    {
        public Monthly_distribution_percentageService(ERPNextClient client)
            : base(DocType.Monthly_distribution_percentage, client) { }

        protected override ERPMonthly_distribution_percentage fromERPObject(ERPObject obj)
        {
            return new ERPMonthly_distribution_percentage(obj);
        }
    }
}