using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_action_resolution
{
    public class ERPQuality_action_resolution : ERPNextObjectBase
    {
        public ERPQuality_action_resolution() : this(new ERPObject(DocType.Quality_action_resolution)) { }
        public ERPQuality_action_resolution(ERPObject obj) : base(obj) { }

        public static ERPQuality_action_resolution Create()

        {
            ERPQuality_action_resolution obj = new ERPQuality_action_resolution();
            return obj;
        }

        public string problem
        {
            get { return data.problem; }
            set
            {
                data.problem = value;
                data.name = value;
            }

        }

        public string resolution
        {
            get { return data.resolution; }
            set { data.resolution = value; }
        }


    }

    //Enums go here

}