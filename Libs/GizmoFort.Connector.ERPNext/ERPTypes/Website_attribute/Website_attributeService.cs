using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website_attribute
{
    public class Website_attributeService : SubServiceBase<ERPWebsite_attribute>
    {
        public Website_attributeService(ERPNextClient client)
            : base(DocType.Website_attribute, client) { }

        protected override ERPWebsite_attribute fromERPObject(ERPObject obj)
        {
            return new ERPWebsite_attribute(obj);
        }
    }
}