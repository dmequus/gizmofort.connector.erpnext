using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Article
{
    public class ArticleService : SubServiceBase<ERPArticle>
    {
        public ArticleService(ERPNextClient client)
            : base(DocType.Article, client) { }

        protected override ERPArticle fromERPObject(ERPObject obj)
        {
            return new ERPArticle(obj);
        }
    }
}