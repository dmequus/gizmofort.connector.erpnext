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

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
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

        private int _selling = 0;
        public int selling
        {
            get { return data._selling; }
            set { data._selling = value; }
        }

        private int _buying = 0;
        public int buying
        {
            get { return data._buying; }
            set { data._buying = value; }
        }

        private int _hr = 0;
        public int hr
        {
            get { return data._hr; }
            set { data._hr = value; }
        }


    }

    //Enums go here

}