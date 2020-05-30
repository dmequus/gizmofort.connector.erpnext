using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Grading_scale_interval
{
    public class Grading_scale_intervalService : SubServiceBase<ERPGrading_scale_interval>
    {
        public Grading_scale_intervalService(ERPNextClient client)
            : base(DocType.Grading_scale_interval, client) { }

        protected override ERPGrading_scale_interval fromERPObject(ERPObject obj)
        {
            return new ERPGrading_scale_interval(obj);
        }
    }
}