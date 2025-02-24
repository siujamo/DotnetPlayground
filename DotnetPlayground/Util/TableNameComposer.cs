namespace DotnetPlayground.Util;

public class TableNameComposer : IComposer
{
    /// <summary>
    /// 根据给定的前缀、年份和月份生成表名。
    /// </summary>
    /// <param name="prefix">表名前缀</param>
    /// <param name="year">年份</param>
    /// <param name="month">月份</param>
    /// <returns>格式化后的表名，形如 "prefix_year_month"。</returns>
    public string Compose(string prefix, int year, int month)
    {
        return $"{prefix}_{year}_{month:00}";
    }
}