using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DocumentValidator;

namespace CpfValidator
{
    public class CpfValidatorHttpTrigger
    {
        private readonly ILogger<CpfValidatorHttpTrigger> _logger;

        public CpfValidatorHttpTrigger(ILogger<CpfValidatorHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("validations_cpf")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req,
            CancellationToken cancellationToken)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request to validate cpf.");

            string? documentValue = await ReadDocumentValueAsync(req, cancellationToken);
            if (string.IsNullOrEmpty(documentValue))
            {
                return new BadRequestResult();
            }
            
            var messageResult = IsValidCpf(documentValue) ? "Cpf válido" : "Cpf inválido";

            return new OkObjectResult(messageResult);
        }

        private async Task<string?> ReadDocumentValueAsync(HttpRequest request, CancellationToken cancellationToken)
        {
            string? result = null;

            try
            {
                var content = await request.ReadFromJsonAsync<DocumentValidation>(cancellationToken);
                result = content.Document;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Formato json inválido");
            }

            return result;
        }

        private static bool IsValidCpf(string document) =>
            CpfValidation.Validate(document);
    }

    public record DocumentValidation(string Document);
}
