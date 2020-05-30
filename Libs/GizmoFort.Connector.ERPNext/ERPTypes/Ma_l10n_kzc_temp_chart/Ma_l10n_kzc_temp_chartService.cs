using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ma_l10n_kzc_temp_chart
{
    public class Ma_l10n_kzc_temp_chartService : SubServiceBase<ERPMa_l10n_kzc_temp_chart>
    {
        public Ma_l10n_kzc_temp_chartService(ERPNextClient client)
            : base(DocType.Ma_l10n_kzc_temp_chart, client) { }

        protected override ERPMa_l10n_kzc_temp_chart fromERPObject(ERPObject obj)
        {
            return new ERPMa_l10n_kzc_temp_chart(obj);
        }
    }
}