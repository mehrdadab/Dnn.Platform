﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dnn.ExportImport.Components.Dto.Jobs
{
    [JsonObject]
    public class JobItem
    {
        public int JobId { get; set; }
        public int PortalId { get; set; }
        public string User { get; set; }
        public string JobType { get; set; }
        public int Status { get; set; }
        public string JobStatus { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string ExportFile { get; set; }
        public IEnumerable<LogItem> Summary { get; set; }
    }
}