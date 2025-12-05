using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operix.Domain.Entities.Common
{
    public class FileMetaDomainEntity:BaseDomainEntity
    {
        public string Url { get; set; } // signed URL or CDN URL

        public string FileName { get; set; }

        public long SizeBytes { get; set; }

        public string ContentType { get; set; }

        // Generic linking to any entity
        public string EntityType { get; set; } // e.g., "Lead", "TaskItem", "Invoice"

        public Guid? EntityId { get; set; } // Id of the linked entity
    }
}