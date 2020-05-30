using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Task_type
{
    public class ERPTask_type : ERPNextObjectBase
    {
        public ERPTask_type() : this(new ERPObject(DocType.Task_type)) { }
        public ERPTask_type(ERPObject obj) : base(obj) { }

        public static ERPTask_type Create(double weight, string description)

        {
            ERPTask_type obj = new ERPTask_type();
            obj.weight = weight;
            obj.description = description;
            return obj;
        }

        private double _weight = 0.0;
        public double weight
        {
            get { return data._weight; }
            set { data._weight = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}