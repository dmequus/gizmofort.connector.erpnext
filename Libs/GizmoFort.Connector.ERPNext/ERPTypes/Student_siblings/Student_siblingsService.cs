using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_siblings
{
    public class Student_siblingsService : SubServiceBase<ERPStudent_siblings>
    {
        public Student_siblingsService(ERPNextClient client)
            : base(DocType.Student_siblings, client) { }

        protected override ERPStudent_siblings fromERPObject(ERPObject obj)
        {
            return new ERPStudent_siblings(obj);
        }
    }
}