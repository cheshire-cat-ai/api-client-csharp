# CheshireCatApi.Api.PluginsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePlugin**](PluginsApi.md#deleteplugin) | **DELETE** /plugins/{plugin_id} | Delete Plugin |
| [**GetPluginDetails**](PluginsApi.md#getplugindetails) | **GET** /plugins/{plugin_id} | Get Plugin Details |
| [**GetPluginSettings**](PluginsApi.md#getpluginsettings) | **GET** /plugins/settings/{plugin_id} | Get Plugin Settings |
| [**GetPluginsSettings**](PluginsApi.md#getpluginssettings) | **GET** /plugins/settings | Get Plugins Settings |
| [**InstallPlugin**](PluginsApi.md#installplugin) | **POST** /plugins/upload | Install Plugin |
| [**InstallPluginFromRegistry**](PluginsApi.md#installpluginfromregistry) | **POST** /plugins/upload/registry | Install Plugin From Registry |
| [**ListAvailablePlugins**](PluginsApi.md#listavailableplugins) | **GET** /plugins | List Available Plugins |
| [**TogglePlugin**](PluginsApi.md#toggleplugin) | **PUT** /plugins/toggle/{plugin_id} | Toggle Plugin |
| [**UpsertPluginSettings**](PluginsApi.md#upsertpluginsettings) | **PUT** /plugins/settings/{plugin_id} | Upsert Plugin Settings |

<a id="deleteplugin"></a>
# **DeletePlugin**
> List&lt;string&gt; DeletePlugin (string pluginId)

Delete Plugin

Physically remove a plugin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class DeletePluginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var pluginId = "pluginId_example";  // string | 

            try
            {
                // Delete Plugin
                List<string> result = apiInstance.DeletePlugin(pluginId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.DeletePlugin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePluginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Plugin
    ApiResponse<List<string>> response = apiInstance.DeletePluginWithHttpInfo(pluginId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.DeletePluginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pluginId** | **string** |  |  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getplugindetails"></a>
# **GetPluginDetails**
> Plugin GetPluginDetails (string pluginId)

Get Plugin Details

Returns information on a single plugin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetPluginDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var pluginId = "pluginId_example";  // string | 

            try
            {
                // Get Plugin Details
                Plugin result = apiInstance.GetPluginDetails(pluginId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPluginDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPluginDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Plugin Details
    ApiResponse<Plugin> response = apiInstance.GetPluginDetailsWithHttpInfo(pluginId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.GetPluginDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pluginId** | **string** |  |  |

### Return type

[**Plugin**](Plugin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpluginsettings"></a>
# **GetPluginSettings**
> GetPluginSettings200Response GetPluginSettings (string pluginId)

Get Plugin Settings

Returns the settings of a specific plugin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetPluginSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var pluginId = "pluginId_example";  // string | 

            try
            {
                // Get Plugin Settings
                GetPluginSettings200Response result = apiInstance.GetPluginSettings(pluginId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPluginSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPluginSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Plugin Settings
    ApiResponse<GetPluginSettings200Response> response = apiInstance.GetPluginSettingsWithHttpInfo(pluginId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.GetPluginSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pluginId** | **string** |  |  |

### Return type

[**GetPluginSettings200Response**](GetPluginSettings200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpluginssettings"></a>
# **GetPluginsSettings**
> SettingsResponse GetPluginsSettings ()

Get Plugins Settings

Returns the settings of all the plugins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetPluginsSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);

            try
            {
                // Get Plugins Settings
                SettingsResponse result = apiInstance.GetPluginsSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPluginsSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPluginsSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Plugins Settings
    ApiResponse<SettingsResponse> response = apiInstance.GetPluginsSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.GetPluginsSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SettingsResponse**](SettingsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="installplugin"></a>
# **InstallPlugin**
> FileResponse InstallPlugin (System.IO.Stream file)

Install Plugin

Install a new plugin from a zip file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class InstallPluginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Install Plugin
                FileResponse result = apiInstance.InstallPlugin(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.InstallPlugin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallPluginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Install Plugin
    ApiResponse<FileResponse> response = apiInstance.InstallPluginWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.InstallPluginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="installpluginfromregistry"></a>
# **InstallPluginFromRegistry**
> FileResponse InstallPluginFromRegistry (BodyUploadUrl bodyUploadUrl)

Install Plugin From Registry

Install a new plugin from external repository

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class InstallPluginFromRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var bodyUploadUrl = new BodyUploadUrl(); // BodyUploadUrl | 

            try
            {
                // Install Plugin From Registry
                FileResponse result = apiInstance.InstallPluginFromRegistry(bodyUploadUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.InstallPluginFromRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallPluginFromRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Install Plugin From Registry
    ApiResponse<FileResponse> response = apiInstance.InstallPluginFromRegistryWithHttpInfo(bodyUploadUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.InstallPluginFromRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bodyUploadUrl** | [**BodyUploadUrl**](BodyUploadUrl.md) |  |  |

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listavailableplugins"></a>
# **ListAvailablePlugins**
> PluginsList ListAvailablePlugins (string? query = null)

List Available Plugins

List both installed and registry plugins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class ListAvailablePluginsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var query = "query_example";  // string? |  (optional) 

            try
            {
                // List Available Plugins
                PluginsList result = apiInstance.ListAvailablePlugins(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.ListAvailablePlugins: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAvailablePluginsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Available Plugins
    ApiResponse<PluginsList> response = apiInstance.ListAvailablePluginsWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.ListAvailablePluginsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string?** |  | [optional]  |

### Return type

[**PluginsList**](PluginsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="toggleplugin"></a>
# **TogglePlugin**
> ToggleResponse TogglePlugin (string pluginId)

Toggle Plugin

Enable or disable a single plugin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class TogglePluginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var pluginId = "pluginId_example";  // string | 

            try
            {
                // Toggle Plugin
                ToggleResponse result = apiInstance.TogglePlugin(pluginId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.TogglePlugin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TogglePluginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Toggle Plugin
    ApiResponse<ToggleResponse> response = apiInstance.TogglePluginWithHttpInfo(pluginId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.TogglePluginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pluginId** | **string** |  |  |

### Return type

[**ToggleResponse**](ToggleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertpluginsettings"></a>
# **UpsertPluginSettings**
> Setting UpsertPluginSettings (string pluginId, Object body)

Upsert Plugin Settings

Updates the settings of a specific plugin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class UpsertPluginSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PluginsApi(config);
            var pluginId = "pluginId_example";  // string | 
            var body = {"setting_a":"some value","setting_b":"another value"};  // Object | 

            try
            {
                // Upsert Plugin Settings
                Setting result = apiInstance.UpsertPluginSettings(pluginId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.UpsertPluginSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertPluginSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upsert Plugin Settings
    ApiResponse<Setting> response = apiInstance.UpsertPluginSettingsWithHttpInfo(pluginId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.UpsertPluginSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pluginId** | **string** |  |  |
| **body** | **Object** |  |  |

### Return type

[**Setting**](Setting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

