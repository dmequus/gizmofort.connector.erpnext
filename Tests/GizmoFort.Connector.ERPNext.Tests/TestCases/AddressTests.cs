using System;
using System.Collections.Generic;
using GizmoFort.Connector.ERPNext.ERPTypes.Address;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    [TestClass()]
    public class AddressTests
    {
        [TestMethod()]
        public void AddressFull()
        {
            var client = TestUtils.CreateClient();

            string test_address_title = "Test_" + Guid.NewGuid().ToString();
            string test_address_line_1 = "Somewhere Road";
            string test_city = "Somewhere Town";
            string test_country = "United States";
            string test_taxcat = "Ohio Tax";

            ERPAddress initial_data = new ERPAddress();
            initial_data.address_title = test_address_title;
            initial_data.address_line1 = test_address_line_1;
            initial_data.city  = test_city;
            initial_data.country = test_country;
            initial_data.tax_category = test_taxcat;

            #region Test - Insert

            client.InsertObject(initial_data.Object);

            #endregion

            #region Test - List

            FetchListOption listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Address, "address_title", OperatorFilter.Equals, test_address_title));
            listOption.IncludedFields.AddRange(new string[] { "address_title", "address_line1", "city", "country" });
            var documents = client.ListObjects(DocType.Address, listOption);

            Assert.IsTrue(documents.Count == 1, "Address result is not one");
            Assert.IsTrue(documents[0].Data.address_title == test_address_title, "Address title is invalid");
            Assert.IsTrue(documents[0].Data.address_line1 == test_address_line_1, "Address Line 1 is invalid");
            Assert.IsTrue(documents[0].Data.city == test_city, "City is invalid");
            Assert.IsTrue(documents[0].Data.country == test_country, "Country is invalid");

            #endregion

            #region Test - Get

            //Address will be created by concatenating address type to address title - quick hack here to test
            string test_address_name = test_address_title + "-Billing";

            var full_address_object = client.GetObject(DocType.Address, test_address_name);
            Assert.IsTrue(full_address_object.Data.address_title == test_address_title, "Address title is invalid");
            Assert.IsTrue(full_address_object.Data.address_line1 == test_address_line_1, "Address Line 1 is invalid");
            Assert.IsTrue(full_address_object.Data.city == test_city, "City is invalid");
            Assert.IsTrue(full_address_object.Data.country == test_country, "Country is invalid");

            #endregion

            #region Test - Wrapper

            ERPAddress address = new ERPAddress(full_address_object);
            Assert.IsTrue(address.address_title == test_address_title, "address title is invalid");
            Assert.IsTrue(address.address_line1  == test_address_line_1, "Address Line 1 is invalid");
            Assert.IsTrue(address.city == test_city, "City is invalid");
            Assert.IsTrue(address.country == test_country, "Country is invalid");

            #endregion

            #region Test - Update

            ERPObject updated_obj = new ERPObject(DocType.Address);
            updated_obj.Data.address_line1 = "New Address Detail Line";

            // update first
            client.UpdateObject(DocType.Address, test_address_name, updated_obj);

            // get a new instance - after update
            var remote_updated_address = client.GetObject(DocType.Address, test_address_name);

            // test
            Assert.IsTrue(remote_updated_address.Data.address_line1 == updated_obj.Data.address_line1, "Address Line 1 is invalid - after update");
            Assert.IsTrue(remote_updated_address.Data.city == initial_data.city, "Address city is invalid - after update");
            Assert.IsTrue(remote_updated_address.Data.country == initial_data.country, "Address country is invalid - after update");

            #endregion

            #region Test - Delete

            client.DeleteObject(DocType.Address, test_address_name);

            FetchListOption option = new FetchListOption();
            option.Filters.Add(new ERPFilter(DocType.Address, nameof(ERPAddress.address_title), OperatorFilter.Equals,
                test_address_title));
            var after_delete_result = client.ListObjects(DocType.Address, option);
            Assert.IsTrue(after_delete_result.Count == 0, "Failed to delete Address");

            #endregion
        }
    }
}