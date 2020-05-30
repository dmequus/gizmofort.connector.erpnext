using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise_type_step
{
    public class Exercise_type_stepService : SubServiceBase<ERPExercise_type_step>
    {
        public Exercise_type_stepService(ERPNextClient client)
            : base(DocType.Exercise_type_step, client) { }

        protected override ERPExercise_type_step fromERPObject(ERPObject obj)
        {
            return new ERPExercise_type_step(obj);
        }
    }
}