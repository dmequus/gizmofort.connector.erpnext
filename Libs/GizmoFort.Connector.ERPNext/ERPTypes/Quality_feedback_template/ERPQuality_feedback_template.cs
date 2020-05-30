using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_template
{
    public class ERPQuality_feedback_template : ERPNextObjectBase
    {
        public ERPQuality_feedback_template() : this(new ERPObject(DocType.Quality_feedback_template)) { }
        public ERPQuality_feedback_template(ERPObject obj) : base(obj) { }

        public static ERPQuality_feedback_template Create(string template)

        {
            ERPQuality_feedback_template obj = new ERPQuality_feedback_template();
            obj.template = template;
            return obj;
        }

        public string template
        {
            get { return data.template; }
            set
            {
                data.template = value;
                data.name = value;
            }

        }

        public string parameters
        {
            get { return data.parameters; }
            set { data.parameters = value; }
        }


    }

    //Enums go here

}