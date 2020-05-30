using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise_type
{
    public class Exercise_typeService : SubServiceBase<ERPExercise_type>
    {
        public Exercise_typeService(ERPNextClient client)
            : base(DocType.Exercise_type, client) { }

        protected override ERPExercise_type fromERPObject(ERPObject obj)
        {
            return new ERPExercise_type(obj);
        }
    }
}