﻿//-----------------------------------------------------------------------
// <copyright file="<file>.cs" company="The Outercurve Foundation">
//    Copyright (c) 2011, The Outercurve Foundation. 
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// <author>Nathan Totten (ntotten.com), Jim Zimmerman (jimzimmerman.com) and Prabir Shrestha (prabir.me)</author>
// <website>https://github.com/facebook-csharp-sdk/facbook-csharp-sdk</website>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Facebook.Tests.Mocks
{
    public class HttpRequestMock : HttpRequestBase
    {

        public override Uri Url
        {
            get
            {
                return base.Url;
            }
        }

        public override System.Collections.Specialized.NameValueCollection Headers
        {
            get
            {
                return base.Headers;
            }
        }

        public override HttpCookieCollection Cookies
        {
            get
            {
                return base.Cookies;
            }
        }

        public override System.Collections.Specialized.NameValueCollection Params
        {
            get
            {
                return base.Params;
            }
        }

    }
}
