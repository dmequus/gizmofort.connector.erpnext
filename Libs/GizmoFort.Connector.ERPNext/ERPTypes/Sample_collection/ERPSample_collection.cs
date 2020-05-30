using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sample_collection
{
    public class ERPSample_collection : ERPNextObjectBase
    {
        public ERPSample_collection() : this(new ERPObject(DocType.Sample_collection)) { }
        public ERPSample_collection(ERPObject obj) : base(obj) { }

        public static ERPSample_collection Create(string patient, string namingseries, string sample)

        {
            ERPSample_collection obj = new ERPSample_collection();
            obj.patient = patient;
            obj.naming_series = namingseries;
            obj.sample = sample;
            return obj;
        }

        public string patient
        {
            get { return data.patient; }
            set
            {
                data.patient = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string sample
        {
            get { return data.sample; }
            set { data.sample = value; }
        }

        public string inpatient_record
        {
            get { return data.inpatient_record; }
            set { data.inpatient_record = value; }
        }

        public long invoiced
        {
            get { return data.invoiced; }
            set { data.invoiced = value; }
        }

        public string patient_age
        {
            get { return data.patient_age; }
            set { data.patient_age = value; }
        }

        public string patient_sex
        {
            get { return data.patient_sex; }
            set { data.patient_sex = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string sample_uom
        {
            get { return data.sample_uom; }
            set { data.sample_uom = value; }
        }

        public string collected_by
        {
            get { return data.collected_by; }
            set { data.collected_by = value; }
        }

        public string collected_time
        {
            get { return data.collected_time; }
            set { data.collected_time = value; }
        }

        public int num_print
        {
            get { return data.num_print; }
            set { data.num_print = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public double sample_qty
        {
            get { return data.sample_qty; }
            set { data.sample_qty = value; }
        }

        public string sample_details
        {
            get { return data.sample_details; }
            set { data.sample_details = value; }
        }


    }

    //Enums go here

}