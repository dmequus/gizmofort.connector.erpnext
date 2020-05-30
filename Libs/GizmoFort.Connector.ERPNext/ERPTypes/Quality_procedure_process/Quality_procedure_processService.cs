using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_procedure_process
{
    public class Quality_procedure_processService : SubServiceBase<ERPQuality_procedure_process>
    {
        public Quality_procedure_processService(ERPNextClient client)
            : base(DocType.Quality_procedure_process, client) { }

        protected override ERPQuality_procedure_process fromERPObject(ERPObject obj)
        {
            return new ERPQuality_procedure_process(obj);
        }
    }
}