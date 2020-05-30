using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_rate
{
    public class Tax_withholding_rateService : SubServiceBase<ERPTax_withholding_rate>
    {
        public Tax_withholding_rateService(ERPNextClient client)
            : base(DocType.Tax_withholding_rate, client) { }

        protected override ERPTax_withholding_rate fromERPObject(ERPObject obj)
        {
            return new ERPTax_withholding_rate(obj);
        }
    }
}