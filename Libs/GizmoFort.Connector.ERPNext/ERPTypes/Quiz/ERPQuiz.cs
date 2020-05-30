using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz
{
    public class ERPQuiz : ERPNextObjectBase
    {
        public ERPQuiz() : this(new ERPObject(DocType.Quiz)) { }
        public ERPQuiz(ERPObject obj) : base(obj) { }

        public static ERPQuiz Create(string title, string question, double passingscore, int maxattempts)

        {
            ERPQuiz obj = new ERPQuiz();
            obj.title = title;
            obj.question = question;
            obj.passing_score = passingscore;
            obj.max_attempts = maxattempts;
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

        public string question
        {
            get { return data.question; }
            set { data.question = value; }
        }

        private double _passing_score = 0.0;
        public double passing_score
        {
            get { return data._passing_score; }
            set { data._passing_score = value; }
        }

        private int _max_attempts = 0;
        public int max_attempts
        {
            get { return data._max_attempts; }
            set { data._max_attempts = value; }
        }

        public Gradingbasis grading_basis
        {
            get { return parseEnum<Gradingbasis>(data.grading_basis); }
            set { data.grading_basis = value.ToString(); }
        }


    }

    //Enums go here
    public enum Gradingbasis
    {
        [Description("Latest Highest Score")]
        LatestHighestScore,
        [Description("Latest Attempt")]
        LatestAttempt,
    }


}