# CheshireCatApi.Api.RabbitHoleApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllowedMimetypes**](RabbitHoleApi.md#getallowedmimetypes) | **GET** /rabbithole/allowed-mimetypes | Get Allowed Mimetypes |
| [**UploadFile**](RabbitHoleApi.md#uploadfile) | **POST** /rabbithole | Upload File |
| [**UploadMemory**](RabbitHoleApi.md#uploadmemory) | **POST** /rabbithole/memory | Upload Memory |
| [**UploadUrl**](RabbitHoleApi.md#uploadurl) | **POST** /rabbithole/web | Upload URL |

<a id="getallowedmimetypes"></a>
# **GetAllowedMimetypes**
> ResponseGetAllowedMimetypes GetAllowedMimetypes ()

Get Allowed Mimetypes

Retrieve the allowed mimetypes that can be ingested by the Rabbit Hole

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetAllowedMimetypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RabbitHoleApi(config);

            try
            {
                // Get Allowed Mimetypes
                ResponseGetAllowedMimetypes result = apiInstance.GetAllowedMimetypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RabbitHoleApi.GetAllowedMimetypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllowedMimetypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Allowed Mimetypes
    ApiResponse<ResponseGetAllowedMimetypes> response = apiInstance.GetAllowedMimetypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RabbitHoleApi.GetAllowedMimetypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResponseGetAllowedMimetypes**](ResponseGetAllowedMimetypes.md)

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

<a id="uploadfile"></a>
# **UploadFile**
> FileResponse UploadFile (System.IO.Stream file)

Upload File

Upload a file containing text (.txt, .md, .pdf, etc.). File content will be extracted and segmented into chunks. Chunks will be then vectorized and stored into documents memory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class UploadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RabbitHoleApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Upload File
                FileResponse result = apiInstance.UploadFile(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RabbitHoleApi.UploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload File
    ApiResponse<FileResponse> response = apiInstance.UploadFileWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RabbitHoleApi.UploadFileWithHttpInfo: " + e.Message);
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

<a id="uploadmemory"></a>
# **UploadMemory**
> Object UploadMemory (System.IO.Stream file)

Upload Memory

Upload a memory json file to the cat memory

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class UploadMemoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RabbitHoleApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Upload Memory
                Object result = apiInstance.UploadMemory(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RabbitHoleApi.UploadMemory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadMemoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload Memory
    ApiResponse<Object> response = apiInstance.UploadMemoryWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RabbitHoleApi.UploadMemoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

**Object**

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

<a id="uploadurl"></a>
# **UploadUrl**
> WebResponse UploadUrl (BodyUploadUrl bodyUploadUrl)

Upload URL

Upload a URL. Website content will be extracted and segmented into chunks. Chunks will be then vectorized and stored into documents memory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class UploadUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RabbitHoleApi(config);
            var bodyUploadUrl = new BodyUploadUrl(); // BodyUploadUrl | 

            try
            {
                // Upload URL
                WebResponse result = apiInstance.UploadUrl(bodyUploadUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RabbitHoleApi.UploadUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload URL
    ApiResponse<WebResponse> response = apiInstance.UploadUrlWithHttpInfo(bodyUploadUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RabbitHoleApi.UploadUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bodyUploadUrl** | [**BodyUploadUrl**](BodyUploadUrl.md) |  |  |

### Return type

[**WebResponse**](WebResponse.md)

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

