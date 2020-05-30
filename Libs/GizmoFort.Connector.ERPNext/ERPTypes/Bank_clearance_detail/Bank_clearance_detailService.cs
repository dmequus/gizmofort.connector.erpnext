using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_clearance_detail
{
    public class Bank_clearance_detailService : SubServiceBase<ERPBank_clearance_detail>
    {
        public Bank_clearance_detailService(ERPNextClient client)
            : base(DocType.Bank_clearance_detail, client) { }

        protected override ERPBank_clearance_detail fromERPObject(ERPObject obj)
        {
            return new ERPBank_clearance_detail(obj);
        }
    }
}