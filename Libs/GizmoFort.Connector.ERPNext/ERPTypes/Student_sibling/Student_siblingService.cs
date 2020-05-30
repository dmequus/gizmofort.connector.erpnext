using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_sibling
{
    public class Student_siblingService : SubServiceBase<ERPStudent_sibling>
    {
        public Student_siblingService(ERPNextClient client)
            : base(DocType.Student_sibling, client) { }

        protected override ERPStudent_sibling fromERPObject(ERPObject obj)
        {
            return new ERPStudent_sibling(obj);
        }
    }
}