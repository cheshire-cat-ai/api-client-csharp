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
    ///  Class for testing SettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SettingsApiTests : IDisposable
    {
        private SettingsApi instance;

        public SettingsApiTests()
        {
            instance = new SettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsApi
            //Assert.IsType<SettingsApi>(instance);
        }

        /// <summary>
        /// Test CreateSetting
        /// </summary>
        [Fact]
        public void CreateSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingBody settingBody = null;
            //var response = instance.CreateSetting(settingBody);
            //Assert.IsType<Setting>(response);
        }

        /// <summary>
        /// Test DeleteSetting
        /// </summary>
        [Fact]
        public void DeleteSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string settingId = null;
            //var response = instance.DeleteSetting(settingId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetSetting
        /// </summary>
        [Fact]
        public void GetSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string settingId = null;
            //var response = instance.GetSetting(settingId);
            //Assert.IsType<Setting>(response);
        }

        /// <summary>
        /// Test GetSettings
        /// </summary>
        [Fact]
        public void GetSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? search = null;
            //var response = instance.GetSettings(search);
            //Assert.IsType<SettingsResponse>(response);
        }

        /// <summary>
        /// Test UpdateSetting
        /// </summary>
        [Fact]
        public void UpdateSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string settingId = null;
            //SettingBody settingBody = null;
            //var response = instance.UpdateSetting(settingId, settingBody);
            //Assert.IsType<Setting>(response);
        }
    }
}
