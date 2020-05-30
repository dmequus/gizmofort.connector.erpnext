using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purpose_of_travel
{
    public class Purpose_of_travelService : SubServiceBase<ERPPurpose_of_travel>
    {
        public Purpose_of_travelService(ERPNextClient client)
            : base(DocType.Purpose_of_travel, client) { }

        protected override ERPPurpose_of_travel fromERPObject(ERPObject obj)
        {
            return new ERPPurpose_of_travel(obj);
        }
    }
}