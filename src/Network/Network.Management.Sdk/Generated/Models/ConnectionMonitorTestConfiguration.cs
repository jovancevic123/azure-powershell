// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a connection monitor test configuration.
    /// </summary>
    public partial class ConnectionMonitorTestConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorTestConfiguration class.
        /// </summary>
        public ConnectionMonitorTestConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorTestConfiguration class.
        /// </summary>

        /// <param name="name">The name of the connection monitor test configuration.
        /// </param>

        /// <param name="testFrequencySec">The frequency of test evaluation, in seconds.
        /// </param>

        /// <param name="protocol">The protocol to use in test evaluation.
        /// Possible values include: &#39;Tcp&#39;, &#39;Http&#39;, &#39;Icmp&#39;</param>

        /// <param name="preferredIPVersion">The preferred IP version to use in test evaluation. The connection monitor
        /// may choose to use a different version depending on other parameters.
        /// Possible values include: &#39;IPv4&#39;, &#39;IPv6&#39;</param>

        /// <param name="httpConfiguration">The parameters used to perform test evaluation over HTTP.
        /// </param>

        /// <param name="tcpConfiguration">The parameters used to perform test evaluation over TCP.
        /// </param>

        /// <param name="icmpConfiguration">The parameters used to perform test evaluation over ICMP.
        /// </param>

        /// <param name="successThreshold">The threshold for declaring a test successful.
        /// </param>
        public ConnectionMonitorTestConfiguration(string name, string protocol, int? testFrequencySec = default(int?), string preferredIPVersion = default(string), ConnectionMonitorHttpConfiguration httpConfiguration = default(ConnectionMonitorHttpConfiguration), ConnectionMonitorTcpConfiguration tcpConfiguration = default(ConnectionMonitorTcpConfiguration), ConnectionMonitorIcmpConfiguration icmpConfiguration = default(ConnectionMonitorIcmpConfiguration), ConnectionMonitorSuccessThreshold successThreshold = default(ConnectionMonitorSuccessThreshold))

        {
            this.Name = name;
            this.TestFrequencySec = testFrequencySec;
            this.Protocol = protocol;
            this.PreferredIPVersion = preferredIPVersion;
            this.HttpConfiguration = httpConfiguration;
            this.TcpConfiguration = tcpConfiguration;
            this.IcmpConfiguration = icmpConfiguration;
            this.SuccessThreshold = successThreshold;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the connection monitor test configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the frequency of test evaluation, in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "testFrequencySec")]
        public int? TestFrequencySec {get; set; }

        /// <summary>
        /// Gets or sets the protocol to use in test evaluation. Possible values include: &#39;Tcp&#39;, &#39;Http&#39;, &#39;Icmp&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protocol")]
        public string Protocol {get; set; }

        /// <summary>
        /// Gets or sets the preferred IP version to use in test evaluation. The
        /// connection monitor may choose to use a different version depending on other
        /// parameters. Possible values include: &#39;IPv4&#39;, &#39;IPv6&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "preferredIPVersion")]
        public string PreferredIPVersion {get; set; }

        /// <summary>
        /// Gets or sets the parameters used to perform test evaluation over HTTP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "httpConfiguration")]
        public ConnectionMonitorHttpConfiguration HttpConfiguration {get; set; }

        /// <summary>
        /// Gets or sets the parameters used to perform test evaluation over TCP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tcpConfiguration")]
        public ConnectionMonitorTcpConfiguration TcpConfiguration {get; set; }

        /// <summary>
        /// Gets or sets the parameters used to perform test evaluation over ICMP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "icmpConfiguration")]
        public ConnectionMonitorIcmpConfiguration IcmpConfiguration {get; set; }

        /// <summary>
        /// Gets or sets the threshold for declaring a test successful.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "successThreshold")]
        public ConnectionMonitorSuccessThreshold SuccessThreshold {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.Protocol == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Protocol");
            }



            if (this.HttpConfiguration != null)
            {
                this.HttpConfiguration.Validate();
            }
            if (this.TcpConfiguration != null)
            {
                this.TcpConfiguration.Validate();
            }


        }
    }
}