using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Web.Profiles
{
    public class JobsProfile: Profile
    {
        public JobsProfile()
        {
            CreateMap<JobBoard.Core.Entities.Job, Models.JobDto>();
        }
    }
}
