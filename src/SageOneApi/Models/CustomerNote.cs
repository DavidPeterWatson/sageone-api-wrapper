﻿using System;

namespace SageOneApi.Models
{
    public class CustomerNote : BaseModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int NotePriority { get; set; }
        public int NoteType { get; set; }
        public string Subject { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ActionDate { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
        public bool HasAttachments { get; set; }
    }
}