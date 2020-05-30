using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_finance_book
{
    public class ERPAsset_finance_book : ERPNextObjectBase
    {
        public ERPAsset_finance_book() : this(new ERPObject(DocType.Asset_finance_book)) { }
        public ERPAsset_finance_book(ERPObject obj) : base(obj) { }

        public static ERPAsset_finance_book Create(string financebook, Depreciationmethod depreciationmethod, int totalnumberofdepreciations, int frequencyofdepreciation, string depreciationstartdate, double expectedvalueafterusefullife, double valueafterdepreciation, double rateofdepreciation)

        {
            ERPAsset_finance_book obj = new ERPAsset_finance_book();
            obj.finance_book = financebook;
            obj.depreciation_method = depreciationmethod;
            obj.total_number_of_depreciations = totalnumberofdepreciations;
            obj.frequency_of_depreciation = frequencyofdepreciation;
            obj.depreciation_start_date = depreciationstartdate;
            obj.expected_value_after_useful_life = expectedvalueafterusefullife;
            obj.value_after_depreciation = valueafterdepreciation;
            obj.rate_of_depreciation = rateofdepreciation;
            return obj;
        }

        public string finance_book
        {
            get { return data.finance_book; }
            set
            {
                data.finance_book = value;
                data.name = value;
            }

        }

        public Depreciationmethod depreciation_method
        {
            get { return parseEnum<Depreciationmethod>(data.depreciation_method); }
            set { data.depreciation_method = value.ToString(); }
        }

        public int total_number_of_depreciations
        {
            get { return data.total_number_of_depreciations; }
            set { data.total_number_of_depreciations = value; }
        }

        public int frequency_of_depreciation
        {
            get { return data.frequency_of_depreciation; }
            set { data.frequency_of_depreciation = value; }
        }

        public string depreciation_start_date
        {
            get { return data.depreciation_start_date; }
            set { data.depreciation_start_date = value; }
        }

        public double expected_value_after_useful_life
        {
            get { return data.expected_value_after_useful_life; }
            set { data.expected_value_after_useful_life = value; }
        }

        public double value_after_depreciation
        {
            get { return data.value_after_depreciation; }
            set { data.value_after_depreciation = value; }
        }

        public double rate_of_depreciation
        {
            get { return data.rate_of_depreciation; }
            set { data.rate_of_depreciation = value; }
        }


    }

    //Enums go here
    public enum Depreciationmethod
    {
        [Description("Straight Line")]
        StraightLine,
        [Description("Double Declining Balance")]
        DoubleDecliningBalance,
        [Description("Written Down Value")]
        WrittenDownValue,
        [Description("Manual")]
        Manual,
    }


}