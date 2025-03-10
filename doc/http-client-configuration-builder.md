
# HttpClientConfigurationBuilder

Class to build instances of HttpClientConfiguration.

## Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `Timeout(TimeSpan timeout)` | Http client timeout. | [`Builder`](../doc/http-client-configuration-builder.md) |
| `NumberOfRetries(int numberOfRetries)` | Number of times the request is retried. | [`Builder`](../doc/http-client-configuration-builder.md) |
| `BackoffFactor(int backoffFactor)` | Exponential backoff factor for duration between retry calls. | [`Builder`](../doc/http-client-configuration-builder.md) |
| `RetryInterval(double retryInterval)` | The time interval between the endpoint calls. | [`Builder`](../doc/http-client-configuration-builder.md) |
| `MaximumRetryWaitTime(TimeSpan maximumRetryWaitTime)` | The maximum retry wait time. | [`Builder`](../doc/http-client-configuration-builder.md) |
| `StatusCodesToRetry(IList<int> statusCodesToRetry)` | List of Http status codes to invoke retry. | [`Builder`](../doc/http-client-configuration-builder.md) |
| `RequestMethodsToRetry(IList<HttpMethod> requestMethodsToRetry)` | List of Http request methods to invoke retry. | [`Builder`](../doc/http-client-configuration-builder.md) |
| `Build()` | Builds a new HttpClientConfiguration object using the set fields. | [`HttpClientConfiguration`](../doc/http-client-configuration.md) |

