using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise
{
    public class ERPExercise : ERPNextObjectBase
    {
        public ERPExercise() : this(new ERPObject(DocType.Exercise)) { }
        public ERPExercise(ERPObject obj) : base(obj) { }

        public static ERPExercise Create(string exercisetype)

        {
            ERPExercise obj = new ERPExercise();
            obj.exercise_type = exercisetype;
            return obj;
        }

        public string exercise_type
        {
            get { return data.exercise_type; }
            set
            {
                data.exercise_type = value;
                data.name = value;
            }

        }

        public string difficulty_level
        {
            get { return data.difficulty_level; }
            set { data.difficulty_level = value; }
        }

        private int _counts_target = 0;
        public int counts_target
        {
            get { return data._counts_target; }
            set { data._counts_target = value; }
        }

        private int _counts_completed = 0;
        public int counts_completed
        {
            get { return data._counts_completed; }
            set { data._counts_completed = value; }
        }

        public Assistancelevel assistance_level
        {
            get { return parseEnum<Assistancelevel>(data.assistance_level); }
            set { data.assistance_level = value.ToString(); }
        }


    }

    //Enums go here
    public enum Assistancelevel
    {
        [Description("Passive")]
        Passive,
        [Description("Active Assist")]
        ActiveAssist,
        [Description("Active")]
        Active,
    }


}