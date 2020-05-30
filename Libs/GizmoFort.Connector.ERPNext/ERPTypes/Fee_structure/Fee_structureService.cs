using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_structure
{
    public class Fee_structureService : SubServiceBase<ERPFee_structure>
    {
        public Fee_structureService(ERPNextClient client)
            : base(DocType.Fee_structure, client) { }

        protected override ERPFee_structure fromERPObject(ERPObject obj)
        {
            return new ERPFee_structure(obj);
        }
    }
}