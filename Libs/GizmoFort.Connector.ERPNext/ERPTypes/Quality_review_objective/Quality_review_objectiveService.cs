using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_review_objective
{
    public class Quality_review_objectiveService : SubServiceBase<ERPQuality_review_objective>
    {
        public Quality_review_objectiveService(ERPNextClient client)
            : base(DocType.Quality_review_objective, client) { }

        protected override ERPQuality_review_objective fromERPObject(ERPObject obj)
        {
            return new ERPQuality_review_objective(obj);
        }
    }
}