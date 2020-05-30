using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage_section
{
    public class Homepage_sectionService : SubServiceBase<ERPHomepage_section>
    {
        public Homepage_sectionService(ERPNextClient client)
            : base(DocType.Homepage_section, client) { }

        protected override ERPHomepage_section fromERPObject(ERPObject obj)
        {
            return new ERPHomepage_section(obj);
        }
    }
}