using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_details
{
    public class Pos_closing_voucher_detailsService : SubServiceBase<ERPPos_closing_voucher_details>
    {
        public Pos_closing_voucher_detailsService(ERPNextClient client)
            : base(DocType.Pos_closing_voucher_details, client) { }

        protected override ERPPos_closing_voucher_details fromERPObject(ERPObject obj)
        {
            return new ERPPos_closing_voucher_details(obj);
        }
    }
}