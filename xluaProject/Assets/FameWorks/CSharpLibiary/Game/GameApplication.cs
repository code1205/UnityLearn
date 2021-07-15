using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class GameApplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    void awark()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //初始化数据------------
    void Init()
    {    //test
        LuaEnv luaenv = new LuaEnv();
        luaenv.DoString("CS.UnityEngine.Debug.Log('hello world')");
        luaenv.Dispose();
    }
}
