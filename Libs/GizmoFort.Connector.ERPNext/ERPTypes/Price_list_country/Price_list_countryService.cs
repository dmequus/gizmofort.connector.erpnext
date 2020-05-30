using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Price_list_country
{
    public class Price_list_countryService : SubServiceBase<ERPPrice_list_country>
    {
        public Price_list_countryService(ERPNextClient client)
            : base(DocType.Price_list_country, client) { }

        protected override ERPPrice_list_country fromERPObject(ERPObject obj)
        {
            return new ERPPrice_list_country(obj);
        }
    }
}