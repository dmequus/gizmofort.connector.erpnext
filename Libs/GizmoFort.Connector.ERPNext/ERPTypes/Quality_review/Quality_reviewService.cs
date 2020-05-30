using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_review
{
    public class Quality_reviewService : SubServiceBase<ERPQuality_review>
    {
        public Quality_reviewService(ERPNextClient client)
            : base(DocType.Quality_review, client) { }

        protected override ERPQuality_review fromERPObject(ERPObject obj)
        {
            return new ERPQuality_review(obj);
        }
    }
}