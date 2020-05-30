using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_soil_analysis
{
    public class ERPLinked_soil_analysis : ERPNextObjectBase
    {
        public ERPLinked_soil_analysis() : this(new ERPObject(DocType.Linked_soil_analysis)) { }
        public ERPLinked_soil_analysis(ERPObject obj) : base(obj) { }

        public static ERPLinked_soil_analysis Create(string soilanalysis)

        {
            ERPLinked_soil_analysis obj = new ERPLinked_soil_analysis();
            obj.soil_analysis = soilanalysis;
            return obj;
        }

        public string soil_analysis
        {
            get { return data.soil_analysis; }
            set
            {
                data.soil_analysis = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}