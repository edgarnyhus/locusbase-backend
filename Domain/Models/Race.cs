﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Domain.Interfaces;

namespace Domain.Models
{

   public class Race : EntityBase
    {
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public DateTime? ScheduledAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Waypoint>? Waypoints { get; set; }
        public ICollection<Sign>? Signs { get; set; }
        public Guid? OrganizationId { get; set; }
        public Organization? Organization { get; set; }
        [ForeignKey("TenantId")]
        public Guid? TenantId { get; set; }
    }
}
