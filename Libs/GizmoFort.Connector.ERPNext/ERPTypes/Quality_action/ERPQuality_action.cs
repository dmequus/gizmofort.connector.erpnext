using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_action
{
    public class ERPQuality_action : ERPNextObjectBase
    {
        public ERPQuality_action() : this(new ERPObject(DocType.Quality_action)) { }
        public ERPQuality_action(ERPObject obj) : base(obj) { }

        public static ERPQuality_action Create(Documenttype documenttype, Correctivepreventive correctivepreventive)

        {
            ERPQuality_action obj = new ERPQuality_action();
            obj.document_type = documenttype;
            obj.corrective_preventive = correctivepreventive;
            return obj;
        }

        public Documenttype document_type
        {
            get { return parseEnum<Documenttype>(data.document_type); }
            set { data.document_type = value.ToString(); }
        }

        public Correctivepreventive corrective_preventive
        {
            get { return parseEnum<Correctivepreventive>(data.corrective_preventive); }
            set { data.corrective_preventive = value.ToString(); }
        }

        public string goal
        {
            get { return data.goal; }
            set { data.goal = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string procedure
        {
            get { return data.procedure; }
            set { data.procedure = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string document_name
        {
            get { return data.document_name; }
            set { data.document_name = value; }
        }

        public string resolutions
        {
            get { return data.resolutions; }
            set { data.resolutions = value; }
        }


    }

    //Enums go here
    public enum Documenttype
    {
        [Description("Quality Review")]
        QualityReview,
        [Description("Quality Feedback")]
        QualityFeedback,
    }

    public enum Correctivepreventive
    {
        [Description("Corrective")]
        Corrective,
        [Description("Preventive")]
        Preventive,
    }

    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Closed")]
        Closed,
    }


}