using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_promotion
{
    public class Employee_promotionService : SubServiceBase<ERPEmployee_promotion>
    {
        public Employee_promotionService(ERPNextClient client)
            : base(DocType.Employee_promotion, client) { }

        protected override ERPEmployee_promotion fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_promotion(obj);
        }
    }
}