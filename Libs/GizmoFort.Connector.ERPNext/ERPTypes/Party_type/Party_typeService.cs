using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Party_type
{
    public class Party_typeService : SubServiceBase<ERPParty_type>
    {
        public Party_typeService(ERPNextClient client)
            : base(DocType.Party_type, client) { }

        protected override ERPParty_type fromERPObject(ERPObject obj)
        {
            return new ERPParty_type(obj);
        }
    }
}