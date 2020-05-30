using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_plan_detail
{
    public class ERPTherapy_plan_detail : ERPNextObjectBase
    {
        public ERPTherapy_plan_detail() : this(new ERPObject(DocType.Therapy_plan_detail)) { }
        public ERPTherapy_plan_detail(ERPObject obj) : base(obj) { }

        public static ERPTherapy_plan_detail Create(string therapytype)

        {
            ERPTherapy_plan_detail obj = new ERPTherapy_plan_detail();
            obj.therapy_type = therapytype;
            return obj;
        }

        public string therapy_type
        {
            get { return data.therapy_type; }
            set
            {
                data.therapy_type = value;
                data.name = value;
            }

        }

        private int _no_of_sessions = 0;
        public int no_of_sessions
        {
            get { return data._no_of_sessions; }
            set { data._no_of_sessions = value; }
        }

        private int _sessions_completed = 0;
        public int sessions_completed
        {
            get { return data._sessions_completed; }
            set { data._sessions_completed = value; }
        }


    }

    //Enums go here

}