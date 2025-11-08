using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("v1/ml")]
public class MLController : ControllerBase
{
    [HttpPost("predict")]
    public IActionResult Predict([FromBody] MLInput input)
    {
        // implementação dummy para demonstrar endpoint ML
        return Ok(new { prediction = input.Value * 2 });
    }

    public class MLInput
    {
        public float Value { get; set; }
    }
}
