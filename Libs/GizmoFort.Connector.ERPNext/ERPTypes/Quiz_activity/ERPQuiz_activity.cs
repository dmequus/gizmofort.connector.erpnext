using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz_activity
{
    public class ERPQuiz_activity : ERPNextObjectBase
    {
        public ERPQuiz_activity() : this(new ERPObject(DocType.Quiz_activity)) { }
        public ERPQuiz_activity(ERPObject obj) : base(obj) { }

        public static ERPQuiz_activity Create(string enrollment, string student, string course, string quiz, Status status, string result, string activitydate, string score)

        {
            ERPQuiz_activity obj = new ERPQuiz_activity();
            obj.enrollment = enrollment;
            obj.student = student;
            obj.course = course;
            obj.quiz = quiz;
            obj.status = status;
            obj.result = result;
            obj.activity_date = activitydate;
            obj.score = score;
            return obj;
        }

        public string enrollment
        {
            get { return data.enrollment; }
            set
            {
                data.enrollment = value;
                data.name = value;
            }

        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string quiz
        {
            get { return data.quiz; }
            set { data.quiz = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string result
        {
            get { return data.result; }
            set { data.result = value; }
        }

        public string activity_date
        {
            get { return data.activity_date; }
            set { data.activity_date = value; }
        }

        public string score
        {
            get { return data.score; }
            set { data.score = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Pass")]
        Pass,
        [Description("Fail")]
        Fail,
    }


}