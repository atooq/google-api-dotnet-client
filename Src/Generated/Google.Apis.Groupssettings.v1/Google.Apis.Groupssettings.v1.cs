// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.10.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Groups Settings API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/google-apps/groups-settings/get_started'>Groups Settings API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20140428 (0)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/google-apps/groups-settings/get_started'>
 *              https://developers.google.com/google-apps/groups-settings/get_started</a>
 *      <tr><th>Discovery Name<td>groupssettings
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Groups Settings API can be found at
 * <a href='https://developers.google.com/google-apps/groups-settings/get_started'>https://developers.google.com/google-apps/groups-settings/get_started</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Groupssettings.v1
{
    /// <summary>The Groupssettings Service.</summary>
    public class GroupssettingsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GroupssettingsService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GroupssettingsService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            groups = new GroupsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "groupssettings"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/groups/v1/groups/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "groups/v1/groups/"; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the Groups Settings API.</summary>
        public class Scope
        {
            /// <summary>View and manage the settings of a Google Apps Group</summary>
            public static string AppsGroupsSettings = "https://www.googleapis.com/auth/apps.groups.settings";

        }



        private readonly GroupsResource groups;

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups
        {
            get { return groups; }
        }
    }

    ///<summary>A base abstract class for Groupssettings requests.</summary>
    public abstract class GroupssettingsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new GroupssettingsBaseServiceRequest instance.</summary>
        protected GroupssettingsBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: atom]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/atom+xml</summary>
            [Google.Apis.Util.StringValueAttribute("atom")]
            Atom,
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Groupssettings parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "atom",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "groups" collection of methods.</summary>
    public class GroupsResource
    {
        private const string Resource = "groups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GroupsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets one resource by id.</summary>
        /// <param name="groupUniqueId">The resource ID</param>
        public virtual GetRequest Get(string groupUniqueId)
        {
            return new GetRequest(service, groupUniqueId);
        }

        /// <summary>Gets one resource by id.</summary>
        public class GetRequest : GroupssettingsBaseServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string groupUniqueId)
                : base(service)
            {
                GroupUniqueId = groupUniqueId;
                InitParameters();
            }


            /// <summary>The resource ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{groupUniqueId}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupUniqueId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupUniqueId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates an existing resource. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupUniqueId">The resource ID</param>
        public virtual PatchRequest Patch(Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId)
        {
            return new PatchRequest(service, body, groupUniqueId);
        }

        /// <summary>Updates an existing resource. This method supports patch semantics.</summary>
        public class PatchRequest : GroupssettingsBaseServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId)
                : base(service)
            {
                GroupUniqueId = groupUniqueId;
                Body = body;
                InitParameters();
            }


            /// <summary>The resource ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Groupssettings.v1.Data.Groups Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "patch"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PATCH"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{groupUniqueId}"; }
            }

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupUniqueId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupUniqueId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupUniqueId">The resource ID</param>
        public virtual UpdateRequest Update(Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId)
        {
            return new UpdateRequest(service, body, groupUniqueId);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : GroupssettingsBaseServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId)
                : base(service)
            {
                GroupUniqueId = groupUniqueId;
                Body = body;
                InitParameters();
            }


            /// <summary>The resource ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Groupssettings.v1.Data.Groups Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "update"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PUT"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{groupUniqueId}"; }
            }

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupUniqueId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupUniqueId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Groupssettings.v1.Data
{    

    /// <summary>JSON template for Group resource</summary>
    public class Groups : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Are external members allowed to join the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExternalMembers")]
        public virtual string AllowExternalMembers { get; set; } 

        /// <summary>Is google allowed to contact admins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGoogleCommunication")]
        public virtual string AllowGoogleCommunication { get; set; } 

        /// <summary>If posting from web is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowWebPosting")]
        public virtual string AllowWebPosting { get; set; } 

        /// <summary>If the group is archive only</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveOnly")]
        public virtual string ArchiveOnly { get; set; } 

        /// <summary>Default email to which reply to any message should go.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customReplyTo")]
        public virtual string CustomReplyTo { get; set; } 

        /// <summary>Default message deny notification message</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMessageDenyNotificationText")]
        public virtual string DefaultMessageDenyNotificationText { get; set; } 

        /// <summary>Description of the group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Email id of the group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>If this groups should be included in global address list or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeInGlobalAddressList")]
        public virtual string IncludeInGlobalAddressList { get; set; } 

        /// <summary>If the contents of the group are archived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isArchived")]
        public virtual string IsArchived { get; set; } 

        /// <summary>The type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Maximum message size allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMessageBytes")]
        public virtual System.Nullable<int> MaxMessageBytes { get; set; } 

        /// <summary>Can members post using the group email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membersCanPostAsTheGroup")]
        public virtual string MembersCanPostAsTheGroup { get; set; } 

        /// <summary>Default message display font. Possible values are: DEFAULT_FONT FIXED_WIDTH_FONT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageDisplayFont")]
        public virtual string MessageDisplayFont { get; set; } 

        /// <summary>Moderation level for messages. Possible values are: MODERATE_ALL_MESSAGES MODERATE_NON_MEMBERS
        /// MODERATE_NEW_MEMBERS MODERATE_NONE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageModerationLevel")]
        public virtual string MessageModerationLevel { get; set; } 

        /// <summary>Name of the Group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Primary language for the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryLanguage")]
        public virtual string PrimaryLanguage { get; set; } 

        /// <summary>Whome should the default reply to a message go to. Possible values are: REPLY_TO_CUSTOM
        /// REPLY_TO_SENDER REPLY_TO_LIST REPLY_TO_OWNER REPLY_TO_IGNORE REPLY_TO_MANAGERS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyTo")]
        public virtual string ReplyTo { get; set; } 

        /// <summary>Should the member be notified if his message is denied by owner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendMessageDenyNotification")]
        public virtual string SendMessageDenyNotification { get; set; } 

        /// <summary>Is the group listed in groups directory</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showInGroupDirectory")]
        public virtual string ShowInGroupDirectory { get; set; } 

        /// <summary>Moderation level for messages detected as spam. Possible values are: ALLOW MODERATE
        /// SILENTLY_MODERATE REJECT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spamModerationLevel")]
        public virtual string SpamModerationLevel { get; set; } 

        /// <summary>Permission to contact owner of the group via web UI. Possbile values are: ANYONE_CAN_CONTACT
        /// ALL_IN_DOMAIN_CAN_CONTACT ALL_MEMBERS_CAN_CONTACT ALL_MANAGERS_CAN_CONTACT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanContactOwner")]
        public virtual string WhoCanContactOwner { get; set; } 

        /// <summary>Permissions to invite members. Possbile values are: ALL_MEMBERS_CAN_INVITE
        /// ALL_MANAGERS_CAN_INVITE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanInvite")]
        public virtual string WhoCanInvite { get; set; } 

        /// <summary>Permissions to join the group. Possible values are: ANYONE_CAN_JOIN ALL_IN_DOMAIN_CAN_JOIN
        /// INVITED_CAN_JOIN CAN_REQUEST_TO_JOIN</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanJoin")]
        public virtual string WhoCanJoin { get; set; } 

        /// <summary>Permission to leave the group. Possible values are: ALL_MANAGERS_CAN_LEAVE
        /// ALL_MEMBERS_CAN_LEAVE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanLeaveGroup")]
        public virtual string WhoCanLeaveGroup { get; set; } 

        /// <summary>Permissions to post messages to the group. Possible values are: NONE_CAN_POST ALL_MANAGERS_CAN_POST
        /// ALL_MEMBERS_CAN_POST ALL_IN_DOMAIN_CAN_POST ANYONE_CAN_POST</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanPostMessage")]
        public virtual string WhoCanPostMessage { get; set; } 

        /// <summary>Permissions to view group. Possbile values are: ANYONE_CAN_VIEW ALL_IN_DOMAIN_CAN_VIEW
        /// ALL_MEMBERS_CAN_VIEW ALL_MANAGERS_CAN_VIEW</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanViewGroup")]
        public virtual string WhoCanViewGroup { get; set; } 

        /// <summary>Permissions to view membership. Possbile values are: ALL_IN_DOMAIN_CAN_VIEW ALL_MEMBERS_CAN_VIEW
        /// ALL_MANAGERS_CAN_VIEW</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanViewMembership")]
        public virtual string WhoCanViewMembership { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}