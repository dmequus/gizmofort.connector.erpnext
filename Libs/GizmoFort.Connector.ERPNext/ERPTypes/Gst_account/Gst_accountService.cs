using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gst_account
{
    public class Gst_accountService : SubServiceBase<ERPGst_account>
    {
        public Gst_accountService(ERPNextClient client)
            : base(DocType.Gst_account, client) { }

        protected override ERPGst_account fromERPObject(ERPObject obj)
        {
            return new ERPGst_account(obj);
        }
    }
}