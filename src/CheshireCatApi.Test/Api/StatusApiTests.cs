/*
 * 😸 Cheshire-Cat API
 *
 * Customizable AI architecture
 *
 * The version of the OpenAPI document: 0.0.5
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using CheshireCatApi.Client;
using CheshireCatApi.Api;
// uncomment below to import models
//using CheshireCatApi.Model;

namespace CheshireCatApi.Test.Api
{
    /// <summary>
    ///  Class for testing StatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StatusApiTests : IDisposable
    {
        private StatusApi instance;

        public StatusApiTests()
        {
            instance = new StatusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StatusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StatusApi
            //Assert.IsType<StatusApi>(instance);
        }

        /// <summary>
        /// Test Home
        /// </summary>
        [Fact]
        public void HomeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Home();
            //Assert.IsType<Status>(response);
        }
    }
}
