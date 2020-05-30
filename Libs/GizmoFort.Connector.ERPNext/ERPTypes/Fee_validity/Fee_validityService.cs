using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_validity
{
    public class Fee_validityService : SubServiceBase<ERPFee_validity>
    {
        public Fee_validityService(ERPNextClient client)
            : base(DocType.Fee_validity, client) { }

        protected override ERPFee_validity fromERPObject(ERPObject obj)
        {
            return new ERPFee_validity(obj);
        }
    }
}