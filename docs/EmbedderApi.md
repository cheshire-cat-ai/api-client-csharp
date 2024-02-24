# CheshireCatApi.Api.EmbedderApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEmbedderSettings**](EmbedderApi.md#getembeddersettings) | **GET** /embedder/settings/{languageEmbedderName} | Get Embedder Settings |
| [**GetEmbeddersSettings**](EmbedderApi.md#getembedderssettings) | **GET** /embedder/settings | Get Embedders Settings |
| [**UpsertEmbedderSetting**](EmbedderApi.md#upsertembeddersetting) | **PUT** /embedder/settings/{languageEmbedderName} | Upsert Embedder Setting |

<a id="getembeddersettings"></a>
# **GetEmbedderSettings**
> Setting GetEmbedderSettings (string languageEmbedderName)

Get Embedder Settings

Get settings and schema of the specified Embedder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetEmbedderSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EmbedderApi(config);
            var languageEmbedderName = "languageEmbedderName_example";  // string | 

            try
            {
                // Get Embedder Settings
                Setting result = apiInstance.GetEmbedderSettings(languageEmbedderName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedderApi.GetEmbedderSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmbedderSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Embedder Settings
    ApiResponse<Setting> response = apiInstance.GetEmbedderSettingsWithHttpInfo(languageEmbedderName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbedderApi.GetEmbedderSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **languageEmbedderName** | **string** |  |  |

### Return type

[**Setting**](Setting.md)

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

<a id="getembedderssettings"></a>
# **GetEmbeddersSettings**
> SettingsResponse GetEmbeddersSettings ()

Get Embedders Settings

Get the list of the Embedders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetEmbeddersSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EmbedderApi(config);

            try
            {
                // Get Embedders Settings
                SettingsResponse result = apiInstance.GetEmbeddersSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedderApi.GetEmbeddersSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmbeddersSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Embedders Settings
    ApiResponse<SettingsResponse> response = apiInstance.GetEmbeddersSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbedderApi.GetEmbeddersSettingsWithHttpInfo: " + e.Message);
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

<a id="upsertembeddersetting"></a>
# **UpsertEmbedderSetting**
> Setting UpsertEmbedderSetting (string languageEmbedderName, Object body)

Upsert Embedder Setting

Upsert the Embedder setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class UpsertEmbedderSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EmbedderApi(config);
            var languageEmbedderName = "languageEmbedderName_example";  // string | 
            var body = {"openai_api_key":"your-key-here"};  // Object | 

            try
            {
                // Upsert Embedder Setting
                Setting result = apiInstance.UpsertEmbedderSetting(languageEmbedderName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedderApi.UpsertEmbedderSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertEmbedderSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upsert Embedder Setting
    ApiResponse<Setting> response = apiInstance.UpsertEmbedderSettingWithHttpInfo(languageEmbedderName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbedderApi.UpsertEmbedderSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **languageEmbedderName** | **string** |  |  |
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

