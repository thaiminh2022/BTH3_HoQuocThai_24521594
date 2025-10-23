using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bai09
{
    internal class StorageJSON
    {
        public readonly string FilePath;
        public StorageJSON()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "data.json";
            FilePath = Path.Combine(folderPath, fileName);
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
