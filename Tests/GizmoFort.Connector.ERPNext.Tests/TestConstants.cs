﻿namespace GizmoFort.Connector.ERPNext.Tests
{
    public static class TestConstants
    {
        public const string TEST_DOMAIN = "https://your.erpnext.com";
        public const string TEST_USERNAME = "username";
        public const string TEST_PASSWORD = "password";

        public static ERPNextClient CreateClient()
        {
            return new ERPNextClient(TestConstants.TEST_DOMAIN, TestConstants.TEST_USERNAME, TestConstants.TEST_PASSWORD);
        }
    }
}