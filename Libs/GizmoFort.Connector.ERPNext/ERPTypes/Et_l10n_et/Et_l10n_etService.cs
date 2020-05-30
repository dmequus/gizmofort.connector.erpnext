using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Et_l10n_et
{
    public class Et_l10n_etService : SubServiceBase<ERPEt_l10n_et>
    {
        public Et_l10n_etService(ERPNextClient client)
            : base(DocType.Et_l10n_et, client) { }

        protected override ERPEt_l10n_et fromERPObject(ERPObject obj)
        {
            return new ERPEt_l10n_et(obj);
        }
    }
}