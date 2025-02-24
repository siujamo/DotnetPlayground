namespace DotnetPlayground.Util;

public interface IComposer
{
    /// <summary>
    /// 组装信息
    /// </summary>
    /// <param name="prefix">信息前缀</param>
    /// <param name="year">年份</param>
    /// <param name="month">月份</param>
    /// <returns></returns>
    string Compose(string prefix, int year, int month);
}