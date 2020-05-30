using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Plant_analysis
{
    public class ERPPlant_analysis : ERPNextObjectBase
    {
        public ERPPlant_analysis() : this(new ERPObject(DocType.Plant_analysis)) { }
        public ERPPlant_analysis(ERPObject obj) : base(obj) { }

        public static ERPPlant_analysis Create(string crop, string location, string collectiondatetime, string laboratorytestingdatetime, string resultdatetime, string plantanalysiscriteria)

        {
            ERPPlant_analysis obj = new ERPPlant_analysis();
            obj.crop = crop;
            obj.location = location;
            obj.collection_datetime = collectiondatetime;
            obj.laboratory_testing_datetime = laboratorytestingdatetime;
            obj.result_datetime = resultdatetime;
            obj.plant_analysis_criteria = plantanalysiscriteria;
            return obj;
        }

        public string crop
        {
            get { return data.crop; }
            set
            {
                data.crop = value;
                data.name = value;
            }

        }

        public string location
        {
            get { return data.location; }
            set { data.location = value; }
        }

        public string collection_datetime
        {
            get { return data.collection_datetime; }
            set { data.collection_datetime = value; }
        }

        public string laboratory_testing_datetime
        {
            get { return data.laboratory_testing_datetime; }
            set { data.laboratory_testing_datetime = value; }
        }

        public string result_datetime
        {
            get { return data.result_datetime; }
            set { data.result_datetime = value; }
        }

        public string plant_analysis_criteria
        {
            get { return data.plant_analysis_criteria; }
            set { data.plant_analysis_criteria = value; }
        }


    }

    //Enums go here

}