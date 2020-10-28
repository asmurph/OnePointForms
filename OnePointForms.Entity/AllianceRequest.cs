using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
    public class AllianceRequest
    {
        [Key]
        public int ID { get; set; }
        public string DeliverToLocation { get; set; }
        public string DeliverTo { get; set; }
        public string DateNeeded { get; set; }
        public string DeliverToPhone { get; set; }
        public string Supplier { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public string ItemPart { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string NaturalExpense { get; set; }
        public string GLDept { get; set; }
        public string Location { get; set; }
        public string Justification { get; set; }
        public string NoteForBuyer { get; set; }
        public string Requestor { get; set; }
        public Nullable<int> DeliverToLocationID { get; set; }
        public Nullable<int> GLDeptId { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<int> NEID { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Databytes { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> LocationID1 { get; set; }
        public Nullable<int> LocationID2 { get; set; }
        public Nullable<int> LocationID3 { get; set; }
        public Nullable<int> LocationID4 { get; set; }
        public Nullable<int> LocationID5 { get; set; }
        public Nullable<int> UnitId1 { get; set; }
        public Nullable<int> UnitId2 { get; set; }
        public Nullable<int> UnitId3 { get; set; }
        public Nullable<int> UnitId4 { get; set; }
        public Nullable<int> UnitId5 { get; set; }
        public Nullable<int> GLDeptId1 { get; set; }
        public Nullable<int> GLDeptId2 { get; set; }
        public Nullable<int> GLDeptId3 { get; set; }
        public Nullable<int> GLDeptId4 { get; set; }
        public Nullable<int> GLDeptId5 { get; set; }
        public Nullable<int> NEID1 { get; set; }
        public Nullable<int> NEID2 { get; set; }
        public Nullable<int> NEID3 { get; set; }
        public Nullable<int> NEID4 { get; set; }
        public Nullable<int> NEID5 { get; set; }
        public string ItemPart1 { get; set; }
        public string ItemPart2 { get; set; }
        public string ItemPart3 { get; set; }
        public string ItemPart4 { get; set; }
        public string ItemPart5 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }
        public Nullable<double> Quantity1 { get; set; }
        public Nullable<double> Quantity2 { get; set; }
        public Nullable<double> Quantity3 { get; set; }
        public Nullable<double> Quantity4 { get; set; }
        public Nullable<double> Quantity5 { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Choice { get; set; }
        public string PONUMBER { get; set; }
        public string RequisitionNumber { get; set; }
        public string BuyersName { get; set; }
        public string BuyersFileName { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Filenames0 { get; set; }
        public string Filenames1 { get; set; }
        public string Filenames2 { get; set; }
        public string Filenames3 { get; set; }
        public string Filenames4 { get; set; }
        public byte[] FileName0Bytes { get; set; }
        public string FileName0ContentType { get; set; }
        public string BuyerNotes { get; set; }
        public Nullable<int> BuyerNameID { get; set; }
        public string BuyerFileContentType { get; set; }
        public byte[] BuyersFileDataBytes { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Approved { get; set; }
        public Nullable<int> ApprovalID { get; set; }
        public string WasBuyerEmailed { get; set; }
        public string Total { get; set; }
        public Nullable<double> PPU { get; set; }
        public Nullable<double> PPU1 { get; set; }
        public Nullable<double> PPU2 { get; set; }
        public Nullable<double> PPU4 { get; set; }
        public Nullable<double> PPU5 { get; set; }
        public Nullable<double> PPU3 { get; set; }
        public string TotalLine { get; set; }
        public string TotalLine1 { get; set; }
        public string TotalLine2 { get; set; }
        public string TotalLine3 { get; set; }
        public string TotalLine4 { get; set; }
        public string TotalLine5 { get; set; }
        public string Filenames1ContentType { get; set; }
        public string Flenames2ContentType { get; set; }
        public string Filenames3ContentType { get; set; }
        public string Filenames4ContentType { get; set; }
        public byte[] Filenames4Bytes { get; set; }
        public byte[] Filenames3Bytes { get; set; }
        public byte[] Filenames2Bytes { get; set; }
        public byte[] Filenames1Bytes { get; set; }
        public string RejectedComments { get; set; }
        public Nullable<int> AcceptedID { get; set; }

        public virtual AcceptStatus AcceptStatus { get; set; }
        public virtual Approval Approval { get; set; }
        public virtual BuyersName BuyersName1 { get; set; }
        public virtual DeliverToLocation DeliverToLocation1 { get; set; }
        public virtual GLDept GLDept1 { get; set; }
        public virtual GLDept GLDept2 { get; set; }
        public virtual GLDept GLDept3 { get; set; }
        public virtual GLDept GLDept4 { get; set; }
        public virtual GLDept GLDept5 { get; set; }
        public virtual GLDept GLDept6 { get; set; }
        public virtual Location Location1 { get; set; }
        public virtual Location Location2 { get; set; }
        public virtual Location Location3 { get; set; }
        public virtual Location Location4 { get; set; }
        public virtual Location Location5 { get; set; }
        public virtual Location Location6 { get; set; }
        public virtual NaturalExpense NaturalExpense1 { get; set; }
        public virtual NaturalExpense NaturalExpense2 { get; set; }
        public virtual NaturalExpense NaturalExpense3 { get; set; }
        public virtual NaturalExpense NaturalExpense4 { get; set; }
        public virtual NaturalExpense NaturalExpense5 { get; set; }
        public virtual Status Status { get; set; }
        public virtual Unit Unit1 { get; set; }
        public virtual Unit Unit2 { get; set; }
        public virtual Unit Unit3 { get; set; }
        public virtual Unit Unit4 { get; set; }
        public virtual Unit Unit5 { get; set; }
        public virtual Unit Unit6 { get; set; }
        public virtual NaturalExpense NaturalExpense6 { get; set; }
    }
}
