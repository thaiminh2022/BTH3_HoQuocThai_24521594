using System.Text.Json;

namespace Bai09
{
    internal class StorageJSON
    {
        public string FilePath { get; set; }
        public static string DefaultDirectory => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string DefaultFilePath => Path.Combine(DefaultDirectory, "data.json");


        public StorageJSON(string? filePath = null)
        {
            FilePath = filePath ?? DefaultFilePath;
        }

        public void Store(IEnumerable<Student> students)
        {
            var json = JsonSerializer.Serialize(students.ToList());
            File.WriteAllText(FilePath, json);
        }

        public IEnumerable<Student> Load()
        {
            if (!File.Exists(FilePath))
                return [];

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<IEnumerable<Student>>(json) ?? [];
        }
    }
}
