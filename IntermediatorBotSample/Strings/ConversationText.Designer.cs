﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntermediatorBot.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ConversationText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConversationText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IntermediatorBot.Strings.ConversationText", typeof(ConversationText).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To set up an aggregation channel, type &quot;{0}&quot;.
        /// </summary>
        internal static string AddAggregationChannelCommandHint {
            get {
                return ResourceManager.GetString("AddAggregationChannelCommandHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A connection request was made, but the requestor party is null.
        /// </summary>
        internal static string ConnectionRequestMadeButRequestorIsNull {
            get {
                return ResourceManager.GetString("ConnectionRequestMadeButRequestorIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To initiate a conversation with an agent, type &quot;{0}&quot;.
        /// </summary>
        internal static string ConnectRequestCommandHint {
            get {
                return ResourceManager.GetString("ConnectRequestCommandHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You said: {0}.
        /// </summary>
        internal static string EchoMessage {
            get {
                return ResourceManager.GetString("EchoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured (result: {0}).
        /// </summary>
        internal static string ErrorOccuredWithResult {
            get {
                return ResourceManager.GetString("ErrorOccuredWithResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find the bot party on aggregation channel &quot;{0}&quot;.
        /// </summary>
        internal static string FailedToFindBotOnAggregationChannel {
            get {
                return ResourceManager.GetString("FailedToFindBotOnAggregationChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to forward the message.
        /// </summary>
        internal static string FailedToForwardMessage {
            get {
                return ResourceManager.GetString("FailedToForwardMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, there are no agents available right now.
        /// </summary>
        internal static string NoAgentsAvailable {
            get {
                return ResourceManager.GetString("NoAgentsAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No aggregation channel set up.
        /// </summary>
        internal static string NoAggregationChannel {
            get {
                return ResourceManager.GetString("NoAggregationChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your request was accepted and you are now chatting with {0}.
        /// </summary>
        internal static string NotifyClientConnected {
            get {
                return ResourceManager.GetString("NotifyClientConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your conversation with {0} has ended.
        /// </summary>
        internal static string NotifyClientDisconnected {
            get {
                return ResourceManager.GetString("NotifyClientDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your request has already been received, please wait for an agent to respond.
        /// </summary>
        internal static string NotifyClientDuplicateRequest {
            get {
                return ResourceManager.GetString("NotifyClientDuplicateRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unfortunately your request could not be processed.
        /// </summary>
        internal static string NotifyClientRequestRejected {
            get {
                return ResourceManager.GetString("NotifyClientRequestRejected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait for your request to be accepted.
        /// </summary>
        internal static string NotifyClientWaitForRequestHandling {
            get {
                return ResourceManager.GetString("NotifyClientWaitForRequestHandling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are now connected to user &quot;{0}&quot;.
        /// </summary>
        internal static string NotifyOwnerConnected {
            get {
                return ResourceManager.GetString("NotifyOwnerConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are now disconnected from the conversation with user &quot;{0}&quot;.
        /// </summary>
        internal static string NotifyOwnerDisconnected {
            get {
                return ResourceManager.GetString("NotifyOwnerDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request from user &quot;{0}&quot; rejected.
        /// </summary>
        internal static string NotifyOwnerRequestRejected {
            get {
                return ResourceManager.GetString("NotifyOwnerRequestRejected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To see the available commands, type &quot;{0}&quot;.
        /// </summary>
        internal static string OptionsCommandHint {
            get {
                return ResourceManager.GetString("OptionsCommandHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Party &quot;{0}&quot; removed.
        /// </summary>
        internal static string PartyRemoved {
            get {
                return ResourceManager.GetString("PartyRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data of user &quot;{0}&quot; deleted.
        /// </summary>
        internal static string UserDataDeleted {
            get {
                return ResourceManager.GetString("UserDataDeleted", resourceCulture);
            }
        }
    }
}
