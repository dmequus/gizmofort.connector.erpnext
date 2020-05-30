using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website_filter_field
{
    public class Website_filter_fieldService : SubServiceBase<ERPWebsite_filter_field>
    {
        public Website_filter_fieldService(ERPNextClient client)
            : base(DocType.Website_filter_field, client) { }

        protected override ERPWebsite_filter_field fromERPObject(ERPObject obj)
        {
            return new ERPWebsite_filter_field(obj);
        }
    }
}