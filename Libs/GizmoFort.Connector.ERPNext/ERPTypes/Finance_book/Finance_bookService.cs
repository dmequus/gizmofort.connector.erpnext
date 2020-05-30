using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Finance_book
{
    public class Finance_bookService : SubServiceBase<ERPFinance_book>
    {
        public Finance_bookService(ERPNextClient client)
            : base(DocType.Finance_book, client) { }

        protected override ERPFinance_book fromERPObject(ERPObject obj)
        {
            return new ERPFinance_book(obj);
        }
    }
}