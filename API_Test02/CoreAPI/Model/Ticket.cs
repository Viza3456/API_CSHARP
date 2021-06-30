using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using CoreAPI.ValidationAttributes;

namespace CoreAPI.Model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string text { get; set; }

        public string demo { get; set; }
        [Required]
        public string dsc { get; set; }
        public string owner { get; set; }
        [Ticket_ValidationFutureDueDate]
        [Ticket_ValidationDueDatePresence]
        [Ticket_ValidationDueDateAfterReportDate]
        public DateTime? DueDate { get; set; }
        [Ticket_ValidationReportDatePresence]
        public DateTime? ReportDate { get; set; }

        public bool ValidationFutureDueDate()
        {
            if (!DueDate.HasValue)
            {
                return true;
            }
            else
            {
                return (DueDate.Value > DateTime.Now);
            }
        }
        public bool ValidationReportDatePresence()
        {
            if (string.IsNullOrWhiteSpace(owner))
            {
                return true;
            }
            else
            {
                return ReportDate.HasValue;
            }
        }
        public bool ValidationDueDatePresence()
        {
            if (string.IsNullOrWhiteSpace(owner))
            {
                return true;
            }
            else
            {
                return DueDate.HasValue;
            }
        }
        public bool ValidationDueDateAfterReportDate()
        {
            if (!DueDate.HasValue || !ReportDate.HasValue)
            {
                return true;
            }
            else
            {
                return DueDate.Value.Date >= ReportDate.Value.Date;
            }
        }
    }
}
