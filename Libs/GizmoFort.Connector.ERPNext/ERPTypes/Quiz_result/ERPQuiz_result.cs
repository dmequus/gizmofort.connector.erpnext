using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz_result
{
    public class ERPQuiz_result : ERPNextObjectBase
    {
        public ERPQuiz_result() : this(new ERPObject(DocType.Quiz_result)) { }
        public ERPQuiz_result(ERPObject obj) : base(obj) { }

        public static ERPQuiz_result Create(string question, Quizresult quizresult)

        {
            ERPQuiz_result obj = new ERPQuiz_result();
            obj.question = question;
            obj.quiz_result = quizresult;
            return obj;
        }

        public string question
        {
            get { return data.question; }
            set
            {
                data.question = value;
                data.name = value;
            }

        }

        public Quizresult quiz_result
        {
            get { return parseEnum<Quizresult>(data.quiz_result); }
            set { data.quiz_result = value.ToString(); }
        }

        public string selected_option
        {
            get { return data.selected_option; }
            set { data.selected_option = value; }
        }


    }

    //Enums go here
    public enum Quizresult
    {
        [Description("Correct")]
        Correct,
        [Description("Wrong")]
        Wrong,
    }


}