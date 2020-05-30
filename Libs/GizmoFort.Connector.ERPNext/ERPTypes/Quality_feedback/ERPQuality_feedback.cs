using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback
{
    public class ERPQuality_feedback : ERPNextObjectBase
    {
        public ERPQuality_feedback() : this(new ERPObject(DocType.Quality_feedback)) { }
        public ERPQuality_feedback(ERPObject obj) : base(obj) { }

        public static ERPQuality_feedback Create(string template, Documenttype documenttype, string documentname)

        {
            ERPQuality_feedback obj = new ERPQuality_feedback();
            obj.template = template;
            obj.document_type = documenttype;
            obj.document_name = documentname;
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

        public Documenttype document_type
        {
            get { return parseEnum<Documenttype>(data.document_type); }
            set { data.document_type = value.ToString(); }
        }

        public string document_name
        {
            get { return data.document_name; }
            set { data.document_name = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string parameters
        {
            get { return data.parameters; }
            set { data.parameters = value; }
        }


    }

    //Enums go here
    public enum Documenttype
    {
        [Description("User")]
        User,
        [Description("Customer")]
        Customer,
    }


}