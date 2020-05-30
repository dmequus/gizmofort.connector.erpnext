using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Chapter
{
    public class ChapterService : SubServiceBase<ERPChapter>
    {
        public ChapterService(ERPNextClient client)
            : base(DocType.Chapter, client) { }

        protected override ERPChapter fromERPObject(ERPObject obj)
        {
            return new ERPChapter(obj);
        }
    }
}