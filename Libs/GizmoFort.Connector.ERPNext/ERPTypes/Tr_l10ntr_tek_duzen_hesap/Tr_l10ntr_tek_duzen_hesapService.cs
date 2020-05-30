using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tr_l10ntr_tek_duzen_hesap
{
    public class Tr_l10ntr_tek_duzen_hesapService : SubServiceBase<ERPTr_l10ntr_tek_duzen_hesap>
    {
        public Tr_l10ntr_tek_duzen_hesapService(ERPNextClient client)
            : base(DocType.Tr_l10ntr_tek_duzen_hesap, client) { }

        protected override ERPTr_l10ntr_tek_duzen_hesap fromERPObject(ERPObject obj)
        {
            return new ERPTr_l10ntr_tek_duzen_hesap(obj);
        }
    }
}