using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_parameter
{
    public class ERPQuality_feedback_parameter : ERPNextObjectBase
    {
        public ERPQuality_feedback_parameter() : this(new ERPObject(DocType.Quality_feedback_parameter)) { }
        public ERPQuality_feedback_parameter(ERPObject obj) : base(obj) { }

        public static ERPQuality_feedback_parameter Create(Rating rating, string feedback)

        {
            ERPQuality_feedback_parameter obj = new ERPQuality_feedback_parameter();
            obj.rating = rating;
            obj.feedback = feedback;
            return obj;
        }

        public Rating rating
        {
            get { return parseEnum<Rating>(data.rating); }
            set { data.rating = value.ToString(); }
        }

        public string feedback
        {
            get { return data.feedback; }
            set { data.feedback = value; }
        }

        public string parameter
        {
            get { return data.parameter; }
            set { data.parameter = value; }
        }


    }

    //Enums go here
    public enum Rating
    {
        [Description("1")]
        num1,
        [Description("2")]
        num2,
        [Description("3")]
        num3,
        [Description("4")]
        num4,
        [Description("5")]
        num5,
    }


}