using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise_type
{
    public class ERPExercise_type : ERPNextObjectBase
    {
        public ERPExercise_type() : this(new ERPObject(DocType.Exercise_type)) { }
        public ERPExercise_type(ERPObject obj) : base(obj) { }

        public static ERPExercise_type Create(string exercisename)

        {
            ERPExercise_type obj = new ERPExercise_type();
            obj.exercise_name = exercisename;
            return obj;
        }

        public string exercise_name
        {
            get { return data.exercise_name; }
            set
            {
                data.exercise_name = value;
                data.name = value;
            }

        }

        public string difficulty_level
        {
            get { return data.difficulty_level; }
            set { data.difficulty_level = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string exercise_steps
        {
            get { return data.exercise_steps; }
            set { data.exercise_steps = value; }
        }

        public string exercise_video
        {
            get { return data.exercise_video; }
            set { data.exercise_video = value; }
        }

        public string steps_html
        {
            get { return data.steps_html; }
            set { data.steps_html = value; }
        }

        public string steps_table
        {
            get { return data.steps_table; }
            set { data.steps_table = value; }
        }

        public string body_parts
        {
            get { return data.body_parts; }
            set { data.body_parts = value; }
        }


    }

    //Enums go here

}