using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_training
{
    public class ERPEmployee_training : ERPNextObjectBase
    {
        public ERPEmployee_training() : this(new ERPObject(DocType.Employee_training)) { }
        public ERPEmployee_training(ERPObject obj) : base(obj) { }

        public static ERPEmployee_training Create(string training, string trainingdate)

        {
            ERPEmployee_training obj = new ERPEmployee_training();
            obj.training = training;
            obj.training_date = trainingdate;
            return obj;
        }

        public string training
        {
            get { return data.training; }
            set
            {
                data.training = value;
                data.name = value;
            }

        }

        public string training_date
        {
            get { return data.training_date; }
            set { data.training_date = value; }
        }


    }

    //Enums go here

}