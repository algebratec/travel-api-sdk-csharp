# IO.Swagger.Api.FlightApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FlightAirRevalidate**](FlightApi.md#flightairrevalidate) | **POST** /v1/flight/booking/fare | airRevalidate service to check if flight is still bookable
[**FlightAirportAutocomplete**](FlightApi.md#flightairportautocomplete) | **GET** /v1/flight/booking/airport/{term} | airport autocomplete service
[**FlightAvailability**](FlightApi.md#flightavailability) | **POST** /v1/flight/booking/availability | flight availability service
[**FlightBookingConfirmaiton**](FlightApi.md#flightbookingconfirmaiton) | **POST** /v1/flight/booking/confirmation | confirm flight booking
[**FlightFare**](FlightApi.md#flightfare) | **POST** /v1/flight/booking/fareRules | flight fare service, this service provide the airline fare rules
[**FlightOnHoldBookingConfirmation**](FlightApi.md#flightonholdbookingconfirmation) | **POST** /v1/flight/booking/confirmOnHoldBooking/{bookingId} | confirm on hold flight booking
[**FlightRefreshPNR**](FlightApi.md#flightrefreshpnr) | **POST** /v1/flight/booking/refresh/{bookingId} | Refresh flight booking using booking id
[**FlightRetrievePNR**](FlightApi.md#flightretrievepnr) | **GET** /v1/flight/booking/retrievePNR/{recordLocator} | retrieve PNR using PNR record
[**FlightVoidPNR**](FlightApi.md#flightvoidpnr) | **DELETE** /v1/flight/booking/voidPNR/{bookingId} | void PNR service, this service should be used in non BSP market to cancel the PNR before midnight

<a name="flightairrevalidate"></a>
# **FlightAirRevalidate**
> FlightFareResponse FlightAirRevalidate (BookingKeyRequest body = null)

airRevalidate service to check if flight is still bookable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightAirRevalidateExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var body = new BookingKeyRequest(); // BookingKeyRequest |  (optional) 

            try
            {
                // airRevalidate service to check if flight is still bookable
                FlightFareResponse result = apiInstance.FlightAirRevalidate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightAirRevalidate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BookingKeyRequest**](BookingKeyRequest.md)|  | [optional] 

### Return type

[**FlightFareResponse**](FlightFareResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightairportautocomplete"></a>
# **FlightAirportAutocomplete**
> FlightAirportAutocompleteResponse FlightAirportAutocomplete (string term)

airport autocomplete service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightAirportAutocompleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var term = term_example;  // string | 

            try
            {
                // airport autocomplete service
                FlightAirportAutocompleteResponse result = apiInstance.FlightAirportAutocomplete(term);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightAirportAutocomplete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | **string**|  | 

### Return type

[**FlightAirportAutocompleteResponse**](FlightAirportAutocompleteResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightavailability"></a>
# **FlightAvailability**
> FlightAvailabilityResponse FlightAvailability (FlightAvailabilityRequest body = null)

flight availability service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightAvailabilityExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var body = new FlightAvailabilityRequest(); // FlightAvailabilityRequest |  (optional) 

            try
            {
                // flight availability service
                FlightAvailabilityResponse result = apiInstance.FlightAvailability(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightAvailabilityRequest**](FlightAvailabilityRequest.md)|  | [optional] 

### Return type

[**FlightAvailabilityResponse**](FlightAvailabilityResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightbookingconfirmaiton"></a>
# **FlightBookingConfirmaiton**
> FlightBookingResponse FlightBookingConfirmaiton (FlightConfirmationRequest body = null)

confirm flight booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightBookingConfirmaitonExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var body = new FlightConfirmationRequest(); // FlightConfirmationRequest |  (optional) 

            try
            {
                // confirm flight booking
                FlightBookingResponse result = apiInstance.FlightBookingConfirmaiton(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightBookingConfirmaiton: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightConfirmationRequest**](FlightConfirmationRequest.md)|  | [optional] 

### Return type

[**FlightBookingResponse**](FlightBookingResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightfare"></a>
# **FlightFare**
> FlightFareRulesResponse FlightFare (BookingKeyRequest body = null)

flight fare service, this service provide the airline fare rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightFareExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var body = new BookingKeyRequest(); // BookingKeyRequest |  (optional) 

            try
            {
                // flight fare service, this service provide the airline fare rules
                FlightFareRulesResponse result = apiInstance.FlightFare(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightFare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BookingKeyRequest**](BookingKeyRequest.md)|  | [optional] 

### Return type

[**FlightFareRulesResponse**](FlightFareRulesResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightonholdbookingconfirmation"></a>
# **FlightOnHoldBookingConfirmation**
> FlightBookingResponse FlightOnHoldBookingConfirmation (string bookingId)

confirm on hold flight booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightOnHoldBookingConfirmationExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // confirm on hold flight booking
                FlightBookingResponse result = apiInstance.FlightOnHoldBookingConfirmation(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightOnHoldBookingConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **string**|  | 

### Return type

[**FlightBookingResponse**](FlightBookingResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightrefreshpnr"></a>
# **FlightRefreshPNR**
> FlightBookingResponse FlightRefreshPNR (string bookingId)

Refresh flight booking using booking id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightRefreshPNRExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Refresh flight booking using booking id
                FlightBookingResponse result = apiInstance.FlightRefreshPNR(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightRefreshPNR: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **string**|  | 

### Return type

[**FlightBookingResponse**](FlightBookingResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightretrievepnr"></a>
# **FlightRetrievePNR**
> FlightBookingResponse FlightRetrievePNR (string recordLocator)

retrieve PNR using PNR record

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightRetrievePNRExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var recordLocator = recordLocator_example;  // string | 

            try
            {
                // retrieve PNR using PNR record
                FlightBookingResponse result = apiInstance.FlightRetrievePNR(recordLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightRetrievePNR: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordLocator** | **string**|  | 

### Return type

[**FlightBookingResponse**](FlightBookingResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flightvoidpnr"></a>
# **FlightVoidPNR**
> FlightBookingResponse FlightVoidPNR (string bookingId)

void PNR service, this service should be used in non BSP market to cancel the PNR before midnight

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightVoidPNRExample
    {
        public void main()
        {
            // Configure API key authorization: api_auth
            Configuration.Default.AddApiKey("X-AUTHORIZATION", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AUTHORIZATION", "Bearer");

            var apiInstance = new FlightApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // void PNR service, this service should be used in non BSP market to cancel the PNR before midnight
                FlightBookingResponse result = apiInstance.FlightVoidPNR(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightApi.FlightVoidPNR: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **string**|  | 

### Return type

[**FlightBookingResponse**](FlightBookingResponse.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
