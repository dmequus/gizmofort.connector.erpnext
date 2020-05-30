using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Retention_bonus
{
    public class Retention_bonusService : SubServiceBase<ERPRetention_bonus>
    {
        public Retention_bonusService(ERPNextClient client)
            : base(DocType.Retention_bonus, client) { }

        protected override ERPRetention_bonus fromERPObject(ERPObject obj)
        {
            return new ERPRetention_bonus(obj);
        }
    }
}