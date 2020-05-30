using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_log
{
    public class Student_logService : SubServiceBase<ERPStudent_log>
    {
        public Student_logService(ERPNextClient client)
            : base(DocType.Student_log, client) { }

        protected override ERPStudent_log fromERPObject(ERPObject obj)
        {
            return new ERPStudent_log(obj);
        }
    }
}