using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Exercise_type_step
{
    public class ERPExercise_type_step : ERPNextObjectBase
    {
        public ERPExercise_type_step() : this(new ERPObject(DocType.Exercise_type_step)) { }
        public ERPExercise_type_step(ERPObject obj) : base(obj) { }

        public static ERPExercise_type_step Create(string title)

        {
            ERPExercise_type_step obj = new ERPExercise_type_step();
            obj.title = title;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}