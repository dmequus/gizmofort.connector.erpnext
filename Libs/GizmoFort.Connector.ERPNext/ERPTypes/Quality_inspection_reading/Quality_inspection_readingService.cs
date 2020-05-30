using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection_reading
{
    public class Quality_inspection_readingService : SubServiceBase<ERPQuality_inspection_reading>
    {
        public Quality_inspection_readingService(ERPNextClient client)
            : base(DocType.Quality_inspection_reading, client) { }

        protected override ERPQuality_inspection_reading fromERPObject(ERPObject obj)
        {
            return new ERPQuality_inspection_reading(obj);
        }
    }
}