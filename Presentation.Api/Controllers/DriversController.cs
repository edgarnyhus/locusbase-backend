﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Api.API.Helpers;
using Application.Helpers;
using Application.Interfaces;
using Domain.Contracts;
using Domain.Queries.Helpers;

namespace Api.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriversController : ControllerBase
    {
        private readonly IDriverService _service;
        private readonly AttachmentCreatedDateResolver _resolver;

        public DriversController(IDriverService service, AttachmentCreatedDateResolver resolver)
        {
            _service = service;
            _resolver = resolver;
        }


        // GET: api/drivers
        [HttpGet]
        [Authorize("get:api")]
        public async Task<IActionResult> GetDrivers([FromQuery] QueryParameters queryParameters)
        {
            _resolver.SetTimeZone(Request.Headers["TimeZone"]);

            var result = await _service.GetDrivers(queryParameters);

            int count = ((IList)result).Count;
            var metadata = new
            {
                count,
                queryParameters.page,
                queryParameters.page_size
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            return Ok(result);
        }


        // GET: api/drivers<id>
        [HttpGet("{id}")]
        [Authorize("get:api")]
        public async Task<IActionResult> GetDriverById(string id)
        {
            _resolver.SetTimeZone(Request.Headers["TimeZone"]);

            var result = await _service.GetDriverById(id);
            return result != null ? (IActionResult) Ok(result) : NotFound();

        }


        // POST: api/drivers
        [HttpPost]
        [Authorize("post:api")]
        public async Task<IActionResult> CreateDriver([FromBody] DriverContract contract)
        {
            try
            {
                _resolver.SetTimeZone(Request.Headers["TimeZone"]);

                var result = await _service.CreateDriver(contract);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                if (ex.InnerException != null)
                    error = ex.InnerException.Message;
                throw new HttpResponseException((int)HttpStatusCode.Conflict, error);
            }
        }


        // PUT: api/drivers
        [HttpPut("{id}")]
        [Authorize("put:api")]
        public async Task<IActionResult> UpdateDriver(string id, DriverContract contract)
        {
            try
            {
                var result = await _service.UpdateDriver(id, contract);
                if (!result)
                    return NotFound();
                return Ok("Driver updated");
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                if (ex.InnerException != null)
                    error = ex.InnerException.Message;
                throw new HttpResponseException((int)HttpStatusCode.Conflict, error);
            }
        }


        // DELETE: api/drivers
        [HttpDelete("{id}")]
        [Authorize("delete:vehicles")]
        public async Task<IActionResult> DeleteDriver(string id)
        {
            try
            {
                _resolver.SetTimeZone(Request.Headers["TimeZone"]);

                var result = await _service.DeleteDriver(id);
                return result ? (IActionResult) Ok("Driver deleted.") : NotFound();
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                if (ex.InnerException != null)
                    error = ex.InnerException.Message;
                throw new HttpResponseException((int)HttpStatusCode.Conflict, error);
            }
        }
    }
}