using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using RecipeJournal.Models.Commands.Recipes;
using RecipeJournal.Models.Results.Recipes;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeJournal.Endpoints.Recipes
{
    public class Create : BaseAsyncEndpoint
        .WithRequest<CreateRecipeCommand>
        .WithResponse<CreateRecipeResult>
    {
        [HttpPost("/recipe")]
        [SwaggerOperation(
            Summary = "Creates a recipe",
            Description = "Creates a recipe",
            OperationId = "Recipe.Create",
            Tags = new[] { "RecipeEndpoint" })]
        public override async Task<ActionResult<CreateRecipeResult>> HandleAsync([FromBody]CreateRecipeCommand command, CancellationToken cancellationToken = default)
        {
            var result = new CreateRecipeResult
            {
                Id = 1
            };

            return await Task.FromResult(Ok(result));
        }
    }
}
