using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Grading_scale
{
    public class Grading_scaleService : SubServiceBase<ERPGrading_scale>
    {
        public Grading_scaleService(ERPNextClient client)
            : base(DocType.Grading_scale, client) { }

        protected override ERPGrading_scale fromERPObject(ERPObject obj)
        {
            return new ERPGrading_scale(obj);
        }
    }
}