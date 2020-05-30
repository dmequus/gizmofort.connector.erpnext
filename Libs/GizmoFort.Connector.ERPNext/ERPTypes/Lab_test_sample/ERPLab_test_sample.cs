using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_sample
{
    public class ERPLab_test_sample : ERPNextObjectBase
    {
        public ERPLab_test_sample() : this(new ERPObject(DocType.Lab_test_sample)) { }
        public ERPLab_test_sample(ERPObject obj) : base(obj) { }

        public static ERPLab_test_sample Create(string sample)

        {
            ERPLab_test_sample obj = new ERPLab_test_sample();
            obj.sample = sample;
            return obj;
        }

        public string sample
        {
            get { return data.sample; }
            set
            {
                data.sample = value;
                data.name = value;
            }

        }

        public string sample_uom
        {
            get { return data.sample_uom; }
            set { data.sample_uom = value; }
        }


    }

    //Enums go here

}