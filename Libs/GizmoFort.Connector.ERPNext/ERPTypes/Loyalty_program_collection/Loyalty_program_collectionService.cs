using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_program_collection
{
    public class Loyalty_program_collectionService : SubServiceBase<ERPLoyalty_program_collection>
    {
        public Loyalty_program_collectionService(ERPNextClient client)
            : base(DocType.Loyalty_program_collection, client) { }

        protected override ERPLoyalty_program_collection fromERPObject(ERPObject obj)
        {
            return new ERPLoyalty_program_collection(obj);
        }
    }
}