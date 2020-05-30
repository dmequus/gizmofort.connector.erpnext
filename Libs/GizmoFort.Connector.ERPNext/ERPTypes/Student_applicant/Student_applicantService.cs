using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_applicant
{
    public class Student_applicantService : SubServiceBase<ERPStudent_applicant>
    {
        public Student_applicantService(ERPNextClient client)
            : base(DocType.Student_applicant, client) { }

        protected override ERPStudent_applicant fromERPObject(ERPObject obj)
        {
            return new ERPStudent_applicant(obj);
        }
    }
}