using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VResourceVersion
    {
        public int ResourceVersionId { get; set; }
        public int ResourceId { get; set; }
        public int BranchId { get; set; }
        public string Status { get; set; }
        public string Folder { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int ResourceTypeId { get; set; }
        public string RepositoryPath { get; set; }
        public int ProjectVersion { get; set; }
        public int? DataImportSessionId { get; set; }
        public int? ChangelistId { get; set; }
        public int ModuleId { get; set; }
        public int? PreviousResourceVersionId { get; set; }
        public int ModelTypeId { get; set; }
        public int WritingWorkflowStateId { get; set; }
        public int ProductionStateId { get; set; }
        public string ResourceUniqueId { get; set; }
        public string ScopeTag { get; set; }
        public string ScopeSubTag { get; set; }
        public string TypeTag { get; set; }
        public string WritingPointOfContact { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
