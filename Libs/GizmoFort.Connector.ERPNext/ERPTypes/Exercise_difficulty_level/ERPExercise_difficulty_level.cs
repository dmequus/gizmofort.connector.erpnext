using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise_difficulty_level
{
    public class ERPExercise_difficulty_level : ERPNextObjectBase
    {
        public ERPExercise_difficulty_level() : this(new ERPObject(DocType.Exercise_difficulty_level)) { }
        public ERPExercise_difficulty_level(ERPObject obj) : base(obj) { }

        public static ERPExercise_difficulty_level Create(string difficultylevel)

        {
            ERPExercise_difficulty_level obj = new ERPExercise_difficulty_level();
            obj.difficulty_level = difficultylevel;
            return obj;
        }

        public string difficulty_level
        {
            get { return data.difficulty_level; }
            set
            {
                data.difficulty_level = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}