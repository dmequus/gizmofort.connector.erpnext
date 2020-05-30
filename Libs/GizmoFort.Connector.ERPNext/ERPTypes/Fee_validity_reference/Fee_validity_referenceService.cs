using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_validity_reference
{
    public class Fee_validity_referenceService : SubServiceBase<ERPFee_validity_reference>
    {
        public Fee_validity_referenceService(ERPNextClient client)
            : base(DocType.Fee_validity_reference, client) { }

        protected override ERPFee_validity_reference fromERPObject(ERPObject obj)
        {
            return new ERPFee_validity_reference(obj);
        }
    }
}