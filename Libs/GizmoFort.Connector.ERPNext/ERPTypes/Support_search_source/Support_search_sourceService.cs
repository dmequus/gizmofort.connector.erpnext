using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Support_search_source
{
    public class Support_search_sourceService : SubServiceBase<ERPSupport_search_source>
    {
        public Support_search_sourceService(ERPNextClient client)
            : base(DocType.Support_search_source, client) { }

        protected override ERPSupport_search_source fromERPObject(ERPObject obj)
        {
            return new ERPSupport_search_source(obj);
        }
    }
}