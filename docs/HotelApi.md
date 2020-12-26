# IO.Swagger.Api.HotelApi

All URIs are relative to *https://virtserver.swaggerhub.com/alswagger/algebratecAPI/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HotelAvailability**](HotelApi.md#hotelavailability) | **POST** /v1/hotel/booking/availability | list bookable hotels
[**HotelBookingCancellation**](HotelApi.md#hotelbookingcancellation) | **DELETE** /v1/hotel/booking/cancellation/{reference} | cancel hotel booking
[**HotelBookingConfirmation**](HotelApi.md#hotelbookingconfirmation) | **POST** /v1/hotel/booking/confirmation | confirm hotel booking
[**HotelCheckRate**](HotelApi.md#hotelcheckrate) | **POST** /v1/hotel/booking/checkrate | check hotel rating
[**HotelRetrieveBooking**](HotelApi.md#hotelretrievebooking) | **POST** /v1/hotel/booking/{reference} | retrieve hotel booking

<a name="hotelavailability"></a>
# **HotelAvailability**
> HotelAvailabilityResponse HotelAvailability (HotelAvailabilityRequest body = null)

list bookable hotels

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotelAvailabilityExample
    {
        public void main()
        {
            var apiInstance = new HotelApi();
            var body = new HotelAvailabilityRequest(); // HotelAvailabilityRequest |  (optional) 

            try
            {
                // list bookable hotels
                HotelAvailabilityResponse result = apiInstance.HotelAvailability(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelApi.HotelAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelAvailabilityRequest**](HotelAvailabilityRequest.md)|  | [optional] 

### Return type

[**HotelAvailabilityResponse**](HotelAvailabilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="hotelbookingcancellation"></a>
# **HotelBookingCancellation**
> HotelCancellationResponse HotelBookingCancellation (string reference, bool? SIMULATION, string language = null)

cancel hotel booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotelBookingCancellationExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new HotelApi();
            var reference = reference_example;  // string | 
            var SIMULATION = true;  // bool? | 
            var language = language_example;  // string |  (optional) 

            try
            {
                // cancel hotel booking
                HotelCancellationResponse result = apiInstance.HotelBookingCancellation(reference, SIMULATION, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelApi.HotelBookingCancellation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reference** | **string**|  | 
 **SIMULATION** | **bool?**|  | 
 **language** | **string**|  | [optional] 

### Return type

[**HotelCancellationResponse**](HotelCancellationResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="hotelbookingconfirmation"></a>
# **HotelBookingConfirmation**
> HotelConfirmationResponse HotelBookingConfirmation (HotelConfirmationRequest body = null)

confirm hotel booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotelBookingConfirmationExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new HotelApi();
            var body = new HotelConfirmationRequest(); // HotelConfirmationRequest |  (optional) 

            try
            {
                // confirm hotel booking
                HotelConfirmationResponse result = apiInstance.HotelBookingConfirmation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelApi.HotelBookingConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelConfirmationRequest**](HotelConfirmationRequest.md)|  | [optional] 

### Return type

[**HotelConfirmationResponse**](HotelConfirmationResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="hotelcheckrate"></a>
# **HotelCheckRate**
> HotelCheckRatesResponse HotelCheckRate (HotelCheckRatesRequest body = null)

check hotel rating

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotelCheckRateExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new HotelApi();
            var body = new HotelCheckRatesRequest(); // HotelCheckRatesRequest |  (optional) 

            try
            {
                // check hotel rating
                HotelCheckRatesResponse result = apiInstance.HotelCheckRate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelApi.HotelCheckRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelCheckRatesRequest**](HotelCheckRatesRequest.md)|  | [optional] 

### Return type

[**HotelCheckRatesResponse**](HotelCheckRatesResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="hotelretrievebooking"></a>
# **HotelRetrieveBooking**
> HotelRetrieveBookingResponse HotelRetrieveBooking (string reference, string language = null)

retrieve hotel booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotelRetrieveBookingExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new HotelApi();
            var reference = reference_example;  // string | 
            var language = language_example;  // string |  (optional) 

            try
            {
                // retrieve hotel booking
                HotelRetrieveBookingResponse result = apiInstance.HotelRetrieveBooking(reference, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelApi.HotelRetrieveBooking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reference** | **string**|  | 
 **language** | **string**|  | [optional] 

### Return type

[**HotelRetrieveBookingResponse**](HotelRetrieveBookingResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
