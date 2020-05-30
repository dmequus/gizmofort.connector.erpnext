using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_template_parameter
{
    public class ERPQuality_feedback_template_parameter : ERPNextObjectBase
    {
        public ERPQuality_feedback_template_parameter() : this(new ERPObject(DocType.Quality_feedback_template_parameter)) { }
        public ERPQuality_feedback_template_parameter(ERPObject obj) : base(obj) { }

        public static ERPQuality_feedback_template_parameter Create()

        {
            ERPQuality_feedback_template_parameter obj = new ERPQuality_feedback_template_parameter();
            return obj;
        }

        public string parameter
        {
            get { return data.parameter; }
            set
            {
                data.parameter = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}