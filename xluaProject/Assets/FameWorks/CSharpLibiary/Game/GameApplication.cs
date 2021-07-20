using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.IO;
using XLua;

namespace FrameWork.Game
{
    public class GameApplication: MonoBehaviour
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
        {
            // init lua
            print("------");
            LuaOperator.instance.init();
        }
    }
}