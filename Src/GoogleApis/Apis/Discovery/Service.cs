/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Google.Apis.Json;
using Google.Apis.Requests;

namespace Google.Apis.Discovery
{
	// represents a single version of a service
	internal abstract class BaseService:IService
	{
		protected internal JsonDictionary information;
		private Dictionary<string, IResource> resources;

		public string Name {get; private set;}
		public string Version {get; private set;}
		

		internal BaseService (string version, string name, JsonDictionary js)
		{
			this.Version = version;
			this.Name = name;
			this.information = js;
		}

		private BaseService ()
		{
		}

        public abstract DiscoveryVersion DiscoveryVersion{get;}
		public abstract Uri BaseUri {get;}
        public abstract IResource CreateResource(KeyValuePair<string, object> kvp);

		public Uri RpcUri 
		{
			get { return new Uri (this.information[ServiceFactory.RpcUrl] as string); }
		}

		public IDictionary<string, IResource> Resources 
		{
			get 
			{
				if (this.resources == null) 
				{
					JsonDictionary js = this.information[ServiceFactory.Resources] as JsonDictionary;
					if (js != null) 
					{
						this.resources = new Dictionary<string, IResource> ();
						foreach (KeyValuePair<string, object> kvp in js) 
						{
							IResource r = CreateResource(kvp);
							this.resources.Add (kvp.Key, r);
						}
					}
				}
				return this.resources;
			}
		}

		/// <summary>
		/// Creates a Request Object based on the HTTP Method Type.
		/// </summary>
		/// <param name="method">
		/// A <see cref="Method"/>
		/// </param>
		/// <returns>
		/// A <see cref="Request"/>
		/// </returns>
		public IRequest CreateRequest (string resource, string methodName)
		{
			var method = this.Resources[resource].Methods[methodName];
			var request = Request.CreateRequest(this, method);
			
			return request;
		}
	}
    
    internal class ServiceV0_1 : BaseService
    {
        internal ServiceV0_1 (string version, string name, JsonDictionary js):
            base(version, name, js)
        {
            
        }
        
        public override DiscoveryVersion DiscoveryVersion {
            get { return DiscoveryVersion.Version_0_1;}
        }
 
        
        public override Uri BaseUri 
        {
            get { return new Uri (
                    this.information[ServiceFactory.ServiceFactoryDiscoveryV0_1.BaseUrl] as string); }
        }
        
        public override IResource CreateResource (KeyValuePair<string, object> kvp)
        {
            return new ResourceV_0_1(kvp);
        }

    }
    
    internal class ServiceV0_2 : BaseService
    {
        private string ServerUrl{get;set;}
        private readonly Uri baseUri;
        internal ServiceV0_2 (string version, string name, ServiceFactory.FactoryV0_2Parameter param, JsonDictionary js):
            base(version, name, js)
        {
            this.ServerUrl = param.ServerUrl;
            if(param.BaseUrl != null && param.BaseUrl.Length > 0)
            {
                this.baseUri = new Uri(param.BaseUrl);
            } 
            else
            {
                this.baseUri = new Uri (this.ServerUrl +
                    this.information[ServiceFactory.ServiceFactoryDiscoveryV0_2.BaseUrl] as string);
            }
        }
        
        public override DiscoveryVersion DiscoveryVersion 
        {
            get {return DiscoveryVersion.Version_0_2;}
        }
        
        public override Uri BaseUri 
        { 
            get {return baseUri;}
        }
        
        public override IResource CreateResource (KeyValuePair<string, object> kvp)
        {
            return new ResourceV_0_2(kvp);
        }
    }
}
