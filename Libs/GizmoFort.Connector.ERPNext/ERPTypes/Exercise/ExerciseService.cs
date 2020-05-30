using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise
{
    public class ExerciseService : SubServiceBase<ERPExercise>
    {
        public ExerciseService(ERPNextClient client)
            : base(DocType.Exercise, client) { }

        protected override ERPExercise fromERPObject(ERPObject obj)
        {
            return new ERPExercise(obj);
        }
    }
}