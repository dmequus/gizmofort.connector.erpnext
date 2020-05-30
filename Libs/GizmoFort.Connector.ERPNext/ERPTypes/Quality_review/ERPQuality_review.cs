using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_review
{
    public class ERPQuality_review : ERPNextObjectBase
    {
        public ERPQuality_review() : this(new ERPObject(DocType.Quality_review)) { }
        public ERPQuality_review(ERPObject obj) : base(obj) { }

        public static ERPQuality_review Create(string goal)

        {
            ERPQuality_review obj = new ERPQuality_review();
            obj.goal = goal;
            return obj;
        }

        public string goal
        {
            get { return data.goal; }
            set
            {
                data.goal = value;
                data.name = value;
            }

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

        public string additional_information
        {
            get { return data.additional_information; }
            set { data.additional_information = value; }
        }

        public string reviews
        {
            get { return data.reviews; }
            set { data.reviews = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Closed")]
        Closed,
    }


}