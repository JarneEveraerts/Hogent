// 3 manieren:
// 1. @
// 2. \\ -> \
// 3. Linux-way: /
var fp = new FileProcessor(@"C:\Users\evera\OneDrive\Documents\Hogent\Sem 2\Programmeren Gevorderde\Opdrachten\OI", "extract", "straatnamen");
//fp.Unzip("straatnamenInfo.zip");
fp.ReadFiles(new List<string> {
    "straatnamen.csv",
    "Gemeentenaam.csv",
    "StraatnaamID_gemeenteID.csv",
    "ProvincieInfo.csv",
    "ProvincieIDsVlaanderen.csv"
});