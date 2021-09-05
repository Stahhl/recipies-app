using Microsoft.AspNetCore.Mvc;

namespace RecipiesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipiesController : ControllerBase
{
    /// <summary>
    /// Short description
    /// </summary>
    /// <remarks>
    /// Long description   
    /// </remarks>
    [HttpGet("{id}", Name = nameof(GetRecipe))]
    public async Task<ActionResult> GetRecipe(string id)
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
    [HttpGet(Name = nameof(GetRecipes))]
    public async Task<ActionResult> GetRecipes()
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
    [HttpPost(Name = nameof(CreateRecipe))]
    public async Task<ActionResult> CreateRecipe()
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
    [HttpPut("{id}", Name = nameof(UpdateRecipe))]
    public async Task<ActionResult> UpdateRecipe()
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
    [HttpDelete("{id}", Name = nameof(DeleteRecipe))]
    public async Task<ActionResult> DeleteRecipe(string id)
    {
        await Task.Delay(100);

        throw new NotImplementedException();
    }
}