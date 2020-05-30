using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_clearance
{
    public class Bank_clearanceService : SubServiceBase<ERPBank_clearance>
    {
        public Bank_clearanceService(ERPNextClient client)
            : base(DocType.Bank_clearance, client) { }

        protected override ERPBank_clearance fromERPObject(ERPObject obj)
        {
            return new ERPBank_clearance(obj);
        }
    }
}