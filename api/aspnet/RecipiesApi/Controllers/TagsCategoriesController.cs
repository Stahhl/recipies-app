using Microsoft.AspNetCore.Mvc;

namespace RecipiesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TagCategoriesController  : ControllerBase
{
    /// <summary>
    /// Short description
    /// </summary>
    /// <remarks>
    /// Long description   
    /// </remarks>
    [HttpGet("{id}", Name = nameof(GetTagCategory))]
    public async Task<ActionResult> GetTagCategory(string id)
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
    [HttpGet(Name = nameof(GetTagCategorys))]
    public async Task<ActionResult> GetTagCategorys()
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
    [HttpPost(Name = nameof(CreateTagCategory))]
    public async Task<ActionResult> CreateTagCategory()
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
    [HttpPut("{id}", Name = nameof(UpdateTagCategory))]
    public async Task<ActionResult> UpdateTagCategory()
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
    [HttpDelete("{id}", Name = nameof(DeleteTagCategory))]
    public async Task<ActionResult> DeleteTagCategory(string id)
    {
        await Task.Delay(100);

        throw new NotImplementedException();
    }
}