using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;

public static class Utility
{
    public static void Redirect_Print(params object[] objs)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var item in objs)
        {
            sb.Append(item.ToString() + "\n");
            Debug.Log("Redirect_Print: " + item.ToString());
        }
    }
}
