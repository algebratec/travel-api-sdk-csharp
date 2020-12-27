# IO.Swagger.Model.FlightAvailabilityRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Language** | **string** | EN &#x3D; English &lt;br&gt; FR &#x3D; French &lt;br&gt; AR &#x3D; Arabic | [optional] 
**Bounds** | [**List&lt;FlightAvailabilityRequestBound&gt;**](FlightAvailabilityRequestBound.md) |  | [optional] 
**CabinClass** | **string** | M &#x3D; ECONOMY STANDARD &lt;br&gt; Y &#x3D; ECONOMY &lt;br&gt; W &#x3D; ECONOMY PREMIUM &lt;br&gt; C &#x3D; BUSINESS &lt;br&gt; F &#x3D; FIRST | [optional] 
**TripType** | **string** | rt &#x3D; Roundtrip &lt;br&gt; ow &#x3D; Oneway &lt;br&gt; md &#x3D; multidestination | [optional] 
**Flexible** | **bool?** |  | [optional] 
**Range** | **int?** |  | [optional] 
**NrOfAdult** | **int?** |  | [optional] 
**NrOfChild** | **int?** |  | [optional] 
**NrOfInfant** | **int?** |  | [optional] 
**NrOfInfantWithSeat** | **int?** |  | [optional] 
**NrOfSenior** | **int?** |  | [optional] 
**NrOfYouth** | **int?** |  | [optional] 
**DirectFlight** | **bool?** | if true, the system will reply with direct flights only | [optional] 
**WithBaggage** | **bool?** | if true, the system will reply with recommendations with baggage only | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

