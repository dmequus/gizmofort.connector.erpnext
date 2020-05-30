using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_alternative
{
    public class Item_alternativeService : SubServiceBase<ERPItem_alternative>
    {
        public Item_alternativeService(ERPNextClient client)
            : base(DocType.Item_alternative, client) { }

        protected override ERPItem_alternative fromERPObject(ERPObject obj)
        {
            return new ERPItem_alternative(obj);
        }
    }
}