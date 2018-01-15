using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SedonaServices.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TicketsLostPastDue.Models
{
    public class APITicket
    {
        public int ServiceTicketId { get; set; }
        public string TicketStatus { get; set; }
        public string TicketStatusName { get; set; }
        public int TicketNumber { get; set; }
        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string SiteName { get; set; }
        public int CustomerSiteId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CustomerSiteAddress { get; set; }
        public int CustomerSystemId { get; set; }
        public string AlarmAccount { get; set; }
        public string SystemCode { get; set; }
        public bool MultipleSystems { get; set; }
        public DateTime CreationDate { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedByPhone { get; set; }
        public string RequestedByPhoneExt { get; set; }
        public string AutoNotify { get; set; }
        public string ProblemCode { get; set; }
        public string SubProblemCode { get; set; }
        public DateTime ScheduledFor { get; set; }
        public string ServiceTechCode { get; set; }
        public int EstimatedLength { get; set; }
        public string ResolutionCode { get; set; }
        public bool Billable { get; set; }
        public bool Billed { get; set; }
        public double EquipmentCharge { get; set; }
        public double LaborCharge { get; set; }
        public double OtherCharge { get; set; }
        public double TaxTotal { get; set; }
        public string CustomerComments { get; set; }
        public double RegularHours { get; set; }
        public double OvertimeHours { get; set; }
        public double HolidayHours { get; set; }
        public double TripCharge { get; set; }
        public int InvoiceNumber { get; set; }
        public double RegularRate { get; set; }
        public double OvertimeRate { get; set; }
        public double HolidayRate { get; set; }
        public bool BypassWarranty { get; set; }
        public bool BypassServiceLevel { get; set; }
        public bool IsInspection { get; set; }
        public DateTime ClosedDate { get; set; }
        public object DaysToClosed { get; set; }
        public bool ManualLabor { get; set; }
        public string ServiceCompanyCode { get; set; }
        public int ServiceCompanyID { get; set; }
        public string Priority { get; set; }
        public string CategoryCode { get; set; }
        public int ExpertiseLevel { get; set; }
        public string EnteredBy { get; set; }
        public string InvoiceContact { get; set; }
        public string Signer { get; set; }
        public string ServiceLevelCode { get; set; }
        public string UserCode { get; set; }
        public string PONumber { get; set; }
        public string RouteCode { get; set; }
        public int SubCustomerSiteId { get; set; }
        public int CustomerCCId { get; set; }
        public int CustomerBankId { get; set; }
        public int CustomerBillId { get; set; }
        public int CustomerContactId { get; set; }
        public int InspectionId { get; set; }
        public object ServiceTicketGroupId { get; set; }
        public int ServiceCoordinatorEmployeeId { get; set; }
        public List<Notes> Notes { get; set; }
        public List<object> Parts { get; set; }
        public Customer Customer { get; set; }
        public Site Site { get; set; }
        public System System { get; set; }


    }
    public class Notes
    {
       
              public int NoteId { get; set; }
              public int ServiceTicketNumber { get; set; }
              public string Note { get; set; }
              public int AccessLevel { get; set; }
              public string UserCode { get; set; }
              public bool IsResolution { get; set; }
              public DateTime CreationDate { get; set; }
        
    }
    public class Part
    {
        public int ServiceTicketPartId{ get; set; }
        public int ServiceTicketNumber { get; set; }
        public string PartCode { get; set; }
        public string PartDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public string Location { get; set; }
        public string ServiceTechCode { get; set; }
        public bool  FromStock { get; set; }
        public string SerialNumber { get; set; }
        public string LotNumber { get; set; }
        public string WarehouseCode { get; set; }

    }
    public class System
    {
        public int CustomerSystemId { get; set; }
        public object CSCustomerSystemId { get; set; }
        public int CustomerId { get; set; }
        public object CustomerNumber { get; set; }
        public object CustomerName { get; set; }
        public int CustomerSiteId { get; set; }
        public object SiteAddress { get; set; }
        public object SitePhone { get; set; }
        public object SitePhone2 { get; set; }
        public string SystemCode { get; set; }
        public string PanelTypeCode { get; set; }
        public string PanelLocation { get; set; }
        public string Memo { get; set; }
        public string JobCode { get; set; }
        public string ContractFormCode { get; set; }
        public string ContractNumber { get; set; }
        public string WarrantyCode { get; set; }
        public string ServiceLevelCode { get; set; }
        public int ServiceLevelId { get; set; }
        public string AlarmAccount { get; set; }
        public string AlarmCompanyCode { get; set; }
        public string ServiceCompanyCode { get; set; }
        public int ServiceCompanyId { get; set; }
        public string ContractStartDate { get; set; }
        public int Months { get; set; }
        public int RenewalMonths { get; set; }
        public int InvoiceDescriptionId { get; set; }
        public string CyclePONumber { get; set; }
        public string CyclePOExpire { get; set; }
        public string LastInspectionDate { get; set; }
        public string NextInspectionDate { get; set; }
        public string InspectionNotes { get; set; }
        public string SystemComments { get; set; }
        public string OkToIncrDate { get; set; }
        public string WarrantyDate { get; set; }
        public bool Inactive { get; set; }
        public bool PORequired { get; set; }
        public int RouteCode { get; set; }
        public object TransmissionFormatId { get; set; }
        public object SystemPassword { get; set; }
        public object DuressPassword { get; set; }
        public bool KeysOnFile { get; set; }
        public object KeyNumber { get; set; }
        public object ULGradeId { get; set; }
        public bool HasSounder { get; set; }
        public object KeypadCode { get; set; }
        public object PanelPhone { get; set; }
        public object CSPhone { get; set; }
        public object SecondaryAccount { get; set; }
        public object SecondaryPanelTypeId { get; set; }
        public object SecTransmissionFormatId { get; set; }
        public object EmergencyContacts { get; set; }
        public object RecurLines { get; set; }
        public object SystemCustomer { get; set; }
        public object SystemSite { get; set; }
    }
   // public class Inspections
   // {
   //    public List<SearchInspections> SearchInspections { get; set; }
   //}
    public class CustomerSystemCallList
    {
       public int  CustomerSystemCallListId { get; set; }

       public int CustomerSystemId { get; set; }
        public string Title { get; set; }
       public string ContactName { get; set; }
       public string HomePhone { get; set; }
       public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Extension { get; set; }
       public string EMail { get; set; }
       public string Fax { get; set; }
        public string Pager { get; set; }
        public string Usernumber { get; set; }
        public string Passcode { get; set; }

        public bool VerifyPasscode { get; set; }
        public bool KeyHolder { get; set; }
       
        public bool AllowAlarmResolution { get; set; }


    
        public bool AllowSystemChanges { get; set; }
             public string Instructions { get; set; }
        public int Sequence { get; set; }
         public string Relation { get; set; }

  }
    public class CustomerRecurring
    {
        public int CustomerRecurringId { get; set; }
            public int CustomerId { get; set; }
            public int CustomerBillId { get; set; }
        public int CustomerSiteId { get; set; }
        public int CustomerSystemId { get; set; }
        public string ItemCode { get; set; }
            public string BillCycle { get; set; }
            public decimal MonthlyAmount { get; set; }
        public string CycleStartDate { get; set; }
        public string CycleEndDate { get; set; }
        public string LastCycleDate { get; set; }
        public string NextCycleDate { get; set; }
        public decimal PendingAmt { get; set; }
        public string JobCode { get; set; }
        public bool IsCancelled { get; set; }
        public int CancelledRMRTrackingId { get; set; }
        public string LateRateIncrease { get; set; }
        public string MasterItemCode { get; set; }
        public string MasterAccountCode { get; set; }
        public decimal CycleAmount { get; set; }
        public int BillOnDay { get; set; }
        public string UserDescription { get; set; }
        public string InvoiceItemMemo { get; set; }
        public string BranchCode { get; set; }
        public string RMRReasonCode { get; set; }
        public string RMRTrackingComments { get; set; }
        public string UserCode { get; set; }



    }
 
}