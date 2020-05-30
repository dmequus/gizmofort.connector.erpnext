using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Question
{
    public class ERPQuestion : ERPNextObjectBase
    {
        public ERPQuestion() : this(new ERPObject(DocType.Question)) { }
        public ERPQuestion(ERPObject obj) : base(obj) { }

        public static ERPQuestion Create(string question, string options)

        {
            ERPQuestion obj = new ERPQuestion();
            obj.question = question;
            obj.options = options;
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

        public string options
        {
            get { return data.options; }
            set { data.options = value; }
        }

        public Questiontype question_type
        {
            get { return parseEnum<Questiontype>(data.question_type); }
            set { data.question_type = value.ToString(); }
        }


    }

    //Enums go here
    public enum Questiontype
    {
        [Description("Single Correct Answer")]
        SingleCorrectAnswer,
        [Description("Multiple Correct Answer")]
        MultipleCorrectAnswer,
    }


}