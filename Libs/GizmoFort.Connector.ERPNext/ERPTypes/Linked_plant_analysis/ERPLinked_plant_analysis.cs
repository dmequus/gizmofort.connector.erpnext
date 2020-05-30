using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_plant_analysis
{
    public class ERPLinked_plant_analysis : ERPNextObjectBase
    {
        public ERPLinked_plant_analysis() : this(new ERPObject(DocType.Linked_plant_analysis)) { }
        public ERPLinked_plant_analysis(ERPObject obj) : base(obj) { }

        public static ERPLinked_plant_analysis Create(string plantanalysis)

        {
            ERPLinked_plant_analysis obj = new ERPLinked_plant_analysis();
            obj.plant_analysis = plantanalysis;
            return obj;
        }

        public string plant_analysis
        {
            get { return data.plant_analysis; }
            set
            {
                data.plant_analysis = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}