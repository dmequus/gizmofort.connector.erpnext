using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Content_question
{
    public class ERPContent_question : ERPNextObjectBase
    {
        public ERPContent_question() : this(new ERPObject(DocType.Content_question)) { }
        public ERPContent_question(ERPObject obj) : base(obj) { }

        public static ERPContent_question Create(string questionlink)

        {
            ERPContent_question obj = new ERPContent_question();
            obj.question_link = questionlink;
            return obj;
        }

        public string question_link
        {
            get { return data.question_link; }
            set
            {
                data.question_link = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}