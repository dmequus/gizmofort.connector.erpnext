using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage_section_card
{
    public class Homepage_section_cardService : SubServiceBase<ERPHomepage_section_card>
    {
        public Homepage_section_cardService(ERPNextClient client)
            : base(DocType.Homepage_section_card, client) { }

        protected override ERPHomepage_section_card fromERPObject(ERPObject obj)
        {
            return new ERPHomepage_section_card(obj);
        }
    }
}