// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwaggerPetstore.Standard;
using SwaggerPetstore.Standard.Authentication;
using SwaggerPetstore.Standard.Http.Client;
using SwaggerPetstore.Standard.Models;

namespace SwaggerPetstore.Tests
{
    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallback HttpCallBack { get; private set; } = new HttpCallback();

        /// <summary>
        /// Gets SwaggerPetstoreClient Client.
        /// </summary>
        protected SwaggerPetstoreClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            SwaggerPetstoreClient config = SwaggerPetstoreClient.CreateFromEnvironment();
            this.Client = config.ToBuilder()
                .HttpCallback(HttpCallBack)
                .HttpBasicCredentials(new HttpBasicModel.Builder("test", "testPassword").Build())
                .Build();
        }
    }
}