/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        private UserApi instance;

        public UserApiTests()
        {
            instance = new UserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserApi
            //Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Fact]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User user = null;
            //instance.CreateUser(user);
        }

        /// <summary>
        /// Test CreateUsersWithArrayInput
        /// </summary>
        [Fact]
        public void CreateUsersWithArrayInputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<User> user = null;
            //instance.CreateUsersWithArrayInput(user);
        }

        /// <summary>
        /// Test CreateUsersWithListInput
        /// </summary>
        [Fact]
        public void CreateUsersWithListInputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<User> user = null;
            //instance.CreateUsersWithListInput(user);
        }

        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Fact]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.DeleteUser(username);
        }

        /// <summary>
        /// Test GetUserByName
        /// </summary>
        [Fact]
        public void GetUserByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetUserByName(username);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test LoginUser
        /// </summary>
        [Fact]
        public void LoginUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //var response = instance.LoginUser(username, password);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test LogoutUser
        /// </summary>
        [Fact]
        public void LogoutUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.LogoutUser();
        }

        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Fact]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //User user = null;
            //instance.UpdateUser(username, user);
        }
    }
}