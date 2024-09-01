using Core.ValidationAttributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Ticket
    {
        public int? TicketId { get; set; }

        [Required]
        public int? ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        [Ticket_EnsureReportDatePresenceAttribute]
        public DateTime? ReportDate { get; set; }

        [Ticket_EnsureDueDatePresenceAttribute]
        [Ticket_EnsureFutureDueDateAttribute]
        [Ticket_EnsureDueDateAfterReportDateAttribute]
        public DateTime? DueDate { get; set; }
        public Project Project { get; set; }

        //When creating a ticket, id due date is entered, it has be inthe future.
        public bool ValidateFutureDueDate()
        {
            if (TicketId.HasValue) return true;
            if (!DueDate.HasValue) return true;

            return (DueDate.Value > DateTime.Now);
        }

        //When owner is assigned, the report date has to be present.
        public bool ValidateReportDatePresence()
        {
            if (string.IsNullOrWhiteSpace(Owner)) return true;

            return ReportDate.HasValue;
        }

        //When owner is assigned, the due date has to be present.
        public bool ValidateDueDatePresence()
        {
            if (string.IsNullOrWhiteSpace(Owner)) return true;

            return DueDate.HasValue;
        }

        //Due date has to be later then ReportDate, when both are present
        public bool ValidateDueDateAfterReportDate()
        {
            if (!DueDate.HasValue || !ReportDate.HasValue) return true;

            return DueDate.Value.Date >= ReportDate.Value.Date;
        }
    }
}
