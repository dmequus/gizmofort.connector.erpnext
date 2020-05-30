using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_procedure
{
    public class Quality_procedureService : SubServiceBase<ERPQuality_procedure>
    {
        public Quality_procedureService(ERPNextClient client)
            : base(DocType.Quality_procedure, client) { }

        protected override ERPQuality_procedure fromERPObject(ERPObject obj)
        {
            return new ERPQuality_procedure(obj);
        }
    }
}