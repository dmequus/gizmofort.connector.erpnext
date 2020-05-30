using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_tax
{
    public class Item_taxService : SubServiceBase<ERPItem_tax>
    {
        public Item_taxService(ERPNextClient client)
            : base(DocType.Item_tax, client) { }

        protected override ERPItem_tax fromERPObject(ERPObject obj)
        {
            return new ERPItem_tax(obj);
        }
    }
}