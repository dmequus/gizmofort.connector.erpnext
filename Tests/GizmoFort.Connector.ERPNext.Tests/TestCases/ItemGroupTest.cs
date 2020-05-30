using System;
using System.Collections.Generic;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_group;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    [TestClass()]
    public class ItemGroupTests
    {
        [TestMethod()]
        public void ItemGroupFull()
        {
            var client = TestUtils.CreateClient();

            string test_group_name = "Test_" + Guid.NewGuid().ToString();
            int test_is_group = 0;
            string test_description = "Group Description Test";

            ERPItem_group initial_data = new ERPItem_group();
            initial_data.item_group_name = test_group_name;
            initial_data.is_group = test_is_group;
            initial_data.description = test_description;

            #region Test - Insert

            client.InsertObject(initial_data.Object);

            #endregion

            #region Test - List

            FetchListOption listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Item_group , "item_group_name", OperatorFilter.Equals, test_group_name));
            listOption.IncludedFields.AddRange(new string[] { "item_group_name", "is_group", "description" });
            var documents = client.ListObjects(DocType.Item_group, listOption);

            Console.WriteLine (documents[0]);

            Assert.IsTrue(documents.Count == 1, "Item Group result is not one");
            Assert.IsTrue(documents[0].Data.item_group_name == test_group_name, "Group Name is invalid");
            Assert.IsTrue(documents[0].Data.is_group == test_is_group, "Is a Group is invalid");
            Assert.IsTrue(documents[0].Data.description == test_description, "Description is invalid");

            #endregion

            #region Test - Get

            var full_itemgroup_object = client.GetObject(DocType.Item_group, test_group_name);
            Assert.IsTrue(full_itemgroup_object.Data.item_group_name == test_group_name, "Group Name is invalid");
            Assert.IsTrue(full_itemgroup_object.Data.is_group == test_is_group, "Is Group is invalid");
            Assert.IsTrue(full_itemgroup_object.Data.description == test_description, "Description is invalid");

            #endregion

            #region Test - Wrapper

            ERPItem_group item_group = new ERPItem_group(full_itemgroup_object);
            Assert.IsTrue(item_group.item_group_name  == test_group_name, "address title is invalid");
            Assert.IsTrue(item_group.is_group == test_is_group, "Address Line 1 is invalid");
            Assert.IsTrue(item_group.description == test_description, "City is invalid");

            #endregion

            #region Test - Update

            ERPObject updated_obj = new ERPObject(DocType.Item_group );
            test_description = "Test 2 - Update the description";

            updated_obj.Data.description = test_description;
            // update first
            client.UpdateObject(DocType.Item_group, test_group_name, updated_obj);

            // get a new instance - after update
            var remote_updated_group = client.GetObject(DocType.Item_group, test_group_name);

            // test
            Assert.IsTrue(remote_updated_group.Data.description == updated_obj.Data.description, "Invalid Description - after update");
            Assert.IsTrue(remote_updated_group.Data.is_group == initial_data.is_group, "Invalid Is A Group - after update");
            Assert.IsTrue(remote_updated_group.Data.item_group_name == initial_data.item_group_name, "Invalid name - after update");

            #endregion

            #region Test - Delete

            client.DeleteObject(DocType.Item_group, test_group_name);

            FetchListOption option = new FetchListOption();
            option.Filters.Add(new ERPFilter(DocType.Item_group, nameof(ERPItem_group.item_group_name ), OperatorFilter.Equals,
                test_group_name));
            var after_delete_result = client.ListObjects(DocType.Item_group, option);
            Assert.IsTrue(after_delete_result.Count == 0, "Failed to delete Address");

            #endregion
        }
    }
}