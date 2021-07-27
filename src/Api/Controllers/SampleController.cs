using System;
using Contracts.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<GetSampleResponse> Get() =>
            Ok(new GetSampleResponse
            {
                Id = Guid.NewGuid(),
                Name = "Test sample name",
                Value = 42
            });

        [HttpPost("Create")]
        public void Create(CreateSampleRequest createSampleRequest)
        {
            FakeCreatingSample(createSampleRequest);
            FakeNotifyingSampleCreated();
        }

        private void FakeCreatingSample(CreateSampleRequest createSampleRequest)
        {
        }

        private void FakeNotifyingSampleCreated()
        {
        }
    }
}
