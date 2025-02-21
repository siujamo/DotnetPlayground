// See https://aka.ms/new-console-template for more information

using DotnetPlayground.Util;

var sqls = new List<string>();
for (var year = 2010; year <= 2030; year++)
{
    for (var month = 1; month <= 12; month++)
    {
        var sql = $"select * from {TableNameComposer.Compose("gec_project_cert_info", year, month)}";
        sqls.Add(sql);
    }
}

Console.WriteLine(string.Join("\nunion all\n", sqls));