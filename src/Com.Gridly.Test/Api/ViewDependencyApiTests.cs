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
    ///  Class for testing ViewDependencyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewDependencyApiTests
    {
        private ViewDependencyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ViewDependencyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewDependencyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ViewDependencyApi
            //Assert.IsInstanceOf(typeof(ViewDependencyApi), instance);
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //CreateDependency createDependency = null;
            //var response = instance.Create(viewId, createDependency);
            //Assert.IsInstanceOf(typeof(Dependency), response, "response is Dependency");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //DeleteDependency deleteDependency = null;
            //instance.Delete(viewId, deleteDependency);
            
        }
        
        /// <summary>
        /// Test DeleteById
        /// </summary>
        [Test]
        public void DeleteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //string dependencyId = null;
            //instance.DeleteById(viewId, dependencyId);
            
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dependencyId = null;
            //string viewId = null;
            //var response = instance.Get(dependencyId, viewId);
            //Assert.IsInstanceOf(typeof(Dependency), response, "response is Dependency");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //var response = instance.List(viewId);
            //Assert.IsInstanceOf(typeof(List<Dependency>), response, "response is List<Dependency>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dependencyId = null;
            //string viewId = null;
            //UpdateDependency updateDependency = null;
            //var response = instance.Update(dependencyId, viewId, updateDependency);
            //Assert.IsInstanceOf(typeof(Dependency), response, "response is Dependency");
        }
        
    }

}
