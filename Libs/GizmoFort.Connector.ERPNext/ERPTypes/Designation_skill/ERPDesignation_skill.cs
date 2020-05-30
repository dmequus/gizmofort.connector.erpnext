using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Designation_skill
{
    public class ERPDesignation_skill : ERPNextObjectBase
    {
        public ERPDesignation_skill() : this(new ERPObject(DocType.Designation_skill)) { }
        public ERPDesignation_skill(ERPObject obj) : base(obj) { }

        public static ERPDesignation_skill Create(string skill)

        {
            ERPDesignation_skill obj = new ERPDesignation_skill();
            obj.skill = skill;
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


    }

    //Enums go here

}