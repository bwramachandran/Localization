using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVosessionData
    {
        public int VosessionDataId { get; set; }
        public int VosessionId { get; set; }
        public string Status { get; set; }
        public DateTime SessionDate { get; set; }
        public int? SessionDurationInMinutes { get; set; }
        public string Actor { get; set; }
        public string Studio { get; set; }
        public string InternalNotes { get; set; }
        public string ChecklistNotes { get; set; }
        public string StudioInvoiceNumber { get; set; }
        public DateTime? StudioInvoiceDate { get; set; }
        public bool StudioInvoicePaid { get; set; }
        public string ActorInvoiceNumber { get; set; }
        public DateTime? ActorInvoiceDate { get; set; }
        public bool ActorInvoicePaid { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedBy { get; set; }

        public virtual TVosession Vosession { get; set; }
    }
}
