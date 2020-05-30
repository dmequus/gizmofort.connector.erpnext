using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_category
{
    public class Tax_withholding_categoryService : SubServiceBase<ERPTax_withholding_category>
    {
        public Tax_withholding_categoryService(ERPNextClient client)
            : base(DocType.Tax_withholding_category, client) { }

        protected override ERPTax_withholding_category fromERPObject(ERPObject obj)
        {
            return new ERPTax_withholding_category(obj);
        }
    }
}