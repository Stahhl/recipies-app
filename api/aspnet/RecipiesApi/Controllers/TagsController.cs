using Microsoft.AspNetCore.Mvc;

namespace RecipiesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TagsController  : ControllerBase
{
    /// <summary>
    /// Short description
    /// </summary>
    /// <remarks>
    /// Long description   
    /// </remarks>
    [HttpGet("{id}", Name = nameof(GetTag))]
    public async Task<ActionResult> GetTag(string id)
    {
        await Task.Delay(100);

        throw new NotImplementedException();
    }

    /// <summary>
    /// Short description
    /// </summary>
    /// <remarks>
    /// Long description   
    /// </remarks>
    [HttpGet(Name = nameof(GetTags))]
    public async Task<ActionResult> GetTags()
    {
        await Task.Delay(100);

        throw new NotImplementedException();
    }

    /// <summary>
    /// Short description
    /// </summary>
    /// <remarks>
    /// Long description   
    /// </remarks>
    [HttpPost(Name = nameof(CreateTag))]
    public async Task<ActionResult> CreateTag()
    {
        await Task.Delay(100);

        throw new NotImplementedException();
    }

    /// <summary>
    /// Short description
    /// </summary>
    /// <remarks>
    /// Long description   
    /// </remarks>
    [HttpPut("{id}", Name = nameof(UpdateTag))]
    public async Task<ActionResult> UpdateTag()
    {
        await Task.Delay(100);

        throw new NotImplementedException();
    }

    /// <summary>
    /// Short description
    /// </summary>
    /// <remarks>
    /// Long description   
    /// </remarks>
    [HttpDelete("{id}", Name = nameof(DeleteTag))]
    public async Task<ActionResult> DeleteTag(string id)
    {
        await Task.Delay(100);

        throw new NotImplementedException();
    }
}