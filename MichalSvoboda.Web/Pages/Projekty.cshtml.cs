using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MichalSvoboda.Web.Pages;

public class ProjektyModel : PageModel
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly IWebHostEnvironment _environment;

    public ProjektyModel(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public IReadOnlyList<ProjectItem> Projects { get; private set; } = [];

    public void OnGet()
    {
        var dataPath = Path.Combine(_environment.WebRootPath, "data", "projects.json");

        if (!System.IO.File.Exists(dataPath))
        {
            Projects = [];
            return;
        }

        var json = System.IO.File.ReadAllText(dataPath);
        Projects = JsonSerializer.Deserialize<List<ProjectItem>>(json, JsonOptions) ?? [];
    }

    public sealed record ProjectItem(
        string Name,
        string Description,
        string Platform,
        [property: JsonPropertyName("techStack")] IReadOnlyList<string> TechStack,
        string? Image,
        string? Url,
        string? DownloadUrl);
}
