using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_applicant_source
{
    public class Job_applicant_sourceService : SubServiceBase<ERPJob_applicant_source>
    {
        public Job_applicant_sourceService(ERPNextClient client)
            : base(DocType.Job_applicant_source, client) { }

        protected override ERPJob_applicant_source fromERPObject(ERPObject obj)
        {
            return new ERPJob_applicant_source(obj);
        }
    }
}