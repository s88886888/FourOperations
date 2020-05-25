namespace FourOperations.ClassTheme
{
    /// <summary>
    /// 动态编译 反射解析字符串 转化为 运算符
    /// </summary>
    public class ExpCalc
    {
        //    private static Random rnd = new Random();

        //    private static string RandomString(string CharList = "abcdefghijklmnopqrstuvwxyz", int length = 1)
        //    {
        //        string rndstr = "";
        //        for (int i = 1; i <= length; i++)
        //        {
        //            rndstr += CharList.Substring(rnd.Next(0, CharList.Length), 1);
        //        }
        //        return rndstr;
        //    }

        //    private static string RenderText(string Template, Dictionary<string, string> Params)
        //    {
        //        string result = Template;
        //        foreach (var item in Params)
        //        {
        //            result = result.Replace("@" + item.Key, item.Value);
        //        }
        //        return result;
        //    }

        //    public static double Calc(string exp)
        //    {
        //        var provider = new CSharpCodeProvider();
        //        CompilerParameters cps = new CompilerParameters();
        //        cps.GenerateExecutable = false;
        //        cps.GenerateInMemory = true;
        //        string classSource = "using System;\n" +
        //                            "class @classname\n" +
        //                            "{\n" +
        //                            "\tpublic double Eval { get { return @exp; } } \n" +
        //                            "}";
        //        Dictionary<string, string> renderparams = new Dictionary<string, string>();
        //        string classname = RandomString(length: 10);
        //        renderparams.Add("classname", classname);
        //        renderparams.Add("exp", exp);
        //        classSource = RenderText(classSource, renderparams);
        //        CompilerResults result = provider.CompileAssemblyFromSource(cps, classSource);
        //        Assembly assembly;
        //        try
        //        {
        //            assembly = result.CompiledAssembly;
        //        }
        //        catch
        //        {
        //            throw new Exception("Invaild expression: " + exp);
        //        }
        //        object calcobj = assembly.CreateInstance(classname);
        //        PropertyInfo pi = calcobj.GetType().GetProperty("Eval");
        //        double returnvar = 0.0f;
        //        returnvar = Convert.ToDouble(pi.GetValue(calcobj, null));
        //        return returnvar;
        //    }

        //    public static double Calc(string exp, params Tuple<string, string>[] varlist)
        //    {
        //        double result = 0.00;
        //        Dictionary<string, string> dict = new Dictionary<string, string>();
        //        foreach (var i in varlist.AsEnumerable())
        //        {
        //            dict.Add(i.Item1, i.Item2);
        //        }
        //        exp = RenderText(exp, dict);
        //        result = Calc(exp);
        //        return result;
        //    }
        //}
    }
}

