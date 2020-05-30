using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_applicant
{
    public class Job_applicantService : SubServiceBase<ERPJob_applicant>
    {
        public Job_applicantService(ERPNextClient client)
            : base(DocType.Job_applicant, client) { }

        protected override ERPJob_applicant fromERPObject(ERPObject obj)
        {
            return new ERPJob_applicant(obj);
        }
    }
}