using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_review_objective
{
    public class ERPQuality_review_objective : ERPNextObjectBase
    {
        public ERPQuality_review_objective() : this(new ERPObject(DocType.Quality_review_objective)) { }
        public ERPQuality_review_objective(ERPObject obj) : base(obj) { }

        public static ERPQuality_review_objective Create()

        {
            ERPQuality_review_objective obj = new ERPQuality_review_objective();
            return obj;
        }

        public string objective
        {
            get { return data.objective; }
            set
            {
                data.objective = value;
                data.name = value;
            }

        }

        public string target
        {
            get { return data.target; }
            set { data.target = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string review
        {
            get { return data.review; }
            set { data.review = value; }
        }


    }

    //Enums go here

}