using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Price_list
{
    public class Price_listService : SubServiceBase<ERPPrice_list>
    {
        public Price_listService(ERPNextClient client)
            : base(DocType.Price_list, client) { }

        protected override ERPPrice_list fromERPObject(ERPObject obj)
        {
            return new ERPPrice_list(obj);
        }
    }
}