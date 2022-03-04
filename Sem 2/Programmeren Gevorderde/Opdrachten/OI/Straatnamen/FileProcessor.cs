using System.IO.Compression;
using System.Linq;

public class FileProcessor
{
    #region Properties

    private string _path;
    private string _extractPath;
    private string _resultPath;

    #endregion Properties

    private class ProvincieGemeente
    {
        public string Gemeente { get; set; }
        public string Provincie { get; set; }

        public ProvincieGemeente(string provincie)
        {
            this.Provincie = provincie;
        }
    }

    public FileProcessor(string path, string extractPath, string resultPath)
    {
        this._path = path;
        this._extractPath = extractPath;
        this._resultPath = resultPath;
    }

    public void ReadFiles(List<string> fileNames)
    {
        var provincieIds = new HashSet<int>();
        using (var p = new StreamReader(Path.Combine(_path, _extractPath, fileNames[4])))
        {
            /*
            if (p != null)
            {
                var l = p.ReadLine();
                if (l != null)
                {
                    var ids = l.Trim().Split(";");
                }
            }
            */
            var ids = p?.ReadLine()?.Trim()?.Split(",");
            if (ids != null)
            {
                foreach (var id in ids)
                {
                    provincieIds.Add(Int32.Parse(id));
                }
            }
        }

        Dictionary<int /*gemeenteId */, ProvincieGemeente> gemeenteProvincieLinks = new();
        using (var reader = new StreamReader(Path.Combine(_path, _extractPath, fileNames[3])))
        {
            while (!reader.EndOfStream)
            {
                List<string> lines = new List<string>();
                lines.Add(reader.ReadLine());
                IEnumerable<string> query = lines.Where(value => value.Contains(";nl;"));
                foreach (string value in query)
                {
                    string[] values = value.Split(";");
                    if (provincieIds.Contains(int.Parse(values[1])))
                    {
                        gemeenteProvincieLinks.Add(int.Parse(values[0]), new ProvincieGemeente(values[3]));
                    }
                }
            }
        }

        // G2: gemeentenamen + gemeenteid: gebruik ook de gemeenteProvincieLinks structuur
        using (var reader = new StreamReader(Path.Combine(_path, _extractPath, fileNames[1])))
        {
            while (!reader.EndOfStream)
            {
                List<string> lines = new List<string>();
                lines.Add(reader.ReadLine());
                IEnumerable<string> query = lines.Where(value => value.Contains(";nl;"));
                foreach (string value in query)
                {
                    string[] values = value.Split(";");
                    gemeenteProvincieLinks[int.Parse(values[1])].Gemeente = values[3];
                }
            }
        }

        // G3: lees straatnaamid + gemeenteid
        Dictionary<int /* straatnaamid */, int /* gemeenteid */> straatnaamGemeenteLinks = new();
        using (var reader = new StreamReader(Path.Combine(_path, _extractPath, fileNames[2])))
        {
            while (!reader.EndOfStream)
            {
                string[] values = reader.ReadLine().Split(";");
                straatnaamGemeenteLinks.Add(int.Parse(values[0]), int.Parse(values[1]));
            }
        }
    }

    // G4: lees straatnamen - vul _data
    public void Unzip(string fileName)
    {
        // c:tmp
        // demo.txt
        var fileRef = Path.Combine(_path, fileName);
        if (File.Exists(fileRef))
            ZipFile.ExtractToDirectory(fileRef, Path.Combine(_path, _extractPath));
        else
            throw new Exception("File not found: \"" + fileRef + "\"");
    }
}