using AutoMapper;
using JobBoard.Core.Entities;
using JobBoard.Core.Interfaces;
using JobBoard.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Web.Controllers.Api
{
    [ApiController]
    [Route("api/jobs")]
    public class JobsController: ControllerBase
    {
        private IAsyncRepository<Job> _jobRepository;
        private readonly IMapper _mapper;

        public JobsController(IAsyncRepository<Job> jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository ?? throw new ArgumentNullException(nameof(jobRepository));

            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        public async Task<ActionResult<Job>> GetJobs()
        {
            var jobsFromRepo = await _jobRepository.ListAllAsync();

            return Ok(_mapper.Map<IEnumerable<JobDto>>(jobsFromRepo));
        }



    }
}
