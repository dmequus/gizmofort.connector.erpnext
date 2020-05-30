using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lower_deduction_certificate
{
    public class Lower_deduction_certificateService : SubServiceBase<ERPLower_deduction_certificate>
    {
        public Lower_deduction_certificateService(ERPNextClient client)
            : base(DocType.Lower_deduction_certificate, client) { }

        protected override ERPLower_deduction_certificate fromERPObject(ERPObject obj)
        {
            return new ERPLower_deduction_certificate(obj);
        }
    }
}