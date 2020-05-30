using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lead_source
{
    public class Lead_sourceService : SubServiceBase<ERPLead_source>
    {
        public Lead_sourceService(ERPNextClient client)
            : base(DocType.Lead_source, client) { }

        protected override ERPLead_source fromERPObject(ERPObject obj)
        {
            return new ERPLead_source(obj);
        }
    }
}