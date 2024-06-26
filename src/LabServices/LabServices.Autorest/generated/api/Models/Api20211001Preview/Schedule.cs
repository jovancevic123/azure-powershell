// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>
    /// Schedule for automatically turning virtual machines in a lab on and off at specified times.
    /// </summary>
    public partial class Schedule :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ISchedule,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.Resource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleProperties Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ScheduleProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ISchedulePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ISchedulePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for RecurrencePattern</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRecurrencePattern Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleInternal.RecurrencePattern { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePattern; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePattern = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>Notes for this schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string Note { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).Note; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).Note = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleProperties _property;

        /// <summary>Schedule resource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ScheduleProperties()); set => this._property = value; }

        /// <summary>Current provisioning state of the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ISchedulePropertiesInternal)Property).ProvisioningState; }

        /// <summary>When the recurrence will expire. This date is inclusive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecurrencePatternExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternExpirationDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternExpirationDate = value ?? default(global::System.DateTime); }

        /// <summary>The frequency of the recurrence.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RecurrenceFrequency? RecurrencePatternFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternFrequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternFrequency = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RecurrenceFrequency)""); }

        /// <summary>
        /// The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days.
        /// When no interval is supplied, an interval of 1 is used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public int? RecurrencePatternInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternInterval; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternInterval = value ?? default(int); }

        /// <summary>The week days the schedule runs. Used for when the Frequency is set to Weekly.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay[] RecurrencePatternWeekDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternWeekDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).RecurrencePatternWeekDay = value ?? null /* arrayOf */; }

        /// <summary>
        /// When lab user virtual machines will be started. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).StartAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).StartAt = value ?? default(global::System.DateTime); }

        /// <summary>
        /// When lab user virtual machines will be stopped. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? StopAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).StopAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).StopAt = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType)""); }

        /// <summary>The IANA timezone id for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string TimeZoneId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).TimeZoneId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)Property).TimeZoneId = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Schedule" /> instance.</summary>
        public Schedule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Schedule for automatically turning virtual machines in a lab on and off at specified times.
    public partial interface ISchedule :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResource
    {
        /// <summary>Notes for this schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Notes for this schedule.",
        SerializedName = @"notes",
        PossibleTypes = new [] { typeof(string) })]
        string Note { get; set; }
        /// <summary>Current provisioning state of the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current provisioning state of the schedule.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>When the recurrence will expire. This date is inclusive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When the recurrence will expire. This date is inclusive.",
        SerializedName = @"expirationDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecurrencePatternExpirationDate { get; set; }
        /// <summary>The frequency of the recurrence.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The frequency of the recurrence.",
        SerializedName = @"frequency",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RecurrenceFrequency) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RecurrenceFrequency? RecurrencePatternFrequency { get; set; }
        /// <summary>
        /// The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days.
        /// When no interval is supplied, an interval of 1 is used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days. When no interval is supplied, an interval of 1 is used.",
        SerializedName = @"interval",
        PossibleTypes = new [] { typeof(int) })]
        int? RecurrencePatternInterval { get; set; }
        /// <summary>The week days the schedule runs. Used for when the Frequency is set to Weekly.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The week days the schedule runs. Used for when the Frequency is set to Weekly.",
        SerializedName = @"weekDays",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay[] RecurrencePatternWeekDay { get; set; }
        /// <summary>
        /// When lab user virtual machines will be started. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When lab user virtual machines will be started. Timestamp offsets will be ignored and timeZoneId is used instead.",
        SerializedName = @"startAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartAt { get; set; }
        /// <summary>
        /// When lab user virtual machines will be stopped. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When lab user virtual machines will be stopped. Timestamp offsets will be ignored and timeZoneId is used instead.",
        SerializedName = @"stopAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StopAt { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The IANA timezone id for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IANA timezone id for the schedule.",
        SerializedName = @"timeZoneId",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZoneId { get; set; }

    }
    /// Schedule for automatically turning virtual machines in a lab on and off at specified times.
    internal partial interface IScheduleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal
    {
        /// <summary>Notes for this schedule.</summary>
        string Note { get; set; }
        /// <summary>Schedule resource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleProperties Property { get; set; }
        /// <summary>Current provisioning state of the schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The recurrence pattern of the scheduled actions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRecurrencePattern RecurrencePattern { get; set; }
        /// <summary>When the recurrence will expire. This date is inclusive.</summary>
        global::System.DateTime? RecurrencePatternExpirationDate { get; set; }
        /// <summary>The frequency of the recurrence.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RecurrenceFrequency? RecurrencePatternFrequency { get; set; }
        /// <summary>
        /// The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days.
        /// When no interval is supplied, an interval of 1 is used.
        /// </summary>
        int? RecurrencePatternInterval { get; set; }
        /// <summary>The week days the schedule runs. Used for when the Frequency is set to Weekly.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay[] RecurrencePatternWeekDay { get; set; }
        /// <summary>
        /// When lab user virtual machines will be started. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        global::System.DateTime? StartAt { get; set; }
        /// <summary>
        /// When lab user virtual machines will be stopped. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        global::System.DateTime? StopAt { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The IANA timezone id for the schedule.</summary>
        string TimeZoneId { get; set; }

    }
}