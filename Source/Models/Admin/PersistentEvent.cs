﻿using System;
using System.Diagnostics;

namespace Exceptionless.Models {
    [DebuggerDisplay("{Id}, {Date}")]
    public class PersistentEvent : Event, IOwnedByOrganizationAndProjectAndStackWithIdentity {
        /// <summary>
        /// Unique id that identifies an event.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The organization that the event belongs to.
        /// </summary>
        public string OrganizationId { get; set; }

        /// <summary>
        /// The project that the event belongs to.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// The stack that the event belongs to.
        /// </summary>
        public string StackId { get; set; }

        /// <summary>
        /// Wether the event resulted in the creation of a new stack.
        /// </summary>
        public bool IsFirstOccurrence { get; set; }

        /// <summary>
        /// Wether the event has been marked as fixed or not.
        /// </summary>
        public bool IsFixed { get; set; }

        /// <summary>
        /// Wether the event has been marked as hidden or not.
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// The date that the event was created in the system.
        /// </summary>
        public DateTime CreatedUtc { get; set; }

        /// <summary>
        /// Used to store primitive data type custom fields for searching the event.
        /// </summary>
        public DataDictionary Fields { get; set; }
    }
}
