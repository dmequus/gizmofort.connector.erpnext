using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Skill
{
    public class ERPSkill : ERPNextObjectBase
    {
        public ERPSkill() : this(new ERPObject(DocType.Skill)) { }
        public ERPSkill(ERPObject obj) : base(obj) { }

        public static ERPSkill Create(string skillname)

        {
            ERPSkill obj = new ERPSkill();
            obj.skill_name = skillname;
            return obj;
        }

        public string skill_name
        {
            get { return data.skill_name; }
            set
            {
                data.skill_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}