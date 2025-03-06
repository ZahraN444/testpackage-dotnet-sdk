
# HttpRequest

HttpRequest stores necessary information about the http request.

## Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpMethod | The HTTP verb to use for this request. | `HttpMethod` |
| QueryUrl | The query url for the http request. | `string` |
| QueryParameters | Query parameters collection for the current http request. | `Dictionary<string, object>` |
| Headers | Headers collection for the current http request. | `Dictionary<string, string>` |
| FormParameters | Form parameters for the current http request. | `List<KeyValuePair<string, object>>` |
| Body | Optional raw string to send as request body. | `object` |
| Username | Optional username for Basic Auth. | `string` |
| Password | Optional password for Basic Auth. | `string` |

## Constructors

| Name | Description |
|  --- | --- |
| `HttpRequest(HttpMethod method, string queryUrl)` | Constructor to initialize the http request object. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers and optional Basic auth params. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, object body, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers, body and optional Basic auth params. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, Object>> formParameters, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers, form parameters and optional Basic auth params. |

## Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `AddHeaders(Dictionary<string, string> HeadersToAdd)` | Concatenate values from a Dictionary to this object. | `Dictionary<string, string>` |
| `AddQueryParameters(Dictionary<string, object> queryParameters)` | Concatenate values from a Dictionary to query parameters dictionary. | `void` |

