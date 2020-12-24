/* 
 * Algebratec API
 *
 * Learn and test our api with ease
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@algebratec.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FlightBooking
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FlightBookingTests
    {
        // TODO uncomment below to declare an instance variable for FlightBooking
        //private FlightBooking instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FlightBooking
            //instance = new FlightBooking();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FlightBooking
        /// </summary>
        [Test]
        public void FlightBookingInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FlightBooking
            //Assert.IsInstanceOfType<FlightBooking> (instance, "variable 'instance' is a FlightBooking");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Airlines'
        /// </summary>
        [Test]
        public void AirlinesTest()
        {
            // TODO unit test for the property 'Airlines'
        }
        /// <summary>
        /// Test the property 'BookingCanBeVoid'
        /// </summary>
        [Test]
        public void BookingCanBeVoidTest()
        {
            // TODO unit test for the property 'BookingCanBeVoid'
        }
        /// <summary>
        /// Test the property 'BookingClass'
        /// </summary>
        [Test]
        public void BookingClassTest()
        {
            // TODO unit test for the property 'BookingClass'
        }
        /// <summary>
        /// Test the property 'BookingDate'
        /// </summary>
        [Test]
        public void BookingDateTest()
        {
            // TODO unit test for the property 'BookingDate'
        }
        /// <summary>
        /// Test the property 'BookingNeedExchangeDocuments'
        /// </summary>
        [Test]
        public void BookingNeedExchangeDocumentsTest()
        {
            // TODO unit test for the property 'BookingNeedExchangeDocuments'
        }
        /// <summary>
        /// Test the property 'Bounds'
        /// </summary>
        [Test]
        public void BoundsTest()
        {
            // TODO unit test for the property 'Bounds'
        }
        /// <summary>
        /// Test the property 'Canceled'
        /// </summary>
        [Test]
        public void CanceledTest()
        {
            // TODO unit test for the property 'Canceled'
        }
        /// <summary>
        /// Test the property 'Confirmed'
        /// </summary>
        [Test]
        public void ConfirmedTest()
        {
            // TODO unit test for the property 'Confirmed'
        }
        /// <summary>
        /// Test the property 'CouldNotRetrieveEtickets'
        /// </summary>
        [Test]
        public void CouldNotRetrieveEticketsTest()
        {
            // TODO unit test for the property 'CouldNotRetrieveEtickets'
        }
        /// <summary>
        /// Test the property 'Customer'
        /// </summary>
        [Test]
        public void CustomerTest()
        {
            // TODO unit test for the property 'Customer'
        }
        /// <summary>
        /// Test the property 'CustomerId'
        /// </summary>
        [Test]
        public void CustomerIdTest()
        {
            // TODO unit test for the property 'CustomerId'
        }
        /// <summary>
        /// Test the property 'Destination'
        /// </summary>
        [Test]
        public void DestinationTest()
        {
            // TODO unit test for the property 'Destination'
        }
        /// <summary>
        /// Test the property 'Etickets'
        /// </summary>
        [Test]
        public void EticketsTest()
        {
            // TODO unit test for the property 'Etickets'
        }
        /// <summary>
        /// Test the property 'History'
        /// </summary>
        [Test]
        public void HistoryTest()
        {
            // TODO unit test for the property 'History'
        }
        /// <summary>
        /// Test the property 'Modified'
        /// </summary>
        [Test]
        public void ModifiedTest()
        {
            // TODO unit test for the property 'Modified'
        }
        /// <summary>
        /// Test the property 'Offline'
        /// </summary>
        [Test]
        public void OfflineTest()
        {
            // TODO unit test for the property 'Offline'
        }
        /// <summary>
        /// Test the property 'OptionDeadline'
        /// </summary>
        [Test]
        public void OptionDeadlineTest()
        {
            // TODO unit test for the property 'OptionDeadline'
        }
        /// <summary>
        /// Test the property 'Origin'
        /// </summary>
        [Test]
        public void OriginTest()
        {
            // TODO unit test for the property 'Origin'
        }
        /// <summary>
        /// Test the property 'PaxNumber'
        /// </summary>
        [Test]
        public void PaxNumberTest()
        {
            // TODO unit test for the property 'PaxNumber'
        }
        /// <summary>
        /// Test the property 'Pending'
        /// </summary>
        [Test]
        public void PendingTest()
        {
            // TODO unit test for the property 'Pending'
        }
        /// <summary>
        /// Test the property 'Pnr'
        /// </summary>
        [Test]
        public void PnrTest()
        {
            // TODO unit test for the property 'Pnr'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Test]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }
        /// <summary>
        /// Test the property 'Queued'
        /// </summary>
        [Test]
        public void QueuedTest()
        {
            // TODO unit test for the property 'Queued'
        }
        /// <summary>
        /// Test the property 'Reference'
        /// </summary>
        [Test]
        public void ReferenceTest()
        {
            // TODO unit test for the property 'Reference'
        }
        /// <summary>
        /// Test the property 'Refund'
        /// </summary>
        [Test]
        public void RefundTest()
        {
            // TODO unit test for the property 'Refund'
        }
        /// <summary>
        /// Test the property 'Routing'
        /// </summary>
        [Test]
        public void RoutingTest()
        {
            // TODO unit test for the property 'Routing'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Ticketed'
        /// </summary>
        [Test]
        public void TicketedTest()
        {
            // TODO unit test for the property 'Ticketed'
        }
        /// <summary>
        /// Test the property 'TripType'
        /// </summary>
        [Test]
        public void TripTypeTest()
        {
            // TODO unit test for the property 'TripType'
        }
        /// <summary>
        /// Test the property 'ValidatingCarrier'
        /// </summary>
        [Test]
        public void ValidatingCarrierTest()
        {
            // TODO unit test for the property 'ValidatingCarrier'
        }

    }

}