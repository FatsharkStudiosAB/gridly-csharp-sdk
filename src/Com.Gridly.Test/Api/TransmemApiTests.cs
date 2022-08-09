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
    ///  Class for testing TransmemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransmemApiTests
    {
        private TransmemApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransmemApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransmemApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TransmemApi
            //Assert.IsInstanceOf(typeof(TransmemApi), instance);
        }

        
        /// <summary>
        /// Test Cleanup
        /// </summary>
        [Test]
        public void CleanupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //instance.Cleanup(tmId);
            
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTransMem createTransMem = null;
            //var response = instance.Create(createTransMem);
            //Assert.IsInstanceOf(typeof(TransMem), response, "response is TransMem");
        }
        
        /// <summary>
        /// Test CreateWithFile
        /// </summary>
        [Test]
        public void CreateWithFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //var response = instance.CreateWithFile(file);
            //Assert.IsInstanceOf(typeof(TransMem), response, "response is TransMem");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //var response = instance.Delete(tmId);
            //Assert.IsInstanceOf(typeof(TransMem), response, "response is TransMem");
        }
        
        /// <summary>
        /// Test Export
        /// </summary>
        [Test]
        public void ExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //string sourceLang = null;
            //List<string> targetLangs = null;
            //var response = instance.Export(tmId, sourceLang, targetLangs);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //var response = instance.Get(tmId);
            //Assert.IsInstanceOf(typeof(TransMem), response, "response is TransMem");
        }
        
        /// <summary>
        /// Test ImportTmx
        /// </summary>
        [Test]
        public void ImportTmxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //System.IO.Stream file = null;
            //instance.ImportTmx(tmId, file);
            
        }
        
        /// <summary>
        /// Test ListTM
        /// </summary>
        [Test]
        public void ListTMTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? projectId = null;
            //var response = instance.ListTM(projectId);
            //Assert.IsInstanceOf(typeof(List<TransMem>), response, "response is List<TransMem>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //UpdateTransMem updateTransMem = null;
            //var response = instance.Update(tmId, updateTransMem);
            //Assert.IsInstanceOf(typeof(TransMem), response, "response is TransMem");
        }
        
    }

}
