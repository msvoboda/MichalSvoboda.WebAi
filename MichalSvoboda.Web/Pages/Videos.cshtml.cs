using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MichalSvoboda.Web.Pages;

public class VideosModel : PageModel
{
    private static readonly Dictionary<string, string> VideoContentTypes = new(StringComparer.OrdinalIgnoreCase)
    {
        [".mp4"] = "video/mp4",
        [".webm"] = "video/webm",
        [".mov"] = "video/quicktime",
        [".m4v"] = "video/x-m4v",
        [".ogg"] = "video/ogg"
    };

    private readonly IWebHostEnvironment _environment;

    public VideosModel(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public IReadOnlyList<VideoItem> Videos { get; private set; } = [];

    public void OnGet()
    {
        var videosDirectory = Path.Combine(_environment.WebRootPath, "videos");

        if (!Directory.Exists(videosDirectory))
        {
            Videos = [];
            return;
        }

        Videos = Directory
            .EnumerateFiles(videosDirectory)
            .Select(path => new FileInfo(path))
            .Where(file => VideoContentTypes.ContainsKey(file.Extension))
            .OrderByDescending(file => file.LastWriteTimeUtc)
            .Select((file, index) => new VideoItem(
                file.Name,
                Path.GetFileNameWithoutExtension(file.Name).Replace('-', ' ').Replace('_', ' '),
                $"/videos/{Uri.EscapeDataString(file.Name)}",
                VideoContentTypes[file.Extension],
                FormatSize(file.Length),
                $"video-url-{index}"))
            .ToArray();
    }

    private static string FormatSize(long bytes)
    {
        string[] units = ["B", "KB", "MB", "GB"];
        double size = bytes;
        var unitIndex = 0;

        while (size >= 1024 && unitIndex < units.Length - 1)
        {
            size /= 1024;
            unitIndex++;
        }

        return string.Create(CultureInfo.InvariantCulture, $"{size:0.#} {units[unitIndex]}");
    }

    public sealed record VideoItem(
        string FileName,
        string DisplayName,
        string Url,
        string ContentType,
        string SizeLabel,
        string InputId);
}
