using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Customs_tariff_number
{
    public class Customs_tariff_numberService : SubServiceBase<ERPCustoms_tariff_number>
    {
        public Customs_tariff_numberService(ERPNextClient client)
            : base(DocType.Customs_tariff_number, client) { }

        protected override ERPCustoms_tariff_number fromERPObject(ERPObject obj)
        {
            return new ERPCustoms_tariff_number(obj);
        }
    }
}