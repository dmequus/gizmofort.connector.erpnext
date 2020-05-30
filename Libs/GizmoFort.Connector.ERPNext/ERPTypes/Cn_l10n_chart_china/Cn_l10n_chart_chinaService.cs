using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cn_l10n_chart_china
{
    public class Cn_l10n_chart_chinaService : SubServiceBase<ERPCn_l10n_chart_china>
    {
        public Cn_l10n_chart_chinaService(ERPNextClient client)
            : base(DocType.Cn_l10n_chart_china, client) { }

        protected override ERPCn_l10n_chart_china fromERPObject(ERPObject obj)
        {
            return new ERPCn_l10n_chart_china(obj);
        }
    }
}