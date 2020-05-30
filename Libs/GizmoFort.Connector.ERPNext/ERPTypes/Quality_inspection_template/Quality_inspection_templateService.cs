using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection_template
{
    public class Quality_inspection_templateService : SubServiceBase<ERPQuality_inspection_template>
    {
        public Quality_inspection_templateService(ERPNextClient client)
            : base(DocType.Quality_inspection_template, client) { }

        protected override ERPQuality_inspection_template fromERPObject(ERPObject obj)
        {
            return new ERPQuality_inspection_template(obj);
        }
    }
}