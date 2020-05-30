using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_skill
{
    public class ERPEmployee_skill : ERPNextObjectBase
    {
        public ERPEmployee_skill() : this(new ERPObject(DocType.Employee_skill)) { }
        public ERPEmployee_skill(ERPObject obj) : base(obj) { }

        public static ERPEmployee_skill Create(string skill, string proficiency, string evaluationdate)

        {
            ERPEmployee_skill obj = new ERPEmployee_skill();
            obj.skill = skill;
            obj.proficiency = proficiency;
            obj.evaluation_date = evaluationdate;
            return obj;
        }

        public string skill
        {
            get { return data.skill; }
            set
            {
                data.skill = value;
                data.name = value;
            }

        }

        public string proficiency
        {
            get { return data.proficiency; }
            set { data.proficiency = value; }
        }

        public string evaluation_date
        {
            get { return data.evaluation_date; }
            set { data.evaluation_date = value; }
        }


    }

    //Enums go here

}