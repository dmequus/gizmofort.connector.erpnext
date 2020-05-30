using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_goal_objective
{
    public class ERPQuality_goal_objective : ERPNextObjectBase
    {
        public ERPQuality_goal_objective() : this(new ERPObject(DocType.Quality_goal_objective)) { }
        public ERPQuality_goal_objective(ERPObject obj) : base(obj) { }

        public static ERPQuality_goal_objective Create(string objective)

        {
            ERPQuality_goal_objective obj = new ERPQuality_goal_objective();
            obj.objective = objective;
            return obj;
        }

        public string objective
        {
            get { return data.objective; }
            set
            {
                data.objective = value;
                data.name = value;
            }

        }

        public string target
        {
            get { return data.target; }
            set { data.target = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }


    }

    //Enums go here

}