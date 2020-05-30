using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Upload_attendance
{
    public class Upload_attendanceService : SubServiceBase<ERPUpload_attendance>
    {
        public Upload_attendanceService(ERPNextClient client)
            : base(DocType.Upload_attendance, client) { }

        protected override ERPUpload_attendance fromERPObject(ERPObject obj)
        {
            return new ERPUpload_attendance(obj);
        }
    }
}