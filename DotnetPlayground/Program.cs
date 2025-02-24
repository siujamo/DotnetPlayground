// See https://aka.ms/new-console-template for more information

using DotnetPlayground.Util;

var composer = new TableNameComposer();

var sqls = new List<string>();
foreach (var year in Enumerable.Range(2010, 30))
{
    foreach (var month in Enumerable.Range(1, 12))
    {
        var sql = $"select * from {composer.Compose("gec_project_cert_info", year, month)}";
        sqls.Add(sql);
    }
}

Console.WriteLine(string.Join("\nunion all\n", sqls));