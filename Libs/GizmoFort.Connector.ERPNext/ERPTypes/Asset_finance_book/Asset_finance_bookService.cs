using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_finance_book
{
    public class Asset_finance_bookService : SubServiceBase<ERPAsset_finance_book>
    {
        public Asset_finance_bookService(ERPNextClient client)
            : base(DocType.Asset_finance_book, client) { }

        protected override ERPAsset_finance_book fromERPObject(ERPObject obj)
        {
            return new ERPAsset_finance_book(obj);
        }
    }
}