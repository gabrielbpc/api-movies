using Newtonsoft.Json;
using System.IO;

namespace Api.Movie.Providers
{
    public static class FileProvider
    {
        public static void CreateFileOnTempDirectory<T>(string path, T source) => File.WriteAllText(path, JsonConvert.SerializeObject(source, Formatting.Indented));

        public static string ReadAllText(string path) => File.ReadAllText(path);

        public static bool Exists(string path) => File.Exists(path);

        public static string GetTempPath() => Path.GetTempPath();
    }
}
