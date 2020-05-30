using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_language
{
    public class Student_languageService : SubServiceBase<ERPStudent_language>
    {
        public Student_languageService(ERPNextClient client)
            : base(DocType.Student_language, client) { }

        protected override ERPStudent_language fromERPObject(ERPObject obj)
        {
            return new ERPStudent_language(obj);
        }
    }
}