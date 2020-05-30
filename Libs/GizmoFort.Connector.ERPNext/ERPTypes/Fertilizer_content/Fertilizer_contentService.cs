using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fertilizer_content
{
    public class Fertilizer_contentService : SubServiceBase<ERPFertilizer_content>
    {
        public Fertilizer_contentService(ERPNextClient client)
            : base(DocType.Fertilizer_content, client) { }

        protected override ERPFertilizer_content fromERPObject(ERPObject obj)
        {
            return new ERPFertilizer_content(obj);
        }
    }
}