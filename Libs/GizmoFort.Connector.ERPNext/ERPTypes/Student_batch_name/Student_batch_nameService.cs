using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_batch_name
{
    public class Student_batch_nameService : SubServiceBase<ERPStudent_batch_name>
    {
        public Student_batch_nameService(ERPNextClient client)
            : base(DocType.Student_batch_name, client) { }

        protected override ERPStudent_batch_name fromERPObject(ERPObject obj)
        {
            return new ERPStudent_batch_name(obj);
        }
    }
}