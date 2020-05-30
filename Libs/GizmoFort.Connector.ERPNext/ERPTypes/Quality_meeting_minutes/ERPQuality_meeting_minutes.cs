using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting_minutes
{
    public class ERPQuality_meeting_minutes : ERPNextObjectBase
    {
        public ERPQuality_meeting_minutes() : this(new ERPObject(DocType.Quality_meeting_minutes)) { }
        public ERPQuality_meeting_minutes(ERPObject obj) : base(obj) { }

        public static ERPQuality_meeting_minutes Create(Documenttype documenttype)

        {
            ERPQuality_meeting_minutes obj = new ERPQuality_meeting_minutes();
            obj.document_type = documenttype;
            return obj;
        }

        public Documenttype document_type
        {
            get { return parseEnum<Documenttype>(data.document_type); }
            set { data.document_type = value.ToString(); }
        }

        public string minute
        {
            get { return data.minute; }
            set { data.minute = value; }
        }

        public string document_name
        {
            get { return data.document_name; }
            set { data.document_name = value; }
        }


    }

    //Enums go here
    public enum Documenttype
    {
        [Description("Quality Review")]
        QualityReview,
        [Description("Quality Action")]
        QualityAction,
        [Description("Quality Feedback")]
        QualityFeedback,
    }


}