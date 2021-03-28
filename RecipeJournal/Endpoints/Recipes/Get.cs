using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using RecipeJournal.Models.Results.Recipes;

namespace RecipeJournal.Endpoints.Recipes
{
    public class Get : BaseAsyncEndpoint
        .WithRequest<int>
        .WithResponse<RecipeResult>
    {
        [HttpGet("/recipe/{id}")]
        [SwaggerOperation(
            Summary = "Gets a recipe",
            Description = "Gets a recipe",
            OperationId = "Recipe.Get",
            Tags = new[] { "RecipeEndpoint" })]
        public override async Task<ActionResult<RecipeResult>> HandleAsync(int id, CancellationToken cancellationToken = default)
        {
            var result = new RecipeResult
            {
                Title = "Rice Pudding"
            };

            return await Task.FromResult(Ok(result));
        }
    }
}
