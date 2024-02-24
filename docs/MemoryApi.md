# CheshireCatApi.Api.MemoryApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePointInMemory**](MemoryApi.md#deletepointinmemory) | **DELETE** /memory/collections/{collection_id}/points/{memory_id} | Delete Point In Memory |
| [**GetCollections**](MemoryApi.md#getcollections) | **GET** /memory/collections | Get Collections |
| [**GetConversationHistory**](MemoryApi.md#getconversationhistory) | **GET** /memory/conversation_history | Get Conversation History |
| [**RecallMemoriesFromText**](MemoryApi.md#recallmemoriesfromtext) | **GET** /memory/recall | Recall Memories From Text |
| [**WipeCollections**](MemoryApi.md#wipecollections) | **DELETE** /memory/collections | Wipe Collections |
| [**WipeConversationHistory**](MemoryApi.md#wipeconversationhistory) | **DELETE** /memory/conversation_history | Wipe Conversation History |
| [**WipeMemoryPoints**](MemoryApi.md#wipememorypoints) | **DELETE** /memory/collections/{collection_id}/points | Wipe Memory Points By Metadata |
| [**WipeSingleCollection**](MemoryApi.md#wipesinglecollection) | **DELETE** /memory/collections/{collection_id} | Wipe Single Collection |

<a id="deletepointinmemory"></a>
# **DeletePointInMemory**
> List&lt;string&gt; DeletePointInMemory (string collectionId, string memoryId)

Delete Point In Memory

Delete specific point in memory

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class DeletePointInMemoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);
            var collectionId = "collectionId_example";  // string | 
            var memoryId = "memoryId_example";  // string | 

            try
            {
                // Delete Point In Memory
                List<string> result = apiInstance.DeletePointInMemory(collectionId, memoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.DeletePointInMemory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePointInMemoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Point In Memory
    ApiResponse<List<string>> response = apiInstance.DeletePointInMemoryWithHttpInfo(collectionId, memoryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.DeletePointInMemoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **memoryId** | **string** |  |  |

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

<a id="getcollections"></a>
# **GetCollections**
> CollectionsList GetCollections ()

Get Collections

Get list of available collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);

            try
            {
                // Get Collections
                CollectionsList result = apiInstance.GetCollections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.GetCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Collections
    ApiResponse<CollectionsList> response = apiInstance.GetCollectionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.GetCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CollectionsList**](CollectionsList.md)

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

<a id="getconversationhistory"></a>
# **GetConversationHistory**
> ConversationHistory GetConversationHistory ()

Get Conversation History

Get the specified user's conversation history from working memory

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class GetConversationHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);

            try
            {
                // Get Conversation History
                ConversationHistory result = apiInstance.GetConversationHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.GetConversationHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConversationHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Conversation History
    ApiResponse<ConversationHistory> response = apiInstance.GetConversationHistoryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.GetConversationHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ConversationHistory**](ConversationHistory.md)

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

<a id="recallmemoriesfromtext"></a>
# **RecallMemoriesFromText**
> MemoryRecall RecallMemoriesFromText (string text, int? k = null)

Recall Memories From Text

Search k memories similar to given text.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class RecallMemoriesFromTextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);
            var text = "text_example";  // string | Find memories similar to this text.
            var k = 100;  // int? | How many memories to return. (optional)  (default to 100)

            try
            {
                // Recall Memories From Text
                MemoryRecall result = apiInstance.RecallMemoriesFromText(text, k);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.RecallMemoriesFromText: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecallMemoriesFromTextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Recall Memories From Text
    ApiResponse<MemoryRecall> response = apiInstance.RecallMemoriesFromTextWithHttpInfo(text, k);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.RecallMemoriesFromTextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **text** | **string** | Find memories similar to this text. |  |
| **k** | **int?** | How many memories to return. | [optional] [default to 100] |

### Return type

[**MemoryRecall**](MemoryRecall.md)

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

<a id="wipecollections"></a>
# **WipeCollections**
> List&lt;string&gt; WipeCollections ()

Wipe Collections

Delete and create all collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class WipeCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);

            try
            {
                // Wipe Collections
                List<string> result = apiInstance.WipeCollections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.WipeCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WipeCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wipe Collections
    ApiResponse<List<string>> response = apiInstance.WipeCollectionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.WipeCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wipeconversationhistory"></a>
# **WipeConversationHistory**
> List&lt;string&gt; WipeConversationHistory ()

Wipe Conversation History

Delete the specified user's conversation history from working memory

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class WipeConversationHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);

            try
            {
                // Wipe Conversation History
                List<string> result = apiInstance.WipeConversationHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.WipeConversationHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WipeConversationHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wipe Conversation History
    ApiResponse<List<string>> response = apiInstance.WipeConversationHistoryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.WipeConversationHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wipememorypoints"></a>
# **WipeMemoryPoints**
> List&lt;string&gt; WipeMemoryPoints (string collectionId, Object? body = null)

Wipe Memory Points By Metadata

Delete points in memory by filter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class WipeMemoryPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);
            var collectionId = "collectionId_example";  // string | 
            var body = null;  // Object? |  (optional) 

            try
            {
                // Wipe Memory Points By Metadata
                List<string> result = apiInstance.WipeMemoryPoints(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.WipeMemoryPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WipeMemoryPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wipe Memory Points By Metadata
    ApiResponse<List<string>> response = apiInstance.WipeMemoryPointsWithHttpInfo(collectionId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.WipeMemoryPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **body** | **Object?** |  | [optional]  |

### Return type

**List<string>**

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

<a id="wipesinglecollection"></a>
# **WipeSingleCollection**
> List&lt;string&gt; WipeSingleCollection (string collectionId)

Wipe Single Collection

Delete and recreate a collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using CheshireCatApi.Model;

namespace Example
{
    public class WipeSingleCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MemoryApi(config);
            var collectionId = "collectionId_example";  // string | 

            try
            {
                // Wipe Single Collection
                List<string> result = apiInstance.WipeSingleCollection(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemoryApi.WipeSingleCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WipeSingleCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wipe Single Collection
    ApiResponse<List<string>> response = apiInstance.WipeSingleCollectionWithHttpInfo(collectionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemoryApi.WipeSingleCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |

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

