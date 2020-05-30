using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_category
{
    public class Student_categoryService : SubServiceBase<ERPStudent_category>
    {
        public Student_categoryService(ERPNextClient client)
            : base(DocType.Student_category, client) { }

        protected override ERPStudent_category fromERPObject(ERPObject obj)
        {
            return new ERPStudent_category(obj);
        }
    }
}