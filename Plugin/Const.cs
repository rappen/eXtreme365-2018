// *********************************************************************
// Created by: Latebound Constant Generator 1.2018.2.2 for XrmToolBox
// Author    : Jonas Rapp http://twitter.com/rappen
// Repo      : https://github.com/rappen/LateboundConstantGenerator
// Source Org: https://jonasdev.crm4.dynamics.com/
// Filename  : C:\Dev\Lab\eXtreme2\Plugin\Const.cs
// Created   : 2018-03-14 14:26:08
// *********************************************************************

namespace Plugin
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Account
    {
        public const string EntityName = "account";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "accountid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 160, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 20, Format: Text</summary>
        public const string AccountNumber = "accountnumber";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Account Rating, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string AccountRating = "accountratingcode";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string Aging30 = "aging30";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: aging30</summary>
        public const string Aging30Base = "aging30_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string Aging60 = "aging60";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: aging60</summary>
        public const string Aging60Base = "aging60_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string Aging90 = "aging90";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: aging90</summary>
        public const string Aging90Base = "aging90_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: revenue</summary>
        public const string AnnualRevenueBase = "revenue_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string AnnualRevenue = "revenue";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Business Type, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string BusinessType = "businesstypecode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Category, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Category = "accountcategorycode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Classification, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Classification = "accountclassificationcode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedByDelegate = "createdonbehalfby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: externalparty</summary>
        public const string CreatedByExternalParty = "createdbyexternalparty";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string CreditHold = "creditonhold";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: creditlimit</summary>
        public const string CreditLimitBase = "creditlimit_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string CreditLimit = "creditlimit";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Size, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string CustomerSize = "customersizecode";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "description";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowBulkEmails = "donotbulkemail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowBulkMails = "donotbulkpostalmail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowEmails = "donotemail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowFaxes = "donotfax";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowMails = "donotpostalmail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowPhoneCalls = "donotphone";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string Email = "emailaddress1";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress2 = "emailaddress2";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress3 = "emailaddress3";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string EntityImageId = "entityimageid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0,0000000001, MaxValue: 100000000000, Precision: 10</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Fax = "fax";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: True</summary>
        public const string FollowEmailActivity = "followemail";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Url</summary>
        public const string FTPSite = "ftpsiteurl";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string ImportSequenceNumber = "importsequencenumber";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Industry, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Industry = "industrycode";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string isprivate = "isprivate";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string LastDateIncludedinCampaign = "lastusedincampaign";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string MainPhone = "telephone1";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: marketcap</summary>
        public const string MarketCapitalizationBase = "marketcap_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string MarketCapitalization = "marketcap";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string MarketingOnly = "marketingonly";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account</summary>
        public const string MasterID = "masterid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Merged = "merged";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedByDelegate = "modifiedonbehalfby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: externalparty</summary>
        public const string ModifiedByExternalParty = "modifiedbyexternalparty";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string NumberofEmployees = "numberofemployees";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string OpenDealsLastUpdatedOn = "opendeals_date";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OpenDeals = "opendeals";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OpenDealsState = "opendeals_state";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2, CalculationOf: openrevenue</summary>
        public const string OpenRevenueBase = "openrevenue_base";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string OpenRevenueLastUpdatedOn = "openrevenue_date";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string OpenRevenue = "openrevenue";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OpenRevenueState = "openrevenue_state";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: lead</summary>
        public const string OriginatingLead = "originatingleadid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string OtherPhone = "telephone2";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: EntityName, RequiredLevel: SystemRequired</summary>
        public const string owneridtype = "owneridtype";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Ownership, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Ownership = "ownershipcode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: businessunit</summary>
        public const string OwningBusinessUnit = "owningbusinessunit";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account</summary>
        public const string ParentAccount = "parentaccountid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ParticipatesinWorkflow = "participatesinworkflow";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Payment Terms, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PaymentTerms = "paymenttermscode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Day, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PreferredDay = "preferredappointmentdaycode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: equipment</summary>
        public const string PreferredFacility_Equipment = "preferredequipmentid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Method of Contact, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string PreferredMethodofContact = "preferredcontactmethodcode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: service</summary>
        public const string PreferredService = "preferredserviceid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Time, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PreferredTime = "preferredappointmenttimecode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string PreferredUser = "preferredsystemuserid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: pricelevel</summary>
        public const string PriceList = "defaultpricelevelid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: contact</summary>
        public const string PrimaryContact = "primarycontactid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string PrimarySatoriID = "primarysatoriid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string PrimaryTwitterID = "primarytwitterid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Process = "processid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ProcessStage = "stageid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RecordCreatedOn = "overriddencreatedon";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Type, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string RelationshipType = "customertypecode";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string SendMarketingMaterials = "donotsendmm";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string SharesOutstanding = "sharesoutstanding";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string ShippingMethod = "shippingmethodcode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 20, Format: Text</summary>
        public const string SICCode = "sic";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 20, Format: Text</summary>
        public const string StockExchange = "stockexchange";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Telephone3 = "telephone3";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: territory</summary>
        public const string Territory = "territoryid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Territory Code, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string TerritoryCode = "territorycode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 10, Format: TickerSymbol</summary>
        public const string TickerSymbol = "tickersymbol";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string TimeSpentbyme = "timespentbymeonemailandmeetings";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string TraversedPath = "traversedpath";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Url</summary>
        public const string Website = "websiteurl";
        /// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9223372036854775808, MaxValue: 9223372036854775807</summary>
        public const string VersionNumber = "versionnumber";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 160, Format: PhoneticGuide</summary>
        public const string YomiAccountName = "yominame";
        public enum AccountRating_OptionSet
        {
            DefaultValue = 1
        }
        public enum BusinessType_OptionSet
        {
            DefaultValue = 1
        }
        public enum Category_OptionSet
        {
            PreferredCustomer = 1,
            Standard = 2
        }
        public enum Classification_OptionSet
        {
            DefaultValue = 1
        }
        public enum CustomerSize_OptionSet
        {
            DefaultValue = 1
        }
        public enum Industry_OptionSet
        {
            Accounting = 1,
            AgricultureandNon_petrolNaturalResourceExtraction = 2,
            BroadcastingPrintingandPublishing = 3,
            Brokers = 4,
            BuildingSupplyRetail = 5,
            BusinessServices = 6,
            Consulting = 7,
            ConsumerServices = 8,
            DesignDirectionandCreativeManagement = 9,
            DistributorsDispatchersandProcessors = 10,
            DoctorsOfficesandClinics = 11,
            DurableManufacturing = 12,
            EatingandDrinkingPlaces = 13,
            EntertainmentRetail = 14,
            EquipmentRentalandLeasing = 15,
            Financial = 16,
            FoodandTobaccoProcessing = 17,
            InboundCapitalIntensiveProcessing = 18,
            InboundRepairandServices = 19,
            Insurance = 20,
            LegalServices = 21,
            Non_DurableMerchandiseRetail = 22,
            OutboundConsumerService = 23,
            PetrochemicalExtractionandDistribution = 24,
            ServiceRetail = 25,
            SIGAffiliations = 26,
            SocialServices = 27,
            SpecialOutboundTradeContractors = 28,
            SpecialtyRealty = 29,
            Transportation = 30,
            UtilityCreationandDistribution = 31,
            VehicleRetail = 32,
            Wholesale = 33
        }
        public enum owneridtype_OptionSet
        {
        }
        public enum Ownership_OptionSet
        {
            Public = 1,
            Private = 2,
            Subsidiary = 3,
            Other = 4
        }
        public enum PaymentTerms_OptionSet
        {
            Net30 = 1,
            _210Net30 = 2,
            Net45 = 3,
            Net60 = 4
        }
        public enum PreferredDay_OptionSet
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }
        public enum PreferredMethodofContact_OptionSet
        {
            Any = 1,
            Email = 2,
            Phone = 3,
            Fax = 4,
            Mail = 5
        }
        public enum PreferredTime_OptionSet
        {
            Morning = 1,
            Afternoon = 2,
            Evening = 3
        }
        public enum RelationshipType_OptionSet
        {
            Competitor = 1,
            Consultant = 2,
            Customer = 3,
            Investor = 4,
            Partner = 5,
            Influencer = 6,
            Press = 7,
            Prospect = 8,
            Reseller = 9,
            Supplier = 10,
            Vendor = 11,
            Other = 12
        }
        public enum ShippingMethod_OptionSet
        {
            DefaultValue = 1
        }
        public enum Status_OptionSet
        {
            Active = 0,
            Inactive = 1
        }
        public enum StatusReason_OptionSet
        {
            Active = 1,
            Inactive = 2
        }
        public enum TerritoryCode_OptionSet
        {
            DefaultValue = 1
        }
    }

    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Case
    {
        public const string EntityName = "incident";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "incidentid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 200, Format: Text</summary>
        public const string PrimaryName = "title";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ActivitiesComplete = "activitiescomplete";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string ActualServiceUnits = "actualserviceunits";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string BilledServiceUnits = "billedserviceunits";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string BlockedProfile = "blockedprofile";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string CaseNumber = "ticketnumber";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Stage, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string CaseStage = "incidentstagecode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Type, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string CaseType = "casetypecode";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string CheckEmail = "checkemail";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: contact</summary>
        public const string Contact = "primarycontactid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: contract</summary>
        public const string Contract = "contractid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: contractdetail</summary>
        public const string ContractLine = "contractdetailid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedByDelegate = "createdonbehalfby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: externalparty</summary>
        public const string CreatedByExternalParty = "createdbyexternalparty";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: Customer, RequiredLevel: SystemRequired, Targets: account,contact</summary>
        public const string Customer = "customerid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string CustomerContacted = "customercontacted";
        /// <summary>Type: EntityName, RequiredLevel: ApplicationRequired</summary>
        public const string CustomerType = "customeridtype";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 160, Format: Text</summary>
        public const string customeridname = "customeridname";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 450, Format: Text</summary>
        public const string customeridyominame = "customeridyominame";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: True</summary>
        public const string DecrementEntitlementTerms = "decremententitlementterm";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Decrementing = "isdecrementing";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "description";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress = "emailaddress";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: entitlement</summary>
        public const string Entitlement = "entitlementid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string entityimageid = "entityimageid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string EscalatedOn = "escalatedon";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0,0000000001, MaxValue: 100000000000, Precision: 10</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: incident</summary>
        public const string ExistingCase = "existingcase";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string FirstResponseBy = "responseby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: slakpiinstance</summary>
        public const string FirstResponseByKPI = "firstresponsebykpiid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string FirstResponseSent = "firstresponsesent";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: First Response SLA Status, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string FirstResponseSLAStatus = "firstresponseslastatus";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string FollowUpBy = "followupby";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string FollowupTaskCreated = "followuptaskcreated";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string ImportSequenceNumber = "importsequencenumber";
        /// <summary>Type: Double, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000, Precision: 2</summary>
        public const string InfluenceScore = "influencescore";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string InternalUseOnly = "merged";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsEscalated = "isescalated";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: kbarticle</summary>
        public const string KnowledgeBaseArticle = "kbarticleid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: incident</summary>
        public const string MasterCase = "masterid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedByDelegate = "modifiedonbehalfby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: externalparty</summary>
        public const string ModifiedByExternalParty = "modifiedbyexternalparty";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Case Origin, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Origin = "caseorigincode";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: EntityName, RequiredLevel: SystemRequired</summary>
        public const string owneridtype = "owneridtype";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: businessunit</summary>
        public const string OwningBusinessUnit = "owningbusinessunit";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: incident</summary>
        public const string ParentCase = "parentcaseid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, OptionSetType: Picklist, DefaultFormValue: 2</summary>
        public const string Priority = "prioritycode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ProcessId = "processid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: product</summary>
        public const string Product = "productid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Post Message type, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ReceivedAs = "messagetypecode";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RecordCreatedOn = "overriddencreatedon";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ResolveBy = "resolveby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: slakpiinstance</summary>
        public const string ResolveByKPI = "resolvebykpiid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: ResolveBy SLA Status, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string ResolveBySLAStatus = "resolvebyslastatus";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: contact</summary>
        public const string ResponsibleContact = "responsiblecontactid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: True</summary>
        public const string RouteCase = "routecase";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Satisfaction, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Satisfaction = "customersatisfactioncode";
        /// <summary>Type: Double, RequiredLevel: None, MinValue: -100000000000, MaxValue: 100000000000, Precision: 2</summary>
        public const string SentimentValue = "sentimentvalue";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string SerialNumber = "productserialnumber";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Level, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ServiceLevel = "contractservicelevelcode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Service Stage, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ServiceStage = "servicestage";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Severity, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Severity = "severitycode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: socialprofile</summary>
        public const string SocialProfile = "socialprofileid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string StageId = "stageid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: subject</summary>
        public const string Subject = "subjectid";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string TraversedPath = "traversedpath";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
        /// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9223372036854775808, MaxValue: 9223372036854775807</summary>
        public const string VersionNumber = "versionnumber";
        public enum CaseStage_OptionSet
        {
            DefaultValue = 1
        }
        public enum CaseType_OptionSet
        {
            Question = 1,
            Problem = 2,
            Request = 3
        }
        public enum CustomerType_OptionSet
        {
        }
        public enum FirstResponseSLAStatus_OptionSet
        {
            InProgress = 1,
            NearingNoncompliance = 2,
            Succeeded = 3,
            Noncompliant = 4
        }
        public enum Origin_OptionSet
        {
            Phone = 1,
            Email = 2,
            Web = 3,
            Facebook = 2483,
            Twitter = 3986
        }
        public enum owneridtype_OptionSet
        {
        }
        public enum Priority_OptionSet
        {
            High = 1,
            Normal = 2,
            Low = 3
        }
        public enum ReceivedAs_OptionSet
        {
            PublicMessage = 0,
            PrivateMessage = 1
        }
        public enum ResolveBySLAStatus_OptionSet
        {
            InProgress = 1,
            NearingNoncompliance = 2,
            Succeeded = 3,
            Noncompliant = 4
        }
        public enum Satisfaction_OptionSet
        {
            VerySatisfied = 5,
            Satisfied = 4,
            Neutral = 3,
            Dissatisfied = 2,
            VeryDissatisfied = 1
        }
        public enum ServiceLevel_OptionSet
        {
            Gold = 1,
            Silver = 2,
            Bronze = 3
        }
        public enum ServiceStage_OptionSet
        {
            Identify = 0,
            Research = 1,
            Resolve = 2
        }
        public enum Severity_OptionSet
        {
            DefaultValue = 1
        }
        public enum Status_OptionSet
        {
            Active = 0,
            Resolved = 1,
            Canceled = 2
        }
        public enum StatusReason_OptionSet
        {
            ProblemSolved = 5,
            InformationProvided = 1000,
            Canceled = 6,
            Merged = 2000,
            InProgress = 1,
            OnHold = 2,
            WaitingforDetails = 3,
            Researching = 4
        }
    }

    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Contact
    {
        public const string EntityName = "contact";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "contactid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 160, Format: Text</summary>
        public const string PrimaryName = "fullname";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string Aging30 = "aging30";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: aging30</summary>
        public const string Aging30Base = "aging30_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string Aging60 = "aging60";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: aging60</summary>
        public const string Aging60Base = "aging60_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string Aging90 = "aging90";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: aging90</summary>
        public const string Aging90Base = "aging90_base";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: DateOnly</summary>
        public const string Anniversary = "anniversary";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string AnnualIncome = "annualincome";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: annualincome</summary>
        public const string AnnualIncomeBase = "annualincome_base";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Assistant = "assistantname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string AssistantPhone = "assistantphone";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Auto_created = "isautocreate";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string BackOfficeCustomer = "isbackofficecustomer";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: DateOnly</summary>
        public const string Birthday = "birthdate";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string BusinessPhone = "telephone1";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string BusinessPhone2 = "business2";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string CallbackNumber = "callback";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 255, Format: Text</summary>
        public const string ChildrensNames = "childrensnames";
        /// <summary>Type: Customer, RequiredLevel: None, Targets: account,contact</summary>
        public const string CompanyName = "parentcustomerid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string CompanyPhone = "company";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedByDelegate = "createdonbehalfby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: externalparty</summary>
        public const string CreatedByExternalParty = "createdbyexternalparty";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string CreditHold = "creditonhold";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: creditlimit</summary>
        public const string CreditLimitBase = "creditlimit_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 100000000000000, Precision: 2</summary>
        public const string CreditLimit = "creditlimit";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Size, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string CustomerSize = "customersizecode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Department = "department";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "description";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowBulkEmails = "donotbulkemail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowBulkMails = "donotbulkpostalmail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowEmails = "donotemail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowFaxes = "donotfax";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowMails = "donotpostalmail";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowPhoneCalls = "donotphone";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Education, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Education = "educationcode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string Email = "emailaddress1";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress2 = "emailaddress2";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress3 = "emailaddress3";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Employee = "employeeid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string EntityImageId = "entityimageid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0,0000000001, MaxValue: 100000000000, Precision: 10</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string ExternalUserIdentifier = "externaluseridentifier";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Fax = "fax";
        /// <summary>Type: String, RequiredLevel: Recommended, MaxLength: 50, Format: Text</summary>
        public const string FirstName = "firstname";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: True</summary>
        public const string FollowEmailActivity = "followemail";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Url</summary>
        public const string FTPSite = "ftpsiteurl";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Gender, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Gender = "gendercode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Government = "governmentid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Has Children, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string HasChildren = "haschildrencode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string HomePhone = "telephone2";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string HomePhone2 = "home2";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string ImportSequenceNumber = "importsequencenumber";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string isprivate = "isprivate";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string JobTitle = "jobtitle";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string LastDateIncludedinCampaign = "lastusedincampaign";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 50, Format: Text</summary>
        public const string LastName = "lastname";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Lead Source, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string LeadSource = "leadsourcecode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Manager = "managername";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string ManagerPhone = "managerphone";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Marital Status, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string MaritalStatus = "familystatuscode";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string MarketingOnly = "marketingonly";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: contact</summary>
        public const string MasterID = "masterid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Merged = "merged";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string MiddleName = "middlename";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string MobilePhone = "mobilephone";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedByDelegate = "modifiedonbehalfby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: externalparty</summary>
        public const string ModifiedByExternalParty = "modifiedbyexternalparty";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Nickname = "nickname";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string NoofChildren = "numberofchildren";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: lead</summary>
        public const string OriginatingLead = "originatingleadid";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: EntityName, RequiredLevel: SystemRequired</summary>
        public const string owneridtype = "owneridtype";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: businessunit</summary>
        public const string OwningBusinessUnit = "owningbusinessunit";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Pager = "pager";
        /// <summary>Type: EntityName, RequiredLevel: None</summary>
        public const string ParentCustomerType = "parentcustomeridtype";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 160, Format: Text</summary>
        public const string parentcustomeridname = "parentcustomeridname";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 450, Format: Text</summary>
        public const string parentcustomeridyominame = "parentcustomeridyominame";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ParticipatesinWorkflow = "participatesinworkflow";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Payment Terms, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PaymentTerms = "paymenttermscode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Day, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PreferredDay = "preferredappointmentdaycode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: equipment</summary>
        public const string PreferredFacility_Equipment = "preferredequipmentid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Method of Contact, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string PreferredMethodofContact = "preferredcontactmethodcode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: service</summary>
        public const string PreferredService = "preferredserviceid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Time, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string PreferredTime = "preferredappointmenttimecode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string PreferredUser = "preferredsystemuserid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: pricelevel</summary>
        public const string PriceList = "defaultpricelevelid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Process = "processid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ProcessStage = "stageid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RecordCreatedOn = "overriddencreatedon";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Relationship Type, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string RelationshipType = "customertypecode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Role, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Role = "accountrolecode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Salutation = "salutation";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string SendMarketingMaterials = "donotsendmm";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method , OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string ShippingMethod = "shippingmethodcode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Spouse_PartnerName = "spousesname";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Subscription = "subscriptionid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 10, Format: Text</summary>
        public const string Suffix = "suffix";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Telephone3 = "telephone3";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Territory, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Territory = "territorycode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string TimeSpentbyme = "timespentbymeonemailandmeetings";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string TraversedPath = "traversedpath";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Url</summary>
        public const string Website = "websiteurl";
        /// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9223372036854775808, MaxValue: 9223372036854775807</summary>
        public const string VersionNumber = "versionnumber";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 150, Format: PhoneticGuide</summary>
        public const string YomiFirstName = "yomifirstname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 450, Format: PhoneticGuide</summary>
        public const string YomiFullName = "yomifullname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 150, Format: PhoneticGuide</summary>
        public const string YomiLastName = "yomilastname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 150, Format: PhoneticGuide</summary>
        public const string YomiMiddleName = "yomimiddlename";
        public enum CustomerSize_OptionSet
        {
            DefaultValue = 1
        }
        public enum Education_OptionSet
        {
            DefaultValue = 1
        }
        public enum Gender_OptionSet
        {
            Male = 1,
            Female = 2
        }
        public enum HasChildren_OptionSet
        {
            DefaultValue = 1
        }
        public enum LeadSource_OptionSet
        {
            DefaultValue = 1
        }
        public enum MaritalStatus_OptionSet
        {
            Single = 1,
            Married = 2,
            Divorced = 3,
            Widowed = 4
        }
        public enum owneridtype_OptionSet
        {
        }
        public enum ParentCustomerType_OptionSet
        {
        }
        public enum PaymentTerms_OptionSet
        {
            Net30 = 1,
            _210Net30 = 2,
            Net45 = 3,
            Net60 = 4
        }
        public enum PreferredDay_OptionSet
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }
        public enum PreferredMethodofContact_OptionSet
        {
            Any = 1,
            Email = 2,
            Phone = 3,
            Fax = 4,
            Mail = 5
        }
        public enum PreferredTime_OptionSet
        {
            Morning = 1,
            Afternoon = 2,
            Evening = 3
        }
        public enum RelationshipType_OptionSet
        {
            DefaultValue = 1
        }
        public enum Role_OptionSet
        {
            DecisionMaker = 1,
            Employee = 2,
            Influencer = 3
        }
        public enum ShippingMethod_OptionSet
        {
            DefaultValue = 1
        }
        public enum Status_OptionSet
        {
            Active = 0,
            Inactive = 1
        }
        public enum StatusReason_OptionSet
        {
            Active = 1,
            Inactive = 2
        }
        public enum Territory_OptionSet
        {
            DefaultValue = 1
        }
    }
}
