# CheshireCatApi.Api.LargeLanguageModelApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLlmSettings**](LargeLanguageModelApi.md#getllmsettings) | **GET** /llm/settings/{languageModelName} | Get Llm Settings |
| [**GetLlmsSettings**](LargeLanguageModelApi.md#getllmssettings) | **GET** /llm/settings | Get LLMs Settings |
| [**UpsertLlmSetting**](LargeLanguageModelApi.md#upsertllmsetting) | **PUT** /llm/settings/{languageModelName} | Upsert LLM Setting |

<a id="getllmsettings"></a>
# **GetLlmSettings**
> Setting GetLlmSettings (string languageModelName)

Get Llm Settings

Get settings and schema of the specified Large Language Model

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetLlmSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LargeLanguageModelApi(config);
            var languageModelName = "languageModelName_example";  // string | 

            try
            {
                // Get Llm Settings
                Setting result = apiInstance.GetLlmSettings(languageModelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LargeLanguageModelApi.GetLlmSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLlmSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Llm Settings
    ApiResponse<Setting> response = apiInstance.GetLlmSettingsWithHttpInfo(languageModelName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LargeLanguageModelApi.GetLlmSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **languageModelName** | **string** |  |  |

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

<a id="getllmssettings"></a>
# **GetLlmsSettings**
> SettingsResponse GetLlmsSettings ()

Get LLMs Settings

Get the list of the Large Language Models

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetLlmsSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LargeLanguageModelApi(config);

            try
            {
                // Get LLMs Settings
                SettingsResponse result = apiInstance.GetLlmsSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LargeLanguageModelApi.GetLlmsSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLlmsSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get LLMs Settings
    ApiResponse<SettingsResponse> response = apiInstance.GetLlmsSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LargeLanguageModelApi.GetLlmsSettingsWithHttpInfo: " + e.Message);
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

<a id="upsertllmsetting"></a>
# **UpsertLlmSetting**
> Setting UpsertLlmSetting (string languageModelName, Object body)

Upsert LLM Setting

Upsert the Large Language Model setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class UpsertLlmSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LargeLanguageModelApi(config);
            var languageModelName = "languageModelName_example";  // string | 
            var body = {"openai_api_key":"your-key-here"};  // Object | 

            try
            {
                // Upsert LLM Setting
                Setting result = apiInstance.UpsertLlmSetting(languageModelName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LargeLanguageModelApi.UpsertLlmSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertLlmSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upsert LLM Setting
    ApiResponse<Setting> response = apiInstance.UpsertLlmSettingWithHttpInfo(languageModelName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LargeLanguageModelApi.UpsertLlmSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **languageModelName** | **string** |  |  |
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

