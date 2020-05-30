using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gst_hsn_code
{
    public class Gst_hsn_codeService : SubServiceBase<ERPGst_hsn_code>
    {
        public Gst_hsn_codeService(ERPNextClient client)
            : base(DocType.Gst_hsn_code, client) { }

        protected override ERPGst_hsn_code fromERPObject(ERPObject obj)
        {
            return new ERPGst_hsn_code(obj);
        }
    }
}