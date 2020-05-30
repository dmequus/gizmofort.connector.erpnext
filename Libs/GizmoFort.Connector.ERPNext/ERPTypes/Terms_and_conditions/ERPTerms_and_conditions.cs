using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Terms_and_conditions
{
    public class ERPTerms_and_conditions : ERPNextObjectBase
    {
        public ERPTerms_and_conditions() : this(new ERPObject(DocType.Terms_and_conditions)) { }
        public ERPTerms_and_conditions(ERPObject obj) : base(obj) { }

        public static ERPTerms_and_conditions Create(string title)

        {
            ERPTerms_and_conditions obj = new ERPTerms_and_conditions();
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

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        public string terms_and_conditions_help
        {
            get { return data.terms_and_conditions_help; }
            set { data.terms_and_conditions_help = value; }
        }

        public long selling
        {
            get { return data.selling; }
            set { data.selling = value; }
        }

        public long buying
        {
            get { return data.buying; }
            set { data.buying = value; }
        }

        public long hr
        {
            get { return data.hr; }
            set { data.hr = value; }
        }


    }

    //Enums go here

}