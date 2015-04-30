using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GlobalClass
/// </summary>
public class GlobalClass
{
    private static string username = "";
    public static string GlobalVar
    {
        get { return username; }
        set { username = value; }
    }
    


}