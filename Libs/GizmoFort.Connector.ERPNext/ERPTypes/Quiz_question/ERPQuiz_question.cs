using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz_question
{
    public class ERPQuiz_question : ERPNextObjectBase
    {
        public ERPQuiz_question() : this(new ERPObject(DocType.Quiz_question)) { }
        public ERPQuiz_question(ERPObject obj) : base(obj) { }

        public static ERPQuiz_question Create(string questionlink)

        {
            ERPQuiz_question obj = new ERPQuiz_question();
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

        public string question
        {
            get { return data.question; }
            set { data.question = value; }
        }


    }

    //Enums go here

}