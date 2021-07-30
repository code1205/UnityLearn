using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameWorks.Test
{
    public class Test : BaseGameObject
    {
        // Start is called before the first frame update
        void Start()
        {
            BaseGameObject bgo = gameObject.GetComponent<BaseGameObject>();/// 可以直接获取父类对象组件  很神奇吧
            bgo.pintInfo();
        }
        

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}

