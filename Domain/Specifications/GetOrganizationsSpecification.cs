﻿using System;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Specifications
{
    public sealed class GetOrganizationsSpecification : BaseSpecification<Organization>
    {
        public GetOrganizationsSpecification(string id) : base(x => x.Id.Equals(id))
        {

        }

        public GetOrganizationsSpecification(IQueryParameters parameters) : base(parameters)
        {
            if (parameters.multitenancy)
            {
                if (Guid.TryParse(parameters.tenant_id, out Guid tenantId))
                    AddCriteria(c => c.TenantId == tenantId);
            }

            if (!string.IsNullOrEmpty(parameters.organization_id))
            {
                if (Guid.TryParse(parameters.organization_id, out Guid id))
                    AddCriteria(c => c.Id == id);
            }

            if (parameters.page_size > 0)
            {
                var page = parameters.page == 0 ? parameters.page : parameters.page - 1;
                ApplyPaging(page * parameters.page_size, parameters.page_size);
            }
        }
    }
}