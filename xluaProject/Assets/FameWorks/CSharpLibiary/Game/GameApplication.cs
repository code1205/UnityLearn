using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.IO;
using XLua;

namespace FrameWorks.Game
{
    public class GameApplication: MonoBehaviour
    {
        // 唤醒事件，游戏一开始运行就执行，只执行一次。
        void Awark()
        {
            
        }
        //启用事件，只执行一次。当脚本组件被启用的时候执行一次
        void OnEnable()
        {
            
        }
        // 开始事件，执行一次。
        void Start()
        {
            Init();
        }
        // 固定更新事件，执行N次，0.02秒执行一次。所有物理组件相关的更新都在这个事件中处理。
        void FixedUpdate()
        {
            
        }
        //更新事件，执行N次，每帧执行一次。
        void Update()
        {
            LuaOperator.instance.update();
        }
        //稍后更新事件，执行N次，在 Update() 事件执行完毕后再执行
        void LateUpdate()
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