using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection
{
    public class Quality_inspectionService : SubServiceBase<ERPQuality_inspection>
    {
        public Quality_inspectionService(ERPNextClient client)
            : base(DocType.Quality_inspection, client) { }

        protected override ERPQuality_inspection fromERPObject(ERPObject obj)
        {
            return new ERPQuality_inspection(obj);
        }
    }
}