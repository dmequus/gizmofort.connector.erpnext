using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_category
{
    public class Tax_categoryService : SubServiceBase<ERPTax_category>
    {
        public Tax_categoryService(ERPNextClient client)
            : base(DocType.Tax_category, client) { }

        protected override ERPTax_category fromERPObject(ERPObject obj)
        {
            return new ERPTax_category(obj);
        }
    }
}