using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class EngineRunner : MonoBehaviour
{


    private ScriptEngine engine;
    [TextAreaAttribute(minLines:5,maxLines:120)]
    public string MyTextArea;

    void Awake()
    {
        engine = Python.CreateEngine();
        engine.ImportModule("sys");
        engine.ImportModule("clr");

        engine.Runtime.LoadAssembly(Assembly.GetAssembly(typeof(GameObject)));
        engine.Runtime.LoadAssembly(Assembly.GetAssembly(this.GetType()));
        engine.Runtime.LoadAssembly(Assembly.GetAssembly(typeof(Input)));

        RunEngine(engine);

    }


    private void RunEngine(ScriptEngine engine)
    {
        try
        {
            var scope = engine.CreateScope();
            var source = engine.CreateScriptSourceFromString(
                    MyTextArea
                );


            source.Execute(scope);
        }
        catch(Exception e)
        {
            Debug.LogError("ERROR: intental error from python: " + e);
            engine.Runtime.Shutdown();
        }
    }
}
