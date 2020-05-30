using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Chapter_member
{
    public class Chapter_memberService : SubServiceBase<ERPChapter_member>
    {
        public Chapter_memberService(ERPNextClient client)
            : base(DocType.Chapter_member, client) { }

        protected override ERPChapter_member fromERPObject(ERPObject obj)
        {
            return new ERPChapter_member(obj);
        }
    }
}