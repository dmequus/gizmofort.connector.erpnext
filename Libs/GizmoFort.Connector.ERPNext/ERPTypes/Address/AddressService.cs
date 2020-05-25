using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Address
{
    public class AddressService : SubServiceBase<ERPAddress>
    {
        public AddressService(ERPNextClient client)
            : base(DocType.Address, client) { }

        protected override ERPAddress fromERPObject(ERPObject obj)
        {
            return new ERPAddress(obj);
        }
    }
}
