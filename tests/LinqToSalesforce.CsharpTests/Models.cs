using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using LinqToSalesforce;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace LinqToSalesforce
{
    public class PickAccountType
    {
        public static readonly string  Prospect = "Prospect"; 
        public static readonly string  CustomerDirect = "Customer - Direct"; 
        public static readonly string  CustomerChannel = "Customer - Channel"; 
        public static readonly string  ChannelPartnerReseller = "Channel Partner / Reseller"; 
        public static readonly string  InstallationPartner = "Installation Partner"; 
        public static readonly string  TechnologyPartner = "Technology Partner"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountType o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountType(string s)
        {
            return new PickAccountType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountIndustry
    {
        public static readonly string  Agriculture = "Agriculture"; 
        public static readonly string  Apparel = "Apparel"; 
        public static readonly string  Banking = "Banking"; 
        public static readonly string  Biotechnology = "Biotechnology"; 
        public static readonly string  Chemicals = "Chemicals"; 
        public static readonly string  Communications = "Communications"; 
        public static readonly string  Construction = "Construction"; 
        public static readonly string  Consulting = "Consulting"; 
        public static readonly string  Education = "Education"; 
        public static readonly string  Electronics = "Electronics"; 
        public static readonly string  Energy = "Energy"; 
        public static readonly string  Engineering = "Engineering"; 
        public static readonly string  Entertainment = "Entertainment"; 
        public static readonly string  Environmental = "Environmental"; 
        public static readonly string  Finance = "Finance"; 
        public static readonly string  FoodBeverage = "Food & Beverage"; 
        public static readonly string  Government = "Government"; 
        public static readonly string  Healthcare = "Healthcare"; 
        public static readonly string  Hospitality = "Hospitality"; 
        public static readonly string  Insurance = "Insurance"; 
        public static readonly string  Machinery = "Machinery"; 
        public static readonly string  Manufacturing = "Manufacturing"; 
        public static readonly string  Media = "Media"; 
        public static readonly string  NotForProfit = "Not For Profit"; 
        public static readonly string  Recreation = "Recreation"; 
        public static readonly string  Retail = "Retail"; 
        public static readonly string  Shipping = "Shipping"; 
        public static readonly string  Technology = "Technology"; 
        public static readonly string  Telecommunications = "Telecommunications"; 
        public static readonly string  Transportation = "Transportation"; 
        public static readonly string  Utilities = "Utilities"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountIndustry o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountIndustry(string s)
        {
            return new PickAccountIndustry {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountOwnership
    {
        public static readonly string  Public = "Public"; 
        public static readonly string  Private = "Private"; 
        public static readonly string  Subsidiary = "Subsidiary"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountOwnership o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountOwnership(string s)
        {
            return new PickAccountOwnership {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountRating
    {
        public static readonly string  Hot = "Hot"; 
        public static readonly string  Warm = "Warm"; 
        public static readonly string  Cold = "Cold"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountRating o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountRating(string s)
        {
            return new PickAccountRating {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountCustomerPriority__c
    {
        public static readonly string  High = "High"; 
        public static readonly string  Low = "Low"; 
        public static readonly string  Medium = "Medium"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountCustomerPriority__c o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountCustomerPriority__c(string s)
        {
            return new PickAccountCustomerPriority__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountSLA__c
    {
        public static readonly string  Gold = "Gold"; 
        public static readonly string  Silver = "Silver"; 
        public static readonly string  Platinum = "Platinum"; 
        public static readonly string  Bronze = "Bronze"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountSLA__c o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountSLA__c(string s)
        {
            return new PickAccountSLA__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountActive__c
    {
        public static readonly string  No = "No"; 
        public static readonly string  Yes = "Yes"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountActive__c o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountActive__c(string s)
        {
            return new PickAccountActive__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountUpsellOpportunity__c
    {
        public static readonly string  Maybe = "Maybe"; 
        public static readonly string  No = "No"; 
        public static readonly string  Yes = "Yes"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountUpsellOpportunity__c o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountUpsellOpportunity__c(string s)
        {
            return new PickAccountUpsellOpportunity__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountContactRoleRole
    {
        public static readonly string  BusinessUser = "Business User"; 
        public static readonly string  DecisionMaker = "Decision Maker"; 
        public static readonly string  EconomicBuyer = "Economic Buyer"; 
        public static readonly string  EconomicDecisionMaker = "Economic Decision Maker"; 
        public static readonly string  Evaluator = "Evaluator"; 
        public static readonly string  ExecutiveSponsor = "Executive Sponsor"; 
        public static readonly string  Influencer = "Influencer"; 
        public static readonly string  TechnicalBuyer = "Technical Buyer"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountContactRoleRole o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountContactRoleRole(string s)
        {
            return new PickAccountContactRoleRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountFeedType(string s)
        {
            return new PickAccountFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountHistoryField
    {
        public static readonly string  accountMerged = "accountMerged"; 
        public static readonly string  AccountNumber = "AccountNumber"; 
        public static readonly string  AccountSource = "AccountSource"; 
        public static readonly string  Activec = "Active__c"; 
        public static readonly string  AnnualRevenue = "AnnualRevenue"; 
        public static readonly string  BillingAddress = "BillingAddress"; 
        public static readonly string  BillingCity = "BillingCity"; 
        public static readonly string  BillingCountry = "BillingCountry"; 
        public static readonly string  BillingGeocodeAccuracy = "BillingGeocodeAccuracy"; 
        public static readonly string  BillingLatitude = "BillingLatitude"; 
        public static readonly string  BillingLongitude = "BillingLongitude"; 
        public static readonly string  BillingPostalCode = "BillingPostalCode"; 
        public static readonly string  BillingState = "BillingState"; 
        public static readonly string  BillingStreet = "BillingStreet"; 
        public static readonly string  CleanStatus = "CleanStatus"; 
        public static readonly string  created = "created"; 
        public static readonly string  accountCreatedFromLead = "accountCreatedFromLead"; 
        public static readonly string  CustomerPriorityc = "CustomerPriority__c"; 
        public static readonly string  DandbCompany = "DandbCompany"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  DunsNumber = "DunsNumber"; 
        public static readonly string  Fax = "Fax"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  Industry = "Industry"; 
        public static readonly string  Jigsaw = "Jigsaw"; 
        public static readonly string  accountUpdatedByLead = "accountUpdatedByLead"; 
        public static readonly string  personAccountUpdatedByLead = "personAccountUpdatedByLead"; 
        public static readonly string  NaicsCode = "NaicsCode"; 
        public static readonly string  NaicsDesc = "NaicsDesc"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  NumberOfEmployees = "NumberOfEmployees"; 
        public static readonly string  NumberofLocationsc = "NumberofLocations__c"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  Ownership = "Ownership"; 
        public static readonly string  Parent = "Parent"; 
        public static readonly string  Phone = "Phone"; 
        public static readonly string  Rating = "Rating"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  ShippingAddress = "ShippingAddress"; 
        public static readonly string  ShippingCity = "ShippingCity"; 
        public static readonly string  ShippingCountry = "ShippingCountry"; 
        public static readonly string  ShippingGeocodeAccuracy = "ShippingGeocodeAccuracy"; 
        public static readonly string  ShippingLatitude = "ShippingLatitude"; 
        public static readonly string  ShippingLongitude = "ShippingLongitude"; 
        public static readonly string  ShippingPostalCode = "ShippingPostalCode"; 
        public static readonly string  ShippingState = "ShippingState"; 
        public static readonly string  ShippingStreet = "ShippingStreet"; 
        public static readonly string  Sic = "Sic"; 
        public static readonly string  SicDesc = "SicDesc"; 
        public static readonly string  Site = "Site"; 
        public static readonly string  SLAc = "SLA__c"; 
        public static readonly string  SLAExpirationDatec = "SLAExpirationDate__c"; 
        public static readonly string  SLASerialNumberc = "SLASerialNumber__c"; 
        public static readonly string  TextName = "TextName"; 
        public static readonly string  TickerSymbol = "TickerSymbol"; 
        public static readonly string  Tradestyle = "Tradestyle"; 
        public static readonly string  Type = "Type"; 
        public static readonly string  UpsellOpportunityc = "UpsellOpportunity__c"; 
        public static readonly string  Website = "Website"; 
        public static readonly string  YearStarted = "YearStarted"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountHistoryField(string s)
        {
            return new PickAccountHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountPartnerRole
    {
        public static readonly string  SystemIntegrator = "System Integrator"; 
        public static readonly string  Agency = "Agency"; 
        public static readonly string  Advertiser = "Advertiser"; 
        public static readonly string  VARReseller = "VAR/Reseller"; 
        public static readonly string  Distributor = "Distributor"; 
        public static readonly string  Developer = "Developer"; 
        public static readonly string  Broker = "Broker"; 
        public static readonly string  Lender = "Lender"; 
        public static readonly string  Supplier = "Supplier"; 
        public static readonly string  Institution = "Institution"; 
        public static readonly string  Contractor = "Contractor"; 
        public static readonly string  Dealer = "Dealer"; 
        public static readonly string  Consultant = "Consultant"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountPartnerRole o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountPartnerRole(string s)
        {
            return new PickAccountPartnerRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountShareAccountAccessLevel
    {
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountShareAccountAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountShareAccountAccessLevel(string s)
        {
            return new PickAccountShareAccountAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountShareOpportunityAccessLevel
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountShareOpportunityAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountShareOpportunityAccessLevel(string s)
        {
            return new PickAccountShareOpportunityAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountShareCaseAccessLevel
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountShareCaseAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountShareCaseAccessLevel(string s)
        {
            return new PickAccountShareCaseAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountShareContactAccessLevel
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountShareContactAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountShareContactAccessLevel(string s)
        {
            return new PickAccountShareContactAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAccountShareRowCause
    {
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Manual = "Manual"; 
        public static readonly string  Rule = "Rule"; 
        public static readonly string  ImplicitChild = "ImplicitChild"; 
        public static readonly string  ImplicitParent = "ImplicitParent"; 
        public static readonly string  ImplicitPerson = "ImplicitPerson"; 
        public static readonly string  Team = "Team"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryManual = "TerritoryManual"; 
        public static readonly string  TerritoryRule = "TerritoryRule"; 
        public static readonly string  Territory2Forecast = "Territory2Forecast"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAccountShareRowCause o)
        {
            return o.Value;
        }

        public static implicit operator PickAccountShareRowCause(string s)
        {
            return new PickAccountShareRowCause {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickActivityHistoryStatus
    {
        public static readonly string  NotStarted = "Not Started"; 
        public static readonly string  InProgress = "In Progress"; 
        public static readonly string  Completed = "Completed"; 
        public static readonly string  Waitingonsomeoneelse = "Waiting on someone else"; 
        public static readonly string  Deferred = "Deferred"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickActivityHistoryStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickActivityHistoryStatus(string s)
        {
            return new PickActivityHistoryStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickActivityHistoryPriority
    {
        public static readonly string  High = "High"; 
        public static readonly string  Normal = "Normal"; 
        public static readonly string  Low = "Low"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickActivityHistoryPriority o)
        {
            return o.Value;
        }

        public static implicit operator PickActivityHistoryPriority(string s)
        {
            return new PickActivityHistoryPriority {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickActivityHistoryActivityType
    {
        public static readonly string  Call = "Call"; 
        public static readonly string  Email = "Email"; 
        public static readonly string  Meeting = "Meeting"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickActivityHistoryActivityType o)
        {
            return o.Value;
        }

        public static implicit operator PickActivityHistoryActivityType(string s)
        {
            return new PickActivityHistoryActivityType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickActivityHistoryCallType
    {
        public static readonly string  Internal = "Internal"; 
        public static readonly string  Inbound = "Inbound"; 
        public static readonly string  Outbound = "Outbound"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickActivityHistoryCallType o)
        {
            return o.Value;
        }

        public static implicit operator PickActivityHistoryCallType(string s)
        {
            return new PickActivityHistoryCallType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickApexClassStatus
    {
        public static readonly string  Inactive = "Inactive"; 
        public static readonly string  Active = "Active"; 
        public static readonly string  Deleted = "Deleted"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickApexClassStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickApexClassStatus(string s)
        {
            return new PickApexClassStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickApexComponentControllerType
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _4 = "4"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
        public static readonly string _5 = "5"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickApexComponentControllerType o)
        {
            return o.Value;
        }

        public static implicit operator PickApexComponentControllerType(string s)
        {
            return new PickApexComponentControllerType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickApexLogLocation
    {
        public static readonly string  Monitoring = "Monitoring"; 
        public static readonly string  Profiling = "Profiling"; 
        public static readonly string  SystemLog = "SystemLog"; 
        public static readonly string  HeapDump = "HeapDump"; 
        public static readonly string  Preserved = "Preserved"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickApexLogLocation o)
        {
            return o.Value;
        }

        public static implicit operator PickApexLogLocation(string s)
        {
            return new PickApexLogLocation {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickApexPageControllerType
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _4 = "4"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
        public static readonly string _5 = "5"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickApexPageControllerType o)
        {
            return o.Value;
        }

        public static implicit operator PickApexPageControllerType(string s)
        {
            return new PickApexPageControllerType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickApexTriggerTableEnumOrId
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  Asset = "Asset"; 
        public static readonly string  AssistantInteraction = "AssistantInteraction"; 
        public static readonly string  Attachment = "Attachment"; 
        public static readonly string  Campaign = "Campaign"; 
        public static readonly string  CampaignMember = "CampaignMember"; 
        public static readonly string  Case = "Case"; 
        public static readonly string  CaseComment = "CaseComment"; 
        public static readonly string  ChatterMessage = "ChatterMessage"; 
        public static readonly string  CollaborationGroup = "CollaborationGroup"; 
        public static readonly string  CollaborationGroupMember = "CollaborationGroupMember"; 
        public static readonly string  CollaborationGroupRecord = "CollaborationGroupRecord"; 
        public static readonly string  Contact = "Contact"; 
        public static readonly string  ContentDistribution = "ContentDistribution"; 
        public static readonly string  ContentDocument = "ContentDocument"; 
        public static readonly string  ContentDocumentLink = "ContentDocumentLink"; 
        public static readonly string  ContentVersion = "ContentVersion"; 
        public static readonly string  Contract = "Contract"; 
        public static readonly string  DandBCompany = "DandBCompany"; 
        public static readonly string  DuplicateRecordItem = "DuplicateRecordItem"; 
        public static readonly string  DuplicateRecordSet = "DuplicateRecordSet"; 
        public static readonly string  EmailMessage = "EmailMessage"; 
        public static readonly string  Event = "Event"; 
        public static readonly string  FeedComment = "FeedComment"; 
        public static readonly string  FeedItem = "FeedItem"; 
        public static readonly string  Goal = "Goal"; 
        public static readonly string  GoalLink = "GoalLink"; 
        public static readonly string  Idea = "Idea"; 
        public static readonly string  IdeaComment = "IdeaComment"; 
        public static readonly string  Lead = "Lead"; 
        public static readonly string  Macro = "Macro"; 
        public static readonly string  Metric = "Metric"; 
        public static readonly string  MetricDataLink = "MetricDataLink"; 
        public static readonly string  Note = "Note"; 
        public static readonly string  Opportunity = "Opportunity"; 
        public static readonly string  OpportunityLineItem = "OpportunityLineItem"; 
        public static readonly string  Order = "Order"; 
        public static readonly string  OrderItem = "OrderItem"; 
        public static readonly string  Partner = "Partner"; 
        public static readonly string  Pricebook2 = "Pricebook2"; 
        public static readonly string  Product2 = "Product2"; 
        public static readonly string  RecordOrigin = "RecordOrigin"; 
        public static readonly string  SocialPersona = "SocialPersona"; 
        public static readonly string  Solution = "Solution"; 
        public static readonly string  StreamingChannel = "StreamingChannel"; 
        public static readonly string  Task = "Task"; 
        public static readonly string  Topic = "Topic"; 
        public static readonly string  TopicAssignment = "TopicAssignment"; 
        public static readonly string  User = "User"; 
        public static readonly string  UserProvAccount = "UserProvAccount"; 
        public static readonly string  UserProvAccountStaging = "UserProvAccountStaging"; 
        public static readonly string  UserProvisioningLog = "UserProvisioningLog"; 
        public static readonly string  UserProvisioningRequest = "UserProvisioningRequest"; 
        public static readonly string  UserProvMockTarget = "UserProvMockTarget"; 
        public static readonly string  WorkCoaching = "WorkCoaching"; 
        public static readonly string  WorkFeedback = "WorkFeedback"; 
        public static readonly string  WorkFeedbackQuestion = "WorkFeedbackQuestion"; 
        public static readonly string  WorkFeedbackQuestionSet = "WorkFeedbackQuestionSet"; 
        public static readonly string  WorkFeedbackRequest = "WorkFeedbackRequest"; 
        public static readonly string  WorkFeedbackTemplate = "WorkFeedbackTemplate"; 
        public static readonly string  WorkPerformanceCycle = "WorkPerformanceCycle"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickApexTriggerTableEnumOrId o)
        {
            return o.Value;
        }

        public static implicit operator PickApexTriggerTableEnumOrId(string s)
        {
            return new PickApexTriggerTableEnumOrId {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickApexTriggerStatus
    {
        public static readonly string  Inactive = "Inactive"; 
        public static readonly string  Active = "Active"; 
        public static readonly string  Deleted = "Deleted"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickApexTriggerStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickApexTriggerStatus(string s)
        {
            return new PickApexTriggerStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAssetStatus
    {
        public static readonly string  Shipped = "Shipped"; 
        public static readonly string  Installed = "Installed"; 
        public static readonly string  Registered = "Registered"; 
        public static readonly string  Obsolete = "Obsolete"; 
        public static readonly string  Purchased = "Purchased"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAssetStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickAssetStatus(string s)
        {
            return new PickAssetStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAssetFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAssetFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickAssetFeedType(string s)
        {
            return new PickAssetFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAssetHistoryField
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  Contact = "Contact"; 
        public static readonly string  created = "created"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  InstallDate = "InstallDate"; 
        public static readonly string  IsCompetitorProduct = "IsCompetitorProduct"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  Parent = "Parent"; 
        public static readonly string  Price = "Price"; 
        public static readonly string  Product2 = "Product2"; 
        public static readonly string  PurchaseDate = "PurchaseDate"; 
        public static readonly string  Quantity = "Quantity"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  RootAsset = "RootAsset"; 
        public static readonly string  SerialNumber = "SerialNumber"; 
        public static readonly string  Status = "Status"; 
        public static readonly string  UsageEndDate = "UsageEndDate"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAssetHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickAssetHistoryField(string s)
        {
            return new PickAssetHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAssignmentRuleSobjectType
    {
        public static readonly string  Case = "Case"; 
        public static readonly string  Lead = "Lead"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAssignmentRuleSobjectType o)
        {
            return o.Value;
        }

        public static implicit operator PickAssignmentRuleSobjectType(string s)
        {
            return new PickAssignmentRuleSobjectType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAsyncApexJobJobType
    {
        public static readonly string  Future = "Future"; 
        public static readonly string  SharingRecalculation = "SharingRecalculation"; 
        public static readonly string  ScheduledApex = "ScheduledApex"; 
        public static readonly string  BatchApex = "BatchApex"; 
        public static readonly string  BatchApexWorker = "BatchApexWorker"; 
        public static readonly string  TestRequest = "TestRequest"; 
        public static readonly string  TestWorker = "TestWorker"; 
        public static readonly string  ApexToken = "ApexToken"; 
        public static readonly string  Queueable = "Queueable"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAsyncApexJobJobType o)
        {
            return o.Value;
        }

        public static implicit operator PickAsyncApexJobJobType(string s)
        {
            return new PickAsyncApexJobJobType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickAsyncApexJobStatus
    {
        public static readonly string  Queued = "Queued"; 
        public static readonly string  Processing = "Processing"; 
        public static readonly string  Aborted = "Aborted"; 
        public static readonly string  Completed = "Completed"; 
        public static readonly string  Failed = "Failed"; 
        public static readonly string  Preparing = "Preparing"; 
        public static readonly string  Holding = "Holding"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickAsyncApexJobStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickAsyncApexJobStatus(string s)
        {
            return new PickAsyncApexJobStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickBusinessHoursTimeZoneSidKey
    {
        public static readonly string  PacificKiritimati = "Pacific/Kiritimati"; 
        public static readonly string  PacificTongatapu = "Pacific/Tongatapu"; 
        public static readonly string  PacificChatham = "Pacific/Chatham"; 
        public static readonly string  PacificAuckland = "Pacific/Auckland"; 
        public static readonly string  PacificEnderbury = "Pacific/Enderbury"; 
        public static readonly string  PacificFiji = "Pacific/Fiji"; 
        public static readonly string  AsiaKamchatka = "Asia/Kamchatka"; 
        public static readonly string  AustraliaLordHowe = "Australia/Lord_Howe"; 
        public static readonly string  AustraliaSydney = "Australia/Sydney"; 
        public static readonly string  PacificGuadalcanal = "Pacific/Guadalcanal"; 
        public static readonly string  PacificNorfolk = "Pacific/Norfolk"; 
        public static readonly string  AustraliaAdelaide = "Australia/Adelaide"; 
        public static readonly string  AustraliaBrisbane = "Australia/Brisbane"; 
        public static readonly string  AustraliaDarwin = "Australia/Darwin"; 
        public static readonly string  AsiaSeoul = "Asia/Seoul"; 
        public static readonly string  AsiaTokyo = "Asia/Tokyo"; 
        public static readonly string  AsiaHongKong = "Asia/Hong_Kong"; 
        public static readonly string  AsiaKualaLumpur = "Asia/Kuala_Lumpur"; 
        public static readonly string  AsiaManila = "Asia/Manila"; 
        public static readonly string  AsiaShanghai = "Asia/Shanghai"; 
        public static readonly string  AsiaSingapore = "Asia/Singapore"; 
        public static readonly string  AsiaTaipei = "Asia/Taipei"; 
        public static readonly string  AustraliaPerth = "Australia/Perth"; 
        public static readonly string  AsiaBangkok = "Asia/Bangkok"; 
        public static readonly string  AsiaHoChiMinh = "Asia/Ho_Chi_Minh"; 
        public static readonly string  AsiaJakarta = "Asia/Jakarta"; 
        public static readonly string  AsiaRangoon = "Asia/Rangoon"; 
        public static readonly string  AsiaDhaka = "Asia/Dhaka"; 
        public static readonly string  AsiaKathmandu = "Asia/Kathmandu"; 
        public static readonly string  AsiaColombo = "Asia/Colombo"; 
        public static readonly string  AsiaKolkata = "Asia/Kolkata"; 
        public static readonly string  AsiaKarachi = "Asia/Karachi"; 
        public static readonly string  AsiaTashkent = "Asia/Tashkent"; 
        public static readonly string  AsiaYekaterinburg = "Asia/Yekaterinburg"; 
        public static readonly string  AsiaKabul = "Asia/Kabul"; 
        public static readonly string  AsiaDubai = "Asia/Dubai"; 
        public static readonly string  AsiaTbilisi = "Asia/Tbilisi"; 
        public static readonly string  AsiaTehran = "Asia/Tehran"; 
        public static readonly string  AfricaNairobi = "Africa/Nairobi"; 
        public static readonly string  AsiaBaghdad = "Asia/Baghdad"; 
        public static readonly string  AsiaKuwait = "Asia/Kuwait"; 
        public static readonly string  AsiaRiyadh = "Asia/Riyadh"; 
        public static readonly string  EuropeIstanbul = "Europe/Istanbul"; 
        public static readonly string  EuropeMinsk = "Europe/Minsk"; 
        public static readonly string  EuropeMoscow = "Europe/Moscow"; 
        public static readonly string  AfricaCairo = "Africa/Cairo"; 
        public static readonly string  AfricaJohannesburg = "Africa/Johannesburg"; 
        public static readonly string  AsiaJerusalem = "Asia/Jerusalem"; 
        public static readonly string  EuropeAthens = "Europe/Athens"; 
        public static readonly string  EuropeBucharest = "Europe/Bucharest"; 
        public static readonly string  EuropeHelsinki = "Europe/Helsinki"; 
        public static readonly string  AfricaAlgiers = "Africa/Algiers"; 
        public static readonly string  EuropeAmsterdam = "Europe/Amsterdam"; 
        public static readonly string  EuropeBerlin = "Europe/Berlin"; 
        public static readonly string  EuropeBrussels = "Europe/Brussels"; 
        public static readonly string  EuropeParis = "Europe/Paris"; 
        public static readonly string  EuropePrague = "Europe/Prague"; 
        public static readonly string  EuropeRome = "Europe/Rome"; 
        public static readonly string  EuropeDublin = "Europe/Dublin"; 
        public static readonly string  EuropeLisbon = "Europe/Lisbon"; 
        public static readonly string  EuropeLondon = "Europe/London"; 
        public static readonly string  GMT = "GMT"; 
        public static readonly string  AtlanticCapeVerde = "Atlantic/Cape_Verde"; 
        public static readonly string  AmericaSaoPaulo = "America/Sao_Paulo"; 
        public static readonly string  AtlanticSouthGeorgia = "Atlantic/South_Georgia"; 
        public static readonly string  AmericaArgentinaBuenosAires = "America/Argentina/Buenos_Aires"; 
        public static readonly string  AmericaSantiago = "America/Santiago"; 
        public static readonly string  AmericaStJohns = "America/St_Johns"; 
        public static readonly string  AmericaCaracas = "America/Caracas"; 
        public static readonly string  AmericaHalifax = "America/Halifax"; 
        public static readonly string  AmericaPuertoRico = "America/Puerto_Rico"; 
        public static readonly string  AtlanticBermuda = "Atlantic/Bermuda"; 
        public static readonly string  AmericaBogota = "America/Bogota"; 
        public static readonly string  AmericaIndianaIndianapolis = "America/Indiana/Indianapolis"; 
        public static readonly string  AmericaLima = "America/Lima"; 
        public static readonly string  AmericaNewYork = "America/New_York"; 
        public static readonly string  AmericaPanama = "America/Panama"; 
        public static readonly string  AmericaChicago = "America/Chicago"; 
        public static readonly string  AmericaElSalvador = "America/El_Salvador"; 
        public static readonly string  AmericaMexicoCity = "America/Mexico_City"; 
        public static readonly string  AmericaDenver = "America/Denver"; 
        public static readonly string  AmericaPhoenix = "America/Phoenix"; 
        public static readonly string  AmericaLosAngeles = "America/Los_Angeles"; 
        public static readonly string  AmericaTijuana = "America/Tijuana"; 
        public static readonly string  AmericaAnchorage = "America/Anchorage"; 
        public static readonly string  PacificHonolulu = "Pacific/Honolulu"; 
        public static readonly string  PacificNiue = "Pacific/Niue"; 
        public static readonly string  PacificPagoPago = "Pacific/Pago_Pago"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickBusinessHoursTimeZoneSidKey o)
        {
            return o.Value;
        }

        public static implicit operator PickBusinessHoursTimeZoneSidKey(string s)
        {
            return new PickBusinessHoursTimeZoneSidKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickBusinessProcessTableEnumOrId
    {
        public static readonly string  Case = "Case"; 
        public static readonly string  Lead = "Lead"; 
        public static readonly string  Opportunity = "Opportunity"; 
        public static readonly string  Solution = "Solution"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickBusinessProcessTableEnumOrId o)
        {
            return o.Value;
        }

        public static implicit operator PickBusinessProcessTableEnumOrId(string s)
        {
            return new PickBusinessProcessTableEnumOrId {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCampaignType
    {
        public static readonly string  Conference = "Conference"; 
        public static readonly string  Webinar = "Webinar"; 
        public static readonly string  TradeShow = "Trade Show"; 
        public static readonly string  PublicRelations = "Public Relations"; 
        public static readonly string  Partners = "Partners"; 
        public static readonly string  ReferralProgram = "Referral Program"; 
        public static readonly string  Advertisement = "Advertisement"; 
        public static readonly string  BannerAds = "Banner Ads"; 
        public static readonly string  DirectMail = "Direct Mail"; 
        public static readonly string  Email = "Email"; 
        public static readonly string  Telemarketing = "Telemarketing"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCampaignType o)
        {
            return o.Value;
        }

        public static implicit operator PickCampaignType(string s)
        {
            return new PickCampaignType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCampaignStatus
    {
        public static readonly string  Planned = "Planned"; 
        public static readonly string  InProgress = "In Progress"; 
        public static readonly string  Completed = "Completed"; 
        public static readonly string  Aborted = "Aborted"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCampaignStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickCampaignStatus(string s)
        {
            return new PickCampaignStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCampaignFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCampaignFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickCampaignFeedType(string s)
        {
            return new PickCampaignFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCampaignMemberStatus
    {
        public static readonly string  Planned = "Planned"; 
        public static readonly string  Received = "Received"; 
        public static readonly string  Responded = "Responded"; 
        public static readonly string  Sent = "Sent"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCampaignMemberStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickCampaignMemberStatus(string s)
        {
            return new PickCampaignMemberStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCampaignShareCampaignAccessLevel
    {
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCampaignShareCampaignAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickCampaignShareCampaignAccessLevel(string s)
        {
            return new PickCampaignShareCampaignAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCampaignShareRowCause
    {
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Manual = "Manual"; 
        public static readonly string  Rule = "Rule"; 
        public static readonly string  ImplicitChild = "ImplicitChild"; 
        public static readonly string  ImplicitParent = "ImplicitParent"; 
        public static readonly string  ImplicitPerson = "ImplicitPerson"; 
        public static readonly string  Team = "Team"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryManual = "TerritoryManual"; 
        public static readonly string  TerritoryRule = "TerritoryRule"; 
        public static readonly string  Territory2Forecast = "Territory2Forecast"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCampaignShareRowCause o)
        {
            return o.Value;
        }

        public static implicit operator PickCampaignShareRowCause(string s)
        {
            return new PickCampaignShareRowCause {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseType
    {
        public static readonly string  Mechanical = "Mechanical"; 
        public static readonly string  Electrical = "Electrical"; 
        public static readonly string  Electronic = "Electronic"; 
        public static readonly string  Structural = "Structural"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseType o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseType(string s)
        {
            return new PickCaseType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseStatus
    {
        public static readonly string  New = "New"; 
        public static readonly string  Working = "Working"; 
        public static readonly string  Escalated = "Escalated"; 
        public static readonly string  Closed = "Closed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseStatus(string s)
        {
            return new PickCaseStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseReason
    {
        public static readonly string  Installation = "Installation"; 
        public static readonly string  EquipmentComplexity = "Equipment Complexity"; 
        public static readonly string  Performance = "Performance"; 
        public static readonly string  Breakdown = "Breakdown"; 
        public static readonly string  EquipmentDesign = "Equipment Design"; 
        public static readonly string  Feedback = "Feedback"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseReason o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseReason(string s)
        {
            return new PickCaseReason {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseOrigin
    {
        public static readonly string  Phone = "Phone"; 
        public static readonly string  Email = "Email"; 
        public static readonly string  Web = "Web"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseOrigin o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseOrigin(string s)
        {
            return new PickCaseOrigin {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCasePriority
    {
        public static readonly string  High = "High"; 
        public static readonly string  Medium = "Medium"; 
        public static readonly string  Low = "Low"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCasePriority o)
        {
            return o.Value;
        }

        public static implicit operator PickCasePriority(string s)
        {
            return new PickCasePriority {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseSLAViolation__c
    {
        public static readonly string  No = "No"; 
        public static readonly string  Yes = "Yes"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseSLAViolation__c o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseSLAViolation__c(string s)
        {
            return new PickCaseSLAViolation__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseProduct__c
    {
        public static readonly string  GC1040 = "GC1040"; 
        public static readonly string  GC1060 = "GC1060"; 
        public static readonly string  GC3020 = "GC3020"; 
        public static readonly string  GC3040 = "GC3040"; 
        public static readonly string  GC3060 = "GC3060"; 
        public static readonly string  GC5020 = "GC5020"; 
        public static readonly string  GC5040 = "GC5040"; 
        public static readonly string  GC5060 = "GC5060"; 
        public static readonly string  GC1020 = "GC1020"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseProduct__c o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseProduct__c(string s)
        {
            return new PickCaseProduct__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCasePotentialLiability__c
    {
        public static readonly string  No = "No"; 
        public static readonly string  Yes = "Yes"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCasePotentialLiability__c o)
        {
            return o.Value;
        }

        public static implicit operator PickCasePotentialLiability__c(string s)
        {
            return new PickCasePotentialLiability__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseContactRoleRole
    {
        public static readonly string  TechnicalContact = "Technical Contact"; 
        public static readonly string  BusinessContact = "Business Contact"; 
        public static readonly string  DecisionMaker = "Decision Maker"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseContactRoleRole o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseContactRoleRole(string s)
        {
            return new PickCaseContactRoleRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseFeedType(string s)
        {
            return new PickCaseFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseHistoryField
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  Asset = "Asset"; 
        public static readonly string  BusinessHours = "BusinessHours"; 
        public static readonly string  closed = "closed"; 
        public static readonly string  Contact = "Contact"; 
        public static readonly string  created = "created"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  EngineeringReqNumberc = "EngineeringReqNumber__c"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  IsClosedOnCreate = "IsClosedOnCreate"; 
        public static readonly string  IsEscalated = "IsEscalated"; 
        public static readonly string  Origin = "Origin"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  ownerEscalated = "ownerEscalated"; 
        public static readonly string  Parent = "Parent"; 
        public static readonly string  PotentialLiabilityc = "PotentialLiability__c"; 
        public static readonly string  Priority = "Priority"; 
        public static readonly string  Productc = "Product__c"; 
        public static readonly string  Reason = "Reason"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  SLAViolationc = "SLAViolation__c"; 
        public static readonly string  Status = "Status"; 
        public static readonly string  Subject = "Subject"; 
        public static readonly string  Type = "Type"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseHistoryField(string s)
        {
            return new PickCaseHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseShareCaseAccessLevel
    {
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseShareCaseAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseShareCaseAccessLevel(string s)
        {
            return new PickCaseShareCaseAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseShareRowCause
    {
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Manual = "Manual"; 
        public static readonly string  Rule = "Rule"; 
        public static readonly string  ImplicitChild = "ImplicitChild"; 
        public static readonly string  ImplicitParent = "ImplicitParent"; 
        public static readonly string  ImplicitPerson = "ImplicitPerson"; 
        public static readonly string  Team = "Team"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryManual = "TerritoryManual"; 
        public static readonly string  TerritoryRule = "TerritoryRule"; 
        public static readonly string  Territory2Forecast = "Territory2Forecast"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseShareRowCause o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseShareRowCause(string s)
        {
            return new PickCaseShareRowCause {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCaseTeamRoleAccessLevel
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCaseTeamRoleAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickCaseTeamRoleAccessLevel(string s)
        {
            return new PickCaseTeamRoleAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCategoryNodeSortStyle
    {
        public static readonly string  custom = "custom"; 
        public static readonly string  alphabetical = "alphabetical"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCategoryNodeSortStyle o)
        {
            return o.Value;
        }

        public static implicit operator PickCategoryNodeSortStyle(string s)
        {
            return new PickCategoryNodeSortStyle {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCollaborationGroupCollaborationType
    {
        public static readonly string  Public = "Public"; 
        public static readonly string  Private = "Private"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCollaborationGroupCollaborationType o)
        {
            return o.Value;
        }

        public static implicit operator PickCollaborationGroupCollaborationType(string s)
        {
            return new PickCollaborationGroupCollaborationType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCollaborationGroupFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCollaborationGroupFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickCollaborationGroupFeedType(string s)
        {
            return new PickCollaborationGroupFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCollaborationGroupMemberNotificationFrequency
    {
        public static readonly string  P = "P"; 
        public static readonly string  D = "D"; 
        public static readonly string  W = "W"; 
        public static readonly string  N = "N"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCollaborationGroupMemberNotificationFrequency o)
        {
            return o.Value;
        }

        public static implicit operator PickCollaborationGroupMemberNotificationFrequency(string s)
        {
            return new PickCollaborationGroupMemberNotificationFrequency {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCollaborationInvitationStatus
    {
        public static readonly string  Sent = "Sent"; 
        public static readonly string  Accepted = "Accepted"; 
        public static readonly string  Canceled = "Canceled"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCollaborationInvitationStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickCollaborationInvitationStatus(string s)
        {
            return new PickCollaborationInvitationStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContactSalutation
    {
        public static readonly string  Mr = "Mr."; 
        public static readonly string  Ms = "Ms."; 
        public static readonly string  Mrs = "Mrs."; 
        public static readonly string  Dr = "Dr."; 
        public static readonly string  Prof = "Prof."; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContactSalutation o)
        {
            return o.Value;
        }

        public static implicit operator PickContactSalutation(string s)
        {
            return new PickContactSalutation {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContactLeadSource
    {
        public static readonly string  Web = "Web"; 
        public static readonly string  PhoneInquiry = "Phone Inquiry"; 
        public static readonly string  PartnerReferral = "Partner Referral"; 
        public static readonly string  PurchasedList = "Purchased List"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContactLeadSource o)
        {
            return o.Value;
        }

        public static implicit operator PickContactLeadSource(string s)
        {
            return new PickContactLeadSource {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContactLevel__c
    {
        public static readonly string  Secondary = "Secondary"; 
        public static readonly string  Tertiary = "Tertiary"; 
        public static readonly string  Primary = "Primary"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContactLevel__c o)
        {
            return o.Value;
        }

        public static implicit operator PickContactLevel__c(string s)
        {
            return new PickContactLevel__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContactFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContactFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickContactFeedType(string s)
        {
            return new PickContactFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContactHistoryField
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  AssistantName = "AssistantName"; 
        public static readonly string  AssistantPhone = "AssistantPhone"; 
        public static readonly string  Birthdate = "Birthdate"; 
        public static readonly string  CleanStatus = "CleanStatus"; 
        public static readonly string  contactMerged = "contactMerged"; 
        public static readonly string  created = "created"; 
        public static readonly string  contactCreatedFromLead = "contactCreatedFromLead"; 
        public static readonly string  Department = "Department"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  DoNotCall = "DoNotCall"; 
        public static readonly string  Email = "Email"; 
        public static readonly string  EmailBouncedDate = "EmailBouncedDate"; 
        public static readonly string  EmailBouncedReason = "EmailBouncedReason"; 
        public static readonly string  Fax = "Fax"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  FirstName = "FirstName"; 
        public static readonly string  HasOptedOutOfEmail = "HasOptedOutOfEmail"; 
        public static readonly string  HasOptedOutOfFax = "HasOptedOutOfFax"; 
        public static readonly string  HomePhone = "HomePhone"; 
        public static readonly string  Jigsaw = "Jigsaw"; 
        public static readonly string  Languagesc = "Languages__c"; 
        public static readonly string  LastName = "LastName"; 
        public static readonly string  contactUpdatedByLead = "contactUpdatedByLead"; 
        public static readonly string  LeadSource = "LeadSource"; 
        public static readonly string  Levelc = "Level__c"; 
        public static readonly string  MailingAddress = "MailingAddress"; 
        public static readonly string  MailingCity = "MailingCity"; 
        public static readonly string  MailingCountry = "MailingCountry"; 
        public static readonly string  MailingGeocodeAccuracy = "MailingGeocodeAccuracy"; 
        public static readonly string  MailingLatitude = "MailingLatitude"; 
        public static readonly string  MailingLongitude = "MailingLongitude"; 
        public static readonly string  MailingPostalCode = "MailingPostalCode"; 
        public static readonly string  MailingState = "MailingState"; 
        public static readonly string  MailingStreet = "MailingStreet"; 
        public static readonly string  MobilePhone = "MobilePhone"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  OtherAddress = "OtherAddress"; 
        public static readonly string  OtherCity = "OtherCity"; 
        public static readonly string  OtherCountry = "OtherCountry"; 
        public static readonly string  OtherGeocodeAccuracy = "OtherGeocodeAccuracy"; 
        public static readonly string  OtherLatitude = "OtherLatitude"; 
        public static readonly string  OtherLongitude = "OtherLongitude"; 
        public static readonly string  OtherPhone = "OtherPhone"; 
        public static readonly string  OtherPostalCode = "OtherPostalCode"; 
        public static readonly string  OtherState = "OtherState"; 
        public static readonly string  OtherStreet = "OtherStreet"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  Phone = "Phone"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  ReportsTo = "ReportsTo"; 
        public static readonly string  Salutation = "Salutation"; 
        public static readonly string  Title = "Title"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContactHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickContactHistoryField(string s)
        {
            return new PickContactHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContactShareContactAccessLevel
    {
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContactShareContactAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickContactShareContactAccessLevel(string s)
        {
            return new PickContactShareContactAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContactShareRowCause
    {
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Manual = "Manual"; 
        public static readonly string  Rule = "Rule"; 
        public static readonly string  ImplicitChild = "ImplicitChild"; 
        public static readonly string  ImplicitParent = "ImplicitParent"; 
        public static readonly string  ImplicitPerson = "ImplicitPerson"; 
        public static readonly string  Team = "Team"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryManual = "TerritoryManual"; 
        public static readonly string  TerritoryRule = "TerritoryRule"; 
        public static readonly string  Territory2Forecast = "Territory2Forecast"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContactShareRowCause o)
        {
            return o.Value;
        }

        public static implicit operator PickContactShareRowCause(string s)
        {
            return new PickContactShareRowCause {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContentDocumentPublishStatus
    {
        public static readonly string  U = "U"; 
        public static readonly string  P = "P"; 
        public static readonly string  R = "R"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContentDocumentPublishStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickContentDocumentPublishStatus(string s)
        {
            return new PickContentDocumentPublishStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContentDocumentFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContentDocumentFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickContentDocumentFeedType(string s)
        {
            return new PickContentDocumentFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContentDocumentHistoryField
    {
        public static readonly string  ArchivedBy = "ArchivedBy"; 
        public static readonly string  ArchivedDate = "ArchivedDate"; 
        public static readonly string  ContentAsset = "ContentAsset"; 
        public static readonly string  created = "created"; 
        public static readonly string  DeletedBy = "DeletedBy"; 
        public static readonly string  DeletedDate = "DeletedDate"; 
        public static readonly string  contentDocPublished = "contentDocPublished"; 
        public static readonly string  contentDocFeatured = "contentDocFeatured"; 
        public static readonly string  contentDocRepublished = "contentDocRepublished"; 
        public static readonly string  contentDocUnpublished = "contentDocUnpublished"; 
        public static readonly string  contentDocSubscribed = "contentDocSubscribed"; 
        public static readonly string  contentDocUnsubscribed = "contentDocUnsubscribed"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  IsArchived = "IsArchived"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  Parent = "Parent"; 
        public static readonly string  PublishStatus = "PublishStatus"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  Title = "Title"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContentDocumentHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickContentDocumentHistoryField(string s)
        {
            return new PickContentDocumentHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContentVersionPublishStatus
    {
        public static readonly string  U = "U"; 
        public static readonly string  P = "P"; 
        public static readonly string  R = "R"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContentVersionPublishStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickContentVersionPublishStatus(string s)
        {
            return new PickContentVersionPublishStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContentVersionOrigin
    {
        public static readonly string  C = "C"; 
        public static readonly string  H = "H"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContentVersionOrigin o)
        {
            return o.Value;
        }

        public static implicit operator PickContentVersionOrigin(string s)
        {
            return new PickContentVersionOrigin {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContentVersionHistoryField
    {
        public static readonly string  ContentUrl = "ContentUrl"; 
        public static readonly string  created = "created"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  ExternalDataSource = "ExternalDataSource"; 
        public static readonly string  ExternalDocumentInfo1 = "ExternalDocumentInfo1"; 
        public static readonly string  ExternalDocumentInfo2 = "ExternalDocumentInfo2"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  IsMajorVersion = "IsMajorVersion"; 
        public static readonly string  Language = "Language"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  ReasonForChange = "ReasonForChange"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  SharingOption = "SharingOption"; 
        public static readonly string  Title = "Title"; 
        public static readonly string  contentVersionCommented = "contentVersionCommented"; 
        public static readonly string  contentVersionCreated = "contentVersionCreated"; 
        public static readonly string  contentVersionDataReplaced = "contentVersionDataReplaced"; 
        public static readonly string  contentVersionDeleted = "contentVersionDeleted"; 
        public static readonly string  contentVersionDownloaded = "contentVersionDownloaded"; 
        public static readonly string  contentVersionRated = "contentVersionRated"; 
        public static readonly string  contentVersionUpdated = "contentVersionUpdated"; 
        public static readonly string  contentVersionViewed = "contentVersionViewed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContentVersionHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickContentVersionHistoryField(string s)
        {
            return new PickContentVersionHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContentWorkspaceTagModel
    {
        public static readonly string  U = "U"; 
        public static readonly string  G = "G"; 
        public static readonly string  R = "R"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContentWorkspaceTagModel o)
        {
            return o.Value;
        }

        public static implicit operator PickContentWorkspaceTagModel(string s)
        {
            return new PickContentWorkspaceTagModel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContractOwnerExpirationNotice
    {
        public static readonly string _15 = "15"; 
        public static readonly string _30 = "30"; 
        public static readonly string _45 = "45"; 
        public static readonly string _60 = "60"; 
        public static readonly string _90 = "90"; 
        public static readonly string _120 = "120"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContractOwnerExpirationNotice o)
        {
            return o.Value;
        }

        public static implicit operator PickContractOwnerExpirationNotice(string s)
        {
            return new PickContractOwnerExpirationNotice {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContractStatus
    {
        public static readonly string  InApprovalProcess = "In Approval Process"; 
        public static readonly string  Activated = "Activated"; 
        public static readonly string  Draft = "Draft"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContractStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickContractStatus(string s)
        {
            return new PickContractStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContractStatusCode
    {
        public static readonly string  Draft = "Draft"; 
        public static readonly string  InApproval = "InApproval"; 
        public static readonly string  Activated = "Activated"; 
        public static readonly string  Terminated = "Terminated"; 
        public static readonly string  Expired = "Expired"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContractStatusCode o)
        {
            return o.Value;
        }

        public static implicit operator PickContractStatusCode(string s)
        {
            return new PickContractStatusCode {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContractContactRoleRole
    {
        public static readonly string  BusinessUser = "Business User"; 
        public static readonly string  DecisionMaker = "Decision Maker"; 
        public static readonly string  EconomicBuyer = "Economic Buyer"; 
        public static readonly string  EconomicDecisionMaker = "Economic Decision Maker"; 
        public static readonly string  Evaluator = "Evaluator"; 
        public static readonly string  ExecutiveSponsor = "Executive Sponsor"; 
        public static readonly string  Influencer = "Influencer"; 
        public static readonly string  TechnicalBuyer = "Technical Buyer"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContractContactRoleRole o)
        {
            return o.Value;
        }

        public static implicit operator PickContractContactRoleRole(string s)
        {
            return new PickContractContactRoleRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContractFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContractFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickContractFeedType(string s)
        {
            return new PickContractFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContractHistoryField
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  ActivatedBy = "ActivatedBy"; 
        public static readonly string  ActivatedDate = "ActivatedDate"; 
        public static readonly string  BillingAddress = "BillingAddress"; 
        public static readonly string  BillingCity = "BillingCity"; 
        public static readonly string  BillingCountry = "BillingCountry"; 
        public static readonly string  BillingGeocodeAccuracy = "BillingGeocodeAccuracy"; 
        public static readonly string  BillingLatitude = "BillingLatitude"; 
        public static readonly string  BillingLongitude = "BillingLongitude"; 
        public static readonly string  BillingPostalCode = "BillingPostalCode"; 
        public static readonly string  BillingState = "BillingState"; 
        public static readonly string  BillingStreet = "BillingStreet"; 
        public static readonly string  CompanySigned = "CompanySigned"; 
        public static readonly string  CompanySignedDate = "CompanySignedDate"; 
        public static readonly string  contractActivation = "contractActivation"; 
        public static readonly string  contractApproval = "contractApproval"; 
        public static readonly string  contractConversion = "contractConversion"; 
        public static readonly string  contractDraft = "contractDraft"; 
        public static readonly string  contractExpiration = "contractExpiration"; 
        public static readonly string  ContractTerm = "ContractTerm"; 
        public static readonly string  contractTermination = "contractTermination"; 
        public static readonly string  created = "created"; 
        public static readonly string  CustomerSigned = "CustomerSigned"; 
        public static readonly string  CustomerSignedDate = "CustomerSignedDate"; 
        public static readonly string  CustomerSignedTitle = "CustomerSignedTitle"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  EndDate = "EndDate"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  OwnerExpirationNotice = "OwnerExpirationNotice"; 
        public static readonly string  Pricebook2 = "Pricebook2"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  ShippingAddress = "ShippingAddress"; 
        public static readonly string  ShippingCity = "ShippingCity"; 
        public static readonly string  ShippingCountry = "ShippingCountry"; 
        public static readonly string  ShippingGeocodeAccuracy = "ShippingGeocodeAccuracy"; 
        public static readonly string  ShippingLatitude = "ShippingLatitude"; 
        public static readonly string  ShippingLongitude = "ShippingLongitude"; 
        public static readonly string  ShippingPostalCode = "ShippingPostalCode"; 
        public static readonly string  ShippingState = "ShippingState"; 
        public static readonly string  ShippingStreet = "ShippingStreet"; 
        public static readonly string  SpecialTerms = "SpecialTerms"; 
        public static readonly string  StartDate = "StartDate"; 
        public static readonly string  Status = "Status"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContractHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickContractHistoryField(string s)
        {
            return new PickContractHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickContractStatusStatusCode
    {
        public static readonly string  Draft = "Draft"; 
        public static readonly string  InApproval = "InApproval"; 
        public static readonly string  Activated = "Activated"; 
        public static readonly string  Terminated = "Terminated"; 
        public static readonly string  Expired = "Expired"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickContractStatusStatusCode o)
        {
            return o.Value;
        }

        public static implicit operator PickContractStatusStatusCode(string s)
        {
            return new PickContractStatusStatusCode {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickCronTriggerTimeZoneSidKey
    {
        public static readonly string  PacificKiritimati = "Pacific/Kiritimati"; 
        public static readonly string  PacificTongatapu = "Pacific/Tongatapu"; 
        public static readonly string  PacificChatham = "Pacific/Chatham"; 
        public static readonly string  PacificAuckland = "Pacific/Auckland"; 
        public static readonly string  PacificEnderbury = "Pacific/Enderbury"; 
        public static readonly string  PacificFiji = "Pacific/Fiji"; 
        public static readonly string  AsiaKamchatka = "Asia/Kamchatka"; 
        public static readonly string  AustraliaLordHowe = "Australia/Lord_Howe"; 
        public static readonly string  AustraliaSydney = "Australia/Sydney"; 
        public static readonly string  PacificGuadalcanal = "Pacific/Guadalcanal"; 
        public static readonly string  PacificNorfolk = "Pacific/Norfolk"; 
        public static readonly string  AustraliaAdelaide = "Australia/Adelaide"; 
        public static readonly string  AustraliaBrisbane = "Australia/Brisbane"; 
        public static readonly string  AustraliaDarwin = "Australia/Darwin"; 
        public static readonly string  AsiaSeoul = "Asia/Seoul"; 
        public static readonly string  AsiaTokyo = "Asia/Tokyo"; 
        public static readonly string  AsiaHongKong = "Asia/Hong_Kong"; 
        public static readonly string  AsiaKualaLumpur = "Asia/Kuala_Lumpur"; 
        public static readonly string  AsiaManila = "Asia/Manila"; 
        public static readonly string  AsiaShanghai = "Asia/Shanghai"; 
        public static readonly string  AsiaSingapore = "Asia/Singapore"; 
        public static readonly string  AsiaTaipei = "Asia/Taipei"; 
        public static readonly string  AustraliaPerth = "Australia/Perth"; 
        public static readonly string  AsiaBangkok = "Asia/Bangkok"; 
        public static readonly string  AsiaHoChiMinh = "Asia/Ho_Chi_Minh"; 
        public static readonly string  AsiaJakarta = "Asia/Jakarta"; 
        public static readonly string  AsiaRangoon = "Asia/Rangoon"; 
        public static readonly string  AsiaDhaka = "Asia/Dhaka"; 
        public static readonly string  AsiaKathmandu = "Asia/Kathmandu"; 
        public static readonly string  AsiaColombo = "Asia/Colombo"; 
        public static readonly string  AsiaKolkata = "Asia/Kolkata"; 
        public static readonly string  AsiaKarachi = "Asia/Karachi"; 
        public static readonly string  AsiaTashkent = "Asia/Tashkent"; 
        public static readonly string  AsiaYekaterinburg = "Asia/Yekaterinburg"; 
        public static readonly string  AsiaKabul = "Asia/Kabul"; 
        public static readonly string  AsiaDubai = "Asia/Dubai"; 
        public static readonly string  AsiaTbilisi = "Asia/Tbilisi"; 
        public static readonly string  AsiaTehran = "Asia/Tehran"; 
        public static readonly string  AfricaNairobi = "Africa/Nairobi"; 
        public static readonly string  AsiaBaghdad = "Asia/Baghdad"; 
        public static readonly string  AsiaKuwait = "Asia/Kuwait"; 
        public static readonly string  AsiaRiyadh = "Asia/Riyadh"; 
        public static readonly string  EuropeIstanbul = "Europe/Istanbul"; 
        public static readonly string  EuropeMinsk = "Europe/Minsk"; 
        public static readonly string  EuropeMoscow = "Europe/Moscow"; 
        public static readonly string  AfricaCairo = "Africa/Cairo"; 
        public static readonly string  AfricaJohannesburg = "Africa/Johannesburg"; 
        public static readonly string  AsiaJerusalem = "Asia/Jerusalem"; 
        public static readonly string  EuropeAthens = "Europe/Athens"; 
        public static readonly string  EuropeBucharest = "Europe/Bucharest"; 
        public static readonly string  EuropeHelsinki = "Europe/Helsinki"; 
        public static readonly string  AfricaAlgiers = "Africa/Algiers"; 
        public static readonly string  EuropeAmsterdam = "Europe/Amsterdam"; 
        public static readonly string  EuropeBerlin = "Europe/Berlin"; 
        public static readonly string  EuropeBrussels = "Europe/Brussels"; 
        public static readonly string  EuropeParis = "Europe/Paris"; 
        public static readonly string  EuropePrague = "Europe/Prague"; 
        public static readonly string  EuropeRome = "Europe/Rome"; 
        public static readonly string  EuropeDublin = "Europe/Dublin"; 
        public static readonly string  EuropeLisbon = "Europe/Lisbon"; 
        public static readonly string  EuropeLondon = "Europe/London"; 
        public static readonly string  GMT = "GMT"; 
        public static readonly string  AtlanticCapeVerde = "Atlantic/Cape_Verde"; 
        public static readonly string  AmericaSaoPaulo = "America/Sao_Paulo"; 
        public static readonly string  AtlanticSouthGeorgia = "Atlantic/South_Georgia"; 
        public static readonly string  AmericaArgentinaBuenosAires = "America/Argentina/Buenos_Aires"; 
        public static readonly string  AmericaSantiago = "America/Santiago"; 
        public static readonly string  AmericaStJohns = "America/St_Johns"; 
        public static readonly string  AmericaCaracas = "America/Caracas"; 
        public static readonly string  AmericaHalifax = "America/Halifax"; 
        public static readonly string  AmericaPuertoRico = "America/Puerto_Rico"; 
        public static readonly string  AtlanticBermuda = "Atlantic/Bermuda"; 
        public static readonly string  AmericaBogota = "America/Bogota"; 
        public static readonly string  AmericaIndianaIndianapolis = "America/Indiana/Indianapolis"; 
        public static readonly string  AmericaLima = "America/Lima"; 
        public static readonly string  AmericaNewYork = "America/New_York"; 
        public static readonly string  AmericaPanama = "America/Panama"; 
        public static readonly string  AmericaChicago = "America/Chicago"; 
        public static readonly string  AmericaElSalvador = "America/El_Salvador"; 
        public static readonly string  AmericaMexicoCity = "America/Mexico_City"; 
        public static readonly string  AmericaDenver = "America/Denver"; 
        public static readonly string  AmericaPhoenix = "America/Phoenix"; 
        public static readonly string  AmericaLosAngeles = "America/Los_Angeles"; 
        public static readonly string  AmericaTijuana = "America/Tijuana"; 
        public static readonly string  AmericaAnchorage = "America/Anchorage"; 
        public static readonly string  PacificHonolulu = "Pacific/Honolulu"; 
        public static readonly string  PacificNiue = "Pacific/Niue"; 
        public static readonly string  PacificPagoPago = "Pacific/Pago_Pago"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickCronTriggerTimeZoneSidKey o)
        {
            return o.Value;
        }

        public static implicit operator PickCronTriggerTimeZoneSidKey(string s)
        {
            return new PickCronTriggerTimeZoneSidKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickDashboardLeftSize
    {
        public static readonly string  Narrow = "Narrow"; 
        public static readonly string  Medium = "Medium"; 
        public static readonly string  Wide = "Wide"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickDashboardLeftSize o)
        {
            return o.Value;
        }

        public static implicit operator PickDashboardLeftSize(string s)
        {
            return new PickDashboardLeftSize {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickDashboardMiddleSize
    {
        public static readonly string  Narrow = "Narrow"; 
        public static readonly string  Medium = "Medium"; 
        public static readonly string  Wide = "Wide"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickDashboardMiddleSize o)
        {
            return o.Value;
        }

        public static implicit operator PickDashboardMiddleSize(string s)
        {
            return new PickDashboardMiddleSize {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickDashboardRightSize
    {
        public static readonly string  Narrow = "Narrow"; 
        public static readonly string  Medium = "Medium"; 
        public static readonly string  Wide = "Wide"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickDashboardRightSize o)
        {
            return o.Value;
        }

        public static implicit operator PickDashboardRightSize(string s)
        {
            return new PickDashboardRightSize {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickDashboardBackgroundDirection
    {
        public static readonly string  TopToBottom = "TopToBottom"; 
        public static readonly string  LeftToRight = "LeftToRight"; 
        public static readonly string  Diagonal = "Diagonal"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickDashboardBackgroundDirection o)
        {
            return o.Value;
        }

        public static implicit operator PickDashboardBackgroundDirection(string s)
        {
            return new PickDashboardBackgroundDirection {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickDashboardType
    {
        public static readonly string  SpecifiedUser = "SpecifiedUser"; 
        public static readonly string  LoggedInUser = "LoggedInUser"; 
        public static readonly string  MyTeamUser = "MyTeamUser"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickDashboardType o)
        {
            return o.Value;
        }

        public static implicit operator PickDashboardType(string s)
        {
            return new PickDashboardType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickDashboardFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickDashboardFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickDashboardFeedType(string s)
        {
            return new PickDashboardFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailMessageStatus
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
        public static readonly string _4 = "4"; 
        public static readonly string _5 = "5"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailMessageStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailMessageStatus(string s)
        {
            return new PickEmailMessageStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailServicesFunctionAttachmentOption
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
        public static readonly string _4 = "4"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailServicesFunctionAttachmentOption o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailServicesFunctionAttachmentOption(string s)
        {
            return new PickEmailServicesFunctionAttachmentOption {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailServicesFunctionOverLimitAction
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailServicesFunctionOverLimitAction o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailServicesFunctionOverLimitAction(string s)
        {
            return new PickEmailServicesFunctionOverLimitAction {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailServicesFunctionFunctionInactiveAction
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailServicesFunctionFunctionInactiveAction o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailServicesFunctionFunctionInactiveAction(string s)
        {
            return new PickEmailServicesFunctionFunctionInactiveAction {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailServicesFunctionAddressInactiveAction
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailServicesFunctionAddressInactiveAction o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailServicesFunctionAddressInactiveAction(string s)
        {
            return new PickEmailServicesFunctionAddressInactiveAction {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailServicesFunctionAuthenticationFailureAction
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailServicesFunctionAuthenticationFailureAction o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailServicesFunctionAuthenticationFailureAction(string s)
        {
            return new PickEmailServicesFunctionAuthenticationFailureAction {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailServicesFunctionAuthorizationFailureAction
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailServicesFunctionAuthorizationFailureAction o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailServicesFunctionAuthorizationFailureAction(string s)
        {
            return new PickEmailServicesFunctionAuthorizationFailureAction {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailTemplateTemplateStyle
    {
        public static readonly string  none = "none"; 
        public static readonly string  freeForm = "freeForm"; 
        public static readonly string  formalLetter = "formalLetter"; 
        public static readonly string  promotionRight = "promotionRight"; 
        public static readonly string  promotionLeft = "promotionLeft"; 
        public static readonly string  newsletter = "newsletter"; 
        public static readonly string  products = "products"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailTemplateTemplateStyle o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailTemplateTemplateStyle(string s)
        {
            return new PickEmailTemplateTemplateStyle {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailTemplateTemplateType
    {
        public static readonly string  text = "text"; 
        public static readonly string  html = "html"; 
        public static readonly string  custom = "custom"; 
        public static readonly string  visualforce = "visualforce"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailTemplateTemplateType o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailTemplateTemplateType(string s)
        {
            return new PickEmailTemplateTemplateType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEmailTemplateEncoding
    {
        public static readonly string  UTF8 = "UTF-8"; 
        public static readonly string  ISO88591 = "ISO-8859-1"; 
        public static readonly string  ShiftJIS = "Shift_JIS"; 
        public static readonly string  ISO2022JP = "ISO-2022-JP"; 
        public static readonly string  EUCJP = "EUC-JP"; 
        public static readonly string  ksc56011987 = "ks_c_5601-1987"; 
        public static readonly string  Big5 = "Big5"; 
        public static readonly string  GB2312 = "GB2312"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEmailTemplateEncoding o)
        {
            return o.Value;
        }

        public static implicit operator PickEmailTemplateEncoding(string s)
        {
            return new PickEmailTemplateEncoding {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventShowAs
    {
        public static readonly string  Busy = "Busy"; 
        public static readonly string  OutOfOffice = "OutOfOffice"; 
        public static readonly string  Free = "Free"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventShowAs o)
        {
            return o.Value;
        }

        public static implicit operator PickEventShowAs(string s)
        {
            return new PickEventShowAs {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventGroupEventType
    {
        public static readonly string _0 = "0"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventGroupEventType o)
        {
            return o.Value;
        }

        public static implicit operator PickEventGroupEventType(string s)
        {
            return new PickEventGroupEventType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventRecurrenceTimeZoneSidKey
    {
        public static readonly string  PacificKiritimati = "Pacific/Kiritimati"; 
        public static readonly string  PacificTongatapu = "Pacific/Tongatapu"; 
        public static readonly string  PacificChatham = "Pacific/Chatham"; 
        public static readonly string  PacificAuckland = "Pacific/Auckland"; 
        public static readonly string  PacificEnderbury = "Pacific/Enderbury"; 
        public static readonly string  PacificFiji = "Pacific/Fiji"; 
        public static readonly string  AsiaKamchatka = "Asia/Kamchatka"; 
        public static readonly string  AustraliaLordHowe = "Australia/Lord_Howe"; 
        public static readonly string  AustraliaSydney = "Australia/Sydney"; 
        public static readonly string  PacificGuadalcanal = "Pacific/Guadalcanal"; 
        public static readonly string  PacificNorfolk = "Pacific/Norfolk"; 
        public static readonly string  AustraliaAdelaide = "Australia/Adelaide"; 
        public static readonly string  AustraliaBrisbane = "Australia/Brisbane"; 
        public static readonly string  AustraliaDarwin = "Australia/Darwin"; 
        public static readonly string  AsiaSeoul = "Asia/Seoul"; 
        public static readonly string  AsiaTokyo = "Asia/Tokyo"; 
        public static readonly string  AsiaHongKong = "Asia/Hong_Kong"; 
        public static readonly string  AsiaKualaLumpur = "Asia/Kuala_Lumpur"; 
        public static readonly string  AsiaManila = "Asia/Manila"; 
        public static readonly string  AsiaShanghai = "Asia/Shanghai"; 
        public static readonly string  AsiaSingapore = "Asia/Singapore"; 
        public static readonly string  AsiaTaipei = "Asia/Taipei"; 
        public static readonly string  AustraliaPerth = "Australia/Perth"; 
        public static readonly string  AsiaBangkok = "Asia/Bangkok"; 
        public static readonly string  AsiaHoChiMinh = "Asia/Ho_Chi_Minh"; 
        public static readonly string  AsiaJakarta = "Asia/Jakarta"; 
        public static readonly string  AsiaRangoon = "Asia/Rangoon"; 
        public static readonly string  AsiaDhaka = "Asia/Dhaka"; 
        public static readonly string  AsiaKathmandu = "Asia/Kathmandu"; 
        public static readonly string  AsiaColombo = "Asia/Colombo"; 
        public static readonly string  AsiaKolkata = "Asia/Kolkata"; 
        public static readonly string  AsiaKarachi = "Asia/Karachi"; 
        public static readonly string  AsiaTashkent = "Asia/Tashkent"; 
        public static readonly string  AsiaYekaterinburg = "Asia/Yekaterinburg"; 
        public static readonly string  AsiaKabul = "Asia/Kabul"; 
        public static readonly string  AsiaDubai = "Asia/Dubai"; 
        public static readonly string  AsiaTbilisi = "Asia/Tbilisi"; 
        public static readonly string  AsiaTehran = "Asia/Tehran"; 
        public static readonly string  AfricaNairobi = "Africa/Nairobi"; 
        public static readonly string  AsiaBaghdad = "Asia/Baghdad"; 
        public static readonly string  AsiaKuwait = "Asia/Kuwait"; 
        public static readonly string  AsiaRiyadh = "Asia/Riyadh"; 
        public static readonly string  EuropeIstanbul = "Europe/Istanbul"; 
        public static readonly string  EuropeMinsk = "Europe/Minsk"; 
        public static readonly string  EuropeMoscow = "Europe/Moscow"; 
        public static readonly string  AfricaCairo = "Africa/Cairo"; 
        public static readonly string  AfricaJohannesburg = "Africa/Johannesburg"; 
        public static readonly string  AsiaJerusalem = "Asia/Jerusalem"; 
        public static readonly string  EuropeAthens = "Europe/Athens"; 
        public static readonly string  EuropeBucharest = "Europe/Bucharest"; 
        public static readonly string  EuropeHelsinki = "Europe/Helsinki"; 
        public static readonly string  AfricaAlgiers = "Africa/Algiers"; 
        public static readonly string  EuropeAmsterdam = "Europe/Amsterdam"; 
        public static readonly string  EuropeBerlin = "Europe/Berlin"; 
        public static readonly string  EuropeBrussels = "Europe/Brussels"; 
        public static readonly string  EuropeParis = "Europe/Paris"; 
        public static readonly string  EuropePrague = "Europe/Prague"; 
        public static readonly string  EuropeRome = "Europe/Rome"; 
        public static readonly string  EuropeDublin = "Europe/Dublin"; 
        public static readonly string  EuropeLisbon = "Europe/Lisbon"; 
        public static readonly string  EuropeLondon = "Europe/London"; 
        public static readonly string  GMT = "GMT"; 
        public static readonly string  AtlanticCapeVerde = "Atlantic/Cape_Verde"; 
        public static readonly string  AmericaSaoPaulo = "America/Sao_Paulo"; 
        public static readonly string  AtlanticSouthGeorgia = "Atlantic/South_Georgia"; 
        public static readonly string  AmericaArgentinaBuenosAires = "America/Argentina/Buenos_Aires"; 
        public static readonly string  AmericaSantiago = "America/Santiago"; 
        public static readonly string  AmericaStJohns = "America/St_Johns"; 
        public static readonly string  AmericaCaracas = "America/Caracas"; 
        public static readonly string  AmericaHalifax = "America/Halifax"; 
        public static readonly string  AmericaPuertoRico = "America/Puerto_Rico"; 
        public static readonly string  AtlanticBermuda = "Atlantic/Bermuda"; 
        public static readonly string  AmericaBogota = "America/Bogota"; 
        public static readonly string  AmericaIndianaIndianapolis = "America/Indiana/Indianapolis"; 
        public static readonly string  AmericaLima = "America/Lima"; 
        public static readonly string  AmericaNewYork = "America/New_York"; 
        public static readonly string  AmericaPanama = "America/Panama"; 
        public static readonly string  AmericaChicago = "America/Chicago"; 
        public static readonly string  AmericaElSalvador = "America/El_Salvador"; 
        public static readonly string  AmericaMexicoCity = "America/Mexico_City"; 
        public static readonly string  AmericaDenver = "America/Denver"; 
        public static readonly string  AmericaPhoenix = "America/Phoenix"; 
        public static readonly string  AmericaLosAngeles = "America/Los_Angeles"; 
        public static readonly string  AmericaTijuana = "America/Tijuana"; 
        public static readonly string  AmericaAnchorage = "America/Anchorage"; 
        public static readonly string  PacificHonolulu = "Pacific/Honolulu"; 
        public static readonly string  PacificNiue = "Pacific/Niue"; 
        public static readonly string  PacificPagoPago = "Pacific/Pago_Pago"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventRecurrenceTimeZoneSidKey o)
        {
            return o.Value;
        }

        public static implicit operator PickEventRecurrenceTimeZoneSidKey(string s)
        {
            return new PickEventRecurrenceTimeZoneSidKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventRecurrenceType
    {
        public static readonly string  RecursDaily = "RecursDaily"; 
        public static readonly string  RecursEveryWeekday = "RecursEveryWeekday"; 
        public static readonly string  RecursMonthly = "RecursMonthly"; 
        public static readonly string  RecursMonthlyNth = "RecursMonthlyNth"; 
        public static readonly string  RecursWeekly = "RecursWeekly"; 
        public static readonly string  RecursYearly = "RecursYearly"; 
        public static readonly string  RecursYearlyNth = "RecursYearlyNth"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventRecurrenceType o)
        {
            return o.Value;
        }

        public static implicit operator PickEventRecurrenceType(string s)
        {
            return new PickEventRecurrenceType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventRecurrenceInstance
    {
        public static readonly string  First = "First"; 
        public static readonly string  Second = "Second"; 
        public static readonly string  Third = "Third"; 
        public static readonly string  Fourth = "Fourth"; 
        public static readonly string  Last = "Last"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventRecurrenceInstance o)
        {
            return o.Value;
        }

        public static implicit operator PickEventRecurrenceInstance(string s)
        {
            return new PickEventRecurrenceInstance {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventRecurrenceMonthOfYear
    {
        public static readonly string  January = "January"; 
        public static readonly string  February = "February"; 
        public static readonly string  March = "March"; 
        public static readonly string  April = "April"; 
        public static readonly string  May = "May"; 
        public static readonly string  June = "June"; 
        public static readonly string  July = "July"; 
        public static readonly string  August = "August"; 
        public static readonly string  September = "September"; 
        public static readonly string  October = "October"; 
        public static readonly string  November = "November"; 
        public static readonly string  December = "December"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventRecurrenceMonthOfYear o)
        {
            return o.Value;
        }

        public static implicit operator PickEventRecurrenceMonthOfYear(string s)
        {
            return new PickEventRecurrenceMonthOfYear {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventAttendeeStatus
    {
        public static readonly string  New = "New"; 
        public static readonly string  Declined = "Declined"; 
        public static readonly string  Accepted = "Accepted"; 
        public static readonly string  Uninvited = "Uninvited"; 
        public static readonly string  Maybe = "Maybe"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventAttendeeStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickEventAttendeeStatus(string s)
        {
            return new PickEventAttendeeStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickEventFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickEventFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickEventFeedType(string s)
        {
            return new PickEventFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFeedPostType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFeedPostType o)
        {
            return o.Value;
        }

        public static implicit operator PickFeedPostType(string s)
        {
            return new PickFeedPostType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFiscalYearSettingsYearType
    {
        public static readonly string  Standard = "Standard"; 
        public static readonly string  Custom = "Custom"; 
        public static readonly string  Placeholder = "Placeholder"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFiscalYearSettingsYearType o)
        {
            return o.Value;
        }

        public static implicit operator PickFiscalYearSettingsYearType(string s)
        {
            return new PickFiscalYearSettingsYearType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFiscalYearSettingsQuarterLabelScheme
    {
        public static readonly string  NumberByYear = "NumberByYear"; 
        public static readonly string  Custom = "Custom"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFiscalYearSettingsQuarterLabelScheme o)
        {
            return o.Value;
        }

        public static implicit operator PickFiscalYearSettingsQuarterLabelScheme(string s)
        {
            return new PickFiscalYearSettingsQuarterLabelScheme {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFiscalYearSettingsPeriodLabelScheme
    {
        public static readonly string  NumberByYear = "NumberByYear"; 
        public static readonly string  NumberByQuarter = "NumberByQuarter"; 
        public static readonly string  StandardMonths = "StandardMonths"; 
        public static readonly string  Custom = "Custom"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFiscalYearSettingsPeriodLabelScheme o)
        {
            return o.Value;
        }

        public static implicit operator PickFiscalYearSettingsPeriodLabelScheme(string s)
        {
            return new PickFiscalYearSettingsPeriodLabelScheme {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFiscalYearSettingsWeekLabelScheme
    {
        public static readonly string  NumberByYear = "NumberByYear"; 
        public static readonly string  NumberByQuarter = "NumberByQuarter"; 
        public static readonly string  NumberByPeriod = "NumberByPeriod"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFiscalYearSettingsWeekLabelScheme o)
        {
            return o.Value;
        }

        public static implicit operator PickFiscalYearSettingsWeekLabelScheme(string s)
        {
            return new PickFiscalYearSettingsWeekLabelScheme {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFiscalYearSettingsQuarterPrefix
    {
        public static readonly string  Quarter = "Quarter"; 
        public static readonly string  FQ = "FQ"; 
        public static readonly string  Q = "Q"; 
        public static readonly string  Trimester = "Trimester"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFiscalYearSettingsQuarterPrefix o)
        {
            return o.Value;
        }

        public static implicit operator PickFiscalYearSettingsQuarterPrefix(string s)
        {
            return new PickFiscalYearSettingsQuarterPrefix {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFiscalYearSettingsPeriodPrefix
    {
        public static readonly string  Period = "Period"; 
        public static readonly string  FP = "FP"; 
        public static readonly string  P = "P"; 
        public static readonly string  Month = "Month"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFiscalYearSettingsPeriodPrefix o)
        {
            return o.Value;
        }

        public static implicit operator PickFiscalYearSettingsPeriodPrefix(string s)
        {
            return new PickFiscalYearSettingsPeriodPrefix {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFolderAccessType
    {
        public static readonly string  Shared = "Shared"; 
        public static readonly string  Public = "Public"; 
        public static readonly string  Hidden = "Hidden"; 
        public static readonly string  PublicInternal = "PublicInternal"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFolderAccessType o)
        {
            return o.Value;
        }

        public static implicit operator PickFolderAccessType(string s)
        {
            return new PickFolderAccessType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickFolderType
    {
        public static readonly string  Document = "Document"; 
        public static readonly string  Email = "Email"; 
        public static readonly string  Report = "Report"; 
        public static readonly string  Dashboard = "Dashboard"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickFolderType o)
        {
            return o.Value;
        }

        public static implicit operator PickFolderType(string s)
        {
            return new PickFolderType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickForecastShareAccessLevel
    {
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickForecastShareAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickForecastShareAccessLevel(string s)
        {
            return new PickForecastShareAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickForecastShareRowCause
    {
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Manual = "Manual"; 
        public static readonly string  Rule = "Rule"; 
        public static readonly string  ImplicitChild = "ImplicitChild"; 
        public static readonly string  ImplicitParent = "ImplicitParent"; 
        public static readonly string  ImplicitPerson = "ImplicitPerson"; 
        public static readonly string  Team = "Team"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryManual = "TerritoryManual"; 
        public static readonly string  TerritoryRule = "TerritoryRule"; 
        public static readonly string  Territory2Forecast = "Territory2Forecast"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickForecastShareRowCause o)
        {
            return o.Value;
        }

        public static implicit operator PickForecastShareRowCause(string s)
        {
            return new PickForecastShareRowCause {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickGroupType
    {
        public static readonly string  AllCustomerPortal = "AllCustomerPortal"; 
        public static readonly string  CollaborationGroup = "CollaborationGroup"; 
        public static readonly string  Manager = "Manager"; 
        public static readonly string  ManagerAndSubordinatesInternal = "ManagerAndSubordinatesInternal"; 
        public static readonly string  Organization = "Organization"; 
        public static readonly string  PRMOrganization = "PRMOrganization"; 
        public static readonly string  Queue = "Queue"; 
        public static readonly string  Regular = "Regular"; 
        public static readonly string  Role = "Role"; 
        public static readonly string  RoleAndSubordinates = "RoleAndSubordinates"; 
        public static readonly string  RoleAndSubordinatesInternal = "RoleAndSubordinatesInternal"; 
        public static readonly string  SharingRuleGroup = "SharingRuleGroup"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryAndSubordinates = "TerritoryAndSubordinates"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickGroupType o)
        {
            return o.Value;
        }

        public static implicit operator PickGroupType(string s)
        {
            return new PickGroupType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickHolidayRecurrenceType
    {
        public static readonly string  RecursDaily = "RecursDaily"; 
        public static readonly string  RecursEveryWeekday = "RecursEveryWeekday"; 
        public static readonly string  RecursMonthly = "RecursMonthly"; 
        public static readonly string  RecursMonthlyNth = "RecursMonthlyNth"; 
        public static readonly string  RecursWeekly = "RecursWeekly"; 
        public static readonly string  RecursYearly = "RecursYearly"; 
        public static readonly string  RecursYearlyNth = "RecursYearlyNth"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickHolidayRecurrenceType o)
        {
            return o.Value;
        }

        public static implicit operator PickHolidayRecurrenceType(string s)
        {
            return new PickHolidayRecurrenceType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickHolidayRecurrenceInstance
    {
        public static readonly string  First = "First"; 
        public static readonly string  Second = "Second"; 
        public static readonly string  Third = "Third"; 
        public static readonly string  Fourth = "Fourth"; 
        public static readonly string  Last = "Last"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickHolidayRecurrenceInstance o)
        {
            return o.Value;
        }

        public static implicit operator PickHolidayRecurrenceInstance(string s)
        {
            return new PickHolidayRecurrenceInstance {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickHolidayRecurrenceMonthOfYear
    {
        public static readonly string  January = "January"; 
        public static readonly string  February = "February"; 
        public static readonly string  March = "March"; 
        public static readonly string  April = "April"; 
        public static readonly string  May = "May"; 
        public static readonly string  June = "June"; 
        public static readonly string  July = "July"; 
        public static readonly string  August = "August"; 
        public static readonly string  September = "September"; 
        public static readonly string  October = "October"; 
        public static readonly string  November = "November"; 
        public static readonly string  December = "December"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickHolidayRecurrenceMonthOfYear o)
        {
            return o.Value;
        }

        public static implicit operator PickHolidayRecurrenceMonthOfYear(string s)
        {
            return new PickHolidayRecurrenceMonthOfYear {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickIdeaStatus
    {
    
        public string Value { get; set; }

        public static implicit operator string(PickIdeaStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickIdeaStatus(string s)
        {
            return new PickIdeaStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadSalutation
    {
        public static readonly string  Mr = "Mr."; 
        public static readonly string  Ms = "Ms."; 
        public static readonly string  Mrs = "Mrs."; 
        public static readonly string  Dr = "Dr."; 
        public static readonly string  Prof = "Prof."; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadSalutation o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadSalutation(string s)
        {
            return new PickLeadSalutation {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadLeadSource
    {
        public static readonly string  Web = "Web"; 
        public static readonly string  PhoneInquiry = "Phone Inquiry"; 
        public static readonly string  PartnerReferral = "Partner Referral"; 
        public static readonly string  PurchasedList = "Purchased List"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadLeadSource o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadLeadSource(string s)
        {
            return new PickLeadLeadSource {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadStatus
    {
        public static readonly string  OpenNotContacted = "Open - Not Contacted"; 
        public static readonly string  WorkingContacted = "Working - Contacted"; 
        public static readonly string  ClosedConverted = "Closed - Converted"; 
        public static readonly string  ClosedNotConverted = "Closed - Not Converted"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadStatus(string s)
        {
            return new PickLeadStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadIndustry
    {
        public static readonly string  Agriculture = "Agriculture"; 
        public static readonly string  Apparel = "Apparel"; 
        public static readonly string  Banking = "Banking"; 
        public static readonly string  Biotechnology = "Biotechnology"; 
        public static readonly string  Chemicals = "Chemicals"; 
        public static readonly string  Communications = "Communications"; 
        public static readonly string  Construction = "Construction"; 
        public static readonly string  Consulting = "Consulting"; 
        public static readonly string  Education = "Education"; 
        public static readonly string  Electronics = "Electronics"; 
        public static readonly string  Energy = "Energy"; 
        public static readonly string  Engineering = "Engineering"; 
        public static readonly string  Entertainment = "Entertainment"; 
        public static readonly string  Environmental = "Environmental"; 
        public static readonly string  Finance = "Finance"; 
        public static readonly string  FoodBeverage = "Food & Beverage"; 
        public static readonly string  Government = "Government"; 
        public static readonly string  Healthcare = "Healthcare"; 
        public static readonly string  Hospitality = "Hospitality"; 
        public static readonly string  Insurance = "Insurance"; 
        public static readonly string  Machinery = "Machinery"; 
        public static readonly string  Manufacturing = "Manufacturing"; 
        public static readonly string  Media = "Media"; 
        public static readonly string  NotForProfit = "Not For Profit"; 
        public static readonly string  Recreation = "Recreation"; 
        public static readonly string  Retail = "Retail"; 
        public static readonly string  Shipping = "Shipping"; 
        public static readonly string  Technology = "Technology"; 
        public static readonly string  Telecommunications = "Telecommunications"; 
        public static readonly string  Transportation = "Transportation"; 
        public static readonly string  Utilities = "Utilities"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadIndustry o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadIndustry(string s)
        {
            return new PickLeadIndustry {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadRating
    {
        public static readonly string  Hot = "Hot"; 
        public static readonly string  Warm = "Warm"; 
        public static readonly string  Cold = "Cold"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadRating o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadRating(string s)
        {
            return new PickLeadRating {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadProductInterest__c
    {
        public static readonly string  GC1000series = "GC1000 series"; 
        public static readonly string  GC5000series = "GC5000 series"; 
        public static readonly string  GC3000series = "GC3000 series"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadProductInterest__c o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadProductInterest__c(string s)
        {
            return new PickLeadProductInterest__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadPrimary__c
    {
        public static readonly string  No = "No"; 
        public static readonly string  Yes = "Yes"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadPrimary__c o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadPrimary__c(string s)
        {
            return new PickLeadPrimary__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadFeedType(string s)
        {
            return new PickLeadFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadHistoryField
    {
        public static readonly string  Address = "Address"; 
        public static readonly string  AnnualRevenue = "AnnualRevenue"; 
        public static readonly string  City = "City"; 
        public static readonly string  CleanStatus = "CleanStatus"; 
        public static readonly string  Company = "Company"; 
        public static readonly string  CompanyDunsNumber = "CompanyDunsNumber"; 
        public static readonly string  Country = "Country"; 
        public static readonly string  created = "created"; 
        public static readonly string  CurrentGeneratorsc = "CurrentGenerators__c"; 
        public static readonly string  DandbCompany = "DandbCompany"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  DoNotCall = "DoNotCall"; 
        public static readonly string  Email = "Email"; 
        public static readonly string  EmailBouncedDate = "EmailBouncedDate"; 
        public static readonly string  EmailBouncedReason = "EmailBouncedReason"; 
        public static readonly string  Fax = "Fax"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  FirstName = "FirstName"; 
        public static readonly string  GeocodeAccuracy = "GeocodeAccuracy"; 
        public static readonly string  HasOptedOutOfEmail = "HasOptedOutOfEmail"; 
        public static readonly string  HasOptedOutOfFax = "HasOptedOutOfFax"; 
        public static readonly string  Industry = "Industry"; 
        public static readonly string  IsUnreadByOwner = "IsUnreadByOwner"; 
        public static readonly string  Jigsaw = "Jigsaw"; 
        public static readonly string  LastName = "LastName"; 
        public static readonly string  Latitude = "Latitude"; 
        public static readonly string  leadConverted = "leadConverted"; 
        public static readonly string  leadMerged = "leadMerged"; 
        public static readonly string  LeadSource = "LeadSource"; 
        public static readonly string  Longitude = "Longitude"; 
        public static readonly string  MobilePhone = "MobilePhone"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  NumberOfEmployees = "NumberOfEmployees"; 
        public static readonly string  NumberofLocationsc = "NumberofLocations__c"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  Phone = "Phone"; 
        public static readonly string  PostalCode = "PostalCode"; 
        public static readonly string  Primaryc = "Primary__c"; 
        public static readonly string  ProductInterestc = "ProductInterest__c"; 
        public static readonly string  Rating = "Rating"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  Salutation = "Salutation"; 
        public static readonly string  SICCodec = "SICCode__c"; 
        public static readonly string  State = "State"; 
        public static readonly string  Status = "Status"; 
        public static readonly string  Street = "Street"; 
        public static readonly string  Title = "Title"; 
        public static readonly string  Website = "Website"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadHistoryField(string s)
        {
            return new PickLeadHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadShareLeadAccessLevel
    {
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadShareLeadAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadShareLeadAccessLevel(string s)
        {
            return new PickLeadShareLeadAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickLeadShareRowCause
    {
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Manual = "Manual"; 
        public static readonly string  Rule = "Rule"; 
        public static readonly string  ImplicitChild = "ImplicitChild"; 
        public static readonly string  ImplicitParent = "ImplicitParent"; 
        public static readonly string  ImplicitPerson = "ImplicitPerson"; 
        public static readonly string  Team = "Team"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryManual = "TerritoryManual"; 
        public static readonly string  TerritoryRule = "TerritoryRule"; 
        public static readonly string  Territory2Forecast = "Territory2Forecast"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickLeadShareRowCause o)
        {
            return o.Value;
        }

        public static implicit operator PickLeadShareRowCause(string s)
        {
            return new PickLeadShareRowCause {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickNameType
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  AccountContactRole = "AccountContactRole"; 
        public static readonly string  Asset = "Asset"; 
        public static readonly string  Campaign = "Campaign"; 
        public static readonly string  Case = "Case"; 
        public static readonly string  CollaborationGroup = "CollaborationGroup"; 
        public static readonly string  Contact = "Contact"; 
        public static readonly string  ContentDocument = "ContentDocument"; 
        public static readonly string  ContentVersion = "ContentVersion"; 
        public static readonly string  Contract = "Contract"; 
        public static readonly string  Dashboard = "Dashboard"; 
        public static readonly string  Document = "Document"; 
        public static readonly string  EmailMessage = "EmailMessage"; 
        public static readonly string  Event = "Event"; 
        public static readonly string  Idea = "Idea"; 
        public static readonly string  IdeaComment = "IdeaComment"; 
        public static readonly string  Lead = "Lead"; 
        public static readonly string  Opportunity = "Opportunity"; 
        public static readonly string  Order = "Order"; 
        public static readonly string  OrderItem = "OrderItem"; 
        public static readonly string  Pricebook2 = "Pricebook2"; 
        public static readonly string  Product2 = "Product2"; 
        public static readonly string  Queue = "Queue"; 
        public static readonly string  Report = "Report"; 
        public static readonly string  SelfServiceUser = "SelfServiceUser"; 
        public static readonly string  Solution = "Solution"; 
        public static readonly string  Task = "Task"; 
        public static readonly string  User = "User"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickNameType o)
        {
            return o.Value;
        }

        public static implicit operator PickNameType(string s)
        {
            return new PickNameType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickNewsFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickNewsFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickNewsFeedType(string s)
        {
            return new PickNewsFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpenActivityStatus
    {
        public static readonly string  NotStarted = "Not Started"; 
        public static readonly string  InProgress = "In Progress"; 
        public static readonly string  Completed = "Completed"; 
        public static readonly string  Waitingonsomeoneelse = "Waiting on someone else"; 
        public static readonly string  Deferred = "Deferred"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpenActivityStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickOpenActivityStatus(string s)
        {
            return new PickOpenActivityStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpenActivityPriority
    {
        public static readonly string  High = "High"; 
        public static readonly string  Normal = "Normal"; 
        public static readonly string  Low = "Low"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpenActivityPriority o)
        {
            return o.Value;
        }

        public static implicit operator PickOpenActivityPriority(string s)
        {
            return new PickOpenActivityPriority {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpenActivityActivityType
    {
        public static readonly string  Call = "Call"; 
        public static readonly string  Email = "Email"; 
        public static readonly string  Meeting = "Meeting"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpenActivityActivityType o)
        {
            return o.Value;
        }

        public static implicit operator PickOpenActivityActivityType(string s)
        {
            return new PickOpenActivityActivityType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpenActivityCallType
    {
        public static readonly string  Internal = "Internal"; 
        public static readonly string  Inbound = "Inbound"; 
        public static readonly string  Outbound = "Outbound"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpenActivityCallType o)
        {
            return o.Value;
        }

        public static implicit operator PickOpenActivityCallType(string s)
        {
            return new PickOpenActivityCallType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityStageName
    {
        public static readonly string  Prospecting = "Prospecting"; 
        public static readonly string  Qualification = "Qualification"; 
        public static readonly string  NeedsAnalysis = "Needs Analysis"; 
        public static readonly string  ValueProposition = "Value Proposition"; 
        public static readonly string  IdDecisionMakers = "Id. Decision Makers"; 
        public static readonly string  PerceptionAnalysis = "Perception Analysis"; 
        public static readonly string  ProposalPriceQuote = "Proposal/Price Quote"; 
        public static readonly string  NegotiationReview = "Negotiation/Review"; 
        public static readonly string  ClosedWon = "Closed Won"; 
        public static readonly string  ClosedLost = "Closed Lost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityStageName o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityStageName(string s)
        {
            return new PickOpportunityStageName {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityType
    {
        public static readonly string  ExistingCustomerUpgrade = "Existing Customer - Upgrade"; 
        public static readonly string  ExistingCustomerReplacement = "Existing Customer - Replacement"; 
        public static readonly string  ExistingCustomerDowngrade = "Existing Customer - Downgrade"; 
        public static readonly string  NewCustomer = "New Customer"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityType o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityType(string s)
        {
            return new PickOpportunityType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityLeadSource
    {
        public static readonly string  Web = "Web"; 
        public static readonly string  PhoneInquiry = "Phone Inquiry"; 
        public static readonly string  PartnerReferral = "Partner Referral"; 
        public static readonly string  PurchasedList = "Purchased List"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityLeadSource o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityLeadSource(string s)
        {
            return new PickOpportunityLeadSource {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityForecastCategory
    {
        public static readonly string  Omitted = "Omitted"; 
        public static readonly string  Pipeline = "Pipeline"; 
        public static readonly string  BestCase = "BestCase"; 
        public static readonly string  Forecast = "Forecast"; 
        public static readonly string  Closed = "Closed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityForecastCategory o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityForecastCategory(string s)
        {
            return new PickOpportunityForecastCategory {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityForecastCategoryName
    {
        public static readonly string  Omitted = "Omitted"; 
        public static readonly string  Pipeline = "Pipeline"; 
        public static readonly string  BestCase = "Best Case"; 
        public static readonly string  Commit = "Commit"; 
        public static readonly string  Closed = "Closed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityForecastCategoryName o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityForecastCategoryName(string s)
        {
            return new PickOpportunityForecastCategoryName {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityDeliveryInstallationStatus__c
    {
        public static readonly string  Inprogress = "In progress"; 
        public static readonly string  Yettobegin = "Yet to begin"; 
        public static readonly string  Completed = "Completed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityDeliveryInstallationStatus__c o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityDeliveryInstallationStatus__c(string s)
        {
            return new PickOpportunityDeliveryInstallationStatus__c {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityContactRoleRole
    {
        public static readonly string  BusinessUser = "Business User"; 
        public static readonly string  DecisionMaker = "Decision Maker"; 
        public static readonly string  EconomicBuyer = "Economic Buyer"; 
        public static readonly string  EconomicDecisionMaker = "Economic Decision Maker"; 
        public static readonly string  Evaluator = "Evaluator"; 
        public static readonly string  ExecutiveSponsor = "Executive Sponsor"; 
        public static readonly string  Influencer = "Influencer"; 
        public static readonly string  TechnicalBuyer = "Technical Buyer"; 
        public static readonly string  Other = "Other"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityContactRoleRole o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityContactRoleRole(string s)
        {
            return new PickOpportunityContactRoleRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityFeedType(string s)
        {
            return new PickOpportunityFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityFieldHistoryField
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  Amount = "Amount"; 
        public static readonly string  Campaign = "Campaign"; 
        public static readonly string  CloseDate = "CloseDate"; 
        public static readonly string  Contract = "Contract"; 
        public static readonly string  created = "created"; 
        public static readonly string  opportunityCreatedFromLead = "opportunityCreatedFromLead"; 
        public static readonly string  CurrentGeneratorsc = "CurrentGenerators__c"; 
        public static readonly string  DeliveryInstallationStatusc = "DeliveryInstallationStatus__c"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  ForecastCategoryName = "ForecastCategoryName"; 
        public static readonly string  IsPrivate = "IsPrivate"; 
        public static readonly string  LeadSource = "LeadSource"; 
        public static readonly string  MainCompetitorsc = "MainCompetitors__c"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  NextStep = "NextStep"; 
        public static readonly string  OrderNumberc = "OrderNumber__c"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  Probability = "Probability"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  StageName = "StageName"; 
        public static readonly string  TotalOpportunityQuantity = "TotalOpportunityQuantity"; 
        public static readonly string  TrackingNumberc = "TrackingNumber__c"; 
        public static readonly string  Type = "Type"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityFieldHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityFieldHistoryField(string s)
        {
            return new PickOpportunityFieldHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityHistoryStageName
    {
        public static readonly string  Prospecting = "Prospecting"; 
        public static readonly string  Qualification = "Qualification"; 
        public static readonly string  NeedsAnalysis = "Needs Analysis"; 
        public static readonly string  ValueProposition = "Value Proposition"; 
        public static readonly string  IdDecisionMakers = "Id. Decision Makers"; 
        public static readonly string  PerceptionAnalysis = "Perception Analysis"; 
        public static readonly string  ProposalPriceQuote = "Proposal/Price Quote"; 
        public static readonly string  NegotiationReview = "Negotiation/Review"; 
        public static readonly string  ClosedWon = "Closed Won"; 
        public static readonly string  ClosedLost = "Closed Lost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityHistoryStageName o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityHistoryStageName(string s)
        {
            return new PickOpportunityHistoryStageName {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityHistoryForecastCategory
    {
        public static readonly string  Omitted = "Omitted"; 
        public static readonly string  Pipeline = "Pipeline"; 
        public static readonly string  BestCase = "BestCase"; 
        public static readonly string  Forecast = "Forecast"; 
        public static readonly string  Closed = "Closed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityHistoryForecastCategory o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityHistoryForecastCategory(string s)
        {
            return new PickOpportunityHistoryForecastCategory {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityPartnerRole
    {
        public static readonly string  SystemIntegrator = "System Integrator"; 
        public static readonly string  Agency = "Agency"; 
        public static readonly string  Advertiser = "Advertiser"; 
        public static readonly string  VARReseller = "VAR/Reseller"; 
        public static readonly string  Distributor = "Distributor"; 
        public static readonly string  Developer = "Developer"; 
        public static readonly string  Broker = "Broker"; 
        public static readonly string  Lender = "Lender"; 
        public static readonly string  Supplier = "Supplier"; 
        public static readonly string  Institution = "Institution"; 
        public static readonly string  Contractor = "Contractor"; 
        public static readonly string  Dealer = "Dealer"; 
        public static readonly string  Consultant = "Consultant"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityPartnerRole o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityPartnerRole(string s)
        {
            return new PickOpportunityPartnerRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityShareOpportunityAccessLevel
    {
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityShareOpportunityAccessLevel o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityShareOpportunityAccessLevel(string s)
        {
            return new PickOpportunityShareOpportunityAccessLevel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityShareRowCause
    {
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Manual = "Manual"; 
        public static readonly string  Rule = "Rule"; 
        public static readonly string  ImplicitChild = "ImplicitChild"; 
        public static readonly string  ImplicitParent = "ImplicitParent"; 
        public static readonly string  ImplicitPerson = "ImplicitPerson"; 
        public static readonly string  Team = "Team"; 
        public static readonly string  Territory = "Territory"; 
        public static readonly string  TerritoryManual = "TerritoryManual"; 
        public static readonly string  TerritoryRule = "TerritoryRule"; 
        public static readonly string  Territory2Forecast = "Territory2Forecast"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityShareRowCause o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityShareRowCause(string s)
        {
            return new PickOpportunityShareRowCause {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityStageForecastCategory
    {
        public static readonly string  Omitted = "Omitted"; 
        public static readonly string  Pipeline = "Pipeline"; 
        public static readonly string  BestCase = "BestCase"; 
        public static readonly string  Forecast = "Forecast"; 
        public static readonly string  Closed = "Closed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityStageForecastCategory o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityStageForecastCategory(string s)
        {
            return new PickOpportunityStageForecastCategory {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOpportunityStageForecastCategoryName
    {
        public static readonly string  Omitted = "Omitted"; 
        public static readonly string  Pipeline = "Pipeline"; 
        public static readonly string  BestCase = "Best Case"; 
        public static readonly string  Commit = "Commit"; 
        public static readonly string  Closed = "Closed"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOpportunityStageForecastCategoryName o)
        {
            return o.Value;
        }

        public static implicit operator PickOpportunityStageForecastCategoryName(string s)
        {
            return new PickOpportunityStageForecastCategoryName {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrderStatus
    {
        public static readonly string  Draft = "Draft"; 
        public static readonly string  Activated = "Activated"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrderStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickOrderStatus(string s)
        {
            return new PickOrderStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrderType
    {
    
        public string Value { get; set; }

        public static implicit operator string(PickOrderType o)
        {
            return o.Value;
        }

        public static implicit operator PickOrderType(string s)
        {
            return new PickOrderType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrderStatusCode
    {
        public static readonly string  D = "D"; 
        public static readonly string  A = "A"; 
        public static readonly string  C = "C"; 
        public static readonly string  E = "E"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrderStatusCode o)
        {
            return o.Value;
        }

        public static implicit operator PickOrderStatusCode(string s)
        {
            return new PickOrderStatusCode {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrderHistoryField
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  ActivatedBy = "ActivatedBy"; 
        public static readonly string  ActivatedDate = "ActivatedDate"; 
        public static readonly string  BillingAddress = "BillingAddress"; 
        public static readonly string  BillingCity = "BillingCity"; 
        public static readonly string  BillingCountry = "BillingCountry"; 
        public static readonly string  BillingGeocodeAccuracy = "BillingGeocodeAccuracy"; 
        public static readonly string  BillingLatitude = "BillingLatitude"; 
        public static readonly string  BillingLongitude = "BillingLongitude"; 
        public static readonly string  BillingPostalCode = "BillingPostalCode"; 
        public static readonly string  BillingState = "BillingState"; 
        public static readonly string  BillingStreet = "BillingStreet"; 
        public static readonly string  BillToContact = "BillToContact"; 
        public static readonly string  CompanyAuthorizedBy = "CompanyAuthorizedBy"; 
        public static readonly string  CompanyAuthorizedDate = "CompanyAuthorizedDate"; 
        public static readonly string  Contract = "Contract"; 
        public static readonly string  created = "created"; 
        public static readonly string  CustomerAuthorizedBy = "CustomerAuthorizedBy"; 
        public static readonly string  CustomerAuthorizedDate = "CustomerAuthorizedDate"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  EffectiveDate = "EffectiveDate"; 
        public static readonly string  EndDate = "EndDate"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  Opportunity = "Opportunity"; 
        public static readonly string  orderActivated = "orderActivated"; 
        public static readonly string  orderApproved = "orderApproved"; 
        public static readonly string  orderCancelled = "orderCancelled"; 
        public static readonly string  orderDeactivated = "orderDeactivated"; 
        public static readonly string  orderExpired = "orderExpired"; 
        public static readonly string  OrderReferenceNumber = "OrderReferenceNumber"; 
        public static readonly string  orderSubmitted = "orderSubmitted"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  PoDate = "PoDate"; 
        public static readonly string  PoNumber = "PoNumber"; 
        public static readonly string  Pricebook2 = "Pricebook2"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  ShippingAddress = "ShippingAddress"; 
        public static readonly string  ShippingCity = "ShippingCity"; 
        public static readonly string  ShippingCountry = "ShippingCountry"; 
        public static readonly string  ShippingGeocodeAccuracy = "ShippingGeocodeAccuracy"; 
        public static readonly string  ShippingLatitude = "ShippingLatitude"; 
        public static readonly string  ShippingLongitude = "ShippingLongitude"; 
        public static readonly string  ShippingPostalCode = "ShippingPostalCode"; 
        public static readonly string  ShippingState = "ShippingState"; 
        public static readonly string  ShippingStreet = "ShippingStreet"; 
        public static readonly string  ShipToContact = "ShipToContact"; 
        public static readonly string  Status = "Status"; 
        public static readonly string  StatusCode = "StatusCode"; 
        public static readonly string  Type = "Type"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrderHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickOrderHistoryField(string s)
        {
            return new PickOrderHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultLocaleSidKey
    {
        public static readonly string  arBH = "ar_BH"; 
        public static readonly string  arEG = "ar_EG"; 
        public static readonly string  arJO = "ar_JO"; 
        public static readonly string  arKW = "ar_KW"; 
        public static readonly string  arLB = "ar_LB"; 
        public static readonly string  arSA = "ar_SA"; 
        public static readonly string  arAE = "ar_AE"; 
        public static readonly string  hyAM = "hy_AM"; 
        public static readonly string  bgBG = "bg_BG"; 
        public static readonly string  caES = "ca_ES"; 
        public static readonly string  zhCN = "zh_CN"; 
        public static readonly string  zhHK = "zh_HK"; 
        public static readonly string  zhTW = "zh_TW"; 
        public static readonly string  hrHR = "hr_HR"; 
        public static readonly string  csCZ = "cs_CZ"; 
        public static readonly string  daDK = "da_DK"; 
        public static readonly string  nlBE = "nl_BE"; 
        public static readonly string  nlNL = "nl_NL"; 
        public static readonly string  nlSR = "nl_SR"; 
        public static readonly string  enAU = "en_AU"; 
        public static readonly string  enBB = "en_BB"; 
        public static readonly string  enBM = "en_BM"; 
        public static readonly string  enCA = "en_CA"; 
        public static readonly string  enGH = "en_GH"; 
        public static readonly string  enIN = "en_IN"; 
        public static readonly string  enID = "en_ID"; 
        public static readonly string  enIE = "en_IE"; 
        public static readonly string  enMY = "en_MY"; 
        public static readonly string  enNZ = "en_NZ"; 
        public static readonly string  enNG = "en_NG"; 
        public static readonly string  enPH = "en_PH"; 
        public static readonly string  enSG = "en_SG"; 
        public static readonly string  enZA = "en_ZA"; 
        public static readonly string  enGB = "en_GB"; 
        public static readonly string  enUS = "en_US"; 
        public static readonly string  etEE = "et_EE"; 
        public static readonly string  fiFI = "fi_FI"; 
        public static readonly string  frBE = "fr_BE"; 
        public static readonly string  frCA = "fr_CA"; 
        public static readonly string  frFR = "fr_FR"; 
        public static readonly string  frLU = "fr_LU"; 
        public static readonly string  frMC = "fr_MC"; 
        public static readonly string  frCH = "fr_CH"; 
        public static readonly string  kaGE = "ka_GE"; 
        public static readonly string  deAT = "de_AT"; 
        public static readonly string  deDE = "de_DE"; 
        public static readonly string  deLU = "de_LU"; 
        public static readonly string  deCH = "de_CH"; 
        public static readonly string  elGR = "el_GR"; 
        public static readonly string  iwIL = "iw_IL"; 
        public static readonly string  isIS = "is_IS"; 
        public static readonly string  itIT = "it_IT"; 
        public static readonly string  itCH = "it_CH"; 
        public static readonly string  jaJP = "ja_JP"; 
        public static readonly string  kkKZ = "kk_KZ"; 
        public static readonly string  kmKH = "km_KH"; 
        public static readonly string  koKR = "ko_KR"; 
        public static readonly string  lvLV = "lv_LV"; 
        public static readonly string  ltLT = "lt_LT"; 
        public static readonly string  msMY = "ms_MY"; 
        public static readonly string  noNO = "no_NO"; 
        public static readonly string  ptAO = "pt_AO"; 
        public static readonly string  ptBR = "pt_BR"; 
        public static readonly string  ptPT = "pt_PT"; 
        public static readonly string  roRO = "ro_RO"; 
        public static readonly string  ruRU = "ru_RU"; 
        public static readonly string  srBA = "sr_BA"; 
        public static readonly string  shBA = "sh_BA"; 
        public static readonly string  shCS = "sh_CS"; 
        public static readonly string  srCS = "sr_CS"; 
        public static readonly string  skSK = "sk_SK"; 
        public static readonly string  slSI = "sl_SI"; 
        public static readonly string  esAR = "es_AR"; 
        public static readonly string  esBO = "es_BO"; 
        public static readonly string  esCL = "es_CL"; 
        public static readonly string  esCO = "es_CO"; 
        public static readonly string  esCR = "es_CR"; 
        public static readonly string  esDO = "es_DO"; 
        public static readonly string  esEC = "es_EC"; 
        public static readonly string  esSV = "es_SV"; 
        public static readonly string  esGT = "es_GT"; 
        public static readonly string  esHN = "es_HN"; 
        public static readonly string  esMX = "es_MX"; 
        public static readonly string  esPA = "es_PA"; 
        public static readonly string  esPY = "es_PY"; 
        public static readonly string  esPE = "es_PE"; 
        public static readonly string  esPR = "es_PR"; 
        public static readonly string  esES = "es_ES"; 
        public static readonly string  esUY = "es_UY"; 
        public static readonly string  esVE = "es_VE"; 
        public static readonly string  svSE = "sv_SE"; 
        public static readonly string  tlPH = "tl_PH"; 
        public static readonly string  thTH = "th_TH"; 
        public static readonly string  ukUA = "uk_UA"; 
        public static readonly string  urPK = "ur_PK"; 
        public static readonly string  viVN = "vi_VN"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultLocaleSidKey o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultLocaleSidKey(string s)
        {
            return new PickOrganizationDefaultLocaleSidKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationLanguageLocaleKey
    {
        public static readonly string  enUS = "en_US"; 
        public static readonly string  de = "de"; 
        public static readonly string  es = "es"; 
        public static readonly string  fr = "fr"; 
        public static readonly string  it = "it"; 
        public static readonly string  ja = "ja"; 
        public static readonly string  sv = "sv"; 
        public static readonly string  ko = "ko"; 
        public static readonly string  zhTW = "zh_TW"; 
        public static readonly string  zhCN = "zh_CN"; 
        public static readonly string  ptBR = "pt_BR"; 
        public static readonly string  nlNL = "nl_NL"; 
        public static readonly string  da = "da"; 
        public static readonly string  th = "th"; 
        public static readonly string  fi = "fi"; 
        public static readonly string  ru = "ru"; 
        public static readonly string  esMX = "es_MX"; 
        public static readonly string  no = "no"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationLanguageLocaleKey o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationLanguageLocaleKey(string s)
        {
            return new PickOrganizationLanguageLocaleKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultAccountAccess
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultAccountAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultAccountAccess(string s)
        {
            return new PickOrganizationDefaultAccountAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultContactAccess
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  ControlledByParent = "ControlledByParent"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultContactAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultContactAccess(string s)
        {
            return new PickOrganizationDefaultContactAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultOpportunityAccess
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultOpportunityAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultOpportunityAccess(string s)
        {
            return new PickOrganizationDefaultOpportunityAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultLeadAccess
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  ReadEditTransfer = "ReadEditTransfer"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultLeadAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultLeadAccess(string s)
        {
            return new PickOrganizationDefaultLeadAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultCaseAccess
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  ReadEditTransfer = "ReadEditTransfer"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultCaseAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultCaseAccess(string s)
        {
            return new PickOrganizationDefaultCaseAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultCalendarAccess
    {
        public static readonly string  HideDetails = "HideDetails"; 
        public static readonly string  HideDetailsInsert = "HideDetailsInsert"; 
        public static readonly string  ShowDetails = "ShowDetails"; 
        public static readonly string  ShowDetailsInsert = "ShowDetailsInsert"; 
        public static readonly string  AllowEdits = "AllowEdits"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultCalendarAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultCalendarAccess(string s)
        {
            return new PickOrganizationDefaultCalendarAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultPricebookAccess
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  ReadSelect = "ReadSelect"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultPricebookAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultPricebookAccess(string s)
        {
            return new PickOrganizationDefaultPricebookAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationDefaultCampaignAccess
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
        public static readonly string  All = "All"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationDefaultCampaignAccess o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationDefaultCampaignAccess(string s)
        {
            return new PickOrganizationDefaultCampaignAccess {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationUiSkin
    {
        public static readonly string  Theme1 = "Theme1"; 
        public static readonly string  Theme2 = "Theme2"; 
        public static readonly string  PortalDefault = "PortalDefault"; 
        public static readonly string  Webstore = "Webstore"; 
        public static readonly string  Theme3 = "Theme3"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationUiSkin o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationUiSkin(string s)
        {
            return new PickOrganizationUiSkin {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickOrganizationOrganizationType
    {
        public static readonly string  TeamEdition = "Team Edition"; 
        public static readonly string  ProfessionalEdition = "Professional Edition"; 
        public static readonly string  EnterpriseEdition = "Enterprise Edition"; 
        public static readonly string  DeveloperEdition = "Developer Edition"; 
        public static readonly string  PersonalEdition = "Personal Edition"; 
        public static readonly string  UnlimitedEdition = "Unlimited Edition"; 
        public static readonly string  ContactManagerEdition = "Contact Manager Edition"; 
        public static readonly string  BaseEdition = "Base Edition"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickOrganizationOrganizationType o)
        {
            return o.Value;
        }

        public static implicit operator PickOrganizationOrganizationType(string s)
        {
            return new PickOrganizationOrganizationType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickPartnerRole
    {
        public static readonly string  SystemIntegrator = "System Integrator"; 
        public static readonly string  Agency = "Agency"; 
        public static readonly string  Advertiser = "Advertiser"; 
        public static readonly string  VARReseller = "VAR/Reseller"; 
        public static readonly string  Distributor = "Distributor"; 
        public static readonly string  Developer = "Developer"; 
        public static readonly string  Broker = "Broker"; 
        public static readonly string  Lender = "Lender"; 
        public static readonly string  Supplier = "Supplier"; 
        public static readonly string  Institution = "Institution"; 
        public static readonly string  Contractor = "Contractor"; 
        public static readonly string  Dealer = "Dealer"; 
        public static readonly string  Consultant = "Consultant"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickPartnerRole o)
        {
            return o.Value;
        }

        public static implicit operator PickPartnerRole(string s)
        {
            return new PickPartnerRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickPartnerRoleReverseRole
    {
        public static readonly string  SystemIntegrator = "System Integrator"; 
        public static readonly string  Agency = "Agency"; 
        public static readonly string  Advertiser = "Advertiser"; 
        public static readonly string  VARReseller = "VAR/Reseller"; 
        public static readonly string  Distributor = "Distributor"; 
        public static readonly string  Developer = "Developer"; 
        public static readonly string  Broker = "Broker"; 
        public static readonly string  Lender = "Lender"; 
        public static readonly string  Supplier = "Supplier"; 
        public static readonly string  Institution = "Institution"; 
        public static readonly string  Contractor = "Contractor"; 
        public static readonly string  Dealer = "Dealer"; 
        public static readonly string  Consultant = "Consultant"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickPartnerRoleReverseRole o)
        {
            return o.Value;
        }

        public static implicit operator PickPartnerRoleReverseRole(string s)
        {
            return new PickPartnerRoleReverseRole {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickPeriodType
    {
        public static readonly string  Month = "Month"; 
        public static readonly string  Quarter = "Quarter"; 
        public static readonly string  Week = "Week"; 
        public static readonly string  Year = "Year"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickPeriodType o)
        {
            return o.Value;
        }

        public static implicit operator PickPeriodType(string s)
        {
            return new PickPeriodType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickPeriodQuarterLabel
    {
        public static readonly string  Spring = "Spring"; 
        public static readonly string  Summer = "Summer"; 
        public static readonly string  Fall = "Fall"; 
        public static readonly string  Winter = "Winter"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickPeriodQuarterLabel o)
        {
            return o.Value;
        }

        public static implicit operator PickPeriodQuarterLabel(string s)
        {
            return new PickPeriodQuarterLabel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickPeriodPeriodLabel
    {
    
        public string Value { get; set; }

        public static implicit operator string(PickPeriodPeriodLabel o)
        {
            return o.Value;
        }

        public static implicit operator PickPeriodPeriodLabel(string s)
        {
            return new PickPeriodPeriodLabel {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickPricebook2HistoryField
    {
        public static readonly string  created = "created"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  IsActive = "IsActive"; 
        public static readonly string  IsArchived = "IsArchived"; 
        public static readonly string  IsStandard = "IsStandard"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickPricebook2HistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickPricebook2HistoryField(string s)
        {
            return new PickPricebook2HistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProcessDefinitionType
    {
        public static readonly string  Approval = "Approval"; 
        public static readonly string  State = "State"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProcessDefinitionType o)
        {
            return o.Value;
        }

        public static implicit operator PickProcessDefinitionType(string s)
        {
            return new PickProcessDefinitionType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProcessDefinitionTableEnumOrId
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  Asset = "Asset"; 
        public static readonly string  AssistantProgress = "AssistantProgress"; 
        public static readonly string  Campaign = "Campaign"; 
        public static readonly string  Case = "Case"; 
        public static readonly string  Contact = "Contact"; 
        public static readonly string  Contract = "Contract"; 
        public static readonly string  DuplicateRecordItem = "DuplicateRecordItem"; 
        public static readonly string  DuplicateRecordSet = "DuplicateRecordSet"; 
        public static readonly string  EmailMessage = "EmailMessage"; 
        public static readonly string  ExchangeUserMapping = "ExchangeUserMapping"; 
        public static readonly string  Goal = "Goal"; 
        public static readonly string  KnowledgeArticle = "KnowledgeArticle"; 
        public static readonly string  KnowledgeArticleVersion = "KnowledgeArticleVersion"; 
        public static readonly string  Lead = "Lead"; 
        public static readonly string  Metric = "Metric"; 
        public static readonly string  Opportunity = "Opportunity"; 
        public static readonly string  Order = "Order"; 
        public static readonly string  Product2 = "Product2"; 
        public static readonly string  Solution = "Solution"; 
        public static readonly string  StreamingChannel = "StreamingChannel"; 
        public static readonly string  UserProvisioningRequest = "UserProvisioningRequest"; 
        public static readonly string  WorkCoaching = "WorkCoaching"; 
        public static readonly string  WorkFeedback = "WorkFeedback"; 
        public static readonly string  WorkFeedbackQuestion = "WorkFeedbackQuestion"; 
        public static readonly string  WorkFeedbackQuestionSet = "WorkFeedbackQuestionSet"; 
        public static readonly string  WorkFeedbackRequest = "WorkFeedbackRequest"; 
        public static readonly string  WorkFeedbackTemplate = "WorkFeedbackTemplate"; 
        public static readonly string  WorkPerformanceCycle = "WorkPerformanceCycle"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProcessDefinitionTableEnumOrId o)
        {
            return o.Value;
        }

        public static implicit operator PickProcessDefinitionTableEnumOrId(string s)
        {
            return new PickProcessDefinitionTableEnumOrId {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProcessDefinitionLockType
    {
        public static readonly string  Total = "Total"; 
        public static readonly string  Admin = "Admin"; 
        public static readonly string  Owner = "Owner"; 
        public static readonly string  Workitem = "Workitem"; 
        public static readonly string  Node = "Node"; 
        public static readonly string  none = "none"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProcessDefinitionLockType o)
        {
            return o.Value;
        }

        public static implicit operator PickProcessDefinitionLockType(string s)
        {
            return new PickProcessDefinitionLockType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProcessDefinitionState
    {
        public static readonly string  Active = "Active"; 
        public static readonly string  Inactive = "Inactive"; 
        public static readonly string  Obsolete = "Obsolete"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProcessDefinitionState o)
        {
            return o.Value;
        }

        public static implicit operator PickProcessDefinitionState(string s)
        {
            return new PickProcessDefinitionState {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProcessInstanceStatus
    {
        public static readonly string  Approved = "Approved"; 
        public static readonly string  Rejected = "Rejected"; 
        public static readonly string  Removed = "Removed"; 
        public static readonly string  Fault = "Fault"; 
        public static readonly string  Pending = "Pending"; 
        public static readonly string  Held = "Held"; 
        public static readonly string  Reassigned = "Reassigned"; 
        public static readonly string  Started = "Started"; 
        public static readonly string  NoResponse = "NoResponse"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProcessInstanceStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickProcessInstanceStatus(string s)
        {
            return new PickProcessInstanceStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProcessInstanceHistoryStepStatus
    {
        public static readonly string  Approved = "Approved"; 
        public static readonly string  Rejected = "Rejected"; 
        public static readonly string  Removed = "Removed"; 
        public static readonly string  Fault = "Fault"; 
        public static readonly string  Pending = "Pending"; 
        public static readonly string  Held = "Held"; 
        public static readonly string  Reassigned = "Reassigned"; 
        public static readonly string  Started = "Started"; 
        public static readonly string  NoResponse = "NoResponse"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProcessInstanceHistoryStepStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickProcessInstanceHistoryStepStatus(string s)
        {
            return new PickProcessInstanceHistoryStepStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProcessInstanceStepStepStatus
    {
        public static readonly string  Approved = "Approved"; 
        public static readonly string  Rejected = "Rejected"; 
        public static readonly string  Removed = "Removed"; 
        public static readonly string  Fault = "Fault"; 
        public static readonly string  Pending = "Pending"; 
        public static readonly string  Held = "Held"; 
        public static readonly string  Reassigned = "Reassigned"; 
        public static readonly string  Started = "Started"; 
        public static readonly string  NoResponse = "NoResponse"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProcessInstanceStepStepStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickProcessInstanceStepStepStatus(string s)
        {
            return new PickProcessInstanceStepStepStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProduct2Family
    {
        public static readonly string  None = "None"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProduct2Family o)
        {
            return o.Value;
        }

        public static implicit operator PickProduct2Family(string s)
        {
            return new PickProduct2Family {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProduct2FeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProduct2FeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickProduct2FeedType(string s)
        {
            return new PickProduct2FeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickProfileUserType
    {
        public static readonly string  Standard = "Standard"; 
        public static readonly string  PowerPartner = "PowerPartner"; 
        public static readonly string  PowerCustomerSuccess = "PowerCustomerSuccess"; 
        public static readonly string  CustomerSuccess = "CustomerSuccess"; 
        public static readonly string  Guest = "Guest"; 
        public static readonly string  CSPLitePortal = "CSPLitePortal"; 
        public static readonly string  CSNOnly = "CSNOnly"; 
        public static readonly string  SelfService = "SelfService"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickProfileUserType o)
        {
            return o.Value;
        }

        public static implicit operator PickProfileUserType(string s)
        {
            return new PickProfileUserType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickQueueSobjectSobjectType
    {
        public static readonly string  Case = "Case"; 
        public static readonly string  Goal = "Goal"; 
        public static readonly string  Lead = "Lead"; 
        public static readonly string  Macro = "Macro"; 
        public static readonly string  Metric = "Metric"; 
        public static readonly string  Order = "Order"; 
        public static readonly string  UserProvisioningRequest = "UserProvisioningRequest"; 
        public static readonly string  WorkCoaching = "WorkCoaching"; 
        public static readonly string  WorkFeedback = "WorkFeedback"; 
        public static readonly string  WorkFeedbackQuestion = "WorkFeedbackQuestion"; 
        public static readonly string  WorkFeedbackQuestionSet = "WorkFeedbackQuestionSet"; 
        public static readonly string  WorkFeedbackRequest = "WorkFeedbackRequest"; 
        public static readonly string  WorkFeedbackTemplate = "WorkFeedbackTemplate"; 
        public static readonly string  WorkPerformanceCycle = "WorkPerformanceCycle"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickQueueSobjectSobjectType o)
        {
            return o.Value;
        }

        public static implicit operator PickQueueSobjectSobjectType(string s)
        {
            return new PickQueueSobjectSobjectType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickRecordTypeSobjectType
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  Announcement = "Announcement"; 
        public static readonly string  AssistantProgress = "AssistantProgress"; 
        public static readonly string  Campaign = "Campaign"; 
        public static readonly string  CampaignMember = "CampaignMember"; 
        public static readonly string  Case = "Case"; 
        public static readonly string  CollaborationGroupRecord = "CollaborationGroupRecord"; 
        public static readonly string  Contact = "Contact"; 
        public static readonly string  ContentVersion = "ContentVersion"; 
        public static readonly string  Contract = "Contract"; 
        public static readonly string  DuplicateErrorLog = "DuplicateErrorLog"; 
        public static readonly string  DuplicateRecordItem = "DuplicateRecordItem"; 
        public static readonly string  DuplicateRecordSet = "DuplicateRecordSet"; 
        public static readonly string  Event = "Event"; 
        public static readonly string  FileSearchActivity = "FileSearchActivity"; 
        public static readonly string  Goal = "Goal"; 
        public static readonly string  GoalLink = "GoalLink"; 
        public static readonly string  Idea = "Idea"; 
        public static readonly string  InboundSocialPost = "InboundSocialPost"; 
        public static readonly string  Lead = "Lead"; 
        public static readonly string  Macro = "Macro"; 
        public static readonly string  MacroAction = "MacroAction"; 
        public static readonly string  MacroInstruction = "MacroInstruction"; 
        public static readonly string  Metric = "Metric"; 
        public static readonly string  MetricDataLink = "MetricDataLink"; 
        public static readonly string  Opportunity = "Opportunity"; 
        public static readonly string  Order = "Order"; 
        public static readonly string  Pricebook2 = "Pricebook2"; 
        public static readonly string  Product2 = "Product2"; 
        public static readonly string  RecordOrigin = "RecordOrigin"; 
        public static readonly string  SearchActivity = "SearchActivity"; 
        public static readonly string  SearchPromotionRule = "SearchPromotionRule"; 
        public static readonly string  SetupAssistantAnswer = "SetupAssistantAnswer"; 
        public static readonly string  Solution = "Solution"; 
        public static readonly string  Task = "Task"; 
        public static readonly string  TransactionSecurityAction = "TransactionSecurityAction"; 
        public static readonly string  TransactionSecurityActionEvent = "TransactionSecurityActionEvent"; 
        public static readonly string  WorkCoaching = "WorkCoaching"; 
        public static readonly string  WorkFeedback = "WorkFeedback"; 
        public static readonly string  WorkFeedbackQuestion = "WorkFeedbackQuestion"; 
        public static readonly string  WorkFeedbackQuestionSet = "WorkFeedbackQuestionSet"; 
        public static readonly string  WorkFeedbackRequest = "WorkFeedbackRequest"; 
        public static readonly string  WorkFeedbackTemplate = "WorkFeedbackTemplate"; 
        public static readonly string  WorkPerformanceCycle = "WorkPerformanceCycle"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickRecordTypeSobjectType o)
        {
            return o.Value;
        }

        public static implicit operator PickRecordTypeSobjectType(string s)
        {
            return new PickRecordTypeSobjectType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickReportFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickReportFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickReportFeedType(string s)
        {
            return new PickReportFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickSiteStatus
    {
        public static readonly string  Active = "Active"; 
        public static readonly string  Inactive = "Inactive"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickSiteStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickSiteStatus(string s)
        {
            return new PickSiteStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickSiteFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickSiteFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickSiteFeedType(string s)
        {
            return new PickSiteFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickSiteHistoryField
    {
        public static readonly string  siteActive = "siteActive"; 
        public static readonly string  Admin = "Admin"; 
        public static readonly string  AnalyticsTrackingCode = "AnalyticsTrackingCode"; 
        public static readonly string  siteOverride401 = "siteOverride401"; 
        public static readonly string  siteOverrideChangePassword = "siteOverrideChangePassword"; 
        public static readonly string  ClickjackProtectionLevel = "ClickjackProtectionLevel"; 
        public static readonly string  created = "created"; 
        public static readonly string  SiteDeleteDomain = "SiteDeleteDomain"; 
        public static readonly string  siteNewDomain = "siteNewDomain"; 
        public static readonly string  DefaultDomain = "DefaultDomain"; 
        public static readonly string  siteSetPrimaryDomain = "siteSetPrimaryDomain"; 
        public static readonly string  Description = "Description"; 
        public static readonly string  siteBTDisabled = "siteBTDisabled"; 
        public static readonly string  siteEnableFeeds = "siteEnableFeeds"; 
        public static readonly string  siteAllowStandardAnswersPages = "siteAllowStandardAnswersPages"; 
        public static readonly string  siteAllowHomePage = "siteAllowHomePage"; 
        public static readonly string  siteAllowStandardIdeasPages = "siteAllowStandardIdeasPages"; 
        public static readonly string  siteAllowStandardSearch = "siteAllowStandardSearch"; 
        public static readonly string  siteAllowStandardLookups = "siteAllowStandardLookups"; 
        public static readonly string  FavoriteIcon = "FavoriteIcon"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  siteOverrideForgotPassword = "siteOverrideForgotPassword"; 
        public static readonly string  siteOverride500 = "siteOverride500"; 
        public static readonly string  GuestUser = "GuestUser"; 
        public static readonly string  Guid = "Guid"; 
        public static readonly string  siteOverrideInactive = "siteOverrideInactive"; 
        public static readonly string  IndexPage = "IndexPage"; 
        public static readonly string  Language = "Language"; 
        public static readonly string  siteOverride509 = "siteOverride509"; 
        public static readonly string  siteOverride503 = "siteOverride503"; 
        public static readonly string  MasterLabel = "MasterLabel"; 
        public static readonly string  sitePageLimitExceeded = "sitePageLimitExceeded"; 
        public static readonly string  siteOverrideMyProfile = "siteOverrideMyProfile"; 
        public static readonly string  Name = "Name"; 
        public static readonly string  NewPassTemplate = "NewPassTemplate"; 
        public static readonly string  NewUserTemplate = "NewUserTemplate"; 
        public static readonly string  Options = "Options"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  siteOverride404 = "siteOverride404"; 
        public static readonly string  Portal = "Portal"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  siteNewRedirect = "siteNewRedirect"; 
        public static readonly string  siteDeleteRedirect = "siteDeleteRedirect"; 
        public static readonly string  siteChangeRedirect = "siteChangeRedirect"; 
        public static readonly string  siteRequireInsecurePortalAccess = "siteRequireInsecurePortalAccess"; 
        public static readonly string  siteRequireHttps = "siteRequireHttps"; 
        public static readonly string  siteOverrideSelfReg = "siteOverrideSelfReg"; 
        public static readonly string  ServerIsDown = "ServerIsDown"; 
        public static readonly string  siteOverrideRobotsTxt = "siteOverrideRobotsTxt"; 
        public static readonly string  siteOverrideTemplate = "siteOverrideTemplate"; 
        public static readonly string  SiteType = "SiteType"; 
        public static readonly string  Status = "Status"; 
        public static readonly string  Subdomain = "Subdomain"; 
        public static readonly string  TopLevelDomain = "TopLevelDomain"; 
        public static readonly string  UrlPathPrefix = "UrlPathPrefix"; 
        public static readonly string  UrlRewriterClass = "UrlRewriterClass"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickSiteHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickSiteHistoryField(string s)
        {
            return new PickSiteHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickSolutionStatus
    {
        public static readonly string  Draft = "Draft"; 
        public static readonly string  Reviewed = "Reviewed"; 
        public static readonly string  Duplicate = "Duplicate"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickSolutionStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickSolutionStatus(string s)
        {
            return new PickSolutionStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickSolutionFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickSolutionFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickSolutionFeedType(string s)
        {
            return new PickSolutionFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickSolutionHistoryField
    {
        public static readonly string  created = "created"; 
        public static readonly string  feedEvent = "feedEvent"; 
        public static readonly string  IsPublished = "IsPublished"; 
        public static readonly string  IsPublishedInPublicKb = "IsPublishedInPublicKb"; 
        public static readonly string  ownerAccepted = "ownerAccepted"; 
        public static readonly string  ownerAssignment = "ownerAssignment"; 
        public static readonly string  locked = "locked"; 
        public static readonly string  unlocked = "unlocked"; 
        public static readonly string  SolutionName = "SolutionName"; 
        public static readonly string  SolutionNote = "SolutionNote"; 
        public static readonly string  Status = "Status"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickSolutionHistoryField o)
        {
            return o.Value;
        }

        public static implicit operator PickSolutionHistoryField(string s)
        {
            return new PickSolutionHistoryField {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickStaticResourceCacheControl
    {
        public static readonly string  Private = "Private"; 
        public static readonly string  Public = "Public"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickStaticResourceCacheControl o)
        {
            return o.Value;
        }

        public static implicit operator PickStaticResourceCacheControl(string s)
        {
            return new PickStaticResourceCacheControl {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskStatus
    {
        public static readonly string  NotStarted = "Not Started"; 
        public static readonly string  InProgress = "In Progress"; 
        public static readonly string  Completed = "Completed"; 
        public static readonly string  Waitingonsomeoneelse = "Waiting on someone else"; 
        public static readonly string  Deferred = "Deferred"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskStatus o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskStatus(string s)
        {
            return new PickTaskStatus {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskPriority
    {
        public static readonly string  High = "High"; 
        public static readonly string  Normal = "Normal"; 
        public static readonly string  Low = "Low"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskPriority o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskPriority(string s)
        {
            return new PickTaskPriority {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskCallType
    {
        public static readonly string  Internal = "Internal"; 
        public static readonly string  Inbound = "Inbound"; 
        public static readonly string  Outbound = "Outbound"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskCallType o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskCallType(string s)
        {
            return new PickTaskCallType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskRecurrenceTimeZoneSidKey
    {
        public static readonly string  PacificKiritimati = "Pacific/Kiritimati"; 
        public static readonly string  PacificTongatapu = "Pacific/Tongatapu"; 
        public static readonly string  PacificChatham = "Pacific/Chatham"; 
        public static readonly string  PacificAuckland = "Pacific/Auckland"; 
        public static readonly string  PacificEnderbury = "Pacific/Enderbury"; 
        public static readonly string  PacificFiji = "Pacific/Fiji"; 
        public static readonly string  AsiaKamchatka = "Asia/Kamchatka"; 
        public static readonly string  AustraliaLordHowe = "Australia/Lord_Howe"; 
        public static readonly string  AustraliaSydney = "Australia/Sydney"; 
        public static readonly string  PacificGuadalcanal = "Pacific/Guadalcanal"; 
        public static readonly string  PacificNorfolk = "Pacific/Norfolk"; 
        public static readonly string  AustraliaAdelaide = "Australia/Adelaide"; 
        public static readonly string  AustraliaBrisbane = "Australia/Brisbane"; 
        public static readonly string  AustraliaDarwin = "Australia/Darwin"; 
        public static readonly string  AsiaSeoul = "Asia/Seoul"; 
        public static readonly string  AsiaTokyo = "Asia/Tokyo"; 
        public static readonly string  AsiaHongKong = "Asia/Hong_Kong"; 
        public static readonly string  AsiaKualaLumpur = "Asia/Kuala_Lumpur"; 
        public static readonly string  AsiaManila = "Asia/Manila"; 
        public static readonly string  AsiaShanghai = "Asia/Shanghai"; 
        public static readonly string  AsiaSingapore = "Asia/Singapore"; 
        public static readonly string  AsiaTaipei = "Asia/Taipei"; 
        public static readonly string  AustraliaPerth = "Australia/Perth"; 
        public static readonly string  AsiaBangkok = "Asia/Bangkok"; 
        public static readonly string  AsiaHoChiMinh = "Asia/Ho_Chi_Minh"; 
        public static readonly string  AsiaJakarta = "Asia/Jakarta"; 
        public static readonly string  AsiaRangoon = "Asia/Rangoon"; 
        public static readonly string  AsiaDhaka = "Asia/Dhaka"; 
        public static readonly string  AsiaKathmandu = "Asia/Kathmandu"; 
        public static readonly string  AsiaColombo = "Asia/Colombo"; 
        public static readonly string  AsiaKolkata = "Asia/Kolkata"; 
        public static readonly string  AsiaKarachi = "Asia/Karachi"; 
        public static readonly string  AsiaTashkent = "Asia/Tashkent"; 
        public static readonly string  AsiaYekaterinburg = "Asia/Yekaterinburg"; 
        public static readonly string  AsiaKabul = "Asia/Kabul"; 
        public static readonly string  AsiaDubai = "Asia/Dubai"; 
        public static readonly string  AsiaTbilisi = "Asia/Tbilisi"; 
        public static readonly string  AsiaTehran = "Asia/Tehran"; 
        public static readonly string  AfricaNairobi = "Africa/Nairobi"; 
        public static readonly string  AsiaBaghdad = "Asia/Baghdad"; 
        public static readonly string  AsiaKuwait = "Asia/Kuwait"; 
        public static readonly string  AsiaRiyadh = "Asia/Riyadh"; 
        public static readonly string  EuropeIstanbul = "Europe/Istanbul"; 
        public static readonly string  EuropeMinsk = "Europe/Minsk"; 
        public static readonly string  EuropeMoscow = "Europe/Moscow"; 
        public static readonly string  AfricaCairo = "Africa/Cairo"; 
        public static readonly string  AfricaJohannesburg = "Africa/Johannesburg"; 
        public static readonly string  AsiaJerusalem = "Asia/Jerusalem"; 
        public static readonly string  EuropeAthens = "Europe/Athens"; 
        public static readonly string  EuropeBucharest = "Europe/Bucharest"; 
        public static readonly string  EuropeHelsinki = "Europe/Helsinki"; 
        public static readonly string  AfricaAlgiers = "Africa/Algiers"; 
        public static readonly string  EuropeAmsterdam = "Europe/Amsterdam"; 
        public static readonly string  EuropeBerlin = "Europe/Berlin"; 
        public static readonly string  EuropeBrussels = "Europe/Brussels"; 
        public static readonly string  EuropeParis = "Europe/Paris"; 
        public static readonly string  EuropePrague = "Europe/Prague"; 
        public static readonly string  EuropeRome = "Europe/Rome"; 
        public static readonly string  EuropeDublin = "Europe/Dublin"; 
        public static readonly string  EuropeLisbon = "Europe/Lisbon"; 
        public static readonly string  EuropeLondon = "Europe/London"; 
        public static readonly string  GMT = "GMT"; 
        public static readonly string  AtlanticCapeVerde = "Atlantic/Cape_Verde"; 
        public static readonly string  AmericaSaoPaulo = "America/Sao_Paulo"; 
        public static readonly string  AtlanticSouthGeorgia = "Atlantic/South_Georgia"; 
        public static readonly string  AmericaArgentinaBuenosAires = "America/Argentina/Buenos_Aires"; 
        public static readonly string  AmericaSantiago = "America/Santiago"; 
        public static readonly string  AmericaStJohns = "America/St_Johns"; 
        public static readonly string  AmericaCaracas = "America/Caracas"; 
        public static readonly string  AmericaHalifax = "America/Halifax"; 
        public static readonly string  AmericaPuertoRico = "America/Puerto_Rico"; 
        public static readonly string  AtlanticBermuda = "Atlantic/Bermuda"; 
        public static readonly string  AmericaBogota = "America/Bogota"; 
        public static readonly string  AmericaIndianaIndianapolis = "America/Indiana/Indianapolis"; 
        public static readonly string  AmericaLima = "America/Lima"; 
        public static readonly string  AmericaNewYork = "America/New_York"; 
        public static readonly string  AmericaPanama = "America/Panama"; 
        public static readonly string  AmericaChicago = "America/Chicago"; 
        public static readonly string  AmericaElSalvador = "America/El_Salvador"; 
        public static readonly string  AmericaMexicoCity = "America/Mexico_City"; 
        public static readonly string  AmericaDenver = "America/Denver"; 
        public static readonly string  AmericaPhoenix = "America/Phoenix"; 
        public static readonly string  AmericaLosAngeles = "America/Los_Angeles"; 
        public static readonly string  AmericaTijuana = "America/Tijuana"; 
        public static readonly string  AmericaAnchorage = "America/Anchorage"; 
        public static readonly string  PacificHonolulu = "Pacific/Honolulu"; 
        public static readonly string  PacificNiue = "Pacific/Niue"; 
        public static readonly string  PacificPagoPago = "Pacific/Pago_Pago"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskRecurrenceTimeZoneSidKey o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskRecurrenceTimeZoneSidKey(string s)
        {
            return new PickTaskRecurrenceTimeZoneSidKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskRecurrenceType
    {
        public static readonly string  RecursDaily = "RecursDaily"; 
        public static readonly string  RecursEveryWeekday = "RecursEveryWeekday"; 
        public static readonly string  RecursMonthly = "RecursMonthly"; 
        public static readonly string  RecursMonthlyNth = "RecursMonthlyNth"; 
        public static readonly string  RecursWeekly = "RecursWeekly"; 
        public static readonly string  RecursYearly = "RecursYearly"; 
        public static readonly string  RecursYearlyNth = "RecursYearlyNth"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskRecurrenceType o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskRecurrenceType(string s)
        {
            return new PickTaskRecurrenceType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskRecurrenceInstance
    {
        public static readonly string  First = "First"; 
        public static readonly string  Second = "Second"; 
        public static readonly string  Third = "Third"; 
        public static readonly string  Fourth = "Fourth"; 
        public static readonly string  Last = "Last"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskRecurrenceInstance o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskRecurrenceInstance(string s)
        {
            return new PickTaskRecurrenceInstance {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskRecurrenceMonthOfYear
    {
        public static readonly string  January = "January"; 
        public static readonly string  February = "February"; 
        public static readonly string  March = "March"; 
        public static readonly string  April = "April"; 
        public static readonly string  May = "May"; 
        public static readonly string  June = "June"; 
        public static readonly string  July = "July"; 
        public static readonly string  August = "August"; 
        public static readonly string  September = "September"; 
        public static readonly string  October = "October"; 
        public static readonly string  November = "November"; 
        public static readonly string  December = "December"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskRecurrenceMonthOfYear o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskRecurrenceMonthOfYear(string s)
        {
            return new PickTaskRecurrenceMonthOfYear {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickTaskFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickTaskFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickTaskFeedType(string s)
        {
            return new PickTaskFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserTimeZoneSidKey
    {
        public static readonly string  PacificKiritimati = "Pacific/Kiritimati"; 
        public static readonly string  PacificTongatapu = "Pacific/Tongatapu"; 
        public static readonly string  PacificChatham = "Pacific/Chatham"; 
        public static readonly string  PacificAuckland = "Pacific/Auckland"; 
        public static readonly string  PacificEnderbury = "Pacific/Enderbury"; 
        public static readonly string  PacificFiji = "Pacific/Fiji"; 
        public static readonly string  AsiaKamchatka = "Asia/Kamchatka"; 
        public static readonly string  AustraliaLordHowe = "Australia/Lord_Howe"; 
        public static readonly string  AustraliaSydney = "Australia/Sydney"; 
        public static readonly string  PacificGuadalcanal = "Pacific/Guadalcanal"; 
        public static readonly string  PacificNorfolk = "Pacific/Norfolk"; 
        public static readonly string  AustraliaAdelaide = "Australia/Adelaide"; 
        public static readonly string  AustraliaBrisbane = "Australia/Brisbane"; 
        public static readonly string  AustraliaDarwin = "Australia/Darwin"; 
        public static readonly string  AsiaSeoul = "Asia/Seoul"; 
        public static readonly string  AsiaTokyo = "Asia/Tokyo"; 
        public static readonly string  AsiaHongKong = "Asia/Hong_Kong"; 
        public static readonly string  AsiaKualaLumpur = "Asia/Kuala_Lumpur"; 
        public static readonly string  AsiaManila = "Asia/Manila"; 
        public static readonly string  AsiaShanghai = "Asia/Shanghai"; 
        public static readonly string  AsiaSingapore = "Asia/Singapore"; 
        public static readonly string  AsiaTaipei = "Asia/Taipei"; 
        public static readonly string  AustraliaPerth = "Australia/Perth"; 
        public static readonly string  AsiaBangkok = "Asia/Bangkok"; 
        public static readonly string  AsiaHoChiMinh = "Asia/Ho_Chi_Minh"; 
        public static readonly string  AsiaJakarta = "Asia/Jakarta"; 
        public static readonly string  AsiaRangoon = "Asia/Rangoon"; 
        public static readonly string  AsiaDhaka = "Asia/Dhaka"; 
        public static readonly string  AsiaKathmandu = "Asia/Kathmandu"; 
        public static readonly string  AsiaColombo = "Asia/Colombo"; 
        public static readonly string  AsiaKolkata = "Asia/Kolkata"; 
        public static readonly string  AsiaKarachi = "Asia/Karachi"; 
        public static readonly string  AsiaTashkent = "Asia/Tashkent"; 
        public static readonly string  AsiaYekaterinburg = "Asia/Yekaterinburg"; 
        public static readonly string  AsiaKabul = "Asia/Kabul"; 
        public static readonly string  AsiaDubai = "Asia/Dubai"; 
        public static readonly string  AsiaTbilisi = "Asia/Tbilisi"; 
        public static readonly string  AsiaTehran = "Asia/Tehran"; 
        public static readonly string  AfricaNairobi = "Africa/Nairobi"; 
        public static readonly string  AsiaBaghdad = "Asia/Baghdad"; 
        public static readonly string  AsiaKuwait = "Asia/Kuwait"; 
        public static readonly string  AsiaRiyadh = "Asia/Riyadh"; 
        public static readonly string  EuropeIstanbul = "Europe/Istanbul"; 
        public static readonly string  EuropeMinsk = "Europe/Minsk"; 
        public static readonly string  EuropeMoscow = "Europe/Moscow"; 
        public static readonly string  AfricaCairo = "Africa/Cairo"; 
        public static readonly string  AfricaJohannesburg = "Africa/Johannesburg"; 
        public static readonly string  AsiaJerusalem = "Asia/Jerusalem"; 
        public static readonly string  EuropeAthens = "Europe/Athens"; 
        public static readonly string  EuropeBucharest = "Europe/Bucharest"; 
        public static readonly string  EuropeHelsinki = "Europe/Helsinki"; 
        public static readonly string  AfricaAlgiers = "Africa/Algiers"; 
        public static readonly string  EuropeAmsterdam = "Europe/Amsterdam"; 
        public static readonly string  EuropeBerlin = "Europe/Berlin"; 
        public static readonly string  EuropeBrussels = "Europe/Brussels"; 
        public static readonly string  EuropeParis = "Europe/Paris"; 
        public static readonly string  EuropePrague = "Europe/Prague"; 
        public static readonly string  EuropeRome = "Europe/Rome"; 
        public static readonly string  EuropeDublin = "Europe/Dublin"; 
        public static readonly string  EuropeLisbon = "Europe/Lisbon"; 
        public static readonly string  EuropeLondon = "Europe/London"; 
        public static readonly string  GMT = "GMT"; 
        public static readonly string  AtlanticCapeVerde = "Atlantic/Cape_Verde"; 
        public static readonly string  AmericaSaoPaulo = "America/Sao_Paulo"; 
        public static readonly string  AtlanticSouthGeorgia = "Atlantic/South_Georgia"; 
        public static readonly string  AmericaArgentinaBuenosAires = "America/Argentina/Buenos_Aires"; 
        public static readonly string  AmericaSantiago = "America/Santiago"; 
        public static readonly string  AmericaStJohns = "America/St_Johns"; 
        public static readonly string  AmericaCaracas = "America/Caracas"; 
        public static readonly string  AmericaHalifax = "America/Halifax"; 
        public static readonly string  AmericaPuertoRico = "America/Puerto_Rico"; 
        public static readonly string  AtlanticBermuda = "Atlantic/Bermuda"; 
        public static readonly string  AmericaBogota = "America/Bogota"; 
        public static readonly string  AmericaIndianaIndianapolis = "America/Indiana/Indianapolis"; 
        public static readonly string  AmericaLima = "America/Lima"; 
        public static readonly string  AmericaNewYork = "America/New_York"; 
        public static readonly string  AmericaPanama = "America/Panama"; 
        public static readonly string  AmericaChicago = "America/Chicago"; 
        public static readonly string  AmericaElSalvador = "America/El_Salvador"; 
        public static readonly string  AmericaMexicoCity = "America/Mexico_City"; 
        public static readonly string  AmericaDenver = "America/Denver"; 
        public static readonly string  AmericaPhoenix = "America/Phoenix"; 
        public static readonly string  AmericaLosAngeles = "America/Los_Angeles"; 
        public static readonly string  AmericaTijuana = "America/Tijuana"; 
        public static readonly string  AmericaAnchorage = "America/Anchorage"; 
        public static readonly string  PacificHonolulu = "Pacific/Honolulu"; 
        public static readonly string  PacificNiue = "Pacific/Niue"; 
        public static readonly string  PacificPagoPago = "Pacific/Pago_Pago"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserTimeZoneSidKey o)
        {
            return o.Value;
        }

        public static implicit operator PickUserTimeZoneSidKey(string s)
        {
            return new PickUserTimeZoneSidKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserLocaleSidKey
    {
        public static readonly string  arBH = "ar_BH"; 
        public static readonly string  arEG = "ar_EG"; 
        public static readonly string  arJO = "ar_JO"; 
        public static readonly string  arKW = "ar_KW"; 
        public static readonly string  arLB = "ar_LB"; 
        public static readonly string  arSA = "ar_SA"; 
        public static readonly string  arAE = "ar_AE"; 
        public static readonly string  hyAM = "hy_AM"; 
        public static readonly string  bgBG = "bg_BG"; 
        public static readonly string  caES = "ca_ES"; 
        public static readonly string  zhCN = "zh_CN"; 
        public static readonly string  zhHK = "zh_HK"; 
        public static readonly string  zhTW = "zh_TW"; 
        public static readonly string  hrHR = "hr_HR"; 
        public static readonly string  csCZ = "cs_CZ"; 
        public static readonly string  daDK = "da_DK"; 
        public static readonly string  nlBE = "nl_BE"; 
        public static readonly string  nlNL = "nl_NL"; 
        public static readonly string  nlSR = "nl_SR"; 
        public static readonly string  enAU = "en_AU"; 
        public static readonly string  enBB = "en_BB"; 
        public static readonly string  enBM = "en_BM"; 
        public static readonly string  enCA = "en_CA"; 
        public static readonly string  enGH = "en_GH"; 
        public static readonly string  enIN = "en_IN"; 
        public static readonly string  enID = "en_ID"; 
        public static readonly string  enIE = "en_IE"; 
        public static readonly string  enMY = "en_MY"; 
        public static readonly string  enNZ = "en_NZ"; 
        public static readonly string  enNG = "en_NG"; 
        public static readonly string  enPH = "en_PH"; 
        public static readonly string  enSG = "en_SG"; 
        public static readonly string  enZA = "en_ZA"; 
        public static readonly string  enGB = "en_GB"; 
        public static readonly string  enUS = "en_US"; 
        public static readonly string  etEE = "et_EE"; 
        public static readonly string  fiFI = "fi_FI"; 
        public static readonly string  frBE = "fr_BE"; 
        public static readonly string  frCA = "fr_CA"; 
        public static readonly string  frFR = "fr_FR"; 
        public static readonly string  frLU = "fr_LU"; 
        public static readonly string  frMC = "fr_MC"; 
        public static readonly string  frCH = "fr_CH"; 
        public static readonly string  kaGE = "ka_GE"; 
        public static readonly string  deAT = "de_AT"; 
        public static readonly string  deDE = "de_DE"; 
        public static readonly string  deLU = "de_LU"; 
        public static readonly string  deCH = "de_CH"; 
        public static readonly string  elGR = "el_GR"; 
        public static readonly string  iwIL = "iw_IL"; 
        public static readonly string  isIS = "is_IS"; 
        public static readonly string  itIT = "it_IT"; 
        public static readonly string  itCH = "it_CH"; 
        public static readonly string  jaJP = "ja_JP"; 
        public static readonly string  kkKZ = "kk_KZ"; 
        public static readonly string  kmKH = "km_KH"; 
        public static readonly string  koKR = "ko_KR"; 
        public static readonly string  lvLV = "lv_LV"; 
        public static readonly string  ltLT = "lt_LT"; 
        public static readonly string  msMY = "ms_MY"; 
        public static readonly string  noNO = "no_NO"; 
        public static readonly string  ptAO = "pt_AO"; 
        public static readonly string  ptBR = "pt_BR"; 
        public static readonly string  ptPT = "pt_PT"; 
        public static readonly string  roRO = "ro_RO"; 
        public static readonly string  ruRU = "ru_RU"; 
        public static readonly string  srBA = "sr_BA"; 
        public static readonly string  shBA = "sh_BA"; 
        public static readonly string  shCS = "sh_CS"; 
        public static readonly string  srCS = "sr_CS"; 
        public static readonly string  skSK = "sk_SK"; 
        public static readonly string  slSI = "sl_SI"; 
        public static readonly string  esAR = "es_AR"; 
        public static readonly string  esBO = "es_BO"; 
        public static readonly string  esCL = "es_CL"; 
        public static readonly string  esCO = "es_CO"; 
        public static readonly string  esCR = "es_CR"; 
        public static readonly string  esDO = "es_DO"; 
        public static readonly string  esEC = "es_EC"; 
        public static readonly string  esSV = "es_SV"; 
        public static readonly string  esGT = "es_GT"; 
        public static readonly string  esHN = "es_HN"; 
        public static readonly string  esMX = "es_MX"; 
        public static readonly string  esPA = "es_PA"; 
        public static readonly string  esPY = "es_PY"; 
        public static readonly string  esPE = "es_PE"; 
        public static readonly string  esPR = "es_PR"; 
        public static readonly string  esES = "es_ES"; 
        public static readonly string  esUY = "es_UY"; 
        public static readonly string  esVE = "es_VE"; 
        public static readonly string  svSE = "sv_SE"; 
        public static readonly string  tlPH = "tl_PH"; 
        public static readonly string  thTH = "th_TH"; 
        public static readonly string  ukUA = "uk_UA"; 
        public static readonly string  urPK = "ur_PK"; 
        public static readonly string  viVN = "vi_VN"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserLocaleSidKey o)
        {
            return o.Value;
        }

        public static implicit operator PickUserLocaleSidKey(string s)
        {
            return new PickUserLocaleSidKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserEmailEncodingKey
    {
        public static readonly string  UTF8 = "UTF-8"; 
        public static readonly string  ISO88591 = "ISO-8859-1"; 
        public static readonly string  ShiftJIS = "Shift_JIS"; 
        public static readonly string  ISO2022JP = "ISO-2022-JP"; 
        public static readonly string  EUCJP = "EUC-JP"; 
        public static readonly string  ksc56011987 = "ks_c_5601-1987"; 
        public static readonly string  Big5 = "Big5"; 
        public static readonly string  GB2312 = "GB2312"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserEmailEncodingKey o)
        {
            return o.Value;
        }

        public static implicit operator PickUserEmailEncodingKey(string s)
        {
            return new PickUserEmailEncodingKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserUserType
    {
        public static readonly string  Standard = "Standard"; 
        public static readonly string  PowerPartner = "PowerPartner"; 
        public static readonly string  PowerCustomerSuccess = "PowerCustomerSuccess"; 
        public static readonly string  CustomerSuccess = "CustomerSuccess"; 
        public static readonly string  Guest = "Guest"; 
        public static readonly string  CSPLitePortal = "CSPLitePortal"; 
        public static readonly string  CSNOnly = "CSNOnly"; 
        public static readonly string  SelfService = "SelfService"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserUserType o)
        {
            return o.Value;
        }

        public static implicit operator PickUserUserType(string s)
        {
            return new PickUserUserType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserLanguageLocaleKey
    {
        public static readonly string  enUS = "en_US"; 
        public static readonly string  de = "de"; 
        public static readonly string  es = "es"; 
        public static readonly string  fr = "fr"; 
        public static readonly string  it = "it"; 
        public static readonly string  ja = "ja"; 
        public static readonly string  sv = "sv"; 
        public static readonly string  ko = "ko"; 
        public static readonly string  zhTW = "zh_TW"; 
        public static readonly string  zhCN = "zh_CN"; 
        public static readonly string  ptBR = "pt_BR"; 
        public static readonly string  nlNL = "nl_NL"; 
        public static readonly string  da = "da"; 
        public static readonly string  th = "th"; 
        public static readonly string  fi = "fi"; 
        public static readonly string  ru = "ru"; 
        public static readonly string  esMX = "es_MX"; 
        public static readonly string  no = "no"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserLanguageLocaleKey o)
        {
            return o.Value;
        }

        public static implicit operator PickUserLanguageLocaleKey(string s)
        {
            return new PickUserLanguageLocaleKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserDigestFrequency
    {
        public static readonly string  D = "D"; 
        public static readonly string  W = "W"; 
        public static readonly string  N = "N"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserDigestFrequency o)
        {
            return o.Value;
        }

        public static implicit operator PickUserDigestFrequency(string s)
        {
            return new PickUserDigestFrequency {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickUserFeedType(string s)
        {
            return new PickUserFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserPreferencePreference
    {
        public static readonly string _57 = "57"; 
        public static readonly string _58 = "58"; 
        public static readonly string _91 = "91"; 
        public static readonly string _92 = "92"; 
        public static readonly string _93 = "93"; 
        public static readonly string _94 = "94"; 
        public static readonly string _96 = "96"; 
        public static readonly string _97 = "97"; 
        public static readonly string _98 = "98"; 
        public static readonly string _99 = "99"; 
        public static readonly string _100 = "100"; 
        public static readonly string _101 = "101"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserPreferencePreference o)
        {
            return o.Value;
        }

        public static implicit operator PickUserPreferencePreference(string s)
        {
            return new PickUserPreferencePreference {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserProfileFeedType
    {
        public static readonly string  TrackedChange = "TrackedChange"; 
        public static readonly string  UserStatus = "UserStatus"; 
        public static readonly string  TextPost = "TextPost"; 
        public static readonly string  AdvancedTextPost = "AdvancedTextPost"; 
        public static readonly string  LinkPost = "LinkPost"; 
        public static readonly string  ContentPost = "ContentPost"; 
        public static readonly string  PollPost = "PollPost"; 
        public static readonly string  RypplePost = "RypplePost"; 
        public static readonly string  ProfileSkillPost = "ProfileSkillPost"; 
        public static readonly string  DashboardComponentSnapshot = "DashboardComponentSnapshot"; 
        public static readonly string  ApprovalPost = "ApprovalPost"; 
        public static readonly string  CaseCommentPost = "CaseCommentPost"; 
        public static readonly string  ReplyPost = "ReplyPost"; 
        public static readonly string  EmailMessageEvent = "EmailMessageEvent"; 
        public static readonly string  CallLogPost = "CallLogPost"; 
        public static readonly string  ChangeStatusPost = "ChangeStatusPost"; 
        public static readonly string  AttachArticleEvent = "AttachArticleEvent"; 
        public static readonly string  MilestoneEvent = "MilestoneEvent"; 
        public static readonly string  ActivityEvent = "ActivityEvent"; 
        public static readonly string  ChatTranscriptPost = "ChatTranscriptPost"; 
        public static readonly string  CollaborationGroupCreated = "CollaborationGroupCreated"; 
        public static readonly string  CollaborationGroupUnarchived = "CollaborationGroupUnarchived"; 
        public static readonly string  SocialPost = "SocialPost"; 
        public static readonly string  QuestionPost = "QuestionPost"; 
        public static readonly string  FacebookPost = "FacebookPost"; 
        public static readonly string  BasicTemplateFeedItem = "BasicTemplateFeedItem"; 
        public static readonly string  CreateRecordEvent = "CreateRecordEvent"; 
        public static readonly string  CanvasPost = "CanvasPost"; 
        public static readonly string  AnnouncementPost = "AnnouncementPost"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserProfileFeedType o)
        {
            return o.Value;
        }

        public static implicit operator PickUserProfileFeedType(string s)
        {
            return new PickUserProfileFeedType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserRoleOpportunityAccessForAccountOwner
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserRoleOpportunityAccessForAccountOwner o)
        {
            return o.Value;
        }

        public static implicit operator PickUserRoleOpportunityAccessForAccountOwner(string s)
        {
            return new PickUserRoleOpportunityAccessForAccountOwner {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserRoleCaseAccessForAccountOwner
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserRoleCaseAccessForAccountOwner o)
        {
            return o.Value;
        }

        public static implicit operator PickUserRoleCaseAccessForAccountOwner(string s)
        {
            return new PickUserRoleCaseAccessForAccountOwner {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserRoleContactAccessForAccountOwner
    {
        public static readonly string  None = "None"; 
        public static readonly string  Read = "Read"; 
        public static readonly string  Edit = "Edit"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserRoleContactAccessForAccountOwner o)
        {
            return o.Value;
        }

        public static implicit operator PickUserRoleContactAccessForAccountOwner(string s)
        {
            return new PickUserRoleContactAccessForAccountOwner {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickUserRolePortalType
    {
        public static readonly string  None = "None"; 
        public static readonly string  CustomerPortal = "CustomerPortal"; 
        public static readonly string  Partner = "Partner"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickUserRolePortalType o)
        {
            return o.Value;
        }

        public static implicit operator PickUserRolePortalType(string s)
        {
            return new PickUserRolePortalType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickVoteType
    {
        public static readonly string  Up = "Up"; 
        public static readonly string  Down = "Down"; 
        public static readonly string _1 = "1"; 
        public static readonly string _2 = "2"; 
        public static readonly string _3 = "3"; 
        public static readonly string _4 = "4"; 
        public static readonly string _5 = "5"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickVoteType o)
        {
            return o.Value;
        }

        public static implicit operator PickVoteType(string s)
        {
            return new PickVoteType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickWebLinkPageOrSobjectType
    {
        public static readonly string  Account = "Account"; 
        public static readonly string  Activity = "Activity"; 
        public static readonly string  Asset = "Asset"; 
        public static readonly string  Campaign = "Campaign"; 
        public static readonly string  CampaignMember = "CampaignMember"; 
        public static readonly string  Case = "Case"; 
        public static readonly string  Contact = "Contact"; 
        public static readonly string  ContentVersion = "ContentVersion"; 
        public static readonly string  Contract = "Contract"; 
        public static readonly string  CustomPageItem = "CustomPageItem"; 
        public static readonly string  DandBCompany = "DandBCompany"; 
        public static readonly string  DashboardComponent = "DashboardComponent"; 
        public static readonly string  DuplicateRecordItem = "DuplicateRecordItem"; 
        public static readonly string  DuplicateRecordSet = "DuplicateRecordSet"; 
        public static readonly string  EmailMessage = "EmailMessage"; 
        public static readonly string  Event = "Event"; 
        public static readonly string  Goal = "Goal"; 
        public static readonly string  GoalLink = "GoalLink"; 
        public static readonly string  Idea = "Idea"; 
        public static readonly string  Lead = "Lead"; 
        public static readonly string  Macro = "Macro"; 
        public static readonly string  Metric = "Metric"; 
        public static readonly string  Opportunity = "Opportunity"; 
        public static readonly string  OpportunityLineItem = "OpportunityLineItem"; 
        public static readonly string  Order = "Order"; 
        public static readonly string  OrderItem = "OrderItem"; 
        public static readonly string  Product2 = "Product2"; 
        public static readonly string  SocialPersona = "SocialPersona"; 
        public static readonly string  Solution = "Solution"; 
        public static readonly string  Task = "Task"; 
        public static readonly string  User = "User"; 
        public static readonly string  UserProvisioningRequest = "UserProvisioningRequest"; 
        public static readonly string  WorkCoaching = "WorkCoaching"; 
        public static readonly string  WorkFeedback = "WorkFeedback"; 
        public static readonly string  WorkFeedbackQuestion = "WorkFeedbackQuestion"; 
        public static readonly string  WorkFeedbackQuestionSet = "WorkFeedbackQuestionSet"; 
        public static readonly string  WorkFeedbackRequest = "WorkFeedbackRequest"; 
        public static readonly string  WorkFeedbackTemplate = "WorkFeedbackTemplate"; 
        public static readonly string  WorkPerformanceCycle = "WorkPerformanceCycle"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickWebLinkPageOrSobjectType o)
        {
            return o.Value;
        }

        public static implicit operator PickWebLinkPageOrSobjectType(string s)
        {
            return new PickWebLinkPageOrSobjectType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickWebLinkEncodingKey
    {
        public static readonly string  UTF8 = "UTF-8"; 
        public static readonly string  ISO88591 = "ISO-8859-1"; 
        public static readonly string  ShiftJIS = "Shift_JIS"; 
        public static readonly string  ISO2022JP = "ISO-2022-JP"; 
        public static readonly string  EUCJP = "EUC-JP"; 
        public static readonly string  ksc56011987 = "ks_c_5601-1987"; 
        public static readonly string  Big5 = "Big5"; 
        public static readonly string  GB2312 = "GB2312"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickWebLinkEncodingKey o)
        {
            return o.Value;
        }

        public static implicit operator PickWebLinkEncodingKey(string s)
        {
            return new PickWebLinkEncodingKey {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickWebLinkLinkType
    {
        public static readonly string  url = "url"; 
        public static readonly string  sControl = "sControl"; 
        public static readonly string  javascript = "javascript"; 
        public static readonly string  page = "page"; 
        public static readonly string  flow = "flow"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickWebLinkLinkType o)
        {
            return o.Value;
        }

        public static implicit operator PickWebLinkLinkType(string s)
        {
            return new PickWebLinkLinkType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickWebLinkOpenType
    {
        public static readonly string  newWindow = "newWindow"; 
        public static readonly string  sidebar = "sidebar"; 
        public static readonly string  noSidebar = "noSidebar"; 
        public static readonly string  replace = "replace"; 
        public static readonly string  onClickJavaScript = "onClickJavaScript"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickWebLinkOpenType o)
        {
            return o.Value;
        }

        public static implicit operator PickWebLinkOpenType(string s)
        {
            return new PickWebLinkOpenType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickWebLinkPosition
    {
        public static readonly string  fullScreen = "fullScreen"; 
        public static readonly string  none = "none"; 
        public static readonly string  topLeft = "topLeft"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickWebLinkPosition o)
        {
            return o.Value;
        }

        public static implicit operator PickWebLinkPosition(string s)
        {
            return new PickWebLinkPosition {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class PickWebLinkDisplayType
    {
        public static readonly string  L = "L"; 
        public static readonly string  B = "B"; 
        public static readonly string  M = "M"; 
    
        public string Value { get; set; }

        public static implicit operator string(PickWebLinkDisplayType o)
        {
            return o.Value;
        }

        public static implicit operator PickWebLinkDisplayType(string s)
        {
            return new PickWebLinkDisplayType {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        

    }
    public class Account : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __MasterRecordId;
        [EntityField(true)]
        public System.String MasterRecordId
        {
            get { return __MasterRecordId; }
            set { SetField(ref __MasterRecordId, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickAccountType __Type;
        [EntityField(true)]
        public PickAccountType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __ParentId;
        [EntityField(true)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __BillingStreet;
        [EntityField(true)]
        public System.String BillingStreet
        {
            get { return __BillingStreet; }
            set { SetField(ref __BillingStreet, value); }
        }
        private System.String __BillingCity;
        [EntityField(true)]
        public System.String BillingCity
        {
            get { return __BillingCity; }
            set { SetField(ref __BillingCity, value); }
        }
        private System.String __BillingState;
        [EntityField(true)]
        public System.String BillingState
        {
            get { return __BillingState; }
            set { SetField(ref __BillingState, value); }
        }
        private System.String __BillingPostalCode;
        [EntityField(true)]
        public System.String BillingPostalCode
        {
            get { return __BillingPostalCode; }
            set { SetField(ref __BillingPostalCode, value); }
        }
        private System.String __BillingCountry;
        [EntityField(true)]
        public System.String BillingCountry
        {
            get { return __BillingCountry; }
            set { SetField(ref __BillingCountry, value); }
        }
        private System.String __ShippingStreet;
        [EntityField(true)]
        public System.String ShippingStreet
        {
            get { return __ShippingStreet; }
            set { SetField(ref __ShippingStreet, value); }
        }
        private System.String __ShippingCity;
        [EntityField(true)]
        public System.String ShippingCity
        {
            get { return __ShippingCity; }
            set { SetField(ref __ShippingCity, value); }
        }
        private System.String __ShippingState;
        [EntityField(true)]
        public System.String ShippingState
        {
            get { return __ShippingState; }
            set { SetField(ref __ShippingState, value); }
        }
        private System.String __ShippingPostalCode;
        [EntityField(true)]
        public System.String ShippingPostalCode
        {
            get { return __ShippingPostalCode; }
            set { SetField(ref __ShippingPostalCode, value); }
        }
        private System.String __ShippingCountry;
        [EntityField(true)]
        public System.String ShippingCountry
        {
            get { return __ShippingCountry; }
            set { SetField(ref __ShippingCountry, value); }
        }
        private System.String __Phone;
        [EntityField(true)]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField(true)]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __AccountNumber;
        [EntityField(true)]
        public System.String AccountNumber
        {
            get { return __AccountNumber; }
            set { SetField(ref __AccountNumber, value); }
        }
        private System.String __Website;
        [EntityField(true)]
        public System.String Website
        {
            get { return __Website; }
            set { SetField(ref __Website, value); }
        }
        private System.String __Sic;
        [EntityField(true)]
        public System.String Sic
        {
            get { return __Sic; }
            set { SetField(ref __Sic, value); }
        }
        private PickAccountIndustry __Industry;
        [EntityField(true)]
        public PickAccountIndustry Industry
        {
            get { return __Industry; }
            set { SetField(ref __Industry, value); }
        }
        private System.String __AnnualRevenue;
        [EntityField(true)]
        public System.String AnnualRevenue
        {
            get { return __AnnualRevenue; }
            set { SetField(ref __AnnualRevenue, value); }
        }
        private System.String __NumberOfEmployees;
        [EntityField(true)]
        public System.String NumberOfEmployees
        {
            get { return __NumberOfEmployees; }
            set { SetField(ref __NumberOfEmployees, value); }
        }
        private PickAccountOwnership __Ownership;
        [EntityField(true)]
        public PickAccountOwnership Ownership
        {
            get { return __Ownership; }
            set { SetField(ref __Ownership, value); }
        }
        private System.String __TickerSymbol;
        [EntityField(true)]
        public System.String TickerSymbol
        {
            get { return __TickerSymbol; }
            set { SetField(ref __TickerSymbol, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickAccountRating __Rating;
        [EntityField(true)]
        public PickAccountRating Rating
        {
            get { return __Rating; }
            set { SetField(ref __Rating, value); }
        }
        private System.String __Site;
        [EntityField(true)]
        public System.String Site
        {
            get { return __Site; }
            set { SetField(ref __Site, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField(true)]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private PickAccountCustomerPriority__c __CustomerPriorityc;
        [JsonProperty(PropertyName = "CustomerPriority__c")]
        [EntityField(true)]
        public PickAccountCustomerPriority__c CustomerPriorityc
        {
            get { return __CustomerPriorityc; }
            set { SetField(ref __CustomerPriorityc, value); }
        }
        private PickAccountSLA__c __SLAc;
        [JsonProperty(PropertyName = "SLA__c")]
        [EntityField(true)]
        public PickAccountSLA__c SLAc
        {
            get { return __SLAc; }
            set { SetField(ref __SLAc, value); }
        }
        private PickAccountActive__c __Activec;
        [JsonProperty(PropertyName = "Active__c")]
        [EntityField(true)]
        public PickAccountActive__c Activec
        {
            get { return __Activec; }
            set { SetField(ref __Activec, value); }
        }
        private System.String __NumberofLocationsc;
        [JsonProperty(PropertyName = "NumberofLocations__c")]
        [EntityField(true)]
        public System.String NumberofLocationsc
        {
            get { return __NumberofLocationsc; }
            set { SetField(ref __NumberofLocationsc, value); }
        }
        private PickAccountUpsellOpportunity__c __UpsellOpportunityc;
        [JsonProperty(PropertyName = "UpsellOpportunity__c")]
        [EntityField(true)]
        public PickAccountUpsellOpportunity__c UpsellOpportunityc
        {
            get { return __UpsellOpportunityc; }
            set { SetField(ref __UpsellOpportunityc, value); }
        }
        private System.String __SLASerialNumberc;
        [JsonProperty(PropertyName = "SLASerialNumber__c")]
        [EntityField(true)]
        public System.String SLASerialNumberc
        {
            get { return __SLASerialNumberc; }
            set { SetField(ref __SLASerialNumberc, value); }
        }
        private System.DateTime? __SLAExpirationDatec;
        [JsonProperty(PropertyName = "SLAExpirationDate__c")]
        [EntityField(true)]
        public System.DateTime? SLAExpirationDatec
        {
            get { return __SLAExpirationDatec; }
            set { SetField(ref __SLAExpirationDatec, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, Account> ChildAccounts
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, AccountContactRole> AccountContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, AccountFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, AccountHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountFromId")]
        public RelationShip<Account, AccountPartner> AccountPartnersFrom
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountToId")]
        public RelationShip<Account, AccountPartner> AccountPartnersTo
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, AccountShare> Shares
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Asset> Assets
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Case> Cases
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Contact> Contacts
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Contract> Contracts
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Account, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Account, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Opportunity> Opportunities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountToId")]
        public RelationShip<Account, OpportunityPartner> OpportunityPartnersTo
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountId")]
        public RelationShip<Account, Order> Orders
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountFromId")]
        public RelationShip<Account, Partner> PartnersFrom
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AccountToId")]
        public RelationShip<Account, Partner> PartnersTo
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Account, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Account, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Account, Task> Tasks
        {
            get;set;
        }
    }
    public class AccountContactRole : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __AccountId;
        [EntityField(false)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __ContactId;
        [EntityField(false)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickAccountContactRoleRole __Role;
        [EntityField(true)]
        public PickAccountContactRoleRole Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField(false)]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
    }
    public class AccountFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickAccountFeedType __Type;
        [EntityField(true)]
        public PickAccountFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AccountFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AccountFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class AccountHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AccountId;
        [EntityField(false)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickAccountHistoryField __Field;
        [EntityField(false)]
        public PickAccountHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class AccountPartner : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountFromId;
        [EntityField(false)]
        public System.String AccountFromId
        {
            get { return __AccountFromId; }
            set { SetField(ref __AccountFromId, value); }
        }
        private System.String __AccountToId;
        [EntityField(true)]
        public System.String AccountToId
        {
            get { return __AccountToId; }
            set { SetField(ref __AccountToId, value); }
        }
        private System.String __OpportunityId;
        [EntityField(true)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private PickAccountPartnerRole __Role;
        [EntityField(true)]
        public PickAccountPartnerRole Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField(false)]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ReversePartnerId;
        [EntityField(true)]
        public System.String ReversePartnerId
        {
            get { return __ReversePartnerId; }
            set { SetField(ref __ReversePartnerId, value); }
        }
    }
    public class AccountShare : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField(false)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickAccountShareAccountAccessLevel __AccountAccessLevel;
        [EntityField(false)]
        public PickAccountShareAccountAccessLevel AccountAccessLevel
        {
            get { return __AccountAccessLevel; }
            set { SetField(ref __AccountAccessLevel, value); }
        }
        private PickAccountShareOpportunityAccessLevel __OpportunityAccessLevel;
        [EntityField(false)]
        public PickAccountShareOpportunityAccessLevel OpportunityAccessLevel
        {
            get { return __OpportunityAccessLevel; }
            set { SetField(ref __OpportunityAccessLevel, value); }
        }
        private PickAccountShareCaseAccessLevel __CaseAccessLevel;
        [EntityField(false)]
        public PickAccountShareCaseAccessLevel CaseAccessLevel
        {
            get { return __CaseAccessLevel; }
            set { SetField(ref __CaseAccessLevel, value); }
        }
        private PickAccountShareContactAccessLevel __ContactAccessLevel;
        [EntityField(true)]
        public PickAccountShareContactAccessLevel ContactAccessLevel
        {
            get { return __ContactAccessLevel; }
            set { SetField(ref __ContactAccessLevel, value); }
        }
        private PickAccountShareRowCause __RowCause;
        [EntityField(true)]
        public PickAccountShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class ActivityHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __WhoId;
        [EntityField(true)]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField(true)]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField(true)]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.Boolean __IsTask;
        [EntityField(false)]
        public System.Boolean IsTask
        {
            get { return __IsTask; }
            set { SetField(ref __IsTask, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField(true)]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __OwnerId;
        [EntityField(true)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickActivityHistoryStatus __Status;
        [EntityField(true)]
        public PickActivityHistoryStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickActivityHistoryPriority __Priority;
        [EntityField(true)]
        public PickActivityHistoryPriority Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private PickActivityHistoryActivityType __ActivityType;
        [EntityField(true)]
        public PickActivityHistoryActivityType ActivityType
        {
            get { return __ActivityType; }
            set { SetField(ref __ActivityType, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsAllDayEvent;
        [EntityField(false)]
        public System.Boolean IsAllDayEvent
        {
            get { return __IsAllDayEvent; }
            set { SetField(ref __IsAllDayEvent, value); }
        }
        private System.Boolean __IsVisibleInSelfService;
        [EntityField(false)]
        public System.Boolean IsVisibleInSelfService
        {
            get { return __IsVisibleInSelfService; }
            set { SetField(ref __IsVisibleInSelfService, value); }
        }
        private System.String __DurationInMinutes;
        [EntityField(true)]
        public System.String DurationInMinutes
        {
            get { return __DurationInMinutes; }
            set { SetField(ref __DurationInMinutes, value); }
        }
        private System.String __Location;
        [EntityField(true)]
        public System.String Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __CallDurationInSeconds;
        [EntityField(true)]
        public System.String CallDurationInSeconds
        {
            get { return __CallDurationInSeconds; }
            set { SetField(ref __CallDurationInSeconds, value); }
        }
        private PickActivityHistoryCallType __CallType;
        [EntityField(true)]
        public PickActivityHistoryCallType CallType
        {
            get { return __CallType; }
            set { SetField(ref __CallType, value); }
        }
        private System.String __CallDisposition;
        [EntityField(true)]
        public System.String CallDisposition
        {
            get { return __CallDisposition; }
            set { SetField(ref __CallDisposition, value); }
        }
        private System.String __CallObject;
        [EntityField(true)]
        public System.String CallObject
        {
            get { return __CallObject; }
            set { SetField(ref __CallObject, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField(true)]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField(false)]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
    }
    public class AdditionalNumber : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CallCenterId;
        [EntityField(true)]
        public System.String CallCenterId
        {
            get { return __CallCenterId; }
            set { SetField(ref __CallCenterId, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Phone;
        [EntityField(true)]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class AggregateResult : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
    }
    public class ApexClass : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ApiVersion;
        [EntityField(false)]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private PickApexClassStatus __Status;
        [EntityField(false)]
        public PickApexClassStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsValid;
        [EntityField(false)]
        public System.Boolean IsValid
        {
            get { return __IsValid; }
            set { SetField(ref __IsValid, value); }
        }
        private System.String __BodyCrc;
        [EntityField(true)]
        public System.String BodyCrc
        {
            get { return __BodyCrc; }
            set { SetField(ref __BodyCrc, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __LengthWithoutComments;
        [EntityField(false)]
        public System.String LengthWithoutComments
        {
            get { return __LengthWithoutComments; }
            set { SetField(ref __LengthWithoutComments, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ApexComponent : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ApiVersion;
        [EntityField(false)]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private System.String __MasterLabel;
        [EntityField(false)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickApexComponentControllerType __ControllerType;
        [EntityField(false)]
        public PickApexComponentControllerType ControllerType
        {
            get { return __ControllerType; }
            set { SetField(ref __ControllerType, value); }
        }
        private System.String __ControllerKey;
        [EntityField(true)]
        public System.String ControllerKey
        {
            get { return __ControllerKey; }
            set { SetField(ref __ControllerKey, value); }
        }
        private System.String __Markup;
        [EntityField(false)]
        public System.String Markup
        {
            get { return __Markup; }
            set { SetField(ref __Markup, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ApexLog : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __LogUserId;
        [EntityField(true)]
        public System.String LogUserId
        {
            get { return __LogUserId; }
            set { SetField(ref __LogUserId, value); }
        }
        private System.String __LogLength;
        [EntityField(false)]
        public System.String LogLength
        {
            get { return __LogLength; }
            set { SetField(ref __LogLength, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __Request;
        [EntityField(false)]
        public System.String Request
        {
            get { return __Request; }
            set { SetField(ref __Request, value); }
        }
        private System.String __Operation;
        [EntityField(false)]
        public System.String Operation
        {
            get { return __Operation; }
            set { SetField(ref __Operation, value); }
        }
        private System.String __Application;
        [EntityField(false)]
        public System.String Application
        {
            get { return __Application; }
            set { SetField(ref __Application, value); }
        }
        private System.String __Status;
        [EntityField(false)]
        public System.String Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __DurationMilliseconds;
        [EntityField(false)]
        public System.String DurationMilliseconds
        {
            get { return __DurationMilliseconds; }
            set { SetField(ref __DurationMilliseconds, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __StartTime;
        [EntityField(false)]
        public System.DateTime StartTime
        {
            get { return __StartTime; }
            set { SetField(ref __StartTime, value); }
        }
        private PickApexLogLocation __Location;
        [EntityField(true)]
        public PickApexLogLocation Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
    }
    public class ApexPage : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ApiVersion;
        [EntityField(false)]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private System.String __MasterLabel;
        [EntityField(false)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickApexPageControllerType __ControllerType;
        [EntityField(false)]
        public PickApexPageControllerType ControllerType
        {
            get { return __ControllerType; }
            set { SetField(ref __ControllerType, value); }
        }
        private System.String __ControllerKey;
        [EntityField(true)]
        public System.String ControllerKey
        {
            get { return __ControllerKey; }
            set { SetField(ref __ControllerKey, value); }
        }
        private System.String __Markup;
        [EntityField(false)]
        public System.String Markup
        {
            get { return __Markup; }
            set { SetField(ref __Markup, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ApexTrigger : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickApexTriggerTableEnumOrId __TableEnumOrId;
        [EntityField(true)]
        public PickApexTriggerTableEnumOrId TableEnumOrId
        {
            get { return __TableEnumOrId; }
            set { SetField(ref __TableEnumOrId, value); }
        }
        private System.Boolean __UsageBeforeInsert;
        [EntityField(false)]
        public System.Boolean UsageBeforeInsert
        {
            get { return __UsageBeforeInsert; }
            set { SetField(ref __UsageBeforeInsert, value); }
        }
        private System.Boolean __UsageAfterInsert;
        [EntityField(false)]
        public System.Boolean UsageAfterInsert
        {
            get { return __UsageAfterInsert; }
            set { SetField(ref __UsageAfterInsert, value); }
        }
        private System.Boolean __UsageBeforeUpdate;
        [EntityField(false)]
        public System.Boolean UsageBeforeUpdate
        {
            get { return __UsageBeforeUpdate; }
            set { SetField(ref __UsageBeforeUpdate, value); }
        }
        private System.Boolean __UsageAfterUpdate;
        [EntityField(false)]
        public System.Boolean UsageAfterUpdate
        {
            get { return __UsageAfterUpdate; }
            set { SetField(ref __UsageAfterUpdate, value); }
        }
        private System.Boolean __UsageBeforeDelete;
        [EntityField(false)]
        public System.Boolean UsageBeforeDelete
        {
            get { return __UsageBeforeDelete; }
            set { SetField(ref __UsageBeforeDelete, value); }
        }
        private System.Boolean __UsageAfterDelete;
        [EntityField(false)]
        public System.Boolean UsageAfterDelete
        {
            get { return __UsageAfterDelete; }
            set { SetField(ref __UsageAfterDelete, value); }
        }
        private System.Boolean __UsageIsBulk;
        [EntityField(false)]
        public System.Boolean UsageIsBulk
        {
            get { return __UsageIsBulk; }
            set { SetField(ref __UsageIsBulk, value); }
        }
        private System.Boolean __UsageAfterUndelete;
        [EntityField(false)]
        public System.Boolean UsageAfterUndelete
        {
            get { return __UsageAfterUndelete; }
            set { SetField(ref __UsageAfterUndelete, value); }
        }
        private System.String __ApiVersion;
        [EntityField(false)]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private PickApexTriggerStatus __Status;
        [EntityField(false)]
        public PickApexTriggerStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsValid;
        [EntityField(false)]
        public System.Boolean IsValid
        {
            get { return __IsValid; }
            set { SetField(ref __IsValid, value); }
        }
        private System.String __BodyCrc;
        [EntityField(true)]
        public System.String BodyCrc
        {
            get { return __BodyCrc; }
            set { SetField(ref __BodyCrc, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __LengthWithoutComments;
        [EntityField(false)]
        public System.String LengthWithoutComments
        {
            get { return __LengthWithoutComments; }
            set { SetField(ref __LengthWithoutComments, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Asset : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContactId;
        [EntityField(true)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __Product2Id;
        [EntityField(true)]
        public System.String Product2Id
        {
            get { return __Product2Id; }
            set { SetField(ref __Product2Id, value); }
        }
        private System.Boolean __IsCompetitorProduct;
        [EntityField(false)]
        public System.Boolean IsCompetitorProduct
        {
            get { return __IsCompetitorProduct; }
            set { SetField(ref __IsCompetitorProduct, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __SerialNumber;
        [EntityField(true)]
        public System.String SerialNumber
        {
            get { return __SerialNumber; }
            set { SetField(ref __SerialNumber, value); }
        }
        private System.DateTime? __InstallDate;
        [EntityField(true)]
        public System.DateTime? InstallDate
        {
            get { return __InstallDate; }
            set { SetField(ref __InstallDate, value); }
        }
        private System.DateTime? __PurchaseDate;
        [EntityField(true)]
        public System.DateTime? PurchaseDate
        {
            get { return __PurchaseDate; }
            set { SetField(ref __PurchaseDate, value); }
        }
        private System.DateTime? __UsageEndDate;
        [EntityField(true)]
        public System.DateTime? UsageEndDate
        {
            get { return __UsageEndDate; }
            set { SetField(ref __UsageEndDate, value); }
        }
        private PickAssetStatus __Status;
        [EntityField(true)]
        public PickAssetStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __Price;
        [EntityField(true)]
        public System.String Price
        {
            get { return __Price; }
            set { SetField(ref __Price, value); }
        }
        private System.String __Quantity;
        [EntityField(true)]
        public System.String Quantity
        {
            get { return __Quantity; }
            set { SetField(ref __Quantity, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, AssetFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AssetId")]
        public RelationShip<Asset, AssetHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AssetId")]
        public RelationShip<Asset, Case> Cases
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Asset, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Asset, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Asset, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Asset, Task> Tasks
        {
            get;set;
        }
    }
    public class AssetFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickAssetFeedType __Type;
        [EntityField(true)]
        public PickAssetFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AssetFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<AssetFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class AssetHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AssetId;
        [EntityField(false)]
        public System.String AssetId
        {
            get { return __AssetId; }
            set { SetField(ref __AssetId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickAssetHistoryField __Field;
        [EntityField(false)]
        public PickAssetHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class AssignmentRule : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(true)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickAssignmentRuleSobjectType __SobjectType;
        [EntityField(true)]
        public PickAssignmentRuleSobjectType SobjectType
        {
            get { return __SobjectType; }
            set { SetField(ref __SobjectType, value); }
        }
        private System.Boolean __Active;
        [EntityField(false)]
        public System.Boolean Active
        {
            get { return __Active; }
            set { SetField(ref __Active, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class AsyncApexJob : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private PickAsyncApexJobJobType __JobType;
        [EntityField(false)]
        public PickAsyncApexJobJobType JobType
        {
            get { return __JobType; }
            set { SetField(ref __JobType, value); }
        }
        private System.String __ApexClassId;
        [EntityField(true)]
        public System.String ApexClassId
        {
            get { return __ApexClassId; }
            set { SetField(ref __ApexClassId, value); }
        }
        private PickAsyncApexJobStatus __Status;
        [EntityField(false)]
        public PickAsyncApexJobStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __JobItemsProcessed;
        [EntityField(false)]
        public System.String JobItemsProcessed
        {
            get { return __JobItemsProcessed; }
            set { SetField(ref __JobItemsProcessed, value); }
        }
        private System.String __TotalJobItems;
        [EntityField(true)]
        public System.String TotalJobItems
        {
            get { return __TotalJobItems; }
            set { SetField(ref __TotalJobItems, value); }
        }
        private System.String __NumberOfErrors;
        [EntityField(true)]
        public System.String NumberOfErrors
        {
            get { return __NumberOfErrors; }
            set { SetField(ref __NumberOfErrors, value); }
        }
        private System.DateTime? __CompletedDate;
        [EntityField(true)]
        public System.DateTime? CompletedDate
        {
            get { return __CompletedDate; }
            set { SetField(ref __CompletedDate, value); }
        }
        private System.String __MethodName;
        [EntityField(true)]
        public System.String MethodName
        {
            get { return __MethodName; }
            set { SetField(ref __MethodName, value); }
        }
        private System.String __ExtendedStatus;
        [EntityField(true)]
        public System.String ExtendedStatus
        {
            get { return __ExtendedStatus; }
            set { SetField(ref __ExtendedStatus, value); }
        }
        private System.String __ParentJobId;
        [EntityField(true)]
        public System.String ParentJobId
        {
            get { return __ParentJobId; }
            set { SetField(ref __ParentJobId, value); }
        }
        private System.String __LastProcessed;
        [EntityField(true)]
        public System.String LastProcessed
        {
            get { return __LastProcessed; }
            set { SetField(ref __LastProcessed, value); }
        }
        private System.String __LastProcessedOffset;
        [EntityField(true)]
        public System.String LastProcessedOffset
        {
            get { return __LastProcessedOffset; }
            set { SetField(ref __LastProcessedOffset, value); }
        }
    }
    public class Attachment : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField(false)]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __ContentType;
        [EntityField(true)]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __BodyLength;
        [EntityField(true)]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField(false)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
    }
    public class BrandTemplate : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Value;
        [EntityField(false)]
        public System.String Value
        {
            get { return __Value; }
            set { SetField(ref __Value, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class BusinessHours : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.String __SundayStartTime;
        [EntityField(true)]
        public System.String SundayStartTime
        {
            get { return __SundayStartTime; }
            set { SetField(ref __SundayStartTime, value); }
        }
        private System.String __SundayEndTime;
        [EntityField(true)]
        public System.String SundayEndTime
        {
            get { return __SundayEndTime; }
            set { SetField(ref __SundayEndTime, value); }
        }
        private System.String __MondayStartTime;
        [EntityField(true)]
        public System.String MondayStartTime
        {
            get { return __MondayStartTime; }
            set { SetField(ref __MondayStartTime, value); }
        }
        private System.String __MondayEndTime;
        [EntityField(true)]
        public System.String MondayEndTime
        {
            get { return __MondayEndTime; }
            set { SetField(ref __MondayEndTime, value); }
        }
        private System.String __TuesdayStartTime;
        [EntityField(true)]
        public System.String TuesdayStartTime
        {
            get { return __TuesdayStartTime; }
            set { SetField(ref __TuesdayStartTime, value); }
        }
        private System.String __TuesdayEndTime;
        [EntityField(true)]
        public System.String TuesdayEndTime
        {
            get { return __TuesdayEndTime; }
            set { SetField(ref __TuesdayEndTime, value); }
        }
        private System.String __WednesdayStartTime;
        [EntityField(true)]
        public System.String WednesdayStartTime
        {
            get { return __WednesdayStartTime; }
            set { SetField(ref __WednesdayStartTime, value); }
        }
        private System.String __WednesdayEndTime;
        [EntityField(true)]
        public System.String WednesdayEndTime
        {
            get { return __WednesdayEndTime; }
            set { SetField(ref __WednesdayEndTime, value); }
        }
        private System.String __ThursdayStartTime;
        [EntityField(true)]
        public System.String ThursdayStartTime
        {
            get { return __ThursdayStartTime; }
            set { SetField(ref __ThursdayStartTime, value); }
        }
        private System.String __ThursdayEndTime;
        [EntityField(true)]
        public System.String ThursdayEndTime
        {
            get { return __ThursdayEndTime; }
            set { SetField(ref __ThursdayEndTime, value); }
        }
        private System.String __FridayStartTime;
        [EntityField(true)]
        public System.String FridayStartTime
        {
            get { return __FridayStartTime; }
            set { SetField(ref __FridayStartTime, value); }
        }
        private System.String __FridayEndTime;
        [EntityField(true)]
        public System.String FridayEndTime
        {
            get { return __FridayEndTime; }
            set { SetField(ref __FridayEndTime, value); }
        }
        private System.String __SaturdayStartTime;
        [EntityField(true)]
        public System.String SaturdayStartTime
        {
            get { return __SaturdayStartTime; }
            set { SetField(ref __SaturdayStartTime, value); }
        }
        private System.String __SaturdayEndTime;
        [EntityField(true)]
        public System.String SaturdayEndTime
        {
            get { return __SaturdayEndTime; }
            set { SetField(ref __SaturdayEndTime, value); }
        }
        private PickBusinessHoursTimeZoneSidKey __TimeZoneSidKey;
        [EntityField(false)]
        public PickBusinessHoursTimeZoneSidKey TimeZoneSidKey
        {
            get { return __TimeZoneSidKey; }
            set { SetField(ref __TimeZoneSidKey, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class BusinessProcess : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickBusinessProcessTableEnumOrId __TableEnumOrId;
        [EntityField(false)]
        public PickBusinessProcessTableEnumOrId TableEnumOrId
        {
            get { return __TableEnumOrId; }
            set { SetField(ref __TableEnumOrId, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CallCenter : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __InternalName;
        [EntityField(false)]
        public System.String InternalName
        {
            get { return __InternalName; }
            set { SetField(ref __InternalName, value); }
        }
        private System.String __Version;
        [EntityField(true)]
        public System.String Version
        {
            get { return __Version; }
            set { SetField(ref __Version, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class Campaign : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ParentId;
        [EntityField(true)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private PickCampaignType __Type;
        [EntityField(true)]
        public PickCampaignType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private PickCampaignStatus __Status;
        [EntityField(true)]
        public PickCampaignStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __StartDate;
        [EntityField(true)]
        public System.DateTime? StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField(true)]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __ExpectedRevenue;
        [EntityField(true)]
        public System.String ExpectedRevenue
        {
            get { return __ExpectedRevenue; }
            set { SetField(ref __ExpectedRevenue, value); }
        }
        private System.String __BudgetedCost;
        [EntityField(true)]
        public System.String BudgetedCost
        {
            get { return __BudgetedCost; }
            set { SetField(ref __BudgetedCost, value); }
        }
        private System.String __ActualCost;
        [EntityField(true)]
        public System.String ActualCost
        {
            get { return __ActualCost; }
            set { SetField(ref __ActualCost, value); }
        }
        private System.String __ExpectedResponse;
        [EntityField(true)]
        public System.String ExpectedResponse
        {
            get { return __ExpectedResponse; }
            set { SetField(ref __ExpectedResponse, value); }
        }
        private System.String __NumberSent;
        [EntityField(true)]
        public System.String NumberSent
        {
            get { return __NumberSent; }
            set { SetField(ref __NumberSent, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __NumberOfLeads;
        [EntityField(false)]
        public System.String NumberOfLeads
        {
            get { return __NumberOfLeads; }
            set { SetField(ref __NumberOfLeads, value); }
        }
        private System.String __NumberOfConvertedLeads;
        [EntityField(false)]
        public System.String NumberOfConvertedLeads
        {
            get { return __NumberOfConvertedLeads; }
            set { SetField(ref __NumberOfConvertedLeads, value); }
        }
        private System.String __NumberOfContacts;
        [EntityField(false)]
        public System.String NumberOfContacts
        {
            get { return __NumberOfContacts; }
            set { SetField(ref __NumberOfContacts, value); }
        }
        private System.String __NumberOfResponses;
        [EntityField(false)]
        public System.String NumberOfResponses
        {
            get { return __NumberOfResponses; }
            set { SetField(ref __NumberOfResponses, value); }
        }
        private System.String __NumberOfOpportunities;
        [EntityField(false)]
        public System.String NumberOfOpportunities
        {
            get { return __NumberOfOpportunities; }
            set { SetField(ref __NumberOfOpportunities, value); }
        }
        private System.String __NumberOfWonOpportunities;
        [EntityField(false)]
        public System.String NumberOfWonOpportunities
        {
            get { return __NumberOfWonOpportunities; }
            set { SetField(ref __NumberOfWonOpportunities, value); }
        }
        private System.String __AmountAllOpportunities;
        [EntityField(false)]
        public System.String AmountAllOpportunities
        {
            get { return __AmountAllOpportunities; }
            set { SetField(ref __AmountAllOpportunities, value); }
        }
        private System.String __AmountWonOpportunities;
        [EntityField(false)]
        public System.String AmountWonOpportunities
        {
            get { return __AmountWonOpportunities; }
            set { SetField(ref __AmountWonOpportunities, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField(true)]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.String __CampaignMemberRecordTypeId;
        [EntityField(true)]
        public System.String CampaignMemberRecordTypeId
        {
            get { return __CampaignMemberRecordTypeId; }
            set { SetField(ref __CampaignMemberRecordTypeId, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, Campaign> ChildCampaigns
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, CampaignFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CampaignId")]
        public RelationShip<Campaign, CampaignMember> CampaignMembers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CampaignId")]
        public RelationShip<Campaign, CampaignShare> Shares
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Campaign, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CampaignId")]
        public RelationShip<Campaign, Opportunity> Opportunities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Campaign, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Campaign, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Campaign, Task> Tasks
        {
            get;set;
        }
    }
    public class CampaignFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickCampaignFeedType __Type;
        [EntityField(true)]
        public PickCampaignFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CampaignFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CampaignFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class CampaignMember : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CampaignId;
        [EntityField(false)]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.String __LeadId;
        [EntityField(true)]
        public System.String LeadId
        {
            get { return __LeadId; }
            set { SetField(ref __LeadId, value); }
        }
        private System.String __ContactId;
        [EntityField(true)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickCampaignMemberStatus __Status;
        [EntityField(true)]
        public PickCampaignMemberStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __HasResponded;
        [EntityField(false)]
        public System.Boolean HasResponded
        {
            get { return __HasResponded; }
            set { SetField(ref __HasResponded, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __FirstRespondedDate;
        [EntityField(true)]
        public System.DateTime? FirstRespondedDate
        {
            get { return __FirstRespondedDate; }
            set { SetField(ref __FirstRespondedDate, value); }
        }
    }
    public class CampaignMemberStatus : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CampaignId;
        [EntityField(false)]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.String __Label;
        [EntityField(false)]
        public System.String Label
        {
            get { return __Label; }
            set { SetField(ref __Label, value); }
        }
        private System.String __SortOrder;
        [EntityField(false)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __HasResponded;
        [EntityField(false)]
        public System.Boolean HasResponded
        {
            get { return __HasResponded; }
            set { SetField(ref __HasResponded, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CampaignShare : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CampaignId;
        [EntityField(false)]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickCampaignShareCampaignAccessLevel __CampaignAccessLevel;
        [EntityField(false)]
        public PickCampaignShareCampaignAccessLevel CampaignAccessLevel
        {
            get { return __CampaignAccessLevel; }
            set { SetField(ref __CampaignAccessLevel, value); }
        }
        private PickCampaignShareRowCause __RowCause;
        [EntityField(true)]
        public PickCampaignShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class Case : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CaseNumber;
        [EntityField(false)]
        public System.String CaseNumber
        {
            get { return __CaseNumber; }
            set { SetField(ref __CaseNumber, value); }
        }
        private System.String __ContactId;
        [EntityField(true)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __AssetId;
        [EntityField(true)]
        public System.String AssetId
        {
            get { return __AssetId; }
            set { SetField(ref __AssetId, value); }
        }
        private System.String __ParentId;
        [EntityField(true)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __SuppliedName;
        [EntityField(true)]
        public System.String SuppliedName
        {
            get { return __SuppliedName; }
            set { SetField(ref __SuppliedName, value); }
        }
        private System.String __SuppliedEmail;
        [EntityField(true)]
        public System.String SuppliedEmail
        {
            get { return __SuppliedEmail; }
            set { SetField(ref __SuppliedEmail, value); }
        }
        private System.String __SuppliedPhone;
        [EntityField(true)]
        public System.String SuppliedPhone
        {
            get { return __SuppliedPhone; }
            set { SetField(ref __SuppliedPhone, value); }
        }
        private System.String __SuppliedCompany;
        [EntityField(true)]
        public System.String SuppliedCompany
        {
            get { return __SuppliedCompany; }
            set { SetField(ref __SuppliedCompany, value); }
        }
        private PickCaseType __Type;
        [EntityField(true)]
        public PickCaseType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private PickCaseStatus __Status;
        [EntityField(true)]
        public PickCaseStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickCaseReason __Reason;
        [EntityField(true)]
        public PickCaseReason Reason
        {
            get { return __Reason; }
            set { SetField(ref __Reason, value); }
        }
        private PickCaseOrigin __Origin;
        [EntityField(true)]
        public PickCaseOrigin Origin
        {
            get { return __Origin; }
            set { SetField(ref __Origin, value); }
        }
        private System.String __Subject;
        [EntityField(true)]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private PickCasePriority __Priority;
        [EntityField(true)]
        public PickCasePriority Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.DateTime? __ClosedDate;
        [EntityField(true)]
        public System.DateTime? ClosedDate
        {
            get { return __ClosedDate; }
            set { SetField(ref __ClosedDate, value); }
        }
        private System.Boolean __IsEscalated;
        [EntityField(false)]
        public System.Boolean IsEscalated
        {
            get { return __IsEscalated; }
            set { SetField(ref __IsEscalated, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __EngineeringReqNumberc;
        [JsonProperty(PropertyName = "EngineeringReqNumber__c")]
        [EntityField(true)]
        public System.String EngineeringReqNumberc
        {
            get { return __EngineeringReqNumberc; }
            set { SetField(ref __EngineeringReqNumberc, value); }
        }
        private PickCaseSLAViolation__c __SLAViolationc;
        [JsonProperty(PropertyName = "SLAViolation__c")]
        [EntityField(true)]
        public PickCaseSLAViolation__c SLAViolationc
        {
            get { return __SLAViolationc; }
            set { SetField(ref __SLAViolationc, value); }
        }
        private PickCaseProduct__c __Productc;
        [JsonProperty(PropertyName = "Product__c")]
        [EntityField(true)]
        public PickCaseProduct__c Productc
        {
            get { return __Productc; }
            set { SetField(ref __Productc, value); }
        }
        private PickCasePotentialLiability__c __PotentialLiabilityc;
        [JsonProperty(PropertyName = "PotentialLiability__c")]
        [EntityField(true)]
        public PickCasePotentialLiability__c PotentialLiabilityc
        {
            get { return __PotentialLiabilityc; }
            set { SetField(ref __PotentialLiabilityc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, Case> Cases
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseComment> CaseComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CasesId")]
        public RelationShip<Case, CaseContactRole> CaseContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CaseId")]
        public RelationShip<Case, CaseHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CaseId")]
        public RelationShip<Case, CaseShare> Shares
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CaseId")]
        public RelationShip<Case, CaseSolution> CaseSolutions
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseTeamMember> TeamMembers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, CaseTeamTemplateRecord> TeamTemplateRecords
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, EmailMessage> EmailMessages
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Case, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Case, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Case, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Case, Task> Tasks
        {
            get;set;
        }
    }
    public class CaseComment : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.Boolean __IsPublished;
        [EntityField(false)]
        public System.Boolean IsPublished
        {
            get { return __IsPublished; }
            set { SetField(ref __IsPublished, value); }
        }
        private System.String __CommentBody;
        [EntityField(true)]
        public System.String CommentBody
        {
            get { return __CommentBody; }
            set { SetField(ref __CommentBody, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseContactRole : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CasesId;
        [EntityField(false)]
        public System.String CasesId
        {
            get { return __CasesId; }
            set { SetField(ref __CasesId, value); }
        }
        private System.String __ContactId;
        [EntityField(false)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickCaseContactRoleRole __Role;
        [EntityField(true)]
        public PickCaseContactRoleRole Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickCaseFeedType __Type;
        [EntityField(true)]
        public PickCaseFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CaseFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CaseFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class CaseHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __CaseId;
        [EntityField(false)]
        public System.String CaseId
        {
            get { return __CaseId; }
            set { SetField(ref __CaseId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickCaseHistoryField __Field;
        [EntityField(false)]
        public PickCaseHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class CaseShare : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CaseId;
        [EntityField(false)]
        public System.String CaseId
        {
            get { return __CaseId; }
            set { SetField(ref __CaseId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickCaseShareCaseAccessLevel __CaseAccessLevel;
        [EntityField(false)]
        public PickCaseShareCaseAccessLevel CaseAccessLevel
        {
            get { return __CaseAccessLevel; }
            set { SetField(ref __CaseAccessLevel, value); }
        }
        private PickCaseShareRowCause __RowCause;
        [EntityField(true)]
        public PickCaseShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseSolution : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CaseId;
        [EntityField(false)]
        public System.String CaseId
        {
            get { return __CaseId; }
            set { SetField(ref __CaseId, value); }
        }
        private System.String __SolutionId;
        [EntityField(false)]
        public System.String SolutionId
        {
            get { return __SolutionId; }
            set { SetField(ref __SolutionId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class CaseStatus : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamMember : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __MemberId;
        [EntityField(false)]
        public System.String MemberId
        {
            get { return __MemberId; }
            set { SetField(ref __MemberId, value); }
        }
        private System.String __TeamTemplateMemberId;
        [EntityField(true)]
        public System.String TeamTemplateMemberId
        {
            get { return __TeamTemplateMemberId; }
            set { SetField(ref __TeamTemplateMemberId, value); }
        }
        private System.String __TeamRoleId;
        [EntityField(false)]
        public System.String TeamRoleId
        {
            get { return __TeamRoleId; }
            set { SetField(ref __TeamRoleId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamRole : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private PickCaseTeamRoleAccessLevel __AccessLevel;
        [EntityField(false)]
        public PickCaseTeamRoleAccessLevel AccessLevel
        {
            get { return __AccessLevel; }
            set { SetField(ref __AccessLevel, value); }
        }
        private System.Boolean __PreferencesVisibleInCSP;
        [EntityField(false)]
        public System.Boolean PreferencesVisibleInCSP
        {
            get { return __PreferencesVisibleInCSP; }
            set { SetField(ref __PreferencesVisibleInCSP, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamTemplate : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamTemplateMember : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __TeamTemplateId;
        [EntityField(false)]
        public System.String TeamTemplateId
        {
            get { return __TeamTemplateId; }
            set { SetField(ref __TeamTemplateId, value); }
        }
        private System.String __MemberId;
        [EntityField(false)]
        public System.String MemberId
        {
            get { return __MemberId; }
            set { SetField(ref __MemberId, value); }
        }
        private System.String __TeamRoleId;
        [EntityField(true)]
        public System.String TeamRoleId
        {
            get { return __TeamRoleId; }
            set { SetField(ref __TeamRoleId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CaseTeamTemplateRecord : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __TeamTemplateId;
        [EntityField(false)]
        public System.String TeamTemplateId
        {
            get { return __TeamTemplateId; }
            set { SetField(ref __TeamTemplateId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CategoryData : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CategoryNodeId;
        [EntityField(false)]
        public System.String CategoryNodeId
        {
            get { return __CategoryNodeId; }
            set { SetField(ref __CategoryNodeId, value); }
        }
        private System.String __RelatedSobjectId;
        [EntityField(false)]
        public System.String RelatedSobjectId
        {
            get { return __RelatedSobjectId; }
            set { SetField(ref __RelatedSobjectId, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CategoryNode : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(true)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __MasterLabel;
        [EntityField(false)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private PickCategoryNodeSortStyle __SortStyle;
        [EntityField(false)]
        public PickCategoryNodeSortStyle SortStyle
        {
            get { return __SortStyle; }
            set { SetField(ref __SortStyle, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ClientBrowser : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UsersId;
        [EntityField(false)]
        public System.String UsersId
        {
            get { return __UsersId; }
            set { SetField(ref __UsersId, value); }
        }
        private System.String __FullUserAgent;
        [EntityField(true)]
        public System.String FullUserAgent
        {
            get { return __FullUserAgent; }
            set { SetField(ref __FullUserAgent, value); }
        }
        private System.String __ProxyInfo;
        [EntityField(true)]
        public System.String ProxyInfo
        {
            get { return __ProxyInfo; }
            set { SetField(ref __ProxyInfo, value); }
        }
        private System.DateTime? __LastUpdate;
        [EntityField(true)]
        public System.DateTime? LastUpdate
        {
            get { return __LastUpdate; }
            set { SetField(ref __LastUpdate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
    }
    public class CollaborationGroup : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __MemberCount;
        [EntityField(true)]
        public System.String MemberCount
        {
            get { return __MemberCount; }
            set { SetField(ref __MemberCount, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickCollaborationGroupCollaborationType __CollaborationType;
        [EntityField(false)]
        public PickCollaborationGroupCollaborationType CollaborationType
        {
            get { return __CollaborationType; }
            set { SetField(ref __CollaborationType, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __FullPhotoUrl;
        [EntityField(true)]
        public System.String FullPhotoUrl
        {
            get { return __FullPhotoUrl; }
            set { SetField(ref __FullPhotoUrl, value); }
        }
        private System.String __SmallPhotoUrl;
        [EntityField(true)]
        public System.String SmallPhotoUrl
        {
            get { return __SmallPhotoUrl; }
            set { SetField(ref __SmallPhotoUrl, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<CollaborationGroup, CollaborationGroupFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CollaborationGroupId")]
        public RelationShip<CollaborationGroup, CollaborationGroupMember> GroupMembers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<CollaborationGroup, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
    }
    public class CollaborationGroupFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickCollaborationGroupFeedType __Type;
        [EntityField(true)]
        public PickCollaborationGroupFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CollaborationGroupFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<CollaborationGroupFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class CollaborationGroupMember : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CollaborationGroupId;
        [EntityField(false)]
        public System.String CollaborationGroupId
        {
            get { return __CollaborationGroupId; }
            set { SetField(ref __CollaborationGroupId, value); }
        }
        private System.String __MemberId;
        [EntityField(false)]
        public System.String MemberId
        {
            get { return __MemberId; }
            set { SetField(ref __MemberId, value); }
        }
        private PickCollaborationGroupMemberNotificationFrequency __NotificationFrequency;
        [EntityField(true)]
        public PickCollaborationGroupMemberNotificationFrequency NotificationFrequency
        {
            get { return __NotificationFrequency; }
            set { SetField(ref __NotificationFrequency, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CollaborationInvitation : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(true)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __SharedEntityId;
        [EntityField(false)]
        public System.String SharedEntityId
        {
            get { return __SharedEntityId; }
            set { SetField(ref __SharedEntityId, value); }
        }
        private System.String __InviterId;
        [EntityField(false)]
        public System.String InviterId
        {
            get { return __InviterId; }
            set { SetField(ref __InviterId, value); }
        }
        private System.String __InvitedUserEmail;
        [EntityField(false)]
        public System.String InvitedUserEmail
        {
            get { return __InvitedUserEmail; }
            set { SetField(ref __InvitedUserEmail, value); }
        }
        private System.String __InvitedUserEmailNormalized;
        [EntityField(false)]
        public System.String InvitedUserEmailNormalized
        {
            get { return __InvitedUserEmailNormalized; }
            set { SetField(ref __InvitedUserEmailNormalized, value); }
        }
        private PickCollaborationInvitationStatus __Status;
        [EntityField(false)]
        public PickCollaborationInvitationStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __OptionalMessage;
        [EntityField(true)]
        public System.String OptionalMessage
        {
            get { return __OptionalMessage; }
            set { SetField(ref __OptionalMessage, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Community : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
    }
    public class Contact : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __MasterRecordId;
        [EntityField(true)]
        public System.String MasterRecordId
        {
            get { return __MasterRecordId; }
            set { SetField(ref __MasterRecordId, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __LastName;
        [EntityField(false)]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField(true)]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private PickContactSalutation __Salutation;
        [EntityField(true)]
        public PickContactSalutation Salutation
        {
            get { return __Salutation; }
            set { SetField(ref __Salutation, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __OtherStreet;
        [EntityField(true)]
        public System.String OtherStreet
        {
            get { return __OtherStreet; }
            set { SetField(ref __OtherStreet, value); }
        }
        private System.String __OtherCity;
        [EntityField(true)]
        public System.String OtherCity
        {
            get { return __OtherCity; }
            set { SetField(ref __OtherCity, value); }
        }
        private System.String __OtherState;
        [EntityField(true)]
        public System.String OtherState
        {
            get { return __OtherState; }
            set { SetField(ref __OtherState, value); }
        }
        private System.String __OtherPostalCode;
        [EntityField(true)]
        public System.String OtherPostalCode
        {
            get { return __OtherPostalCode; }
            set { SetField(ref __OtherPostalCode, value); }
        }
        private System.String __OtherCountry;
        [EntityField(true)]
        public System.String OtherCountry
        {
            get { return __OtherCountry; }
            set { SetField(ref __OtherCountry, value); }
        }
        private System.String __MailingStreet;
        [EntityField(true)]
        public System.String MailingStreet
        {
            get { return __MailingStreet; }
            set { SetField(ref __MailingStreet, value); }
        }
        private System.String __MailingCity;
        [EntityField(true)]
        public System.String MailingCity
        {
            get { return __MailingCity; }
            set { SetField(ref __MailingCity, value); }
        }
        private System.String __MailingState;
        [EntityField(true)]
        public System.String MailingState
        {
            get { return __MailingState; }
            set { SetField(ref __MailingState, value); }
        }
        private System.String __MailingPostalCode;
        [EntityField(true)]
        public System.String MailingPostalCode
        {
            get { return __MailingPostalCode; }
            set { SetField(ref __MailingPostalCode, value); }
        }
        private System.String __MailingCountry;
        [EntityField(true)]
        public System.String MailingCountry
        {
            get { return __MailingCountry; }
            set { SetField(ref __MailingCountry, value); }
        }
        private System.String __Phone;
        [EntityField(true)]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField(true)]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __MobilePhone;
        [EntityField(true)]
        public System.String MobilePhone
        {
            get { return __MobilePhone; }
            set { SetField(ref __MobilePhone, value); }
        }
        private System.String __HomePhone;
        [EntityField(true)]
        public System.String HomePhone
        {
            get { return __HomePhone; }
            set { SetField(ref __HomePhone, value); }
        }
        private System.String __OtherPhone;
        [EntityField(true)]
        public System.String OtherPhone
        {
            get { return __OtherPhone; }
            set { SetField(ref __OtherPhone, value); }
        }
        private System.String __AssistantPhone;
        [EntityField(true)]
        public System.String AssistantPhone
        {
            get { return __AssistantPhone; }
            set { SetField(ref __AssistantPhone, value); }
        }
        private System.String __ReportsToId;
        [EntityField(true)]
        public System.String ReportsToId
        {
            get { return __ReportsToId; }
            set { SetField(ref __ReportsToId, value); }
        }
        private System.String __Email;
        [EntityField(true)]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Title;
        [EntityField(true)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Department;
        [EntityField(true)]
        public System.String Department
        {
            get { return __Department; }
            set { SetField(ref __Department, value); }
        }
        private System.String __AssistantName;
        [EntityField(true)]
        public System.String AssistantName
        {
            get { return __AssistantName; }
            set { SetField(ref __AssistantName, value); }
        }
        private PickContactLeadSource __LeadSource;
        [EntityField(true)]
        public PickContactLeadSource LeadSource
        {
            get { return __LeadSource; }
            set { SetField(ref __LeadSource, value); }
        }
        private System.DateTime? __Birthdate;
        [EntityField(true)]
        public System.DateTime? Birthdate
        {
            get { return __Birthdate; }
            set { SetField(ref __Birthdate, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField(true)]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.DateTime? __LastCURequestDate;
        [EntityField(true)]
        public System.DateTime? LastCURequestDate
        {
            get { return __LastCURequestDate; }
            set { SetField(ref __LastCURequestDate, value); }
        }
        private System.DateTime? __LastCUUpdateDate;
        [EntityField(true)]
        public System.DateTime? LastCUUpdateDate
        {
            get { return __LastCUUpdateDate; }
            set { SetField(ref __LastCUUpdateDate, value); }
        }
        private System.String __EmailBouncedReason;
        [EntityField(true)]
        public System.String EmailBouncedReason
        {
            get { return __EmailBouncedReason; }
            set { SetField(ref __EmailBouncedReason, value); }
        }
        private System.DateTime? __EmailBouncedDate;
        [EntityField(true)]
        public System.DateTime? EmailBouncedDate
        {
            get { return __EmailBouncedDate; }
            set { SetField(ref __EmailBouncedDate, value); }
        }
        private PickContactLevel__c __Levelc;
        [JsonProperty(PropertyName = "Level__c")]
        [EntityField(true)]
        public PickContactLevel__c Levelc
        {
            get { return __Levelc; }
            set { SetField(ref __Levelc, value); }
        }
        private System.String __Languagesc;
        [JsonProperty(PropertyName = "Languages__c")]
        [EntityField(true)]
        public System.String Languagesc
        {
            get { return __Languagesc; }
            set { SetField(ref __Languagesc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, AccountContactRole> AccountContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, Asset> Assets
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, CampaignMember> CampaignMembers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, Case> Cases
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, CaseContactRole> CaseContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, ContactFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, ContactHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, ContactShare> Shares
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CustomerSignedId")]
        public RelationShip<Contact, Contract> ContractsSigned
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, ContractContactRole> ContractContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, EmailStatus> EmailStatuses
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contact, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContactId")]
        public RelationShip<Contact, OpportunityContactRole> OpportunityContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contact, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contact, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Contact, Task> Tasks
        {
            get;set;
        }
    }
    public class ContactFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickContactFeedType __Type;
        [EntityField(true)]
        public PickContactFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContactFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContactFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class ContactHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContactId;
        [EntityField(false)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContactHistoryField __Field;
        [EntityField(false)]
        public PickContactHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContactShare : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContactId;
        [EntityField(false)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickContactShareContactAccessLevel __ContactAccessLevel;
        [EntityField(false)]
        public PickContactShareContactAccessLevel ContactAccessLevel
        {
            get { return __ContactAccessLevel; }
            set { SetField(ref __ContactAccessLevel, value); }
        }
        private PickContactShareRowCause __RowCause;
        [EntityField(true)]
        public PickContactShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class ContentDocument : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Title;
        [EntityField(false)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private PickContentDocumentPublishStatus __PublishStatus;
        [EntityField(false)]
        public PickContentDocumentPublishStatus PublishStatus
        {
            get { return __PublishStatus; }
            set { SetField(ref __PublishStatus, value); }
        }
        private System.String __LatestPublishedVersionId;
        [EntityField(true)]
        public System.String LatestPublishedVersionId
        {
            get { return __LatestPublishedVersionId; }
            set { SetField(ref __LatestPublishedVersionId, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<ContentDocument, ContentDocumentFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContentDocumentId")]
        public RelationShip<ContentDocument, ContentDocumentHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContentDocumentId")]
        public RelationShip<ContentDocument, ContentVersion> ContentVersions
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<ContentDocument, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
    }
    public class ContentDocumentFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickContentDocumentFeedType __Type;
        [EntityField(true)]
        public PickContentDocumentFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContentDocumentFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContentDocumentFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class ContentDocumentHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContentDocumentId;
        [EntityField(false)]
        public System.String ContentDocumentId
        {
            get { return __ContentDocumentId; }
            set { SetField(ref __ContentDocumentId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContentDocumentHistoryField __Field;
        [EntityField(false)]
        public PickContentDocumentHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContentVersion : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContentDocumentId;
        [EntityField(false)]
        public System.String ContentDocumentId
        {
            get { return __ContentDocumentId; }
            set { SetField(ref __ContentDocumentId, value); }
        }
        private System.Boolean __IsLatest;
        [EntityField(false)]
        public System.Boolean IsLatest
        {
            get { return __IsLatest; }
            set { SetField(ref __IsLatest, value); }
        }
        private System.String __ContentUrl;
        [EntityField(true)]
        public System.String ContentUrl
        {
            get { return __ContentUrl; }
            set { SetField(ref __ContentUrl, value); }
        }
        private System.String __VersionNumber;
        [EntityField(true)]
        public System.String VersionNumber
        {
            get { return __VersionNumber; }
            set { SetField(ref __VersionNumber, value); }
        }
        private System.String __Title;
        [EntityField(false)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __ReasonForChange;
        [EntityField(true)]
        public System.String ReasonForChange
        {
            get { return __ReasonForChange; }
            set { SetField(ref __ReasonForChange, value); }
        }
        private System.String __PathOnClient;
        [EntityField(true)]
        public System.String PathOnClient
        {
            get { return __PathOnClient; }
            set { SetField(ref __PathOnClient, value); }
        }
        private System.String __RatingCount;
        [EntityField(true)]
        public System.String RatingCount
        {
            get { return __RatingCount; }
            set { SetField(ref __RatingCount, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime? __ContentModifiedDate;
        [EntityField(true)]
        public System.DateTime? ContentModifiedDate
        {
            get { return __ContentModifiedDate; }
            set { SetField(ref __ContentModifiedDate, value); }
        }
        private System.String __ContentModifiedById;
        [EntityField(true)]
        public System.String ContentModifiedById
        {
            get { return __ContentModifiedById; }
            set { SetField(ref __ContentModifiedById, value); }
        }
        private System.String __PositiveRatingCount;
        [EntityField(true)]
        public System.String PositiveRatingCount
        {
            get { return __PositiveRatingCount; }
            set { SetField(ref __PositiveRatingCount, value); }
        }
        private System.String __NegativeRatingCount;
        [EntityField(true)]
        public System.String NegativeRatingCount
        {
            get { return __NegativeRatingCount; }
            set { SetField(ref __NegativeRatingCount, value); }
        }
        private System.String __FeaturedContentBoost;
        [EntityField(true)]
        public System.String FeaturedContentBoost
        {
            get { return __FeaturedContentBoost; }
            set { SetField(ref __FeaturedContentBoost, value); }
        }
        private System.DateTime? __FeaturedContentDate;
        [EntityField(true)]
        public System.DateTime? FeaturedContentDate
        {
            get { return __FeaturedContentDate; }
            set { SetField(ref __FeaturedContentDate, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __TagCsv;
        [EntityField(true)]
        public System.String TagCsv
        {
            get { return __TagCsv; }
            set { SetField(ref __TagCsv, value); }
        }
        private System.String __FileType;
        [EntityField(false)]
        public System.String FileType
        {
            get { return __FileType; }
            set { SetField(ref __FileType, value); }
        }
        private PickContentVersionPublishStatus __PublishStatus;
        [EntityField(false)]
        public PickContentVersionPublishStatus PublishStatus
        {
            get { return __PublishStatus; }
            set { SetField(ref __PublishStatus, value); }
        }
        private System.String __VersionData;
        [EntityField(true)]
        public System.String VersionData
        {
            get { return __VersionData; }
            set { SetField(ref __VersionData, value); }
        }
        private System.String __ContentSize;
        [EntityField(true)]
        public System.String ContentSize
        {
            get { return __ContentSize; }
            set { SetField(ref __ContentSize, value); }
        }
        private System.String __FirstPublishLocationId;
        [EntityField(true)]
        public System.String FirstPublishLocationId
        {
            get { return __FirstPublishLocationId; }
            set { SetField(ref __FirstPublishLocationId, value); }
        }
        private PickContentVersionOrigin __Origin;
        [EntityField(false)]
        public PickContentVersionOrigin Origin
        {
            get { return __Origin; }
            set { SetField(ref __Origin, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ContentVersionId")]
        public RelationShip<ContentVersion, ContentVersionHistory> Histories
        {
            get;set;
        }
    }
    public class ContentVersionHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContentVersionId;
        [EntityField(false)]
        public System.String ContentVersionId
        {
            get { return __ContentVersionId; }
            set { SetField(ref __ContentVersionId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContentVersionHistoryField __Field;
        [EntityField(false)]
        public PickContentVersionHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContentWorkspace : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickContentWorkspaceTagModel __TagModel;
        [EntityField(true)]
        public PickContentWorkspaceTagModel TagModel
        {
            get { return __TagModel; }
            set { SetField(ref __TagModel, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __DefaultRecordTypeId;
        [EntityField(true)]
        public System.String DefaultRecordTypeId
        {
            get { return __DefaultRecordTypeId; }
            set { SetField(ref __DefaultRecordTypeId, value); }
        }
        private System.Boolean __IsRestrictContentTypes;
        [EntityField(false)]
        public System.Boolean IsRestrictContentTypes
        {
            get { return __IsRestrictContentTypes; }
            set { SetField(ref __IsRestrictContentTypes, value); }
        }
        private System.Boolean __IsRestrictLinkedContentTypes;
        [EntityField(false)]
        public System.Boolean IsRestrictLinkedContentTypes
        {
            get { return __IsRestrictLinkedContentTypes; }
            set { SetField(ref __IsRestrictLinkedContentTypes, value); }
        }
    }
    public class ContentWorkspaceDoc : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContentWorkspaceId;
        [EntityField(false)]
        public System.String ContentWorkspaceId
        {
            get { return __ContentWorkspaceId; }
            set { SetField(ref __ContentWorkspaceId, value); }
        }
        private System.String __ContentDocumentId;
        [EntityField(false)]
        public System.String ContentDocumentId
        {
            get { return __ContentDocumentId; }
            set { SetField(ref __ContentDocumentId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsOwner;
        [EntityField(false)]
        public System.Boolean IsOwner
        {
            get { return __IsOwner; }
            set { SetField(ref __IsOwner, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class Contract : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField(false)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField(true)]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private PickContractOwnerExpirationNotice __OwnerExpirationNotice;
        [EntityField(true)]
        public PickContractOwnerExpirationNotice OwnerExpirationNotice
        {
            get { return __OwnerExpirationNotice; }
            set { SetField(ref __OwnerExpirationNotice, value); }
        }
        private System.DateTime? __StartDate;
        [EntityField(true)]
        public System.DateTime? StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField(true)]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __BillingStreet;
        [EntityField(true)]
        public System.String BillingStreet
        {
            get { return __BillingStreet; }
            set { SetField(ref __BillingStreet, value); }
        }
        private System.String __BillingCity;
        [EntityField(true)]
        public System.String BillingCity
        {
            get { return __BillingCity; }
            set { SetField(ref __BillingCity, value); }
        }
        private System.String __BillingState;
        [EntityField(true)]
        public System.String BillingState
        {
            get { return __BillingState; }
            set { SetField(ref __BillingState, value); }
        }
        private System.String __BillingPostalCode;
        [EntityField(true)]
        public System.String BillingPostalCode
        {
            get { return __BillingPostalCode; }
            set { SetField(ref __BillingPostalCode, value); }
        }
        private System.String __BillingCountry;
        [EntityField(true)]
        public System.String BillingCountry
        {
            get { return __BillingCountry; }
            set { SetField(ref __BillingCountry, value); }
        }
        private System.String __ContractTerm;
        [EntityField(true)]
        public System.String ContractTerm
        {
            get { return __ContractTerm; }
            set { SetField(ref __ContractTerm, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickContractStatus __Status;
        [EntityField(false)]
        public PickContractStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __CompanySignedId;
        [EntityField(true)]
        public System.String CompanySignedId
        {
            get { return __CompanySignedId; }
            set { SetField(ref __CompanySignedId, value); }
        }
        private System.DateTime? __CompanySignedDate;
        [EntityField(true)]
        public System.DateTime? CompanySignedDate
        {
            get { return __CompanySignedDate; }
            set { SetField(ref __CompanySignedDate, value); }
        }
        private System.String __CustomerSignedId;
        [EntityField(true)]
        public System.String CustomerSignedId
        {
            get { return __CustomerSignedId; }
            set { SetField(ref __CustomerSignedId, value); }
        }
        private System.String __CustomerSignedTitle;
        [EntityField(true)]
        public System.String CustomerSignedTitle
        {
            get { return __CustomerSignedTitle; }
            set { SetField(ref __CustomerSignedTitle, value); }
        }
        private System.DateTime? __CustomerSignedDate;
        [EntityField(true)]
        public System.DateTime? CustomerSignedDate
        {
            get { return __CustomerSignedDate; }
            set { SetField(ref __CustomerSignedDate, value); }
        }
        private System.String __SpecialTerms;
        [EntityField(true)]
        public System.String SpecialTerms
        {
            get { return __SpecialTerms; }
            set { SetField(ref __SpecialTerms, value); }
        }
        private System.String __ActivatedById;
        [EntityField(true)]
        public System.String ActivatedById
        {
            get { return __ActivatedById; }
            set { SetField(ref __ActivatedById, value); }
        }
        private System.DateTime? __ActivatedDate;
        [EntityField(true)]
        public System.DateTime? ActivatedDate
        {
            get { return __ActivatedDate; }
            set { SetField(ref __ActivatedDate, value); }
        }
        private PickContractStatusCode __StatusCode;
        [EntityField(false)]
        public PickContractStatusCode StatusCode
        {
            get { return __StatusCode; }
            set { SetField(ref __StatusCode, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContractNumber;
        [EntityField(false)]
        public System.String ContractNumber
        {
            get { return __ContractNumber; }
            set { SetField(ref __ContractNumber, value); }
        }
        private System.DateTime? __LastApprovedDate;
        [EntityField(true)]
        public System.DateTime? LastApprovedDate
        {
            get { return __LastApprovedDate; }
            set { SetField(ref __LastApprovedDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField(true)]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContractId")]
        public RelationShip<Contract, ContractContactRole> ContractContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, ContractFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContractId")]
        public RelationShip<Contract, ContractHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Contract, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ContractId")]
        public RelationShip<Contract, Order> Orders
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contract, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Contract, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Contract, Task> Tasks
        {
            get;set;
        }
    }
    public class ContractContactRole : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContractId;
        [EntityField(false)]
        public System.String ContractId
        {
            get { return __ContractId; }
            set { SetField(ref __ContractId, value); }
        }
        private System.String __ContactId;
        [EntityField(false)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickContractContactRoleRole __Role;
        [EntityField(true)]
        public PickContractContactRoleRole Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField(false)]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class ContractFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickContractFeedType __Type;
        [EntityField(true)]
        public PickContractFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContractFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ContractFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class ContractHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContractId;
        [EntityField(false)]
        public System.String ContractId
        {
            get { return __ContractId; }
            set { SetField(ref __ContractId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickContractHistoryField __Field;
        [EntityField(false)]
        public PickContractHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class ContractStatus : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private PickContractStatusStatusCode __StatusCode;
        [EntityField(true)]
        public PickContractStatusStatusCode StatusCode
        {
            get { return __StatusCode; }
            set { SetField(ref __StatusCode, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class CronTrigger : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.DateTime? __NextFireTime;
        [EntityField(true)]
        public System.DateTime? NextFireTime
        {
            get { return __NextFireTime; }
            set { SetField(ref __NextFireTime, value); }
        }
        private System.DateTime? __PreviousFireTime;
        [EntityField(true)]
        public System.DateTime? PreviousFireTime
        {
            get { return __PreviousFireTime; }
            set { SetField(ref __PreviousFireTime, value); }
        }
        private System.String __State;
        [EntityField(true)]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.DateTime? __StartTime;
        [EntityField(true)]
        public System.DateTime? StartTime
        {
            get { return __StartTime; }
            set { SetField(ref __StartTime, value); }
        }
        private System.DateTime? __EndTime;
        [EntityField(true)]
        public System.DateTime? EndTime
        {
            get { return __EndTime; }
            set { SetField(ref __EndTime, value); }
        }
        private System.String __CronExpression;
        [EntityField(true)]
        public System.String CronExpression
        {
            get { return __CronExpression; }
            set { SetField(ref __CronExpression, value); }
        }
        private PickCronTriggerTimeZoneSidKey __TimeZoneSidKey;
        [EntityField(true)]
        public PickCronTriggerTimeZoneSidKey TimeZoneSidKey
        {
            get { return __TimeZoneSidKey; }
            set { SetField(ref __TimeZoneSidKey, value); }
        }
        private System.String __OwnerId;
        [EntityField(true)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __TimesTriggered;
        [EntityField(true)]
        public System.String TimesTriggered
        {
            get { return __TimesTriggered; }
            set { SetField(ref __TimesTriggered, value); }
        }
    }
    public class Dashboard : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __FolderId;
        [EntityField(false)]
        public System.String FolderId
        {
            get { return __FolderId; }
            set { SetField(ref __FolderId, value); }
        }
        private System.String __Title;
        [EntityField(false)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickDashboardLeftSize __LeftSize;
        [EntityField(false)]
        public PickDashboardLeftSize LeftSize
        {
            get { return __LeftSize; }
            set { SetField(ref __LeftSize, value); }
        }
        private PickDashboardMiddleSize __MiddleSize;
        [EntityField(true)]
        public PickDashboardMiddleSize MiddleSize
        {
            get { return __MiddleSize; }
            set { SetField(ref __MiddleSize, value); }
        }
        private PickDashboardRightSize __RightSize;
        [EntityField(false)]
        public PickDashboardRightSize RightSize
        {
            get { return __RightSize; }
            set { SetField(ref __RightSize, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __RunningUserId;
        [EntityField(false)]
        public System.String RunningUserId
        {
            get { return __RunningUserId; }
            set { SetField(ref __RunningUserId, value); }
        }
        private System.String __TitleColor;
        [EntityField(false)]
        public System.String TitleColor
        {
            get { return __TitleColor; }
            set { SetField(ref __TitleColor, value); }
        }
        private System.String __TitleSize;
        [EntityField(false)]
        public System.String TitleSize
        {
            get { return __TitleSize; }
            set { SetField(ref __TitleSize, value); }
        }
        private System.String __TextColor;
        [EntityField(false)]
        public System.String TextColor
        {
            get { return __TextColor; }
            set { SetField(ref __TextColor, value); }
        }
        private System.String __BackgroundStart;
        [EntityField(false)]
        public System.String BackgroundStart
        {
            get { return __BackgroundStart; }
            set { SetField(ref __BackgroundStart, value); }
        }
        private System.String __BackgroundEnd;
        [EntityField(false)]
        public System.String BackgroundEnd
        {
            get { return __BackgroundEnd; }
            set { SetField(ref __BackgroundEnd, value); }
        }
        private PickDashboardBackgroundDirection __BackgroundDirection;
        [EntityField(false)]
        public PickDashboardBackgroundDirection BackgroundDirection
        {
            get { return __BackgroundDirection; }
            set { SetField(ref __BackgroundDirection, value); }
        }
        private PickDashboardType __Type;
        [EntityField(false)]
        public PickDashboardType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Dashboard, DashboardFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Dashboard, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
    }
    public class DashboardFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickDashboardFeedType __Type;
        [EntityField(true)]
        public PickDashboardFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<DashboardFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<DashboardFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class Document : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FolderId;
        [EntityField(false)]
        public System.String FolderId
        {
            get { return __FolderId; }
            set { SetField(ref __FolderId, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __ContentType;
        [EntityField(true)]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __Type;
        [EntityField(true)]
        public System.String Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.Boolean __IsPublic;
        [EntityField(false)]
        public System.Boolean IsPublic
        {
            get { return __IsPublic; }
            set { SetField(ref __IsPublic, value); }
        }
        private System.String __BodyLength;
        [EntityField(false)]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __Url;
        [EntityField(true)]
        public System.String Url
        {
            get { return __Url; }
            set { SetField(ref __Url, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Keywords;
        [EntityField(true)]
        public System.String Keywords
        {
            get { return __Keywords; }
            set { SetField(ref __Keywords, value); }
        }
        private System.Boolean __IsInternalUseOnly;
        [EntityField(false)]
        public System.Boolean IsInternalUseOnly
        {
            get { return __IsInternalUseOnly; }
            set { SetField(ref __IsInternalUseOnly, value); }
        }
        private System.String __AuthorId;
        [EntityField(false)]
        public System.String AuthorId
        {
            get { return __AuthorId; }
            set { SetField(ref __AuthorId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsBodySearchable;
        [EntityField(false)]
        public System.Boolean IsBodySearchable
        {
            get { return __IsBodySearchable; }
            set { SetField(ref __IsBodySearchable, value); }
        }
    }
    public class DocumentAttachmentMap : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __DocumentId;
        [EntityField(false)]
        public System.String DocumentId
        {
            get { return __DocumentId; }
            set { SetField(ref __DocumentId, value); }
        }
        private System.String __DocumentSequence;
        [EntityField(false)]
        public System.String DocumentSequence
        {
            get { return __DocumentSequence; }
            set { SetField(ref __DocumentSequence, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
    }
    public class EmailMessage : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(true)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __ActivityId;
        [EntityField(true)]
        public System.String ActivityId
        {
            get { return __ActivityId; }
            set { SetField(ref __ActivityId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __TextBody;
        [EntityField(true)]
        public System.String TextBody
        {
            get { return __TextBody; }
            set { SetField(ref __TextBody, value); }
        }
        private System.String __HtmlBody;
        [EntityField(true)]
        public System.String HtmlBody
        {
            get { return __HtmlBody; }
            set { SetField(ref __HtmlBody, value); }
        }
        private System.String __Headers;
        [EntityField(true)]
        public System.String Headers
        {
            get { return __Headers; }
            set { SetField(ref __Headers, value); }
        }
        private System.String __Subject;
        [EntityField(true)]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.String __FromName;
        [EntityField(true)]
        public System.String FromName
        {
            get { return __FromName; }
            set { SetField(ref __FromName, value); }
        }
        private System.String __FromAddress;
        [EntityField(true)]
        public System.String FromAddress
        {
            get { return __FromAddress; }
            set { SetField(ref __FromAddress, value); }
        }
        private System.String __ToAddress;
        [EntityField(true)]
        public System.String ToAddress
        {
            get { return __ToAddress; }
            set { SetField(ref __ToAddress, value); }
        }
        private System.String __CcAddress;
        [EntityField(true)]
        public System.String CcAddress
        {
            get { return __CcAddress; }
            set { SetField(ref __CcAddress, value); }
        }
        private System.String __BccAddress;
        [EntityField(true)]
        public System.String BccAddress
        {
            get { return __BccAddress; }
            set { SetField(ref __BccAddress, value); }
        }
        private System.Boolean __Incoming;
        [EntityField(false)]
        public System.Boolean Incoming
        {
            get { return __Incoming; }
            set { SetField(ref __Incoming, value); }
        }
        private System.Boolean __HasAttachment;
        [EntityField(false)]
        public System.Boolean HasAttachment
        {
            get { return __HasAttachment; }
            set { SetField(ref __HasAttachment, value); }
        }
        private PickEmailMessageStatus __Status;
        [EntityField(false)]
        public PickEmailMessageStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __MessageDate;
        [EntityField(true)]
        public System.DateTime? MessageDate
        {
            get { return __MessageDate; }
            set { SetField(ref __MessageDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<EmailMessage, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<EmailMessage, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<EmailMessage, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
    }
    public class EmailServicesAddress : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __LocalPart;
        [EntityField(false)]
        public System.String LocalPart
        {
            get { return __LocalPart; }
            set { SetField(ref __LocalPart, value); }
        }
        private System.String __EmailDomainName;
        [EntityField(true)]
        public System.String EmailDomainName
        {
            get { return __EmailDomainName; }
            set { SetField(ref __EmailDomainName, value); }
        }
        private System.String __AuthorizedSenders;
        [EntityField(true)]
        public System.String AuthorizedSenders
        {
            get { return __AuthorizedSenders; }
            set { SetField(ref __AuthorizedSenders, value); }
        }
        private System.String __RunAsUserId;
        [EntityField(false)]
        public System.String RunAsUserId
        {
            get { return __RunAsUserId; }
            set { SetField(ref __RunAsUserId, value); }
        }
        private System.String __FunctionId;
        [EntityField(false)]
        public System.String FunctionId
        {
            get { return __FunctionId; }
            set { SetField(ref __FunctionId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class EmailServicesFunction : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __FunctionName;
        [EntityField(false)]
        public System.String FunctionName
        {
            get { return __FunctionName; }
            set { SetField(ref __FunctionName, value); }
        }
        private System.String __AuthorizedSenders;
        [EntityField(true)]
        public System.String AuthorizedSenders
        {
            get { return __AuthorizedSenders; }
            set { SetField(ref __AuthorizedSenders, value); }
        }
        private System.Boolean __IsAuthenticationRequired;
        [EntityField(false)]
        public System.Boolean IsAuthenticationRequired
        {
            get { return __IsAuthenticationRequired; }
            set { SetField(ref __IsAuthenticationRequired, value); }
        }
        private System.Boolean __IsTlsRequired;
        [EntityField(false)]
        public System.Boolean IsTlsRequired
        {
            get { return __IsTlsRequired; }
            set { SetField(ref __IsTlsRequired, value); }
        }
        private PickEmailServicesFunctionAttachmentOption __AttachmentOption;
        [EntityField(false)]
        public PickEmailServicesFunctionAttachmentOption AttachmentOption
        {
            get { return __AttachmentOption; }
            set { SetField(ref __AttachmentOption, value); }
        }
        private System.String __ApexClassId;
        [EntityField(true)]
        public System.String ApexClassId
        {
            get { return __ApexClassId; }
            set { SetField(ref __ApexClassId, value); }
        }
        private PickEmailServicesFunctionOverLimitAction __OverLimitAction;
        [EntityField(true)]
        public PickEmailServicesFunctionOverLimitAction OverLimitAction
        {
            get { return __OverLimitAction; }
            set { SetField(ref __OverLimitAction, value); }
        }
        private PickEmailServicesFunctionFunctionInactiveAction __FunctionInactiveAction;
        [EntityField(true)]
        public PickEmailServicesFunctionFunctionInactiveAction FunctionInactiveAction
        {
            get { return __FunctionInactiveAction; }
            set { SetField(ref __FunctionInactiveAction, value); }
        }
        private PickEmailServicesFunctionAddressInactiveAction __AddressInactiveAction;
        [EntityField(true)]
        public PickEmailServicesFunctionAddressInactiveAction AddressInactiveAction
        {
            get { return __AddressInactiveAction; }
            set { SetField(ref __AddressInactiveAction, value); }
        }
        private PickEmailServicesFunctionAuthenticationFailureAction __AuthenticationFailureAction;
        [EntityField(true)]
        public PickEmailServicesFunctionAuthenticationFailureAction AuthenticationFailureAction
        {
            get { return __AuthenticationFailureAction; }
            set { SetField(ref __AuthenticationFailureAction, value); }
        }
        private PickEmailServicesFunctionAuthorizationFailureAction __AuthorizationFailureAction;
        [EntityField(true)]
        public PickEmailServicesFunctionAuthorizationFailureAction AuthorizationFailureAction
        {
            get { return __AuthorizationFailureAction; }
            set { SetField(ref __AuthorizationFailureAction, value); }
        }
        private System.Boolean __IsTextTruncated;
        [EntityField(false)]
        public System.Boolean IsTextTruncated
        {
            get { return __IsTextTruncated; }
            set { SetField(ref __IsTextTruncated, value); }
        }
        private System.Boolean __IsErrorRoutingEnabled;
        [EntityField(false)]
        public System.Boolean IsErrorRoutingEnabled
        {
            get { return __IsErrorRoutingEnabled; }
            set { SetField(ref __IsErrorRoutingEnabled, value); }
        }
        private System.String __ErrorRoutingAddress;
        [EntityField(true)]
        public System.String ErrorRoutingAddress
        {
            get { return __ErrorRoutingAddress; }
            set { SetField(ref __ErrorRoutingAddress, value); }
        }
        private System.Boolean __IsTextAttachmentsAsBinary;
        [EntityField(false)]
        public System.Boolean IsTextAttachmentsAsBinary
        {
            get { return __IsTextAttachmentsAsBinary; }
            set { SetField(ref __IsTextAttachmentsAsBinary, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FunctionId")]
        public RelationShip<EmailServicesFunction, EmailServicesAddress> Addresses
        {
            get;set;
        }
    }
    public class EmailStatus : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __TaskId;
        [EntityField(false)]
        public System.String TaskId
        {
            get { return __TaskId; }
            set { SetField(ref __TaskId, value); }
        }
        private System.String __WhoId;
        [EntityField(true)]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.String __TimesOpened;
        [EntityField(false)]
        public System.String TimesOpened
        {
            get { return __TimesOpened; }
            set { SetField(ref __TimesOpened, value); }
        }
        private System.DateTime? __FirstOpenDate;
        [EntityField(true)]
        public System.DateTime? FirstOpenDate
        {
            get { return __FirstOpenDate; }
            set { SetField(ref __FirstOpenDate, value); }
        }
        private System.DateTime? __LastOpenDate;
        [EntityField(true)]
        public System.DateTime? LastOpenDate
        {
            get { return __LastOpenDate; }
            set { SetField(ref __LastOpenDate, value); }
        }
        private System.String __EmailTemplateName;
        [EntityField(true)]
        public System.String EmailTemplateName
        {
            get { return __EmailTemplateName; }
            set { SetField(ref __EmailTemplateName, value); }
        }
    }
    public class EmailTemplate : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __FolderId;
        [EntityField(false)]
        public System.String FolderId
        {
            get { return __FolderId; }
            set { SetField(ref __FolderId, value); }
        }
        private System.String __BrandTemplateId;
        [EntityField(true)]
        public System.String BrandTemplateId
        {
            get { return __BrandTemplateId; }
            set { SetField(ref __BrandTemplateId, value); }
        }
        private PickEmailTemplateTemplateStyle __TemplateStyle;
        [EntityField(false)]
        public PickEmailTemplateTemplateStyle TemplateStyle
        {
            get { return __TemplateStyle; }
            set { SetField(ref __TemplateStyle, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private PickEmailTemplateTemplateType __TemplateType;
        [EntityField(false)]
        public PickEmailTemplateTemplateType TemplateType
        {
            get { return __TemplateType; }
            set { SetField(ref __TemplateType, value); }
        }
        private PickEmailTemplateEncoding __Encoding;
        [EntityField(true)]
        public PickEmailTemplateEncoding Encoding
        {
            get { return __Encoding; }
            set { SetField(ref __Encoding, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Subject;
        [EntityField(true)]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.String __HtmlValue;
        [EntityField(true)]
        public System.String HtmlValue
        {
            get { return __HtmlValue; }
            set { SetField(ref __HtmlValue, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __TimesUsed;
        [EntityField(true)]
        public System.String TimesUsed
        {
            get { return __TimesUsed; }
            set { SetField(ref __TimesUsed, value); }
        }
        private System.DateTime? __LastUsedDate;
        [EntityField(true)]
        public System.DateTime? LastUsedDate
        {
            get { return __LastUsedDate; }
            set { SetField(ref __LastUsedDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __ApiVersion;
        [EntityField(true)]
        public System.String ApiVersion
        {
            get { return __ApiVersion; }
            set { SetField(ref __ApiVersion, value); }
        }
        private System.String __Markup;
        [EntityField(true)]
        public System.String Markup
        {
            get { return __Markup; }
            set { SetField(ref __Markup, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<EmailTemplate, Attachment> Attachments
        {
            get;set;
        }
    }
    public class EntitySubscription : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __SubscriberId;
        [EntityField(false)]
        public System.String SubscriberId
        {
            get { return __SubscriberId; }
            set { SetField(ref __SubscriberId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class Event : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __WhoId;
        [EntityField(true)]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField(true)]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField(true)]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.String __Location;
        [EntityField(true)]
        public System.String Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
        private System.Boolean __IsAllDayEvent;
        [EntityField(false)]
        public System.Boolean IsAllDayEvent
        {
            get { return __IsAllDayEvent; }
            set { SetField(ref __IsAllDayEvent, value); }
        }
        private System.DateTime? __ActivityDateTime;
        [EntityField(true)]
        public System.DateTime? ActivityDateTime
        {
            get { return __ActivityDateTime; }
            set { SetField(ref __ActivityDateTime, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField(true)]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __DurationInMinutes;
        [EntityField(true)]
        public System.String DurationInMinutes
        {
            get { return __DurationInMinutes; }
            set { SetField(ref __DurationInMinutes, value); }
        }
        private System.DateTime? __StartDateTime;
        [EntityField(true)]
        public System.DateTime? StartDateTime
        {
            get { return __StartDateTime; }
            set { SetField(ref __StartDateTime, value); }
        }
        private System.DateTime? __EndDateTime;
        [EntityField(true)]
        public System.DateTime? EndDateTime
        {
            get { return __EndDateTime; }
            set { SetField(ref __EndDateTime, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField(false)]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private PickEventShowAs __ShowAs;
        [EntityField(true)]
        public PickEventShowAs ShowAs
        {
            get { return __ShowAs; }
            set { SetField(ref __ShowAs, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.Boolean __IsChild;
        [EntityField(false)]
        public System.Boolean IsChild
        {
            get { return __IsChild; }
            set { SetField(ref __IsChild, value); }
        }
        private System.Boolean __IsGroupEvent;
        [EntityField(false)]
        public System.Boolean IsGroupEvent
        {
            get { return __IsGroupEvent; }
            set { SetField(ref __IsGroupEvent, value); }
        }
        private PickEventGroupEventType __GroupEventType;
        [EntityField(true)]
        public PickEventGroupEventType GroupEventType
        {
            get { return __GroupEventType; }
            set { SetField(ref __GroupEventType, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsArchived;
        [EntityField(false)]
        public System.Boolean IsArchived
        {
            get { return __IsArchived; }
            set { SetField(ref __IsArchived, value); }
        }
        private System.String __RecurrenceActivityId;
        [EntityField(true)]
        public System.String RecurrenceActivityId
        {
            get { return __RecurrenceActivityId; }
            set { SetField(ref __RecurrenceActivityId, value); }
        }
        private System.Boolean __IsRecurrence;
        [EntityField(false)]
        public System.Boolean IsRecurrence
        {
            get { return __IsRecurrence; }
            set { SetField(ref __IsRecurrence, value); }
        }
        private System.DateTime? __RecurrenceStartDateTime;
        [EntityField(true)]
        public System.DateTime? RecurrenceStartDateTime
        {
            get { return __RecurrenceStartDateTime; }
            set { SetField(ref __RecurrenceStartDateTime, value); }
        }
        private System.DateTime? __RecurrenceEndDateOnly;
        [EntityField(true)]
        public System.DateTime? RecurrenceEndDateOnly
        {
            get { return __RecurrenceEndDateOnly; }
            set { SetField(ref __RecurrenceEndDateOnly, value); }
        }
        private PickEventRecurrenceTimeZoneSidKey __RecurrenceTimeZoneSidKey;
        [EntityField(true)]
        public PickEventRecurrenceTimeZoneSidKey RecurrenceTimeZoneSidKey
        {
            get { return __RecurrenceTimeZoneSidKey; }
            set { SetField(ref __RecurrenceTimeZoneSidKey, value); }
        }
        private PickEventRecurrenceType __RecurrenceType;
        [EntityField(true)]
        public PickEventRecurrenceType RecurrenceType
        {
            get { return __RecurrenceType; }
            set { SetField(ref __RecurrenceType, value); }
        }
        private System.String __RecurrenceInterval;
        [EntityField(true)]
        public System.String RecurrenceInterval
        {
            get { return __RecurrenceInterval; }
            set { SetField(ref __RecurrenceInterval, value); }
        }
        private System.String __RecurrenceDayOfWeekMask;
        [EntityField(true)]
        public System.String RecurrenceDayOfWeekMask
        {
            get { return __RecurrenceDayOfWeekMask; }
            set { SetField(ref __RecurrenceDayOfWeekMask, value); }
        }
        private System.String __RecurrenceDayOfMonth;
        [EntityField(true)]
        public System.String RecurrenceDayOfMonth
        {
            get { return __RecurrenceDayOfMonth; }
            set { SetField(ref __RecurrenceDayOfMonth, value); }
        }
        private PickEventRecurrenceInstance __RecurrenceInstance;
        [EntityField(true)]
        public PickEventRecurrenceInstance RecurrenceInstance
        {
            get { return __RecurrenceInstance; }
            set { SetField(ref __RecurrenceInstance, value); }
        }
        private PickEventRecurrenceMonthOfYear __RecurrenceMonthOfYear;
        [EntityField(true)]
        public PickEventRecurrenceMonthOfYear RecurrenceMonthOfYear
        {
            get { return __RecurrenceMonthOfYear; }
            set { SetField(ref __RecurrenceMonthOfYear, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField(true)]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField(false)]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Event, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Event, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("RecurrenceActivityId")]
        public RelationShip<Event, Event> RecurringEvents
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("EventId")]
        public RelationShip<Event, EventAttendee> EventAttendees
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Event, EventFeed> Feeds
        {
            get;set;
        }
    }
    public class EventAttendee : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __EventId;
        [EntityField(false)]
        public System.String EventId
        {
            get { return __EventId; }
            set { SetField(ref __EventId, value); }
        }
        private System.String __AttendeeId;
        [EntityField(false)]
        public System.String AttendeeId
        {
            get { return __AttendeeId; }
            set { SetField(ref __AttendeeId, value); }
        }
        private PickEventAttendeeStatus __Status;
        [EntityField(false)]
        public PickEventAttendeeStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __RespondedDate;
        [EntityField(true)]
        public System.DateTime? RespondedDate
        {
            get { return __RespondedDate; }
            set { SetField(ref __RespondedDate, value); }
        }
        private System.String __Response;
        [EntityField(true)]
        public System.String Response
        {
            get { return __Response; }
            set { SetField(ref __Response, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class EventFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickEventFeedType __Type;
        [EntityField(true)]
        public PickEventFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<EventFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<EventFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class FeedComment : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FeedItemId;
        [EntityField(false)]
        public System.String FeedItemId
        {
            get { return __FeedItemId; }
            set { SetField(ref __FeedItemId, value); }
        }
        private System.String __ParentId;
        [EntityField(true)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CommentBody;
        [EntityField(false)]
        public System.String CommentBody
        {
            get { return __CommentBody; }
            set { SetField(ref __CommentBody, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class FeedPost : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FeedItemId;
        [EntityField(false)]
        public System.String FeedItemId
        {
            get { return __FeedItemId; }
            set { SetField(ref __FeedItemId, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private PickFeedPostType __Type;
        [EntityField(false)]
        public PickFeedPostType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Title;
        [EntityField(true)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __LinkUrl;
        [EntityField(true)]
        public System.String LinkUrl
        {
            get { return __LinkUrl; }
            set { SetField(ref __LinkUrl, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ContentData;
        [EntityField(true)]
        public System.String ContentData
        {
            get { return __ContentData; }
            set { SetField(ref __ContentData, value); }
        }
        private System.String __ContentFileName;
        [EntityField(true)]
        public System.String ContentFileName
        {
            get { return __ContentFileName; }
            set { SetField(ref __ContentFileName, value); }
        }
        private System.String __ContentDescription;
        [EntityField(true)]
        public System.String ContentDescription
        {
            get { return __ContentDescription; }
            set { SetField(ref __ContentDescription, value); }
        }
        private System.String __ContentType;
        [EntityField(true)]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __ContentSize;
        [EntityField(true)]
        public System.String ContentSize
        {
            get { return __ContentSize; }
            set { SetField(ref __ContentSize, value); }
        }
    }
    public class FeedTrackedChange : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FeedItemId;
        [EntityField(false)]
        public System.String FeedItemId
        {
            get { return __FeedItemId; }
            set { SetField(ref __FeedItemId, value); }
        }
        private System.String __FieldName;
        [EntityField(false)]
        public System.String FieldName
        {
            get { return __FieldName; }
            set { SetField(ref __FieldName, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class FiscalYearSettings : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __PeriodId;
        [EntityField(true)]
        public System.String PeriodId
        {
            get { return __PeriodId; }
            set { SetField(ref __PeriodId, value); }
        }
        private System.DateTime? __StartDate;
        [EntityField(true)]
        public System.DateTime? StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField(true)]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsStandardYear;
        [EntityField(false)]
        public System.Boolean IsStandardYear
        {
            get { return __IsStandardYear; }
            set { SetField(ref __IsStandardYear, value); }
        }
        private PickFiscalYearSettingsYearType __YearType;
        [EntityField(true)]
        public PickFiscalYearSettingsYearType YearType
        {
            get { return __YearType; }
            set { SetField(ref __YearType, value); }
        }
        private PickFiscalYearSettingsQuarterLabelScheme __QuarterLabelScheme;
        [EntityField(true)]
        public PickFiscalYearSettingsQuarterLabelScheme QuarterLabelScheme
        {
            get { return __QuarterLabelScheme; }
            set { SetField(ref __QuarterLabelScheme, value); }
        }
        private PickFiscalYearSettingsPeriodLabelScheme __PeriodLabelScheme;
        [EntityField(true)]
        public PickFiscalYearSettingsPeriodLabelScheme PeriodLabelScheme
        {
            get { return __PeriodLabelScheme; }
            set { SetField(ref __PeriodLabelScheme, value); }
        }
        private PickFiscalYearSettingsWeekLabelScheme __WeekLabelScheme;
        [EntityField(true)]
        public PickFiscalYearSettingsWeekLabelScheme WeekLabelScheme
        {
            get { return __WeekLabelScheme; }
            set { SetField(ref __WeekLabelScheme, value); }
        }
        private PickFiscalYearSettingsQuarterPrefix __QuarterPrefix;
        [EntityField(true)]
        public PickFiscalYearSettingsQuarterPrefix QuarterPrefix
        {
            get { return __QuarterPrefix; }
            set { SetField(ref __QuarterPrefix, value); }
        }
        private PickFiscalYearSettingsPeriodPrefix __PeriodPrefix;
        [EntityField(true)]
        public PickFiscalYearSettingsPeriodPrefix PeriodPrefix
        {
            get { return __PeriodPrefix; }
            set { SetField(ref __PeriodPrefix, value); }
        }
        private System.String __WeekStartDay;
        [EntityField(true)]
        public System.String WeekStartDay
        {
            get { return __WeekStartDay; }
            set { SetField(ref __WeekStartDay, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FiscalYearSettingsId")]
        public RelationShip<FiscalYearSettings, Period> Periods
        {
            get;set;
        }
    }
    public class Folder : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField(true)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private PickFolderAccessType __AccessType;
        [EntityField(false)]
        public PickFolderAccessType AccessType
        {
            get { return __AccessType; }
            set { SetField(ref __AccessType, value); }
        }
        private System.Boolean __IsReadonly;
        [EntityField(false)]
        public System.Boolean IsReadonly
        {
            get { return __IsReadonly; }
            set { SetField(ref __IsReadonly, value); }
        }
        private PickFolderType __Type;
        [EntityField(false)]
        public PickFolderType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ForecastShare : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UserRoleId;
        [EntityField(false)]
        public System.String UserRoleId
        {
            get { return __UserRoleId; }
            set { SetField(ref __UserRoleId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickForecastShareAccessLevel __AccessLevel;
        [EntityField(false)]
        public PickForecastShareAccessLevel AccessLevel
        {
            get { return __AccessLevel; }
            set { SetField(ref __AccessLevel, value); }
        }
        private System.Boolean __CanSubmit;
        [EntityField(false)]
        public System.Boolean CanSubmit
        {
            get { return __CanSubmit; }
            set { SetField(ref __CanSubmit, value); }
        }
        private PickForecastShareRowCause __RowCause;
        [EntityField(false)]
        public PickForecastShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class Group : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __RelatedId;
        [EntityField(true)]
        public System.String RelatedId
        {
            get { return __RelatedId; }
            set { SetField(ref __RelatedId, value); }
        }
        private PickGroupType __Type;
        [EntityField(false)]
        public PickGroupType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __Email;
        [EntityField(true)]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.Boolean __DoesSendEmailToMembers;
        [EntityField(false)]
        public System.Boolean DoesSendEmailToMembers
        {
            get { return __DoesSendEmailToMembers; }
            set { SetField(ref __DoesSendEmailToMembers, value); }
        }
        private System.Boolean __DoesIncludeBosses;
        [EntityField(false)]
        public System.Boolean DoesIncludeBosses
        {
            get { return __DoesIncludeBosses; }
            set { SetField(ref __DoesIncludeBosses, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("GroupId")]
        public RelationShip<Group, GroupMember> GroupMembers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("QueueId")]
        public RelationShip<Group, QueueSobject> QueueSobjects
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("DelegatedApproverId")]
        public RelationShip<Group, User> DelegatedUsers
        {
            get;set;
        }
    }
    public class GroupMember : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __GroupId;
        [EntityField(false)]
        public System.String GroupId
        {
            get { return __GroupId; }
            set { SetField(ref __GroupId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Holiday : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsAllDay;
        [EntityField(false)]
        public System.Boolean IsAllDay
        {
            get { return __IsAllDay; }
            set { SetField(ref __IsAllDay, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField(true)]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __StartTimeInMinutes;
        [EntityField(true)]
        public System.String StartTimeInMinutes
        {
            get { return __StartTimeInMinutes; }
            set { SetField(ref __StartTimeInMinutes, value); }
        }
        private System.String __EndTimeInMinutes;
        [EntityField(true)]
        public System.String EndTimeInMinutes
        {
            get { return __EndTimeInMinutes; }
            set { SetField(ref __EndTimeInMinutes, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsRecurrence;
        [EntityField(false)]
        public System.Boolean IsRecurrence
        {
            get { return __IsRecurrence; }
            set { SetField(ref __IsRecurrence, value); }
        }
        private System.DateTime? __RecurrenceStartDate;
        [EntityField(true)]
        public System.DateTime? RecurrenceStartDate
        {
            get { return __RecurrenceStartDate; }
            set { SetField(ref __RecurrenceStartDate, value); }
        }
        private System.DateTime? __RecurrenceEndDateOnly;
        [EntityField(true)]
        public System.DateTime? RecurrenceEndDateOnly
        {
            get { return __RecurrenceEndDateOnly; }
            set { SetField(ref __RecurrenceEndDateOnly, value); }
        }
        private PickHolidayRecurrenceType __RecurrenceType;
        [EntityField(true)]
        public PickHolidayRecurrenceType RecurrenceType
        {
            get { return __RecurrenceType; }
            set { SetField(ref __RecurrenceType, value); }
        }
        private System.String __RecurrenceInterval;
        [EntityField(true)]
        public System.String RecurrenceInterval
        {
            get { return __RecurrenceInterval; }
            set { SetField(ref __RecurrenceInterval, value); }
        }
        private System.String __RecurrenceDayOfWeekMask;
        [EntityField(true)]
        public System.String RecurrenceDayOfWeekMask
        {
            get { return __RecurrenceDayOfWeekMask; }
            set { SetField(ref __RecurrenceDayOfWeekMask, value); }
        }
        private System.String __RecurrenceDayOfMonth;
        [EntityField(true)]
        public System.String RecurrenceDayOfMonth
        {
            get { return __RecurrenceDayOfMonth; }
            set { SetField(ref __RecurrenceDayOfMonth, value); }
        }
        private PickHolidayRecurrenceInstance __RecurrenceInstance;
        [EntityField(true)]
        public PickHolidayRecurrenceInstance RecurrenceInstance
        {
            get { return __RecurrenceInstance; }
            set { SetField(ref __RecurrenceInstance, value); }
        }
        private PickHolidayRecurrenceMonthOfYear __RecurrenceMonthOfYear;
        [EntityField(true)]
        public PickHolidayRecurrenceMonthOfYear RecurrenceMonthOfYear
        {
            get { return __RecurrenceMonthOfYear; }
            set { SetField(ref __RecurrenceMonthOfYear, value); }
        }
    }
    public class Idea : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Title;
        [EntityField(false)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __RecordTypeId;
        [EntityField(true)]
        public System.String RecordTypeId
        {
            get { return __RecordTypeId; }
            set { SetField(ref __RecordTypeId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsLocked;
        [EntityField(false)]
        public System.Boolean IsLocked
        {
            get { return __IsLocked; }
            set { SetField(ref __IsLocked, value); }
        }
        private System.String __CommunityId;
        [EntityField(false)]
        public System.String CommunityId
        {
            get { return __CommunityId; }
            set { SetField(ref __CommunityId, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __NumComments;
        [EntityField(true)]
        public System.String NumComments
        {
            get { return __NumComments; }
            set { SetField(ref __NumComments, value); }
        }
        private System.String __VoteScore;
        [EntityField(true)]
        public System.String VoteScore
        {
            get { return __VoteScore; }
            set { SetField(ref __VoteScore, value); }
        }
        private System.String __VoteTotal;
        [EntityField(true)]
        public System.String VoteTotal
        {
            get { return __VoteTotal; }
            set { SetField(ref __VoteTotal, value); }
        }
        private System.String __Categories;
        [EntityField(true)]
        public System.String Categories
        {
            get { return __Categories; }
            set { SetField(ref __Categories, value); }
        }
        private PickIdeaStatus __Status;
        [EntityField(true)]
        public PickIdeaStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.DateTime? __LastCommentDate;
        [EntityField(true)]
        public System.DateTime? LastCommentDate
        {
            get { return __LastCommentDate; }
            set { SetField(ref __LastCommentDate, value); }
        }
        private System.String __LastCommentId;
        [EntityField(true)]
        public System.String LastCommentId
        {
            get { return __LastCommentId; }
            set { SetField(ref __LastCommentId, value); }
        }
        private System.String __ParentIdeaId;
        [EntityField(true)]
        public System.String ParentIdeaId
        {
            get { return __ParentIdeaId; }
            set { SetField(ref __ParentIdeaId, value); }
        }
        private System.Boolean __IsHtml;
        [EntityField(false)]
        public System.Boolean IsHtml
        {
            get { return __IsHtml; }
            set { SetField(ref __IsHtml, value); }
        }
        [JsonIgnore]
        [ReferencedByField("IdeaId")]
        public RelationShip<Idea, IdeaComment> Comments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Idea, Vote> Votes
        {
            get;set;
        }
    }
    public class IdeaComment : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __IdeaId;
        [EntityField(false)]
        public System.String IdeaId
        {
            get { return __IdeaId; }
            set { SetField(ref __IdeaId, value); }
        }
        private System.String __CommentBody;
        [EntityField(true)]
        public System.String CommentBody
        {
            get { return __CommentBody; }
            set { SetField(ref __CommentBody, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.Boolean __IsHtml;
        [EntityField(false)]
        public System.Boolean IsHtml
        {
            get { return __IsHtml; }
            set { SetField(ref __IsHtml, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<IdeaComment, Vote> Votes
        {
            get;set;
        }
    }
    public class Lead : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __MasterRecordId;
        [EntityField(true)]
        public System.String MasterRecordId
        {
            get { return __MasterRecordId; }
            set { SetField(ref __MasterRecordId, value); }
        }
        private System.String __LastName;
        [EntityField(false)]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField(true)]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private PickLeadSalutation __Salutation;
        [EntityField(true)]
        public PickLeadSalutation Salutation
        {
            get { return __Salutation; }
            set { SetField(ref __Salutation, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Title;
        [EntityField(true)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Company;
        [EntityField(false)]
        public System.String Company
        {
            get { return __Company; }
            set { SetField(ref __Company, value); }
        }
        private System.String __Street;
        [EntityField(true)]
        public System.String Street
        {
            get { return __Street; }
            set { SetField(ref __Street, value); }
        }
        private System.String __City;
        [EntityField(true)]
        public System.String City
        {
            get { return __City; }
            set { SetField(ref __City, value); }
        }
        private System.String __State;
        [EntityField(true)]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.String __PostalCode;
        [EntityField(true)]
        public System.String PostalCode
        {
            get { return __PostalCode; }
            set { SetField(ref __PostalCode, value); }
        }
        private System.String __Country;
        [EntityField(true)]
        public System.String Country
        {
            get { return __Country; }
            set { SetField(ref __Country, value); }
        }
        private System.String __Phone;
        [EntityField(true)]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __MobilePhone;
        [EntityField(true)]
        public System.String MobilePhone
        {
            get { return __MobilePhone; }
            set { SetField(ref __MobilePhone, value); }
        }
        private System.String __Fax;
        [EntityField(true)]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __Email;
        [EntityField(true)]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Website;
        [EntityField(true)]
        public System.String Website
        {
            get { return __Website; }
            set { SetField(ref __Website, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickLeadLeadSource __LeadSource;
        [EntityField(true)]
        public PickLeadLeadSource LeadSource
        {
            get { return __LeadSource; }
            set { SetField(ref __LeadSource, value); }
        }
        private PickLeadStatus __Status;
        [EntityField(false)]
        public PickLeadStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickLeadIndustry __Industry;
        [EntityField(true)]
        public PickLeadIndustry Industry
        {
            get { return __Industry; }
            set { SetField(ref __Industry, value); }
        }
        private PickLeadRating __Rating;
        [EntityField(true)]
        public PickLeadRating Rating
        {
            get { return __Rating; }
            set { SetField(ref __Rating, value); }
        }
        private System.String __AnnualRevenue;
        [EntityField(true)]
        public System.String AnnualRevenue
        {
            get { return __AnnualRevenue; }
            set { SetField(ref __AnnualRevenue, value); }
        }
        private System.String __NumberOfEmployees;
        [EntityField(true)]
        public System.String NumberOfEmployees
        {
            get { return __NumberOfEmployees; }
            set { SetField(ref __NumberOfEmployees, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.Boolean __IsConverted;
        [EntityField(false)]
        public System.Boolean IsConverted
        {
            get { return __IsConverted; }
            set { SetField(ref __IsConverted, value); }
        }
        private System.DateTime? __ConvertedDate;
        [EntityField(true)]
        public System.DateTime? ConvertedDate
        {
            get { return __ConvertedDate; }
            set { SetField(ref __ConvertedDate, value); }
        }
        private System.String __ConvertedAccountId;
        [EntityField(true)]
        public System.String ConvertedAccountId
        {
            get { return __ConvertedAccountId; }
            set { SetField(ref __ConvertedAccountId, value); }
        }
        private System.String __ConvertedContactId;
        [EntityField(true)]
        public System.String ConvertedContactId
        {
            get { return __ConvertedContactId; }
            set { SetField(ref __ConvertedContactId, value); }
        }
        private System.String __ConvertedOpportunityId;
        [EntityField(true)]
        public System.String ConvertedOpportunityId
        {
            get { return __ConvertedOpportunityId; }
            set { SetField(ref __ConvertedOpportunityId, value); }
        }
        private System.Boolean __IsUnreadByOwner;
        [EntityField(false)]
        public System.Boolean IsUnreadByOwner
        {
            get { return __IsUnreadByOwner; }
            set { SetField(ref __IsUnreadByOwner, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField(true)]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.String __EmailBouncedReason;
        [EntityField(true)]
        public System.String EmailBouncedReason
        {
            get { return __EmailBouncedReason; }
            set { SetField(ref __EmailBouncedReason, value); }
        }
        private System.DateTime? __EmailBouncedDate;
        [EntityField(true)]
        public System.DateTime? EmailBouncedDate
        {
            get { return __EmailBouncedDate; }
            set { SetField(ref __EmailBouncedDate, value); }
        }
        private System.String __SICCodec;
        [JsonProperty(PropertyName = "SICCode__c")]
        [EntityField(true)]
        public System.String SICCodec
        {
            get { return __SICCodec; }
            set { SetField(ref __SICCodec, value); }
        }
        private PickLeadProductInterest__c __ProductInterestc;
        [JsonProperty(PropertyName = "ProductInterest__c")]
        [EntityField(true)]
        public PickLeadProductInterest__c ProductInterestc
        {
            get { return __ProductInterestc; }
            set { SetField(ref __ProductInterestc, value); }
        }
        private PickLeadPrimary__c __Primaryc;
        [JsonProperty(PropertyName = "Primary__c")]
        [EntityField(true)]
        public PickLeadPrimary__c Primaryc
        {
            get { return __Primaryc; }
            set { SetField(ref __Primaryc, value); }
        }
        private System.String __CurrentGeneratorsc;
        [JsonProperty(PropertyName = "CurrentGenerators__c")]
        [EntityField(true)]
        public System.String CurrentGeneratorsc
        {
            get { return __CurrentGeneratorsc; }
            set { SetField(ref __CurrentGeneratorsc, value); }
        }
        private System.String __NumberofLocationsc;
        [JsonProperty(PropertyName = "NumberofLocations__c")]
        [EntityField(true)]
        public System.String NumberofLocationsc
        {
            get { return __NumberofLocationsc; }
            set { SetField(ref __NumberofLocationsc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("LeadId")]
        public RelationShip<Lead, CampaignMember> CampaignMembers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, EmailStatus> EmailStatuses
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, LeadFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("LeadId")]
        public RelationShip<Lead, LeadHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("LeadId")]
        public RelationShip<Lead, LeadShare> Shares
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Lead, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Lead, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Lead, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhoId")]
        public RelationShip<Lead, Task> Tasks
        {
            get;set;
        }
    }
    public class LeadFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickLeadFeedType __Type;
        [EntityField(true)]
        public PickLeadFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<LeadFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<LeadFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class LeadHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __LeadId;
        [EntityField(false)]
        public System.String LeadId
        {
            get { return __LeadId; }
            set { SetField(ref __LeadId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickLeadHistoryField __Field;
        [EntityField(false)]
        public PickLeadHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class LeadShare : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __LeadId;
        [EntityField(false)]
        public System.String LeadId
        {
            get { return __LeadId; }
            set { SetField(ref __LeadId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickLeadShareLeadAccessLevel __LeadAccessLevel;
        [EntityField(false)]
        public PickLeadShareLeadAccessLevel LeadAccessLevel
        {
            get { return __LeadAccessLevel; }
            set { SetField(ref __LeadAccessLevel, value); }
        }
        private PickLeadShareRowCause __RowCause;
        [EntityField(true)]
        public PickLeadShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class LeadStatus : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsConverted;
        [EntityField(false)]
        public System.Boolean IsConverted
        {
            get { return __IsConverted; }
            set { SetField(ref __IsConverted, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class LoginIp : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UsersId;
        [EntityField(false)]
        public System.String UsersId
        {
            get { return __UsersId; }
            set { SetField(ref __UsersId, value); }
        }
        private System.String __SourceIp;
        [EntityField(true)]
        public System.String SourceIp
        {
            get { return __SourceIp; }
            set { SetField(ref __SourceIp, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsAuthenticated;
        [EntityField(false)]
        public System.Boolean IsAuthenticated
        {
            get { return __IsAuthenticated; }
            set { SetField(ref __IsAuthenticated, value); }
        }
        private System.DateTime? __ChallengeSentDate;
        [EntityField(true)]
        public System.DateTime? ChallengeSentDate
        {
            get { return __ChallengeSentDate; }
            set { SetField(ref __ChallengeSentDate, value); }
        }
    }
    public class MailmergeTemplate : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __Filename;
        [EntityField(false)]
        public System.String Filename
        {
            get { return __Filename; }
            set { SetField(ref __Filename, value); }
        }
        private System.String __BodyLength;
        [EntityField(true)]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField(false)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.DateTime? __LastUsedDate;
        [EntityField(true)]
        public System.DateTime? LastUsedDate
        {
            get { return __LastUsedDate; }
            set { SetField(ref __LastUsedDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentScannedForXSS;
        [EntityField(false)]
        public System.Boolean SecurityOptionsAttachmentScannedForXSS
        {
            get { return __SecurityOptionsAttachmentScannedForXSS; }
            set { SetField(ref __SecurityOptionsAttachmentScannedForXSS, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentHasXSSThreat;
        [EntityField(false)]
        public System.Boolean SecurityOptionsAttachmentHasXSSThreat
        {
            get { return __SecurityOptionsAttachmentHasXSSThreat; }
            set { SetField(ref __SecurityOptionsAttachmentHasXSSThreat, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentScannedforFlash;
        [EntityField(false)]
        public System.Boolean SecurityOptionsAttachmentScannedforFlash
        {
            get { return __SecurityOptionsAttachmentScannedforFlash; }
            set { SetField(ref __SecurityOptionsAttachmentScannedforFlash, value); }
        }
        private System.Boolean __SecurityOptionsAttachmentHasFlash;
        [EntityField(false)]
        public System.Boolean SecurityOptionsAttachmentHasFlash
        {
            get { return __SecurityOptionsAttachmentHasFlash; }
            set { SetField(ref __SecurityOptionsAttachmentHasFlash, value); }
        }
    }
    public class Name : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String ___Name;
        [JsonProperty(PropertyName = "Name")]
        [EntityField(true)]
        public System.String _Name
        {
            get { return ___Name; }
            set { SetField(ref ___Name, value); }
        }
        private System.String __LastName;
        [EntityField(true)]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField(true)]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private PickNameType __Type;
        [EntityField(true)]
        public PickNameType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __Alias;
        [EntityField(true)]
        public System.String Alias
        {
            get { return __Alias; }
            set { SetField(ref __Alias, value); }
        }
        private System.String __UserRoleId;
        [EntityField(true)]
        public System.String UserRoleId
        {
            get { return __UserRoleId; }
            set { SetField(ref __UserRoleId, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __ProfileId;
        [EntityField(true)]
        public System.String ProfileId
        {
            get { return __ProfileId; }
            set { SetField(ref __ProfileId, value); }
        }
        private System.String __Title;
        [EntityField(true)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Email;
        [EntityField(true)]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Phone;
        [EntityField(true)]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Username;
        [EntityField(true)]
        public System.String Username
        {
            get { return __Username; }
            set { SetField(ref __Username, value); }
        }
    }
    public class NewsFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickNewsFeedType __Type;
        [EntityField(true)]
        public PickNewsFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<NewsFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<NewsFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class Note : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __Title;
        [EntityField(false)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField(false)]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class NoteAndAttachment : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.Boolean __IsNote;
        [EntityField(false)]
        public System.Boolean IsNote
        {
            get { return __IsNote; }
            set { SetField(ref __IsNote, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __Title;
        [EntityField(true)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField(false)]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class OpenActivity : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __WhoId;
        [EntityField(true)]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField(true)]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField(true)]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.Boolean __IsTask;
        [EntityField(false)]
        public System.Boolean IsTask
        {
            get { return __IsTask; }
            set { SetField(ref __IsTask, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField(true)]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private System.String __OwnerId;
        [EntityField(true)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private PickOpenActivityStatus __Status;
        [EntityField(true)]
        public PickOpenActivityStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickOpenActivityPriority __Priority;
        [EntityField(true)]
        public PickOpenActivityPriority Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private PickOpenActivityActivityType __ActivityType;
        [EntityField(true)]
        public PickOpenActivityActivityType ActivityType
        {
            get { return __ActivityType; }
            set { SetField(ref __ActivityType, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsAllDayEvent;
        [EntityField(false)]
        public System.Boolean IsAllDayEvent
        {
            get { return __IsAllDayEvent; }
            set { SetField(ref __IsAllDayEvent, value); }
        }
        private System.Boolean __IsVisibleInSelfService;
        [EntityField(false)]
        public System.Boolean IsVisibleInSelfService
        {
            get { return __IsVisibleInSelfService; }
            set { SetField(ref __IsVisibleInSelfService, value); }
        }
        private System.String __DurationInMinutes;
        [EntityField(true)]
        public System.String DurationInMinutes
        {
            get { return __DurationInMinutes; }
            set { SetField(ref __DurationInMinutes, value); }
        }
        private System.String __Location;
        [EntityField(true)]
        public System.String Location
        {
            get { return __Location; }
            set { SetField(ref __Location, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __CallDurationInSeconds;
        [EntityField(true)]
        public System.String CallDurationInSeconds
        {
            get { return __CallDurationInSeconds; }
            set { SetField(ref __CallDurationInSeconds, value); }
        }
        private PickOpenActivityCallType __CallType;
        [EntityField(true)]
        public PickOpenActivityCallType CallType
        {
            get { return __CallType; }
            set { SetField(ref __CallType, value); }
        }
        private System.String __CallDisposition;
        [EntityField(true)]
        public System.String CallDisposition
        {
            get { return __CallDisposition; }
            set { SetField(ref __CallDisposition, value); }
        }
        private System.String __CallObject;
        [EntityField(true)]
        public System.String CallObject
        {
            get { return __CallObject; }
            set { SetField(ref __CallObject, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField(true)]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField(false)]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
    }
    public class Opportunity : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.Boolean __IsPrivate;
        [EntityField(false)]
        public System.Boolean IsPrivate
        {
            get { return __IsPrivate; }
            set { SetField(ref __IsPrivate, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickOpportunityStageName __StageName;
        [EntityField(false)]
        public PickOpportunityStageName StageName
        {
            get { return __StageName; }
            set { SetField(ref __StageName, value); }
        }
        private System.String __Amount;
        [EntityField(true)]
        public System.String Amount
        {
            get { return __Amount; }
            set { SetField(ref __Amount, value); }
        }
        private System.String __Probability;
        [EntityField(true)]
        public System.String Probability
        {
            get { return __Probability; }
            set { SetField(ref __Probability, value); }
        }
        private System.String __ExpectedRevenue;
        [EntityField(true)]
        public System.String ExpectedRevenue
        {
            get { return __ExpectedRevenue; }
            set { SetField(ref __ExpectedRevenue, value); }
        }
        private System.String __TotalOpportunityQuantity;
        [EntityField(true)]
        public System.String TotalOpportunityQuantity
        {
            get { return __TotalOpportunityQuantity; }
            set { SetField(ref __TotalOpportunityQuantity, value); }
        }
        private System.DateTime __CloseDate;
        [EntityField(false)]
        public System.DateTime CloseDate
        {
            get { return __CloseDate; }
            set { SetField(ref __CloseDate, value); }
        }
        private PickOpportunityType __Type;
        [EntityField(true)]
        public PickOpportunityType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __NextStep;
        [EntityField(true)]
        public System.String NextStep
        {
            get { return __NextStep; }
            set { SetField(ref __NextStep, value); }
        }
        private PickOpportunityLeadSource __LeadSource;
        [EntityField(true)]
        public PickOpportunityLeadSource LeadSource
        {
            get { return __LeadSource; }
            set { SetField(ref __LeadSource, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsWon;
        [EntityField(false)]
        public System.Boolean IsWon
        {
            get { return __IsWon; }
            set { SetField(ref __IsWon, value); }
        }
        private PickOpportunityForecastCategory __ForecastCategory;
        [EntityField(false)]
        public PickOpportunityForecastCategory ForecastCategory
        {
            get { return __ForecastCategory; }
            set { SetField(ref __ForecastCategory, value); }
        }
        private PickOpportunityForecastCategoryName __ForecastCategoryName;
        [EntityField(true)]
        public PickOpportunityForecastCategoryName ForecastCategoryName
        {
            get { return __ForecastCategoryName; }
            set { SetField(ref __ForecastCategoryName, value); }
        }
        private System.String __CampaignId;
        [EntityField(true)]
        public System.String CampaignId
        {
            get { return __CampaignId; }
            set { SetField(ref __CampaignId, value); }
        }
        private System.Boolean __HasOpportunityLineItem;
        [EntityField(false)]
        public System.Boolean HasOpportunityLineItem
        {
            get { return __HasOpportunityLineItem; }
            set { SetField(ref __HasOpportunityLineItem, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField(true)]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __LastActivityDate;
        [EntityField(true)]
        public System.DateTime? LastActivityDate
        {
            get { return __LastActivityDate; }
            set { SetField(ref __LastActivityDate, value); }
        }
        private System.String __FiscalQuarter;
        [EntityField(true)]
        public System.String FiscalQuarter
        {
            get { return __FiscalQuarter; }
            set { SetField(ref __FiscalQuarter, value); }
        }
        private System.String __FiscalYear;
        [EntityField(true)]
        public System.String FiscalYear
        {
            get { return __FiscalYear; }
            set { SetField(ref __FiscalYear, value); }
        }
        private System.String __Fiscal;
        [EntityField(true)]
        public System.String Fiscal
        {
            get { return __Fiscal; }
            set { SetField(ref __Fiscal, value); }
        }
        private PickOpportunityDeliveryInstallationStatus__c __DeliveryInstallationStatusc;
        [JsonProperty(PropertyName = "DeliveryInstallationStatus__c")]
        [EntityField(true)]
        public PickOpportunityDeliveryInstallationStatus__c DeliveryInstallationStatusc
        {
            get { return __DeliveryInstallationStatusc; }
            set { SetField(ref __DeliveryInstallationStatusc, value); }
        }
        private System.String __TrackingNumberc;
        [JsonProperty(PropertyName = "TrackingNumber__c")]
        [EntityField(true)]
        public System.String TrackingNumberc
        {
            get { return __TrackingNumberc; }
            set { SetField(ref __TrackingNumberc, value); }
        }
        private System.String __OrderNumberc;
        [JsonProperty(PropertyName = "OrderNumber__c")]
        [EntityField(true)]
        public System.String OrderNumberc
        {
            get { return __OrderNumberc; }
            set { SetField(ref __OrderNumberc, value); }
        }
        private System.String __CurrentGeneratorsc;
        [JsonProperty(PropertyName = "CurrentGenerators__c")]
        [EntityField(true)]
        public System.String CurrentGeneratorsc
        {
            get { return __CurrentGeneratorsc; }
            set { SetField(ref __CurrentGeneratorsc, value); }
        }
        private System.String __MainCompetitorsc;
        [JsonProperty(PropertyName = "MainCompetitors__c")]
        [EntityField(true)]
        public System.String MainCompetitorsc
        {
            get { return __MainCompetitorsc; }
            set { SetField(ref __MainCompetitorsc, value); }
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, AccountPartner> AccountPartners
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityCompetitor> OpportunityCompetitors
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityContactRole> OpportunityContactRoles
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Opportunity, OpportunityFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityFieldHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityHistory> OpportunityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityLineItem> OpportunityLineItems
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityPartner> OpportunityPartnersFrom
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, OpportunityShare> Shares
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OpportunityId")]
        public RelationShip<Opportunity, Partner> Partners
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Opportunity, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Opportunity, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Opportunity, Task> Tasks
        {
            get;set;
        }
    }
    public class OpportunityCompetitor : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField(false)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __CompetitorName;
        [EntityField(true)]
        public System.String CompetitorName
        {
            get { return __CompetitorName; }
            set { SetField(ref __CompetitorName, value); }
        }
        private System.String __Strengths;
        [EntityField(true)]
        public System.String Strengths
        {
            get { return __Strengths; }
            set { SetField(ref __Strengths, value); }
        }
        private System.String __Weaknesses;
        [EntityField(true)]
        public System.String Weaknesses
        {
            get { return __Weaknesses; }
            set { SetField(ref __Weaknesses, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityContactRole : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField(false)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __ContactId;
        [EntityField(false)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private PickOpportunityContactRoleRole __Role;
        [EntityField(true)]
        public PickOpportunityContactRoleRole Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField(false)]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickOpportunityFeedType __Type;
        [EntityField(true)]
        public PickOpportunityFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<OpportunityFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<OpportunityFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class OpportunityFieldHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OpportunityId;
        [EntityField(false)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickOpportunityFieldHistoryField __Field;
        [EntityField(false)]
        public PickOpportunityFieldHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class OpportunityHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField(false)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickOpportunityHistoryStageName __StageName;
        [EntityField(false)]
        public PickOpportunityHistoryStageName StageName
        {
            get { return __StageName; }
            set { SetField(ref __StageName, value); }
        }
        private System.String __Amount;
        [EntityField(true)]
        public System.String Amount
        {
            get { return __Amount; }
            set { SetField(ref __Amount, value); }
        }
        private System.String __ExpectedRevenue;
        [EntityField(true)]
        public System.String ExpectedRevenue
        {
            get { return __ExpectedRevenue; }
            set { SetField(ref __ExpectedRevenue, value); }
        }
        private System.DateTime? __CloseDate;
        [EntityField(true)]
        public System.DateTime? CloseDate
        {
            get { return __CloseDate; }
            set { SetField(ref __CloseDate, value); }
        }
        private System.String __Probability;
        [EntityField(true)]
        public System.String Probability
        {
            get { return __Probability; }
            set { SetField(ref __Probability, value); }
        }
        private PickOpportunityHistoryForecastCategory __ForecastCategory;
        [EntityField(true)]
        public PickOpportunityHistoryForecastCategory ForecastCategory
        {
            get { return __ForecastCategory; }
            set { SetField(ref __ForecastCategory, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityLineItem : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField(false)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.String __PricebookEntryId;
        [EntityField(true)]
        public System.String PricebookEntryId
        {
            get { return __PricebookEntryId; }
            set { SetField(ref __PricebookEntryId, value); }
        }
        private System.String __Quantity;
        [EntityField(false)]
        public System.String Quantity
        {
            get { return __Quantity; }
            set { SetField(ref __Quantity, value); }
        }
        private System.String __TotalPrice;
        [EntityField(true)]
        public System.String TotalPrice
        {
            get { return __TotalPrice; }
            set { SetField(ref __TotalPrice, value); }
        }
        private System.String __UnitPrice;
        [EntityField(true)]
        public System.String UnitPrice
        {
            get { return __UnitPrice; }
            set { SetField(ref __UnitPrice, value); }
        }
        private System.String __ListPrice;
        [EntityField(true)]
        public System.String ListPrice
        {
            get { return __ListPrice; }
            set { SetField(ref __ListPrice, value); }
        }
        private System.DateTime? __ServiceDate;
        [EntityField(true)]
        public System.DateTime? ServiceDate
        {
            get { return __ServiceDate; }
            set { SetField(ref __ServiceDate, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityPartner : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField(false)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __AccountToId;
        [EntityField(false)]
        public System.String AccountToId
        {
            get { return __AccountToId; }
            set { SetField(ref __AccountToId, value); }
        }
        private PickOpportunityPartnerRole __Role;
        [EntityField(true)]
        public PickOpportunityPartnerRole Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField(false)]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ReversePartnerId;
        [EntityField(true)]
        public System.String ReversePartnerId
        {
            get { return __ReversePartnerId; }
            set { SetField(ref __ReversePartnerId, value); }
        }
    }
    public class OpportunityShare : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField(false)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __UserOrGroupId;
        [EntityField(false)]
        public System.String UserOrGroupId
        {
            get { return __UserOrGroupId; }
            set { SetField(ref __UserOrGroupId, value); }
        }
        private PickOpportunityShareOpportunityAccessLevel __OpportunityAccessLevel;
        [EntityField(false)]
        public PickOpportunityShareOpportunityAccessLevel OpportunityAccessLevel
        {
            get { return __OpportunityAccessLevel; }
            set { SetField(ref __OpportunityAccessLevel, value); }
        }
        private PickOpportunityShareRowCause __RowCause;
        [EntityField(true)]
        public PickOpportunityShareRowCause RowCause
        {
            get { return __RowCause; }
            set { SetField(ref __RowCause, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
    }
    public class OpportunityStage : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.Boolean __IsWon;
        [EntityField(false)]
        public System.Boolean IsWon
        {
            get { return __IsWon; }
            set { SetField(ref __IsWon, value); }
        }
        private PickOpportunityStageForecastCategory __ForecastCategory;
        [EntityField(false)]
        public PickOpportunityStageForecastCategory ForecastCategory
        {
            get { return __ForecastCategory; }
            set { SetField(ref __ForecastCategory, value); }
        }
        private PickOpportunityStageForecastCategoryName __ForecastCategoryName;
        [EntityField(false)]
        public PickOpportunityStageForecastCategoryName ForecastCategoryName
        {
            get { return __ForecastCategoryName; }
            set { SetField(ref __ForecastCategoryName, value); }
        }
        private System.String __DefaultProbability;
        [EntityField(true)]
        public System.String DefaultProbability
        {
            get { return __DefaultProbability; }
            set { SetField(ref __DefaultProbability, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Order : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ContractId;
        [EntityField(true)]
        public System.String ContractId
        {
            get { return __ContractId; }
            set { SetField(ref __ContractId, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.DateTime __EffectiveDate;
        [EntityField(false)]
        public System.DateTime EffectiveDate
        {
            get { return __EffectiveDate; }
            set { SetField(ref __EffectiveDate, value); }
        }
        private System.Boolean __IsReductionOrder;
        [EntityField(false)]
        public System.Boolean IsReductionOrder
        {
            get { return __IsReductionOrder; }
            set { SetField(ref __IsReductionOrder, value); }
        }
        private PickOrderStatus __Status;
        [EntityField(false)]
        public PickOrderStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __CustomerAuthorizedById;
        [EntityField(true)]
        public System.String CustomerAuthorizedById
        {
            get { return __CustomerAuthorizedById; }
            set { SetField(ref __CustomerAuthorizedById, value); }
        }
        private System.DateTime? __CustomerAuthorizedDate;
        [EntityField(true)]
        public System.DateTime? CustomerAuthorizedDate
        {
            get { return __CustomerAuthorizedDate; }
            set { SetField(ref __CustomerAuthorizedDate, value); }
        }
        private System.String __CompanyAuthorizedById;
        [EntityField(true)]
        public System.String CompanyAuthorizedById
        {
            get { return __CompanyAuthorizedById; }
            set { SetField(ref __CompanyAuthorizedById, value); }
        }
        private System.DateTime? __CompanyAuthorizedDate;
        [EntityField(true)]
        public System.DateTime? CompanyAuthorizedDate
        {
            get { return __CompanyAuthorizedDate; }
            set { SetField(ref __CompanyAuthorizedDate, value); }
        }
        private PickOrderType __Type;
        [EntityField(true)]
        public PickOrderType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __BillingStreet;
        [EntityField(true)]
        public System.String BillingStreet
        {
            get { return __BillingStreet; }
            set { SetField(ref __BillingStreet, value); }
        }
        private System.String __BillingCity;
        [EntityField(true)]
        public System.String BillingCity
        {
            get { return __BillingCity; }
            set { SetField(ref __BillingCity, value); }
        }
        private System.String __BillingState;
        [EntityField(true)]
        public System.String BillingState
        {
            get { return __BillingState; }
            set { SetField(ref __BillingState, value); }
        }
        private System.String __BillingPostalCode;
        [EntityField(true)]
        public System.String BillingPostalCode
        {
            get { return __BillingPostalCode; }
            set { SetField(ref __BillingPostalCode, value); }
        }
        private System.String __BillingCountry;
        [EntityField(true)]
        public System.String BillingCountry
        {
            get { return __BillingCountry; }
            set { SetField(ref __BillingCountry, value); }
        }
        private System.String __ShippingStreet;
        [EntityField(true)]
        public System.String ShippingStreet
        {
            get { return __ShippingStreet; }
            set { SetField(ref __ShippingStreet, value); }
        }
        private System.String __ShippingCity;
        [EntityField(true)]
        public System.String ShippingCity
        {
            get { return __ShippingCity; }
            set { SetField(ref __ShippingCity, value); }
        }
        private System.String __ShippingState;
        [EntityField(true)]
        public System.String ShippingState
        {
            get { return __ShippingState; }
            set { SetField(ref __ShippingState, value); }
        }
        private System.String __ShippingPostalCode;
        [EntityField(true)]
        public System.String ShippingPostalCode
        {
            get { return __ShippingPostalCode; }
            set { SetField(ref __ShippingPostalCode, value); }
        }
        private System.String __ShippingCountry;
        [EntityField(true)]
        public System.String ShippingCountry
        {
            get { return __ShippingCountry; }
            set { SetField(ref __ShippingCountry, value); }
        }
        private System.String __Name;
        [EntityField(true)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.DateTime? __PoDate;
        [EntityField(true)]
        public System.DateTime? PoDate
        {
            get { return __PoDate; }
            set { SetField(ref __PoDate, value); }
        }
        private System.String __PoNumber;
        [EntityField(true)]
        public System.String PoNumber
        {
            get { return __PoNumber; }
            set { SetField(ref __PoNumber, value); }
        }
        private System.String __OrderReferenceNumber;
        [EntityField(true)]
        public System.String OrderReferenceNumber
        {
            get { return __OrderReferenceNumber; }
            set { SetField(ref __OrderReferenceNumber, value); }
        }
        private System.String __BillToContactId;
        [EntityField(true)]
        public System.String BillToContactId
        {
            get { return __BillToContactId; }
            set { SetField(ref __BillToContactId, value); }
        }
        private System.String __ShipToContactId;
        [EntityField(true)]
        public System.String ShipToContactId
        {
            get { return __ShipToContactId; }
            set { SetField(ref __ShipToContactId, value); }
        }
        private System.DateTime? __ActivatedDate;
        [EntityField(true)]
        public System.DateTime? ActivatedDate
        {
            get { return __ActivatedDate; }
            set { SetField(ref __ActivatedDate, value); }
        }
        private System.String __ActivatedById;
        [EntityField(true)]
        public System.String ActivatedById
        {
            get { return __ActivatedById; }
            set { SetField(ref __ActivatedById, value); }
        }
        private PickOrderStatusCode __StatusCode;
        [EntityField(false)]
        public PickOrderStatusCode StatusCode
        {
            get { return __StatusCode; }
            set { SetField(ref __StatusCode, value); }
        }
        private System.String __OrderNumber;
        [EntityField(false)]
        public System.String OrderNumber
        {
            get { return __OrderNumber; }
            set { SetField(ref __OrderNumber, value); }
        }
        private System.String __TotalAmount;
        [EntityField(false)]
        public System.String TotalAmount
        {
            get { return __TotalAmount; }
            set { SetField(ref __TotalAmount, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Order, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OrderId")]
        public RelationShip<Order, OrderHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OrderId")]
        public RelationShip<Order, OrderItem> OrderItems
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Order, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Order, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Order, Task> Tasks
        {
            get;set;
        }
    }
    public class OrderHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OrderId;
        [EntityField(false)]
        public System.String OrderId
        {
            get { return __OrderId; }
            set { SetField(ref __OrderId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickOrderHistoryField __Field;
        [EntityField(false)]
        public PickOrderHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class OrderItem : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __OrderId;
        [EntityField(false)]
        public System.String OrderId
        {
            get { return __OrderId; }
            set { SetField(ref __OrderId, value); }
        }
        private System.String __PricebookEntryId;
        [EntityField(false)]
        public System.String PricebookEntryId
        {
            get { return __PricebookEntryId; }
            set { SetField(ref __PricebookEntryId, value); }
        }
        private System.String __OriginalOrderItemId;
        [EntityField(true)]
        public System.String OriginalOrderItemId
        {
            get { return __OriginalOrderItemId; }
            set { SetField(ref __OriginalOrderItemId, value); }
        }
        private System.String __Quantity;
        [EntityField(false)]
        public System.String Quantity
        {
            get { return __Quantity; }
            set { SetField(ref __Quantity, value); }
        }
        private System.String __UnitPrice;
        [EntityField(true)]
        public System.String UnitPrice
        {
            get { return __UnitPrice; }
            set { SetField(ref __UnitPrice, value); }
        }
        private System.String __ListPrice;
        [EntityField(true)]
        public System.String ListPrice
        {
            get { return __ListPrice; }
            set { SetField(ref __ListPrice, value); }
        }
        private System.DateTime? __ServiceDate;
        [EntityField(true)]
        public System.DateTime? ServiceDate
        {
            get { return __ServiceDate; }
            set { SetField(ref __ServiceDate, value); }
        }
        private System.DateTime? __EndDate;
        [EntityField(true)]
        public System.DateTime? EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __OrderItemNumber;
        [EntityField(false)]
        public System.String OrderItemNumber
        {
            get { return __OrderItemNumber; }
            set { SetField(ref __OrderItemNumber, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<OrderItem, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("OriginalOrderItemId")]
        public RelationShip<OrderItem, OrderItem> ChildOrderItems
        {
            get;set;
        }
    }
    public class OrgWideEmailAddress : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Address;
        [EntityField(false)]
        public System.String Address
        {
            get { return __Address; }
            set { SetField(ref __Address, value); }
        }
        private System.String __DisplayName;
        [EntityField(false)]
        public System.String DisplayName
        {
            get { return __DisplayName; }
            set { SetField(ref __DisplayName, value); }
        }
        private System.Boolean __IsAllowAllProfiles;
        [EntityField(false)]
        public System.Boolean IsAllowAllProfiles
        {
            get { return __IsAllowAllProfiles; }
            set { SetField(ref __IsAllowAllProfiles, value); }
        }
    }
    public class Organization : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Division;
        [EntityField(true)]
        public System.String Division
        {
            get { return __Division; }
            set { SetField(ref __Division, value); }
        }
        private System.String __Street;
        [EntityField(true)]
        public System.String Street
        {
            get { return __Street; }
            set { SetField(ref __Street, value); }
        }
        private System.String __City;
        [EntityField(true)]
        public System.String City
        {
            get { return __City; }
            set { SetField(ref __City, value); }
        }
        private System.String __State;
        [EntityField(true)]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.String __PostalCode;
        [EntityField(true)]
        public System.String PostalCode
        {
            get { return __PostalCode; }
            set { SetField(ref __PostalCode, value); }
        }
        private System.String __Country;
        [EntityField(true)]
        public System.String Country
        {
            get { return __Country; }
            set { SetField(ref __Country, value); }
        }
        private System.String __Phone;
        [EntityField(true)]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField(true)]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __PrimaryContact;
        [EntityField(true)]
        public System.String PrimaryContact
        {
            get { return __PrimaryContact; }
            set { SetField(ref __PrimaryContact, value); }
        }
        private PickOrganizationDefaultLocaleSidKey __DefaultLocaleSidKey;
        [EntityField(false)]
        public PickOrganizationDefaultLocaleSidKey DefaultLocaleSidKey
        {
            get { return __DefaultLocaleSidKey; }
            set { SetField(ref __DefaultLocaleSidKey, value); }
        }
        private PickOrganizationLanguageLocaleKey __LanguageLocaleKey;
        [EntityField(false)]
        public PickOrganizationLanguageLocaleKey LanguageLocaleKey
        {
            get { return __LanguageLocaleKey; }
            set { SetField(ref __LanguageLocaleKey, value); }
        }
        private System.Boolean __ReceivesInfoEmails;
        [EntityField(false)]
        public System.Boolean ReceivesInfoEmails
        {
            get { return __ReceivesInfoEmails; }
            set { SetField(ref __ReceivesInfoEmails, value); }
        }
        private System.Boolean __ReceivesAdminInfoEmails;
        [EntityField(false)]
        public System.Boolean ReceivesAdminInfoEmails
        {
            get { return __ReceivesAdminInfoEmails; }
            set { SetField(ref __ReceivesAdminInfoEmails, value); }
        }
        private System.Boolean __PreferencesRequireOpportunityProducts;
        [EntityField(false)]
        public System.Boolean PreferencesRequireOpportunityProducts
        {
            get { return __PreferencesRequireOpportunityProducts; }
            set { SetField(ref __PreferencesRequireOpportunityProducts, value); }
        }
        private System.Boolean __PreferencesTransactionSecurityPolicy;
        [EntityField(false)]
        public System.Boolean PreferencesTransactionSecurityPolicy
        {
            get { return __PreferencesTransactionSecurityPolicy; }
            set { SetField(ref __PreferencesTransactionSecurityPolicy, value); }
        }
        private System.Boolean __PreferencesTerminateOldestSession;
        [EntityField(false)]
        public System.Boolean PreferencesTerminateOldestSession
        {
            get { return __PreferencesTerminateOldestSession; }
            set { SetField(ref __PreferencesTerminateOldestSession, value); }
        }
        private System.String __FiscalYearStartMonth;
        [EntityField(true)]
        public System.String FiscalYearStartMonth
        {
            get { return __FiscalYearStartMonth; }
            set { SetField(ref __FiscalYearStartMonth, value); }
        }
        private System.Boolean __UsesStartDateAsFiscalYearName;
        [EntityField(false)]
        public System.Boolean UsesStartDateAsFiscalYearName
        {
            get { return __UsesStartDateAsFiscalYearName; }
            set { SetField(ref __UsesStartDateAsFiscalYearName, value); }
        }
        private PickOrganizationDefaultAccountAccess __DefaultAccountAccess;
        [EntityField(true)]
        public PickOrganizationDefaultAccountAccess DefaultAccountAccess
        {
            get { return __DefaultAccountAccess; }
            set { SetField(ref __DefaultAccountAccess, value); }
        }
        private PickOrganizationDefaultContactAccess __DefaultContactAccess;
        [EntityField(true)]
        public PickOrganizationDefaultContactAccess DefaultContactAccess
        {
            get { return __DefaultContactAccess; }
            set { SetField(ref __DefaultContactAccess, value); }
        }
        private PickOrganizationDefaultOpportunityAccess __DefaultOpportunityAccess;
        [EntityField(true)]
        public PickOrganizationDefaultOpportunityAccess DefaultOpportunityAccess
        {
            get { return __DefaultOpportunityAccess; }
            set { SetField(ref __DefaultOpportunityAccess, value); }
        }
        private PickOrganizationDefaultLeadAccess __DefaultLeadAccess;
        [EntityField(true)]
        public PickOrganizationDefaultLeadAccess DefaultLeadAccess
        {
            get { return __DefaultLeadAccess; }
            set { SetField(ref __DefaultLeadAccess, value); }
        }
        private PickOrganizationDefaultCaseAccess __DefaultCaseAccess;
        [EntityField(true)]
        public PickOrganizationDefaultCaseAccess DefaultCaseAccess
        {
            get { return __DefaultCaseAccess; }
            set { SetField(ref __DefaultCaseAccess, value); }
        }
        private PickOrganizationDefaultCalendarAccess __DefaultCalendarAccess;
        [EntityField(true)]
        public PickOrganizationDefaultCalendarAccess DefaultCalendarAccess
        {
            get { return __DefaultCalendarAccess; }
            set { SetField(ref __DefaultCalendarAccess, value); }
        }
        private PickOrganizationDefaultPricebookAccess __DefaultPricebookAccess;
        [EntityField(true)]
        public PickOrganizationDefaultPricebookAccess DefaultPricebookAccess
        {
            get { return __DefaultPricebookAccess; }
            set { SetField(ref __DefaultPricebookAccess, value); }
        }
        private PickOrganizationDefaultCampaignAccess __DefaultCampaignAccess;
        [EntityField(true)]
        public PickOrganizationDefaultCampaignAccess DefaultCampaignAccess
        {
            get { return __DefaultCampaignAccess; }
            set { SetField(ref __DefaultCampaignAccess, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __ComplianceBccEmail;
        [EntityField(true)]
        public System.String ComplianceBccEmail
        {
            get { return __ComplianceBccEmail; }
            set { SetField(ref __ComplianceBccEmail, value); }
        }
        private PickOrganizationUiSkin __UiSkin;
        [EntityField(true)]
        public PickOrganizationUiSkin UiSkin
        {
            get { return __UiSkin; }
            set { SetField(ref __UiSkin, value); }
        }
        private System.String __SignupCountryIsoCode;
        [EntityField(true)]
        public System.String SignupCountryIsoCode
        {
            get { return __SignupCountryIsoCode; }
            set { SetField(ref __SignupCountryIsoCode, value); }
        }
        private System.DateTime? __TrialExpirationDate;
        [EntityField(true)]
        public System.DateTime? TrialExpirationDate
        {
            get { return __TrialExpirationDate; }
            set { SetField(ref __TrialExpirationDate, value); }
        }
        private PickOrganizationOrganizationType __OrganizationType;
        [EntityField(true)]
        public PickOrganizationOrganizationType OrganizationType
        {
            get { return __OrganizationType; }
            set { SetField(ref __OrganizationType, value); }
        }
        private System.String __WebToCaseDefaultOrigin;
        [EntityField(true)]
        public System.String WebToCaseDefaultOrigin
        {
            get { return __WebToCaseDefaultOrigin; }
            set { SetField(ref __WebToCaseDefaultOrigin, value); }
        }
        private System.String __MonthlyPageViewsUsed;
        [EntityField(true)]
        public System.String MonthlyPageViewsUsed
        {
            get { return __MonthlyPageViewsUsed; }
            set { SetField(ref __MonthlyPageViewsUsed, value); }
        }
        private System.String __MonthlyPageViewsEntitlement;
        [EntityField(true)]
        public System.String MonthlyPageViewsEntitlement
        {
            get { return __MonthlyPageViewsEntitlement; }
            set { SetField(ref __MonthlyPageViewsEntitlement, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
    }
    public class Partner : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OpportunityId;
        [EntityField(true)]
        public System.String OpportunityId
        {
            get { return __OpportunityId; }
            set { SetField(ref __OpportunityId, value); }
        }
        private System.String __AccountFromId;
        [EntityField(true)]
        public System.String AccountFromId
        {
            get { return __AccountFromId; }
            set { SetField(ref __AccountFromId, value); }
        }
        private System.String __AccountToId;
        [EntityField(false)]
        public System.String AccountToId
        {
            get { return __AccountToId; }
            set { SetField(ref __AccountToId, value); }
        }
        private PickPartnerRole __Role;
        [EntityField(true)]
        public PickPartnerRole Role
        {
            get { return __Role; }
            set { SetField(ref __Role, value); }
        }
        private System.Boolean __IsPrimary;
        [EntityField(false)]
        public System.Boolean IsPrimary
        {
            get { return __IsPrimary; }
            set { SetField(ref __IsPrimary, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ReversePartnerId;
        [EntityField(true)]
        public System.String ReversePartnerId
        {
            get { return __ReversePartnerId; }
            set { SetField(ref __ReversePartnerId, value); }
        }
    }
    public class PartnerRole : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private PickPartnerRoleReverseRole __ReverseRole;
        [EntityField(true)]
        public PickPartnerRoleReverseRole ReverseRole
        {
            get { return __ReverseRole; }
            set { SetField(ref __ReverseRole, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Period : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __FiscalYearSettingsId;
        [EntityField(true)]
        public System.String FiscalYearSettingsId
        {
            get { return __FiscalYearSettingsId; }
            set { SetField(ref __FiscalYearSettingsId, value); }
        }
        private PickPeriodType __Type;
        [EntityField(true)]
        public PickPeriodType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.DateTime __StartDate;
        [EntityField(false)]
        public System.DateTime StartDate
        {
            get { return __StartDate; }
            set { SetField(ref __StartDate, value); }
        }
        private System.DateTime __EndDate;
        [EntityField(false)]
        public System.DateTime EndDate
        {
            get { return __EndDate; }
            set { SetField(ref __EndDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsForecastPeriod;
        [EntityField(false)]
        public System.Boolean IsForecastPeriod
        {
            get { return __IsForecastPeriod; }
            set { SetField(ref __IsForecastPeriod, value); }
        }
        private PickPeriodQuarterLabel __QuarterLabel;
        [EntityField(true)]
        public PickPeriodQuarterLabel QuarterLabel
        {
            get { return __QuarterLabel; }
            set { SetField(ref __QuarterLabel, value); }
        }
        private PickPeriodPeriodLabel __PeriodLabel;
        [EntityField(true)]
        public PickPeriodPeriodLabel PeriodLabel
        {
            get { return __PeriodLabel; }
            set { SetField(ref __PeriodLabel, value); }
        }
        private System.String __Number;
        [EntityField(true)]
        public System.String Number
        {
            get { return __Number; }
            set { SetField(ref __Number, value); }
        }
    }
    public class Pricebook2 : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsStandard;
        [EntityField(false)]
        public System.Boolean IsStandard
        {
            get { return __IsStandard; }
            set { SetField(ref __IsStandard, value); }
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, Contract> Contracts
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, Opportunity> Opportunities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, Pricebook2History> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("Pricebook2Id")]
        public RelationShip<Pricebook2, PricebookEntry> PricebookEntries
        {
            get;set;
        }
    }
    public class Pricebook2History : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField(false)]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickPricebook2HistoryField __Field;
        [EntityField(false)]
        public PickPricebook2HistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class PricebookEntry : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(true)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Pricebook2Id;
        [EntityField(false)]
        public System.String Pricebook2Id
        {
            get { return __Pricebook2Id; }
            set { SetField(ref __Pricebook2Id, value); }
        }
        private System.String __Product2Id;
        [EntityField(false)]
        public System.String Product2Id
        {
            get { return __Product2Id; }
            set { SetField(ref __Product2Id, value); }
        }
        private System.String __UnitPrice;
        [EntityField(false)]
        public System.String UnitPrice
        {
            get { return __UnitPrice; }
            set { SetField(ref __UnitPrice, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.Boolean __UseStandardPrice;
        [EntityField(false)]
        public System.Boolean UseStandardPrice
        {
            get { return __UseStandardPrice; }
            set { SetField(ref __UseStandardPrice, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __ProductCode;
        [EntityField(true)]
        public System.String ProductCode
        {
            get { return __ProductCode; }
            set { SetField(ref __ProductCode, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        [JsonIgnore]
        [ReferencedByField("PricebookEntryId")]
        public RelationShip<PricebookEntry, OpportunityLineItem> OpportunityLineItems
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("PricebookEntryId")]
        public RelationShip<PricebookEntry, OrderItem> OrderItems
        {
            get;set;
        }
    }
    public class ProcessDefinition : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private PickProcessDefinitionType __Type;
        [EntityField(false)]
        public PickProcessDefinitionType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickProcessDefinitionTableEnumOrId __TableEnumOrId;
        [EntityField(false)]
        public PickProcessDefinitionTableEnumOrId TableEnumOrId
        {
            get { return __TableEnumOrId; }
            set { SetField(ref __TableEnumOrId, value); }
        }
        private PickProcessDefinitionLockType __LockType;
        [EntityField(false)]
        public PickProcessDefinitionLockType LockType
        {
            get { return __LockType; }
            set { SetField(ref __LockType, value); }
        }
        private PickProcessDefinitionState __State;
        [EntityField(false)]
        public PickProcessDefinitionState State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessInstance : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ProcessDefinitionId;
        [EntityField(false)]
        public System.String ProcessDefinitionId
        {
            get { return __ProcessDefinitionId; }
            set { SetField(ref __ProcessDefinitionId, value); }
        }
        private System.String __TargetObjectId;
        [EntityField(false)]
        public System.String TargetObjectId
        {
            get { return __TargetObjectId; }
            set { SetField(ref __TargetObjectId, value); }
        }
        private PickProcessInstanceStatus __Status;
        [EntityField(false)]
        public PickProcessInstanceStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ProcessInstanceId")]
        public RelationShip<ProcessInstance, ProcessInstanceHistory> StepsAndWorkitems
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ProcessInstanceId")]
        public RelationShip<ProcessInstance, ProcessInstanceStep> Steps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ProcessInstanceId")]
        public RelationShip<ProcessInstance, ProcessInstanceWorkitem> Workitems
        {
            get;set;
        }
    }
    public class ProcessInstanceHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsPending;
        [EntityField(false)]
        public System.Boolean IsPending
        {
            get { return __IsPending; }
            set { SetField(ref __IsPending, value); }
        }
        private System.String __ProcessInstanceId;
        [EntityField(false)]
        public System.String ProcessInstanceId
        {
            get { return __ProcessInstanceId; }
            set { SetField(ref __ProcessInstanceId, value); }
        }
        private System.String __TargetObjectId;
        [EntityField(true)]
        public System.String TargetObjectId
        {
            get { return __TargetObjectId; }
            set { SetField(ref __TargetObjectId, value); }
        }
        private PickProcessInstanceHistoryStepStatus __StepStatus;
        [EntityField(true)]
        public PickProcessInstanceHistoryStepStatus StepStatus
        {
            get { return __StepStatus; }
            set { SetField(ref __StepStatus, value); }
        }
        private System.String __OriginalActorId;
        [EntityField(false)]
        public System.String OriginalActorId
        {
            get { return __OriginalActorId; }
            set { SetField(ref __OriginalActorId, value); }
        }
        private System.String __ActorId;
        [EntityField(false)]
        public System.String ActorId
        {
            get { return __ActorId; }
            set { SetField(ref __ActorId, value); }
        }
        private System.String __RemindersSent;
        [EntityField(true)]
        public System.String RemindersSent
        {
            get { return __RemindersSent; }
            set { SetField(ref __RemindersSent, value); }
        }
        private System.String __Comments;
        [EntityField(true)]
        public System.String Comments
        {
            get { return __Comments; }
            set { SetField(ref __Comments, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessInstanceStep : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ProcessInstanceId;
        [EntityField(false)]
        public System.String ProcessInstanceId
        {
            get { return __ProcessInstanceId; }
            set { SetField(ref __ProcessInstanceId, value); }
        }
        private PickProcessInstanceStepStepStatus __StepStatus;
        [EntityField(true)]
        public PickProcessInstanceStepStepStatus StepStatus
        {
            get { return __StepStatus; }
            set { SetField(ref __StepStatus, value); }
        }
        private System.String __OriginalActorId;
        [EntityField(false)]
        public System.String OriginalActorId
        {
            get { return __OriginalActorId; }
            set { SetField(ref __OriginalActorId, value); }
        }
        private System.String __ActorId;
        [EntityField(false)]
        public System.String ActorId
        {
            get { return __ActorId; }
            set { SetField(ref __ActorId, value); }
        }
        private System.String __Comments;
        [EntityField(true)]
        public System.String Comments
        {
            get { return __Comments; }
            set { SetField(ref __Comments, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessInstanceWorkitem : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ProcessInstanceId;
        [EntityField(false)]
        public System.String ProcessInstanceId
        {
            get { return __ProcessInstanceId; }
            set { SetField(ref __ProcessInstanceId, value); }
        }
        private System.String __OriginalActorId;
        [EntityField(false)]
        public System.String OriginalActorId
        {
            get { return __OriginalActorId; }
            set { SetField(ref __OriginalActorId, value); }
        }
        private System.String __ActorId;
        [EntityField(false)]
        public System.String ActorId
        {
            get { return __ActorId; }
            set { SetField(ref __ActorId, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class ProcessNode : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __ProcessDefinitionId;
        [EntityField(false)]
        public System.String ProcessDefinitionId
        {
            get { return __ProcessDefinitionId; }
            set { SetField(ref __ProcessDefinitionId, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Product2 : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ProductCode;
        [EntityField(true)]
        public System.String ProductCode
        {
            get { return __ProductCode; }
            set { SetField(ref __ProductCode, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private PickProduct2Family __Family;
        [EntityField(true)]
        public PickProduct2Family Family
        {
            get { return __Family; }
            set { SetField(ref __Family, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("Product2Id")]
        public RelationShip<Product2, Asset> Assets
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, Note> Notes
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, NoteAndAttachment> NotesAndAttachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("Product2Id")]
        public RelationShip<Product2, PricebookEntry> PricebookEntries
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Product2, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Product2, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Product2, Product2Feed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Product2, Task> Tasks
        {
            get;set;
        }
    }
    public class Product2Feed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickProduct2FeedType __Type;
        [EntityField(true)]
        public PickProduct2FeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<Product2Feed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<Product2Feed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class Profile : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __PermissionsEmailSingle;
        [EntityField(false)]
        public System.Boolean PermissionsEmailSingle
        {
            get { return __PermissionsEmailSingle; }
            set { SetField(ref __PermissionsEmailSingle, value); }
        }
        private System.Boolean __PermissionsEmailMass;
        [EntityField(false)]
        public System.Boolean PermissionsEmailMass
        {
            get { return __PermissionsEmailMass; }
            set { SetField(ref __PermissionsEmailMass, value); }
        }
        private System.Boolean __PermissionsEditTask;
        [EntityField(false)]
        public System.Boolean PermissionsEditTask
        {
            get { return __PermissionsEditTask; }
            set { SetField(ref __PermissionsEditTask, value); }
        }
        private System.Boolean __PermissionsEditEvent;
        [EntityField(false)]
        public System.Boolean PermissionsEditEvent
        {
            get { return __PermissionsEditEvent; }
            set { SetField(ref __PermissionsEditEvent, value); }
        }
        private System.Boolean __PermissionsExportReport;
        [EntityField(false)]
        public System.Boolean PermissionsExportReport
        {
            get { return __PermissionsExportReport; }
            set { SetField(ref __PermissionsExportReport, value); }
        }
        private System.Boolean __PermissionsImportPersonal;
        [EntityField(false)]
        public System.Boolean PermissionsImportPersonal
        {
            get { return __PermissionsImportPersonal; }
            set { SetField(ref __PermissionsImportPersonal, value); }
        }
        private System.Boolean __PermissionsManageUsers;
        [EntityField(false)]
        public System.Boolean PermissionsManageUsers
        {
            get { return __PermissionsManageUsers; }
            set { SetField(ref __PermissionsManageUsers, value); }
        }
        private System.Boolean __PermissionsEditPublicTemplates;
        [EntityField(false)]
        public System.Boolean PermissionsEditPublicTemplates
        {
            get { return __PermissionsEditPublicTemplates; }
            set { SetField(ref __PermissionsEditPublicTemplates, value); }
        }
        private System.Boolean __PermissionsModifyAllData;
        [EntityField(false)]
        public System.Boolean PermissionsModifyAllData
        {
            get { return __PermissionsModifyAllData; }
            set { SetField(ref __PermissionsModifyAllData, value); }
        }
        private System.Boolean __PermissionsManageCases;
        [EntityField(false)]
        public System.Boolean PermissionsManageCases
        {
            get { return __PermissionsManageCases; }
            set { SetField(ref __PermissionsManageCases, value); }
        }
        private System.Boolean __PermissionsMassInlineEdit;
        [EntityField(false)]
        public System.Boolean PermissionsMassInlineEdit
        {
            get { return __PermissionsMassInlineEdit; }
            set { SetField(ref __PermissionsMassInlineEdit, value); }
        }
        private System.Boolean __PermissionsViewKnowledge;
        [EntityField(false)]
        public System.Boolean PermissionsViewKnowledge
        {
            get { return __PermissionsViewKnowledge; }
            set { SetField(ref __PermissionsViewKnowledge, value); }
        }
        private System.Boolean __PermissionsEditKnowledge;
        [EntityField(false)]
        public System.Boolean PermissionsEditKnowledge
        {
            get { return __PermissionsEditKnowledge; }
            set { SetField(ref __PermissionsEditKnowledge, value); }
        }
        private System.Boolean __PermissionsManageKnowledge;
        [EntityField(false)]
        public System.Boolean PermissionsManageKnowledge
        {
            get { return __PermissionsManageKnowledge; }
            set { SetField(ref __PermissionsManageKnowledge, value); }
        }
        private System.Boolean __PermissionsManageSolutions;
        [EntityField(false)]
        public System.Boolean PermissionsManageSolutions
        {
            get { return __PermissionsManageSolutions; }
            set { SetField(ref __PermissionsManageSolutions, value); }
        }
        private System.Boolean __PermissionsCustomizeApplication;
        [EntityField(false)]
        public System.Boolean PermissionsCustomizeApplication
        {
            get { return __PermissionsCustomizeApplication; }
            set { SetField(ref __PermissionsCustomizeApplication, value); }
        }
        private System.Boolean __PermissionsEditReadonlyFields;
        [EntityField(false)]
        public System.Boolean PermissionsEditReadonlyFields
        {
            get { return __PermissionsEditReadonlyFields; }
            set { SetField(ref __PermissionsEditReadonlyFields, value); }
        }
        private System.Boolean __PermissionsRunReports;
        [EntityField(false)]
        public System.Boolean PermissionsRunReports
        {
            get { return __PermissionsRunReports; }
            set { SetField(ref __PermissionsRunReports, value); }
        }
        private System.Boolean __PermissionsViewSetup;
        [EntityField(false)]
        public System.Boolean PermissionsViewSetup
        {
            get { return __PermissionsViewSetup; }
            set { SetField(ref __PermissionsViewSetup, value); }
        }
        private System.Boolean __PermissionsTransferAnyEntity;
        [EntityField(false)]
        public System.Boolean PermissionsTransferAnyEntity
        {
            get { return __PermissionsTransferAnyEntity; }
            set { SetField(ref __PermissionsTransferAnyEntity, value); }
        }
        private System.Boolean __PermissionsNewReportBuilder;
        [EntityField(false)]
        public System.Boolean PermissionsNewReportBuilder
        {
            get { return __PermissionsNewReportBuilder; }
            set { SetField(ref __PermissionsNewReportBuilder, value); }
        }
        private System.Boolean __PermissionsActivateContract;
        [EntityField(false)]
        public System.Boolean PermissionsActivateContract
        {
            get { return __PermissionsActivateContract; }
            set { SetField(ref __PermissionsActivateContract, value); }
        }
        private System.Boolean __PermissionsActivateOrder;
        [EntityField(false)]
        public System.Boolean PermissionsActivateOrder
        {
            get { return __PermissionsActivateOrder; }
            set { SetField(ref __PermissionsActivateOrder, value); }
        }
        private System.Boolean __PermissionsImportLeads;
        [EntityField(false)]
        public System.Boolean PermissionsImportLeads
        {
            get { return __PermissionsImportLeads; }
            set { SetField(ref __PermissionsImportLeads, value); }
        }
        private System.Boolean __PermissionsManageLeads;
        [EntityField(false)]
        public System.Boolean PermissionsManageLeads
        {
            get { return __PermissionsManageLeads; }
            set { SetField(ref __PermissionsManageLeads, value); }
        }
        private System.Boolean __PermissionsTransferAnyLead;
        [EntityField(false)]
        public System.Boolean PermissionsTransferAnyLead
        {
            get { return __PermissionsTransferAnyLead; }
            set { SetField(ref __PermissionsTransferAnyLead, value); }
        }
        private System.Boolean __PermissionsViewAllData;
        [EntityField(false)]
        public System.Boolean PermissionsViewAllData
        {
            get { return __PermissionsViewAllData; }
            set { SetField(ref __PermissionsViewAllData, value); }
        }
        private System.Boolean __PermissionsEditPublicDocuments;
        [EntityField(false)]
        public System.Boolean PermissionsEditPublicDocuments
        {
            get { return __PermissionsEditPublicDocuments; }
            set { SetField(ref __PermissionsEditPublicDocuments, value); }
        }
        private System.Boolean __PermissionsViewEncryptedData;
        [EntityField(false)]
        public System.Boolean PermissionsViewEncryptedData
        {
            get { return __PermissionsViewEncryptedData; }
            set { SetField(ref __PermissionsViewEncryptedData, value); }
        }
        private System.Boolean __PermissionsEditBrandTemplates;
        [EntityField(false)]
        public System.Boolean PermissionsEditBrandTemplates
        {
            get { return __PermissionsEditBrandTemplates; }
            set { SetField(ref __PermissionsEditBrandTemplates, value); }
        }
        private System.Boolean __PermissionsEditHtmlTemplates;
        [EntityField(false)]
        public System.Boolean PermissionsEditHtmlTemplates
        {
            get { return __PermissionsEditHtmlTemplates; }
            set { SetField(ref __PermissionsEditHtmlTemplates, value); }
        }
        private System.Boolean __PermissionsDeleteActivatedContract;
        [EntityField(false)]
        public System.Boolean PermissionsDeleteActivatedContract
        {
            get { return __PermissionsDeleteActivatedContract; }
            set { SetField(ref __PermissionsDeleteActivatedContract, value); }
        }
        private System.Boolean __PermissionsSendSitRequests;
        [EntityField(false)]
        public System.Boolean PermissionsSendSitRequests
        {
            get { return __PermissionsSendSitRequests; }
            set { SetField(ref __PermissionsSendSitRequests, value); }
        }
        private System.Boolean __PermissionsManageRemoteAccess;
        [EntityField(false)]
        public System.Boolean PermissionsManageRemoteAccess
        {
            get { return __PermissionsManageRemoteAccess; }
            set { SetField(ref __PermissionsManageRemoteAccess, value); }
        }
        private System.Boolean __PermissionsCanUseNewDashboardBuilder;
        [EntityField(false)]
        public System.Boolean PermissionsCanUseNewDashboardBuilder
        {
            get { return __PermissionsCanUseNewDashboardBuilder; }
            set { SetField(ref __PermissionsCanUseNewDashboardBuilder, value); }
        }
        private System.Boolean __PermissionsManageCategories;
        [EntityField(false)]
        public System.Boolean PermissionsManageCategories
        {
            get { return __PermissionsManageCategories; }
            set { SetField(ref __PermissionsManageCategories, value); }
        }
        private System.Boolean __PermissionsConvertLeads;
        [EntityField(false)]
        public System.Boolean PermissionsConvertLeads
        {
            get { return __PermissionsConvertLeads; }
            set { SetField(ref __PermissionsConvertLeads, value); }
        }
        private System.Boolean __PermissionsPasswordNeverExpires;
        [EntityField(false)]
        public System.Boolean PermissionsPasswordNeverExpires
        {
            get { return __PermissionsPasswordNeverExpires; }
            set { SetField(ref __PermissionsPasswordNeverExpires, value); }
        }
        private System.Boolean __PermissionsUseTeamReassignWizards;
        [EntityField(false)]
        public System.Boolean PermissionsUseTeamReassignWizards
        {
            get { return __PermissionsUseTeamReassignWizards; }
            set { SetField(ref __PermissionsUseTeamReassignWizards, value); }
        }
        private System.Boolean __PermissionsEditActivatedOrders;
        [EntityField(false)]
        public System.Boolean PermissionsEditActivatedOrders
        {
            get { return __PermissionsEditActivatedOrders; }
            set { SetField(ref __PermissionsEditActivatedOrders, value); }
        }
        private System.Boolean __PermissionsInstallMultiforce;
        [EntityField(false)]
        public System.Boolean PermissionsInstallMultiforce
        {
            get { return __PermissionsInstallMultiforce; }
            set { SetField(ref __PermissionsInstallMultiforce, value); }
        }
        private System.Boolean __PermissionsPublishMultiforce;
        [EntityField(false)]
        public System.Boolean PermissionsPublishMultiforce
        {
            get { return __PermissionsPublishMultiforce; }
            set { SetField(ref __PermissionsPublishMultiforce, value); }
        }
        private System.Boolean __PermissionsEditOppLineItemUnitPrice;
        [EntityField(false)]
        public System.Boolean PermissionsEditOppLineItemUnitPrice
        {
            get { return __PermissionsEditOppLineItemUnitPrice; }
            set { SetField(ref __PermissionsEditOppLineItemUnitPrice, value); }
        }
        private System.Boolean __PermissionsCreateMultiforce;
        [EntityField(false)]
        public System.Boolean PermissionsCreateMultiforce
        {
            get { return __PermissionsCreateMultiforce; }
            set { SetField(ref __PermissionsCreateMultiforce, value); }
        }
        private System.Boolean __PermissionsBulkApiHardDelete;
        [EntityField(false)]
        public System.Boolean PermissionsBulkApiHardDelete
        {
            get { return __PermissionsBulkApiHardDelete; }
            set { SetField(ref __PermissionsBulkApiHardDelete, value); }
        }
        private System.Boolean __PermissionsSolutionImport;
        [EntityField(false)]
        public System.Boolean PermissionsSolutionImport
        {
            get { return __PermissionsSolutionImport; }
            set { SetField(ref __PermissionsSolutionImport, value); }
        }
        private System.Boolean __PermissionsManageCallCenters;
        [EntityField(false)]
        public System.Boolean PermissionsManageCallCenters
        {
            get { return __PermissionsManageCallCenters; }
            set { SetField(ref __PermissionsManageCallCenters, value); }
        }
        private System.Boolean __PermissionsManageSynonyms;
        [EntityField(false)]
        public System.Boolean PermissionsManageSynonyms
        {
            get { return __PermissionsManageSynonyms; }
            set { SetField(ref __PermissionsManageSynonyms, value); }
        }
        private System.Boolean __PermissionsViewContent;
        [EntityField(false)]
        public System.Boolean PermissionsViewContent
        {
            get { return __PermissionsViewContent; }
            set { SetField(ref __PermissionsViewContent, value); }
        }
        private System.Boolean __PermissionsManageEmailClientConfig;
        [EntityField(false)]
        public System.Boolean PermissionsManageEmailClientConfig
        {
            get { return __PermissionsManageEmailClientConfig; }
            set { SetField(ref __PermissionsManageEmailClientConfig, value); }
        }
        private System.Boolean __PermissionsEnableNotifications;
        [EntityField(false)]
        public System.Boolean PermissionsEnableNotifications
        {
            get { return __PermissionsEnableNotifications; }
            set { SetField(ref __PermissionsEnableNotifications, value); }
        }
        private System.Boolean __PermissionsManageDataIntegrations;
        [EntityField(false)]
        public System.Boolean PermissionsManageDataIntegrations
        {
            get { return __PermissionsManageDataIntegrations; }
            set { SetField(ref __PermissionsManageDataIntegrations, value); }
        }
        private System.Boolean __PermissionsDistributeFromPersWksp;
        [EntityField(false)]
        public System.Boolean PermissionsDistributeFromPersWksp
        {
            get { return __PermissionsDistributeFromPersWksp; }
            set { SetField(ref __PermissionsDistributeFromPersWksp, value); }
        }
        private System.Boolean __PermissionsViewDataCategories;
        [EntityField(false)]
        public System.Boolean PermissionsViewDataCategories
        {
            get { return __PermissionsViewDataCategories; }
            set { SetField(ref __PermissionsViewDataCategories, value); }
        }
        private System.Boolean __PermissionsManageDataCategories;
        [EntityField(false)]
        public System.Boolean PermissionsManageDataCategories
        {
            get { return __PermissionsManageDataCategories; }
            set { SetField(ref __PermissionsManageDataCategories, value); }
        }
        private System.Boolean __PermissionsAuthorApex;
        [EntityField(false)]
        public System.Boolean PermissionsAuthorApex
        {
            get { return __PermissionsAuthorApex; }
            set { SetField(ref __PermissionsAuthorApex, value); }
        }
        private System.Boolean __PermissionsManageMobile;
        [EntityField(false)]
        public System.Boolean PermissionsManageMobile
        {
            get { return __PermissionsManageMobile; }
            set { SetField(ref __PermissionsManageMobile, value); }
        }
        private System.Boolean __PermissionsApiEnabled;
        [EntityField(false)]
        public System.Boolean PermissionsApiEnabled
        {
            get { return __PermissionsApiEnabled; }
            set { SetField(ref __PermissionsApiEnabled, value); }
        }
        private System.Boolean __PermissionsManageCustomReportTypes;
        [EntityField(false)]
        public System.Boolean PermissionsManageCustomReportTypes
        {
            get { return __PermissionsManageCustomReportTypes; }
            set { SetField(ref __PermissionsManageCustomReportTypes, value); }
        }
        private System.Boolean __PermissionsEditCaseComments;
        [EntityField(false)]
        public System.Boolean PermissionsEditCaseComments
        {
            get { return __PermissionsEditCaseComments; }
            set { SetField(ref __PermissionsEditCaseComments, value); }
        }
        private System.Boolean __PermissionsTransferAnyCase;
        [EntityField(false)]
        public System.Boolean PermissionsTransferAnyCase
        {
            get { return __PermissionsTransferAnyCase; }
            set { SetField(ref __PermissionsTransferAnyCase, value); }
        }
        private System.Boolean __PermissionsContentAdministrator;
        [EntityField(false)]
        public System.Boolean PermissionsContentAdministrator
        {
            get { return __PermissionsContentAdministrator; }
            set { SetField(ref __PermissionsContentAdministrator, value); }
        }
        private System.Boolean __PermissionsCreateWorkspaces;
        [EntityField(false)]
        public System.Boolean PermissionsCreateWorkspaces
        {
            get { return __PermissionsCreateWorkspaces; }
            set { SetField(ref __PermissionsCreateWorkspaces, value); }
        }
        private System.Boolean __PermissionsManageContentPermissions;
        [EntityField(false)]
        public System.Boolean PermissionsManageContentPermissions
        {
            get { return __PermissionsManageContentPermissions; }
            set { SetField(ref __PermissionsManageContentPermissions, value); }
        }
        private System.Boolean __PermissionsManageContentProperties;
        [EntityField(false)]
        public System.Boolean PermissionsManageContentProperties
        {
            get { return __PermissionsManageContentProperties; }
            set { SetField(ref __PermissionsManageContentProperties, value); }
        }
        private System.Boolean __PermissionsManageContentTypes;
        [EntityField(false)]
        public System.Boolean PermissionsManageContentTypes
        {
            get { return __PermissionsManageContentTypes; }
            set { SetField(ref __PermissionsManageContentTypes, value); }
        }
        private System.Boolean __PermissionsManageAnalyticSnapshots;
        [EntityField(false)]
        public System.Boolean PermissionsManageAnalyticSnapshots
        {
            get { return __PermissionsManageAnalyticSnapshots; }
            set { SetField(ref __PermissionsManageAnalyticSnapshots, value); }
        }
        private System.Boolean __PermissionsScheduleReports;
        [EntityField(false)]
        public System.Boolean PermissionsScheduleReports
        {
            get { return __PermissionsScheduleReports; }
            set { SetField(ref __PermissionsScheduleReports, value); }
        }
        private System.Boolean __PermissionsManageBusinessHourHolidays;
        [EntityField(false)]
        public System.Boolean PermissionsManageBusinessHourHolidays
        {
            get { return __PermissionsManageBusinessHourHolidays; }
            set { SetField(ref __PermissionsManageBusinessHourHolidays, value); }
        }
        private System.Boolean __PermissionsManageDynamicDashboards;
        [EntityField(false)]
        public System.Boolean PermissionsManageDynamicDashboards
        {
            get { return __PermissionsManageDynamicDashboards; }
            set { SetField(ref __PermissionsManageDynamicDashboards, value); }
        }
        private System.Boolean __PermissionsCustomSidebarOnAllPages;
        [EntityField(false)]
        public System.Boolean PermissionsCustomSidebarOnAllPages
        {
            get { return __PermissionsCustomSidebarOnAllPages; }
            set { SetField(ref __PermissionsCustomSidebarOnAllPages, value); }
        }
        private System.Boolean __PermissionsManageInteraction;
        [EntityField(false)]
        public System.Boolean PermissionsManageInteraction
        {
            get { return __PermissionsManageInteraction; }
            set { SetField(ref __PermissionsManageInteraction, value); }
        }
        private System.Boolean __PermissionsViewMyTeamsDashboards;
        [EntityField(false)]
        public System.Boolean PermissionsViewMyTeamsDashboards
        {
            get { return __PermissionsViewMyTeamsDashboards; }
            set { SetField(ref __PermissionsViewMyTeamsDashboards, value); }
        }
        private System.Boolean __PermissionsModerateChatter;
        [EntityField(false)]
        public System.Boolean PermissionsModerateChatter
        {
            get { return __PermissionsModerateChatter; }
            set { SetField(ref __PermissionsModerateChatter, value); }
        }
        private System.Boolean __PermissionsManageNetworks;
        [EntityField(false)]
        public System.Boolean PermissionsManageNetworks
        {
            get { return __PermissionsManageNetworks; }
            set { SetField(ref __PermissionsManageNetworks, value); }
        }
        private System.String __UserLicenseId;
        [EntityField(false)]
        public System.String UserLicenseId
        {
            get { return __UserLicenseId; }
            set { SetField(ref __UserLicenseId, value); }
        }
        private PickProfileUserType __UserType;
        [EntityField(true)]
        public PickProfileUserType UserType
        {
            get { return __UserType; }
            set { SetField(ref __UserType, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ProfileId")]
        public RelationShip<Profile, User> Users
        {
            get;set;
        }
    }
    public class QueueSobject : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __QueueId;
        [EntityField(false)]
        public System.String QueueId
        {
            get { return __QueueId; }
            set { SetField(ref __QueueId, value); }
        }
        private PickQueueSobjectSobjectType __SobjectType;
        [EntityField(false)]
        public PickQueueSobjectSobjectType SobjectType
        {
            get { return __SobjectType; }
            set { SetField(ref __SobjectType, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class RecordType : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __BusinessProcessId;
        [EntityField(true)]
        public System.String BusinessProcessId
        {
            get { return __BusinessProcessId; }
            set { SetField(ref __BusinessProcessId, value); }
        }
        private PickRecordTypeSobjectType __SobjectType;
        [EntityField(false)]
        public PickRecordTypeSobjectType SobjectType
        {
            get { return __SobjectType; }
            set { SetField(ref __SobjectType, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class Report : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __DeveloperName;
        [EntityField(false)]
        public System.String DeveloperName
        {
            get { return __DeveloperName; }
            set { SetField(ref __DeveloperName, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime? __LastRunDate;
        [EntityField(true)]
        public System.DateTime? LastRunDate
        {
            get { return __LastRunDate; }
            set { SetField(ref __LastRunDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Report, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Report, ReportFeed> Feeds
        {
            get;set;
        }
    }
    public class ReportFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickReportFeedType __Type;
        [EntityField(true)]
        public PickReportFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ReportFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<ReportFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class SetupAuditTrail : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Action;
        [EntityField(false)]
        public System.String Action
        {
            get { return __Action; }
            set { SetField(ref __Action, value); }
        }
        private System.String __Section;
        [EntityField(true)]
        public System.String Section
        {
            get { return __Section; }
            set { SetField(ref __Section, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.String __Display;
        [EntityField(true)]
        public System.String Display
        {
            get { return __Display; }
            set { SetField(ref __Display, value); }
        }
    }
    public class Site : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __Subdomain;
        [EntityField(true)]
        public System.String Subdomain
        {
            get { return __Subdomain; }
            set { SetField(ref __Subdomain, value); }
        }
        private System.String __TopLevelDomain;
        [EntityField(true)]
        public System.String TopLevelDomain
        {
            get { return __TopLevelDomain; }
            set { SetField(ref __TopLevelDomain, value); }
        }
        private System.String __UrlPathPrefix;
        [EntityField(true)]
        public System.String UrlPathPrefix
        {
            get { return __UrlPathPrefix; }
            set { SetField(ref __UrlPathPrefix, value); }
        }
        private PickSiteStatus __Status;
        [EntityField(false)]
        public PickSiteStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.String __AdminId;
        [EntityField(false)]
        public System.String AdminId
        {
            get { return __AdminId; }
            set { SetField(ref __AdminId, value); }
        }
        private System.Boolean __OptionsEnableFeeds;
        [EntityField(false)]
        public System.Boolean OptionsEnableFeeds
        {
            get { return __OptionsEnableFeeds; }
            set { SetField(ref __OptionsEnableFeeds, value); }
        }
        private System.Boolean __OptionsAllowHomePage;
        [EntityField(false)]
        public System.Boolean OptionsAllowHomePage
        {
            get { return __OptionsAllowHomePage; }
            set { SetField(ref __OptionsAllowHomePage, value); }
        }
        private System.Boolean __OptionsAllowStandardIdeasPages;
        [EntityField(false)]
        public System.Boolean OptionsAllowStandardIdeasPages
        {
            get { return __OptionsAllowStandardIdeasPages; }
            set { SetField(ref __OptionsAllowStandardIdeasPages, value); }
        }
        private System.Boolean __OptionsAllowStandardSearch;
        [EntityField(false)]
        public System.Boolean OptionsAllowStandardSearch
        {
            get { return __OptionsAllowStandardSearch; }
            set { SetField(ref __OptionsAllowStandardSearch, value); }
        }
        private System.Boolean __OptionsAllowStandardLookups;
        [EntityField(false)]
        public System.Boolean OptionsAllowStandardLookups
        {
            get { return __OptionsAllowStandardLookups; }
            set { SetField(ref __OptionsAllowStandardLookups, value); }
        }
        private System.Boolean __OptionsAllowStandardAnswersPages;
        [EntityField(false)]
        public System.Boolean OptionsAllowStandardAnswersPages
        {
            get { return __OptionsAllowStandardAnswersPages; }
            set { SetField(ref __OptionsAllowStandardAnswersPages, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.String __MasterLabel;
        [EntityField(false)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __AnalyticsTrackingCode;
        [EntityField(true)]
        public System.String AnalyticsTrackingCode
        {
            get { return __AnalyticsTrackingCode; }
            set { SetField(ref __AnalyticsTrackingCode, value); }
        }
        private System.String __DailyBandwidthLimit;
        [EntityField(true)]
        public System.String DailyBandwidthLimit
        {
            get { return __DailyBandwidthLimit; }
            set { SetField(ref __DailyBandwidthLimit, value); }
        }
        private System.String __DailyBandwidthUsed;
        [EntityField(true)]
        public System.String DailyBandwidthUsed
        {
            get { return __DailyBandwidthUsed; }
            set { SetField(ref __DailyBandwidthUsed, value); }
        }
        private System.String __DailyRequestTimeLimit;
        [EntityField(true)]
        public System.String DailyRequestTimeLimit
        {
            get { return __DailyRequestTimeLimit; }
            set { SetField(ref __DailyRequestTimeLimit, value); }
        }
        private System.String __DailyRequestTimeUsed;
        [EntityField(true)]
        public System.String DailyRequestTimeUsed
        {
            get { return __DailyRequestTimeUsed; }
            set { SetField(ref __DailyRequestTimeUsed, value); }
        }
        private System.String __MonthlyPageViewsEntitlement;
        [EntityField(true)]
        public System.String MonthlyPageViewsEntitlement
        {
            get { return __MonthlyPageViewsEntitlement; }
            set { SetField(ref __MonthlyPageViewsEntitlement, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Site, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Site, SiteFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("SiteId")]
        public RelationShip<Site, SiteHistory> Histories
        {
            get;set;
        }
    }
    public class SiteFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickSiteFeedType __Type;
        [EntityField(true)]
        public PickSiteFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SiteFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SiteFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class SiteHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __SiteId;
        [EntityField(false)]
        public System.String SiteId
        {
            get { return __SiteId; }
            set { SetField(ref __SiteId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickSiteHistoryField __Field;
        [EntityField(false)]
        public PickSiteHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class Solution : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __SolutionNumber;
        [EntityField(false)]
        public System.String SolutionNumber
        {
            get { return __SolutionNumber; }
            set { SetField(ref __SolutionNumber, value); }
        }
        private System.String __SolutionName;
        [EntityField(false)]
        public System.String SolutionName
        {
            get { return __SolutionName; }
            set { SetField(ref __SolutionName, value); }
        }
        private System.Boolean __IsPublished;
        [EntityField(false)]
        public System.Boolean IsPublished
        {
            get { return __IsPublished; }
            set { SetField(ref __IsPublished, value); }
        }
        private System.Boolean __IsPublishedInPublicKb;
        [EntityField(false)]
        public System.Boolean IsPublishedInPublicKb
        {
            get { return __IsPublishedInPublicKb; }
            set { SetField(ref __IsPublishedInPublicKb, value); }
        }
        private PickSolutionStatus __Status;
        [EntityField(false)]
        public PickSolutionStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private System.Boolean __IsReviewed;
        [EntityField(false)]
        public System.Boolean IsReviewed
        {
            get { return __IsReviewed; }
            set { SetField(ref __IsReviewed, value); }
        }
        private System.String __SolutionNote;
        [EntityField(true)]
        public System.String SolutionNote
        {
            get { return __SolutionNote; }
            set { SetField(ref __SolutionNote, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __TimesUsed;
        [EntityField(false)]
        public System.String TimesUsed
        {
            get { return __TimesUsed; }
            set { SetField(ref __TimesUsed, value); }
        }
        private System.Boolean __IsHtml;
        [EntityField(false)]
        public System.Boolean IsHtml
        {
            get { return __IsHtml; }
            set { SetField(ref __IsHtml, value); }
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, ActivityHistory> ActivityHistories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("SolutionId")]
        public RelationShip<Solution, CaseSolution> CaseSolutions
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, Event> Events
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, OpenActivity> OpenActivities
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Solution, ProcessInstance> ProcessInstances
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("TargetObjectId")]
        public RelationShip<Solution, ProcessInstanceHistory> ProcessSteps
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, SolutionFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("SolutionId")]
        public RelationShip<Solution, SolutionHistory> Histories
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("WhatId")]
        public RelationShip<Solution, Task> Tasks
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Solution, Vote> Votes
        {
            get;set;
        }
    }
    public class SolutionFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickSolutionFeedType __Type;
        [EntityField(true)]
        public PickSolutionFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SolutionFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<SolutionFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class SolutionHistory : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __SolutionId;
        [EntityField(false)]
        public System.String SolutionId
        {
            get { return __SolutionId; }
            set { SetField(ref __SolutionId, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private PickSolutionHistoryField __Field;
        [EntityField(false)]
        public PickSolutionHistoryField Field
        {
            get { return __Field; }
            set { SetField(ref __Field, value); }
        }
        private System.String __OldValue;
        [EntityField(true)]
        public System.String OldValue
        {
            get { return __OldValue; }
            set { SetField(ref __OldValue, value); }
        }
        private System.String __NewValue;
        [EntityField(true)]
        public System.String NewValue
        {
            get { return __NewValue; }
            set { SetField(ref __NewValue, value); }
        }
    }
    public class SolutionStatus : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsReviewed;
        [EntityField(false)]
        public System.Boolean IsReviewed
        {
            get { return __IsReviewed; }
            set { SetField(ref __IsReviewed, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class StaticResource : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ContentType;
        [EntityField(false)]
        public System.String ContentType
        {
            get { return __ContentType; }
            set { SetField(ref __ContentType, value); }
        }
        private System.String __BodyLength;
        [EntityField(false)]
        public System.String BodyLength
        {
            get { return __BodyLength; }
            set { SetField(ref __BodyLength, value); }
        }
        private System.String __Body;
        [EntityField(true)]
        public System.String Body
        {
            get { return __Body; }
            set { SetField(ref __Body, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private PickStaticResourceCacheControl __CacheControl;
        [EntityField(false)]
        public PickStaticResourceCacheControl CacheControl
        {
            get { return __CacheControl; }
            set { SetField(ref __CacheControl, value); }
        }
    }
    public class Task : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __WhoId;
        [EntityField(true)]
        public System.String WhoId
        {
            get { return __WhoId; }
            set { SetField(ref __WhoId, value); }
        }
        private System.String __WhatId;
        [EntityField(true)]
        public System.String WhatId
        {
            get { return __WhatId; }
            set { SetField(ref __WhatId, value); }
        }
        private System.String __Subject;
        [EntityField(true)]
        public System.String Subject
        {
            get { return __Subject; }
            set { SetField(ref __Subject, value); }
        }
        private System.DateTime? __ActivityDate;
        [EntityField(true)]
        public System.DateTime? ActivityDate
        {
            get { return __ActivityDate; }
            set { SetField(ref __ActivityDate, value); }
        }
        private PickTaskStatus __Status;
        [EntityField(false)]
        public PickTaskStatus Status
        {
            get { return __Status; }
            set { SetField(ref __Status, value); }
        }
        private PickTaskPriority __Priority;
        [EntityField(false)]
        public PickTaskPriority Priority
        {
            get { return __Priority; }
            set { SetField(ref __Priority, value); }
        }
        private System.String __OwnerId;
        [EntityField(false)]
        public System.String OwnerId
        {
            get { return __OwnerId; }
            set { SetField(ref __OwnerId, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.Boolean __IsArchived;
        [EntityField(false)]
        public System.Boolean IsArchived
        {
            get { return __IsArchived; }
            set { SetField(ref __IsArchived, value); }
        }
        private System.String __CallDurationInSeconds;
        [EntityField(true)]
        public System.String CallDurationInSeconds
        {
            get { return __CallDurationInSeconds; }
            set { SetField(ref __CallDurationInSeconds, value); }
        }
        private PickTaskCallType __CallType;
        [EntityField(true)]
        public PickTaskCallType CallType
        {
            get { return __CallType; }
            set { SetField(ref __CallType, value); }
        }
        private System.String __CallDisposition;
        [EntityField(true)]
        public System.String CallDisposition
        {
            get { return __CallDisposition; }
            set { SetField(ref __CallDisposition, value); }
        }
        private System.String __CallObject;
        [EntityField(true)]
        public System.String CallObject
        {
            get { return __CallObject; }
            set { SetField(ref __CallObject, value); }
        }
        private System.DateTime? __ReminderDateTime;
        [EntityField(true)]
        public System.DateTime? ReminderDateTime
        {
            get { return __ReminderDateTime; }
            set { SetField(ref __ReminderDateTime, value); }
        }
        private System.Boolean __IsReminderSet;
        [EntityField(false)]
        public System.Boolean IsReminderSet
        {
            get { return __IsReminderSet; }
            set { SetField(ref __IsReminderSet, value); }
        }
        private System.String __RecurrenceActivityId;
        [EntityField(true)]
        public System.String RecurrenceActivityId
        {
            get { return __RecurrenceActivityId; }
            set { SetField(ref __RecurrenceActivityId, value); }
        }
        private System.Boolean __IsRecurrence;
        [EntityField(false)]
        public System.Boolean IsRecurrence
        {
            get { return __IsRecurrence; }
            set { SetField(ref __IsRecurrence, value); }
        }
        private System.DateTime? __RecurrenceStartDateOnly;
        [EntityField(true)]
        public System.DateTime? RecurrenceStartDateOnly
        {
            get { return __RecurrenceStartDateOnly; }
            set { SetField(ref __RecurrenceStartDateOnly, value); }
        }
        private System.DateTime? __RecurrenceEndDateOnly;
        [EntityField(true)]
        public System.DateTime? RecurrenceEndDateOnly
        {
            get { return __RecurrenceEndDateOnly; }
            set { SetField(ref __RecurrenceEndDateOnly, value); }
        }
        private PickTaskRecurrenceTimeZoneSidKey __RecurrenceTimeZoneSidKey;
        [EntityField(true)]
        public PickTaskRecurrenceTimeZoneSidKey RecurrenceTimeZoneSidKey
        {
            get { return __RecurrenceTimeZoneSidKey; }
            set { SetField(ref __RecurrenceTimeZoneSidKey, value); }
        }
        private PickTaskRecurrenceType __RecurrenceType;
        [EntityField(true)]
        public PickTaskRecurrenceType RecurrenceType
        {
            get { return __RecurrenceType; }
            set { SetField(ref __RecurrenceType, value); }
        }
        private System.String __RecurrenceInterval;
        [EntityField(true)]
        public System.String RecurrenceInterval
        {
            get { return __RecurrenceInterval; }
            set { SetField(ref __RecurrenceInterval, value); }
        }
        private System.String __RecurrenceDayOfWeekMask;
        [EntityField(true)]
        public System.String RecurrenceDayOfWeekMask
        {
            get { return __RecurrenceDayOfWeekMask; }
            set { SetField(ref __RecurrenceDayOfWeekMask, value); }
        }
        private System.String __RecurrenceDayOfMonth;
        [EntityField(true)]
        public System.String RecurrenceDayOfMonth
        {
            get { return __RecurrenceDayOfMonth; }
            set { SetField(ref __RecurrenceDayOfMonth, value); }
        }
        private PickTaskRecurrenceInstance __RecurrenceInstance;
        [EntityField(true)]
        public PickTaskRecurrenceInstance RecurrenceInstance
        {
            get { return __RecurrenceInstance; }
            set { SetField(ref __RecurrenceInstance, value); }
        }
        private PickTaskRecurrenceMonthOfYear __RecurrenceMonthOfYear;
        [EntityField(true)]
        public PickTaskRecurrenceMonthOfYear RecurrenceMonthOfYear
        {
            get { return __RecurrenceMonthOfYear; }
            set { SetField(ref __RecurrenceMonthOfYear, value); }
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Task, Attachment> Attachments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Task, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("RecurrenceActivityId")]
        public RelationShip<Task, Task> RecurringTasks
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<Task, TaskFeed> Feeds
        {
            get;set;
        }
    }
    public class TaskFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickTaskFeedType __Type;
        [EntityField(true)]
        public PickTaskFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<TaskFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<TaskFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class TaskPriority : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsHighPriority;
        [EntityField(false)]
        public System.Boolean IsHighPriority
        {
            get { return __IsHighPriority; }
            set { SetField(ref __IsHighPriority, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class TaskStatus : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __SortOrder;
        [EntityField(true)]
        public System.String SortOrder
        {
            get { return __SortOrder; }
            set { SetField(ref __SortOrder, value); }
        }
        private System.Boolean __IsDefault;
        [EntityField(false)]
        public System.Boolean IsDefault
        {
            get { return __IsDefault; }
            set { SetField(ref __IsDefault, value); }
        }
        private System.Boolean __IsClosed;
        [EntityField(false)]
        public System.Boolean IsClosed
        {
            get { return __IsClosed; }
            set { SetField(ref __IsClosed, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class User : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Username;
        [EntityField(false)]
        public System.String Username
        {
            get { return __Username; }
            set { SetField(ref __Username, value); }
        }
        private System.String __LastName;
        [EntityField(false)]
        public System.String LastName
        {
            get { return __LastName; }
            set { SetField(ref __LastName, value); }
        }
        private System.String __FirstName;
        [EntityField(true)]
        public System.String FirstName
        {
            get { return __FirstName; }
            set { SetField(ref __FirstName, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __CompanyName;
        [EntityField(true)]
        public System.String CompanyName
        {
            get { return __CompanyName; }
            set { SetField(ref __CompanyName, value); }
        }
        private System.String __Division;
        [EntityField(true)]
        public System.String Division
        {
            get { return __Division; }
            set { SetField(ref __Division, value); }
        }
        private System.String __Department;
        [EntityField(true)]
        public System.String Department
        {
            get { return __Department; }
            set { SetField(ref __Department, value); }
        }
        private System.String __Title;
        [EntityField(true)]
        public System.String Title
        {
            get { return __Title; }
            set { SetField(ref __Title, value); }
        }
        private System.String __Street;
        [EntityField(true)]
        public System.String Street
        {
            get { return __Street; }
            set { SetField(ref __Street, value); }
        }
        private System.String __City;
        [EntityField(true)]
        public System.String City
        {
            get { return __City; }
            set { SetField(ref __City, value); }
        }
        private System.String __State;
        [EntityField(true)]
        public System.String State
        {
            get { return __State; }
            set { SetField(ref __State, value); }
        }
        private System.String __PostalCode;
        [EntityField(true)]
        public System.String PostalCode
        {
            get { return __PostalCode; }
            set { SetField(ref __PostalCode, value); }
        }
        private System.String __Country;
        [EntityField(true)]
        public System.String Country
        {
            get { return __Country; }
            set { SetField(ref __Country, value); }
        }
        private System.String __Email;
        [EntityField(false)]
        public System.String Email
        {
            get { return __Email; }
            set { SetField(ref __Email, value); }
        }
        private System.String __Phone;
        [EntityField(true)]
        public System.String Phone
        {
            get { return __Phone; }
            set { SetField(ref __Phone, value); }
        }
        private System.String __Fax;
        [EntityField(true)]
        public System.String Fax
        {
            get { return __Fax; }
            set { SetField(ref __Fax, value); }
        }
        private System.String __MobilePhone;
        [EntityField(true)]
        public System.String MobilePhone
        {
            get { return __MobilePhone; }
            set { SetField(ref __MobilePhone, value); }
        }
        private System.String __Alias;
        [EntityField(false)]
        public System.String Alias
        {
            get { return __Alias; }
            set { SetField(ref __Alias, value); }
        }
        private System.String __CommunityNickname;
        [EntityField(false)]
        public System.String CommunityNickname
        {
            get { return __CommunityNickname; }
            set { SetField(ref __CommunityNickname, value); }
        }
        private System.Boolean __IsActive;
        [EntityField(false)]
        public System.Boolean IsActive
        {
            get { return __IsActive; }
            set { SetField(ref __IsActive, value); }
        }
        private PickUserTimeZoneSidKey __TimeZoneSidKey;
        [EntityField(false)]
        public PickUserTimeZoneSidKey TimeZoneSidKey
        {
            get { return __TimeZoneSidKey; }
            set { SetField(ref __TimeZoneSidKey, value); }
        }
        private System.String __UserRoleId;
        [EntityField(true)]
        public System.String UserRoleId
        {
            get { return __UserRoleId; }
            set { SetField(ref __UserRoleId, value); }
        }
        private PickUserLocaleSidKey __LocaleSidKey;
        [EntityField(false)]
        public PickUserLocaleSidKey LocaleSidKey
        {
            get { return __LocaleSidKey; }
            set { SetField(ref __LocaleSidKey, value); }
        }
        private System.Boolean __ReceivesInfoEmails;
        [EntityField(false)]
        public System.Boolean ReceivesInfoEmails
        {
            get { return __ReceivesInfoEmails; }
            set { SetField(ref __ReceivesInfoEmails, value); }
        }
        private System.Boolean __ReceivesAdminInfoEmails;
        [EntityField(false)]
        public System.Boolean ReceivesAdminInfoEmails
        {
            get { return __ReceivesAdminInfoEmails; }
            set { SetField(ref __ReceivesAdminInfoEmails, value); }
        }
        private PickUserEmailEncodingKey __EmailEncodingKey;
        [EntityField(false)]
        public PickUserEmailEncodingKey EmailEncodingKey
        {
            get { return __EmailEncodingKey; }
            set { SetField(ref __EmailEncodingKey, value); }
        }
        private System.String __ProfileId;
        [EntityField(false)]
        public System.String ProfileId
        {
            get { return __ProfileId; }
            set { SetField(ref __ProfileId, value); }
        }
        private PickUserUserType __UserType;
        [EntityField(true)]
        public PickUserUserType UserType
        {
            get { return __UserType; }
            set { SetField(ref __UserType, value); }
        }
        private PickUserLanguageLocaleKey __LanguageLocaleKey;
        [EntityField(false)]
        public PickUserLanguageLocaleKey LanguageLocaleKey
        {
            get { return __LanguageLocaleKey; }
            set { SetField(ref __LanguageLocaleKey, value); }
        }
        private System.String __EmployeeNumber;
        [EntityField(true)]
        public System.String EmployeeNumber
        {
            get { return __EmployeeNumber; }
            set { SetField(ref __EmployeeNumber, value); }
        }
        private System.String __DelegatedApproverId;
        [EntityField(true)]
        public System.String DelegatedApproverId
        {
            get { return __DelegatedApproverId; }
            set { SetField(ref __DelegatedApproverId, value); }
        }
        private System.String __ManagerId;
        [EntityField(true)]
        public System.String ManagerId
        {
            get { return __ManagerId; }
            set { SetField(ref __ManagerId, value); }
        }
        private System.DateTime? __LastLoginDate;
        [EntityField(true)]
        public System.DateTime? LastLoginDate
        {
            get { return __LastLoginDate; }
            set { SetField(ref __LastLoginDate, value); }
        }
        private System.DateTime? __LastPasswordChangeDate;
        [EntityField(true)]
        public System.DateTime? LastPasswordChangeDate
        {
            get { return __LastPasswordChangeDate; }
            set { SetField(ref __LastPasswordChangeDate, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.DateTime? __OfflineTrialExpirationDate;
        [EntityField(true)]
        public System.DateTime? OfflineTrialExpirationDate
        {
            get { return __OfflineTrialExpirationDate; }
            set { SetField(ref __OfflineTrialExpirationDate, value); }
        }
        private System.DateTime? __OfflinePdaTrialExpirationDate;
        [EntityField(true)]
        public System.DateTime? OfflinePdaTrialExpirationDate
        {
            get { return __OfflinePdaTrialExpirationDate; }
            set { SetField(ref __OfflinePdaTrialExpirationDate, value); }
        }
        private System.Boolean __UserPermissionsMarketingUser;
        [EntityField(false)]
        public System.Boolean UserPermissionsMarketingUser
        {
            get { return __UserPermissionsMarketingUser; }
            set { SetField(ref __UserPermissionsMarketingUser, value); }
        }
        private System.Boolean __UserPermissionsOfflineUser;
        [EntityField(false)]
        public System.Boolean UserPermissionsOfflineUser
        {
            get { return __UserPermissionsOfflineUser; }
            set { SetField(ref __UserPermissionsOfflineUser, value); }
        }
        private System.Boolean __UserPermissionsCallCenterAutoLogin;
        [EntityField(false)]
        public System.Boolean UserPermissionsCallCenterAutoLogin
        {
            get { return __UserPermissionsCallCenterAutoLogin; }
            set { SetField(ref __UserPermissionsCallCenterAutoLogin, value); }
        }
        private System.Boolean __UserPermissionsMobileUser;
        [EntityField(false)]
        public System.Boolean UserPermissionsMobileUser
        {
            get { return __UserPermissionsMobileUser; }
            set { SetField(ref __UserPermissionsMobileUser, value); }
        }
        private System.Boolean __UserPermissionsSFContentUser;
        [EntityField(false)]
        public System.Boolean UserPermissionsSFContentUser
        {
            get { return __UserPermissionsSFContentUser; }
            set { SetField(ref __UserPermissionsSFContentUser, value); }
        }
        private System.Boolean __UserPermissionsKnowledgeUser;
        [EntityField(false)]
        public System.Boolean UserPermissionsKnowledgeUser
        {
            get { return __UserPermissionsKnowledgeUser; }
            set { SetField(ref __UserPermissionsKnowledgeUser, value); }
        }
        private System.Boolean __UserPermissionsInteractionUser;
        [EntityField(false)]
        public System.Boolean UserPermissionsInteractionUser
        {
            get { return __UserPermissionsInteractionUser; }
            set { SetField(ref __UserPermissionsInteractionUser, value); }
        }
        private System.Boolean __UserPermissionsSupportUser;
        [EntityField(false)]
        public System.Boolean UserPermissionsSupportUser
        {
            get { return __UserPermissionsSupportUser; }
            set { SetField(ref __UserPermissionsSupportUser, value); }
        }
        private System.Boolean __ForecastEnabled;
        [EntityField(false)]
        public System.Boolean ForecastEnabled
        {
            get { return __ForecastEnabled; }
            set { SetField(ref __ForecastEnabled, value); }
        }
        private System.Boolean __UserPreferencesActivityRemindersPopup;
        [EntityField(false)]
        public System.Boolean UserPreferencesActivityRemindersPopup
        {
            get { return __UserPreferencesActivityRemindersPopup; }
            set { SetField(ref __UserPreferencesActivityRemindersPopup, value); }
        }
        private System.Boolean __UserPreferencesEventRemindersCheckboxDefault;
        [EntityField(false)]
        public System.Boolean UserPreferencesEventRemindersCheckboxDefault
        {
            get { return __UserPreferencesEventRemindersCheckboxDefault; }
            set { SetField(ref __UserPreferencesEventRemindersCheckboxDefault, value); }
        }
        private System.Boolean __UserPreferencesTaskRemindersCheckboxDefault;
        [EntityField(false)]
        public System.Boolean UserPreferencesTaskRemindersCheckboxDefault
        {
            get { return __UserPreferencesTaskRemindersCheckboxDefault; }
            set { SetField(ref __UserPreferencesTaskRemindersCheckboxDefault, value); }
        }
        private System.Boolean __UserPreferencesReminderSoundOff;
        [EntityField(false)]
        public System.Boolean UserPreferencesReminderSoundOff
        {
            get { return __UserPreferencesReminderSoundOff; }
            set { SetField(ref __UserPreferencesReminderSoundOff, value); }
        }
        private System.Boolean __UserPreferencesDisableAutoSubForFeeds;
        [EntityField(false)]
        public System.Boolean UserPreferencesDisableAutoSubForFeeds
        {
            get { return __UserPreferencesDisableAutoSubForFeeds; }
            set { SetField(ref __UserPreferencesDisableAutoSubForFeeds, value); }
        }
        private System.Boolean __UserPreferencesApexPagesDeveloperMode;
        [EntityField(false)]
        public System.Boolean UserPreferencesApexPagesDeveloperMode
        {
            get { return __UserPreferencesApexPagesDeveloperMode; }
            set { SetField(ref __UserPreferencesApexPagesDeveloperMode, value); }
        }
        private System.Boolean __UserPreferencesHideCSNGetChatterMobileTask;
        [EntityField(false)]
        public System.Boolean UserPreferencesHideCSNGetChatterMobileTask
        {
            get { return __UserPreferencesHideCSNGetChatterMobileTask; }
            set { SetField(ref __UserPreferencesHideCSNGetChatterMobileTask, value); }
        }
        private System.Boolean __UserPreferencesHideCSNDesktopTask;
        [EntityField(false)]
        public System.Boolean UserPreferencesHideCSNDesktopTask
        {
            get { return __UserPreferencesHideCSNDesktopTask; }
            set { SetField(ref __UserPreferencesHideCSNDesktopTask, value); }
        }
        private System.Boolean __UserPreferencesSortFeedByComment;
        [EntityField(false)]
        public System.Boolean UserPreferencesSortFeedByComment
        {
            get { return __UserPreferencesSortFeedByComment; }
            set { SetField(ref __UserPreferencesSortFeedByComment, value); }
        }
        private System.Boolean __UserPreferencesOptOutOfTouch;
        [EntityField(false)]
        public System.Boolean UserPreferencesOptOutOfTouch
        {
            get { return __UserPreferencesOptOutOfTouch; }
            set { SetField(ref __UserPreferencesOptOutOfTouch, value); }
        }
        private System.Boolean __UserPreferencesLightningExperiencePreferred;
        [EntityField(false)]
        public System.Boolean UserPreferencesLightningExperiencePreferred
        {
            get { return __UserPreferencesLightningExperiencePreferred; }
            set { SetField(ref __UserPreferencesLightningExperiencePreferred, value); }
        }
        private System.String __ContactId;
        [EntityField(true)]
        public System.String ContactId
        {
            get { return __ContactId; }
            set { SetField(ref __ContactId, value); }
        }
        private System.String __AccountId;
        [EntityField(true)]
        public System.String AccountId
        {
            get { return __AccountId; }
            set { SetField(ref __AccountId, value); }
        }
        private System.String __CallCenterId;
        [EntityField(true)]
        public System.String CallCenterId
        {
            get { return __CallCenterId; }
            set { SetField(ref __CallCenterId, value); }
        }
        private System.String __Extension;
        [EntityField(true)]
        public System.String Extension
        {
            get { return __Extension; }
            set { SetField(ref __Extension, value); }
        }
        private System.String __FederationIdentifier;
        [EntityField(true)]
        public System.String FederationIdentifier
        {
            get { return __FederationIdentifier; }
            set { SetField(ref __FederationIdentifier, value); }
        }
        private System.String __AboutMe;
        [EntityField(true)]
        public System.String AboutMe
        {
            get { return __AboutMe; }
            set { SetField(ref __AboutMe, value); }
        }
        private System.String __CurrentStatus;
        [EntityField(true)]
        public System.String CurrentStatus
        {
            get { return __CurrentStatus; }
            set { SetField(ref __CurrentStatus, value); }
        }
        private System.String __FullPhotoUrl;
        [EntityField(true)]
        public System.String FullPhotoUrl
        {
            get { return __FullPhotoUrl; }
            set { SetField(ref __FullPhotoUrl, value); }
        }
        private System.String __SmallPhotoUrl;
        [EntityField(true)]
        public System.String SmallPhotoUrl
        {
            get { return __SmallPhotoUrl; }
            set { SetField(ref __SmallPhotoUrl, value); }
        }
        private PickUserDigestFrequency __DigestFrequency;
        [EntityField(false)]
        public PickUserDigestFrequency DigestFrequency
        {
            get { return __DigestFrequency; }
            set { SetField(ref __DigestFrequency, value); }
        }
        [JsonIgnore]
        [ReferencedByField("MemberId")]
        public RelationShip<User, CollaborationGroupMember> GroupMemberships
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("CompanySignedId")]
        public RelationShip<User, Contract> ContractsSigned
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<User, EntitySubscription> FeedSubscriptionsForEntity
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("SubscriberId")]
        public RelationShip<User, EntitySubscription> FeedSubscriptions
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("AdminId")]
        public RelationShip<User, Site> UserSites
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("DelegatedApproverId")]
        public RelationShip<User, User> DelegatedUsers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ManagerId")]
        public RelationShip<User, User> ManagedUsers
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("ParentId")]
        public RelationShip<User, UserFeed> Feeds
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("UserId")]
        public RelationShip<User, UserPreference> UserPreferences
        {
            get;set;
        }
    }
    public class UserFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickUserFeedType __Type;
        [EntityField(true)]
        public PickUserFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class UserLicense : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __LicenseDefinitionKey;
        [EntityField(false)]
        public System.String LicenseDefinitionKey
        {
            get { return __LicenseDefinitionKey; }
            set { SetField(ref __LicenseDefinitionKey, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __MonthlyLoginsUsed;
        [EntityField(true)]
        public System.String MonthlyLoginsUsed
        {
            get { return __MonthlyLoginsUsed; }
            set { SetField(ref __MonthlyLoginsUsed, value); }
        }
        private System.String __MonthlyLoginsEntitlement;
        [EntityField(true)]
        public System.String MonthlyLoginsEntitlement
        {
            get { return __MonthlyLoginsEntitlement; }
            set { SetField(ref __MonthlyLoginsEntitlement, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class UserPreference : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __UserId;
        [EntityField(false)]
        public System.String UserId
        {
            get { return __UserId; }
            set { SetField(ref __UserId, value); }
        }
        private PickUserPreferencePreference __Preference;
        [EntityField(false)]
        public PickUserPreferencePreference Preference
        {
            get { return __Preference; }
            set { SetField(ref __Preference, value); }
        }
        private System.String __Value;
        [EntityField(true)]
        public System.String Value
        {
            get { return __Value; }
            set { SetField(ref __Value, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class UserProfileFeed : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private System.String __FeedPostId;
        [EntityField(true)]
        public System.String FeedPostId
        {
            get { return __FeedPostId; }
            set { SetField(ref __FeedPostId, value); }
        }
        private PickUserProfileFeedType __Type;
        [EntityField(true)]
        public PickUserProfileFeedType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserProfileFeed, FeedComment> FeedComments
        {
            get;set;
        }
        [JsonIgnore]
        [ReferencedByField("FeedItemId")]
        public RelationShip<UserProfileFeed, FeedTrackedChange> FeedTrackedChanges
        {
            get;set;
        }
    }
    public class UserRole : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.String __ParentRoleId;
        [EntityField(true)]
        public System.String ParentRoleId
        {
            get { return __ParentRoleId; }
            set { SetField(ref __ParentRoleId, value); }
        }
        private System.String __RollupDescription;
        [EntityField(true)]
        public System.String RollupDescription
        {
            get { return __RollupDescription; }
            set { SetField(ref __RollupDescription, value); }
        }
        private PickUserRoleOpportunityAccessForAccountOwner __OpportunityAccessForAccountOwner;
        [EntityField(false)]
        public PickUserRoleOpportunityAccessForAccountOwner OpportunityAccessForAccountOwner
        {
            get { return __OpportunityAccessForAccountOwner; }
            set { SetField(ref __OpportunityAccessForAccountOwner, value); }
        }
        private PickUserRoleCaseAccessForAccountOwner __CaseAccessForAccountOwner;
        [EntityField(true)]
        public PickUserRoleCaseAccessForAccountOwner CaseAccessForAccountOwner
        {
            get { return __CaseAccessForAccountOwner; }
            set { SetField(ref __CaseAccessForAccountOwner, value); }
        }
        private PickUserRoleContactAccessForAccountOwner __ContactAccessForAccountOwner;
        [EntityField(true)]
        public PickUserRoleContactAccessForAccountOwner ContactAccessForAccountOwner
        {
            get { return __ContactAccessForAccountOwner; }
            set { SetField(ref __ContactAccessForAccountOwner, value); }
        }
        private System.String __ForecastUserId;
        [EntityField(true)]
        public System.String ForecastUserId
        {
            get { return __ForecastUserId; }
            set { SetField(ref __ForecastUserId, value); }
        }
        private System.Boolean __MayForecastManagerShare;
        [EntityField(false)]
        public System.Boolean MayForecastManagerShare
        {
            get { return __MayForecastManagerShare; }
            set { SetField(ref __MayForecastManagerShare, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
        private System.String __PortalAccountId;
        [EntityField(true)]
        public System.String PortalAccountId
        {
            get { return __PortalAccountId; }
            set { SetField(ref __PortalAccountId, value); }
        }
        private PickUserRolePortalType __PortalType;
        [EntityField(true)]
        public PickUserRolePortalType PortalType
        {
            get { return __PortalType; }
            set { SetField(ref __PortalType, value); }
        }
        private System.String __PortalAccountOwnerId;
        [EntityField(true)]
        public System.String PortalAccountOwnerId
        {
            get { return __PortalAccountOwnerId; }
            set { SetField(ref __PortalAccountOwnerId, value); }
        }
        [JsonIgnore]
        [ReferencedByField("UserRoleId")]
        public RelationShip<UserRole, User> Users
        {
            get;set;
        }
    }
    public class Vote : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private System.Boolean __IsDeleted;
        [EntityField(false)]
        public System.Boolean IsDeleted
        {
            get { return __IsDeleted; }
            set { SetField(ref __IsDeleted, value); }
        }
        private System.String __ParentId;
        [EntityField(false)]
        public System.String ParentId
        {
            get { return __ParentId; }
            set { SetField(ref __ParentId, value); }
        }
        private PickVoteType __Type;
        [EntityField(false)]
        public PickVoteType Type
        {
            get { return __Type; }
            set { SetField(ref __Type, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }
    public class WebLink : ISalesforceEntity
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private System.String __Id;
        [EntityField(false)]
        public System.String Id
        {
            get { return __Id; }
            set { SetField(ref __Id, value); }
        }
        private PickWebLinkPageOrSobjectType __PageOrSobjectType;
        [EntityField(false)]
        public PickWebLinkPageOrSobjectType PageOrSobjectType
        {
            get { return __PageOrSobjectType; }
            set { SetField(ref __PageOrSobjectType, value); }
        }
        private System.String __Name;
        [EntityField(false)]
        public System.String Name
        {
            get { return __Name; }
            set { SetField(ref __Name, value); }
        }
        private System.Boolean __IsProtected;
        [EntityField(false)]
        public System.Boolean IsProtected
        {
            get { return __IsProtected; }
            set { SetField(ref __IsProtected, value); }
        }
        private System.String __Url;
        [EntityField(true)]
        public System.String Url
        {
            get { return __Url; }
            set { SetField(ref __Url, value); }
        }
        private PickWebLinkEncodingKey __EncodingKey;
        [EntityField(false)]
        public PickWebLinkEncodingKey EncodingKey
        {
            get { return __EncodingKey; }
            set { SetField(ref __EncodingKey, value); }
        }
        private PickWebLinkLinkType __LinkType;
        [EntityField(false)]
        public PickWebLinkLinkType LinkType
        {
            get { return __LinkType; }
            set { SetField(ref __LinkType, value); }
        }
        private PickWebLinkOpenType __OpenType;
        [EntityField(false)]
        public PickWebLinkOpenType OpenType
        {
            get { return __OpenType; }
            set { SetField(ref __OpenType, value); }
        }
        private System.String __Height;
        [EntityField(true)]
        public System.String Height
        {
            get { return __Height; }
            set { SetField(ref __Height, value); }
        }
        private System.String __Width;
        [EntityField(true)]
        public System.String Width
        {
            get { return __Width; }
            set { SetField(ref __Width, value); }
        }
        private System.Boolean __ShowsLocation;
        [EntityField(false)]
        public System.Boolean ShowsLocation
        {
            get { return __ShowsLocation; }
            set { SetField(ref __ShowsLocation, value); }
        }
        private System.Boolean __HasScrollbars;
        [EntityField(false)]
        public System.Boolean HasScrollbars
        {
            get { return __HasScrollbars; }
            set { SetField(ref __HasScrollbars, value); }
        }
        private System.Boolean __HasToolbar;
        [EntityField(false)]
        public System.Boolean HasToolbar
        {
            get { return __HasToolbar; }
            set { SetField(ref __HasToolbar, value); }
        }
        private System.Boolean __HasMenubar;
        [EntityField(false)]
        public System.Boolean HasMenubar
        {
            get { return __HasMenubar; }
            set { SetField(ref __HasMenubar, value); }
        }
        private System.Boolean __ShowsStatus;
        [EntityField(false)]
        public System.Boolean ShowsStatus
        {
            get { return __ShowsStatus; }
            set { SetField(ref __ShowsStatus, value); }
        }
        private System.Boolean __IsResizable;
        [EntityField(false)]
        public System.Boolean IsResizable
        {
            get { return __IsResizable; }
            set { SetField(ref __IsResizable, value); }
        }
        private PickWebLinkPosition __Position;
        [EntityField(true)]
        public PickWebLinkPosition Position
        {
            get { return __Position; }
            set { SetField(ref __Position, value); }
        }
        private System.String __ScontrolId;
        [EntityField(true)]
        public System.String ScontrolId
        {
            get { return __ScontrolId; }
            set { SetField(ref __ScontrolId, value); }
        }
        private System.String __MasterLabel;
        [EntityField(true)]
        public System.String MasterLabel
        {
            get { return __MasterLabel; }
            set { SetField(ref __MasterLabel, value); }
        }
        private System.String __Description;
        [EntityField(true)]
        public System.String Description
        {
            get { return __Description; }
            set { SetField(ref __Description, value); }
        }
        private PickWebLinkDisplayType __DisplayType;
        [EntityField(false)]
        public PickWebLinkDisplayType DisplayType
        {
            get { return __DisplayType; }
            set { SetField(ref __DisplayType, value); }
        }
        private System.Boolean __RequireRowSelection;
        [EntityField(false)]
        public System.Boolean RequireRowSelection
        {
            get { return __RequireRowSelection; }
            set { SetField(ref __RequireRowSelection, value); }
        }
        private System.String __NamespacePrefix;
        [EntityField(true)]
        public System.String NamespacePrefix
        {
            get { return __NamespacePrefix; }
            set { SetField(ref __NamespacePrefix, value); }
        }
        private System.DateTime __CreatedDate;
        [EntityField(false)]
        public System.DateTime CreatedDate
        {
            get { return __CreatedDate; }
            set { SetField(ref __CreatedDate, value); }
        }
        private System.String __CreatedById;
        [EntityField(false)]
        public System.String CreatedById
        {
            get { return __CreatedById; }
            set { SetField(ref __CreatedById, value); }
        }
        private System.DateTime __LastModifiedDate;
        [EntityField(false)]
        public System.DateTime LastModifiedDate
        {
            get { return __LastModifiedDate; }
            set { SetField(ref __LastModifiedDate, value); }
        }
        private System.String __LastModifiedById;
        [EntityField(false)]
        public System.String LastModifiedById
        {
            get { return __LastModifiedById; }
            set { SetField(ref __LastModifiedById, value); }
        }
        private System.DateTime __SystemModstamp;
        [EntityField(false)]
        public System.DateTime SystemModstamp
        {
            get { return __SystemModstamp; }
            set { SetField(ref __SystemModstamp, value); }
        }
    }

}

