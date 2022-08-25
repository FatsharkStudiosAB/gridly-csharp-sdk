/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.32.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Com.Gridly.Client;
using Com.Gridly.Api;
using Com.Gridly.Model;

namespace Com.Gridly.Test
{
    /// <summary>
    ///  Class for testing RecordApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RecordApiTests
    {
        private RecordApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecordApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecordApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' RecordApi
            //Assert.IsInstanceOf(typeof(RecordApi), instance);
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //List<SetRecord> createRecords = null;
            //var response = instance.Create(viewId, createRecords);
            //Assert.IsInstanceOf(typeof(List<Record>), response, "response is List<Record>");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //DeleteRecord deleteRecord = null;
            //instance.Delete(viewId, deleteRecord);
            
        }
        
        /// <summary>
        /// Test Fetch
        /// </summary>
        [Test]
        public void FetchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //List<string> columnIds = null;
            //string page = null;
            //string query = null;
            //string sort = null;
            //FetchFileOption? fetchFileOption = null;
            //var response = instance.Fetch(viewId, columnIds, page, query, sort, fetchFileOption);
            //Assert.IsInstanceOf(typeof(List<Record>), response, "response is List<Record>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //List<SetRecord> setRecord = null;
            //var response = instance.Update(viewId, setRecord);
            //Assert.IsInstanceOf(typeof(List<Record>), response, "response is List<Record>");
        }
        
        /// <summary>
        /// Test UpdateRecord
        /// </summary>
        [Test]
        public void UpdateRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string viewId = null;
            //SetRecord setRecord = null;
            //string path = null;
            //var response = instance.UpdateRecord(id, viewId, setRecord, path);
            //Assert.IsInstanceOf(typeof(Record), response, "response is Record");
        }
        
    }

}
