using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise_difficulty_level
{
    public class Exercise_difficulty_levelService : SubServiceBase<ERPExercise_difficulty_level>
    {
        public Exercise_difficulty_levelService(ERPNextClient client)
            : base(DocType.Exercise_difficulty_level, client) { }

        protected override ERPExercise_difficulty_level fromERPObject(ERPObject obj)
        {
            return new ERPExercise_difficulty_level(obj);
        }
    }
}