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
    ///  Class for testing PluginsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PluginsApiTests : IDisposable
    {
        private PluginsApi instance;

        public PluginsApiTests()
        {
            instance = new PluginsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PluginsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PluginsApi
            //Assert.IsType<PluginsApi>(instance);
        }

        /// <summary>
        /// Test DeletePlugin
        /// </summary>
        [Fact]
        public void DeletePluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //var response = instance.DeletePlugin(pluginId);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetPluginDetails
        /// </summary>
        [Fact]
        public void GetPluginDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //var response = instance.GetPluginDetails(pluginId);
            //Assert.IsType<Plugin>(response);
        }

        /// <summary>
        /// Test GetPluginSettings
        /// </summary>
        [Fact]
        public void GetPluginSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //var response = instance.GetPluginSettings(pluginId);
            //Assert.IsType<GetPluginSettings200Response>(response);
        }

        /// <summary>
        /// Test GetPluginsSettings
        /// </summary>
        [Fact]
        public void GetPluginsSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPluginsSettings();
            //Assert.IsType<SettingsResponse>(response);
        }

        /// <summary>
        /// Test InstallPlugin
        /// </summary>
        [Fact]
        public void InstallPluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //var response = instance.InstallPlugin(file);
            //Assert.IsType<FileResponse>(response);
        }

        /// <summary>
        /// Test InstallPluginFromRegistry
        /// </summary>
        [Fact]
        public void InstallPluginFromRegistryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BodyUploadUrl bodyUploadUrl = null;
            //var response = instance.InstallPluginFromRegistry(bodyUploadUrl);
            //Assert.IsType<FileResponse>(response);
        }

        /// <summary>
        /// Test ListAvailablePlugins
        /// </summary>
        [Fact]
        public void ListAvailablePluginsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? query = null;
            //var response = instance.ListAvailablePlugins(query);
            //Assert.IsType<PluginsList>(response);
        }

        /// <summary>
        /// Test TogglePlugin
        /// </summary>
        [Fact]
        public void TogglePluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //var response = instance.TogglePlugin(pluginId);
            //Assert.IsType<ToggleResponse>(response);
        }

        /// <summary>
        /// Test UpsertPluginSettings
        /// </summary>
        [Fact]
        public void UpsertPluginSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //Object body = null;
            //var response = instance.UpsertPluginSettings(pluginId, body);
            //Assert.IsType<Setting>(response);
        }
    }
}
