using UnityEngine;
using System.IO;
using XLua;
using FrameWorks.AssetManager;

// tsl
// AsserLoadManager.cs
//作为gameObject 只创建一次添加到舞台，用来主要管理所有加载到舞台上的资源   加密 解密 

namespace FrameWork.Game.AssetLoadManager
{
    public class AssetLoadManager: MonoBehaviour
    {   
        private static readonly string assetRoot = Application.dataPath;
        public static AssetLoadManager _instance = null;
        public static AssetLoadManager instance
        {
            get
            {
                if (_instance == null)
                {
                    var obj = new GameObject("AssetLoadManager");
                    GameObject.DontDestroyOnLoad(obj);
                    obj.transform.position = Vector3.one * 10000;
                    _instance = obj.AddComponent<AssetLoadManager>();
                }
                return _instance;
            }
        }
        // 加载lua文件 luaFilePath：lua文件asset下相对路径  根据不同的平台 或者  以及该文件是否已经被加载过  整合粗气绝对路径，并对其该行为管理
        // 返回是否加载成功， 若加载成功， out出加载文件的字节流
        public bool LoadLuaFile(string luaFilePath, out byte[] sourceCode)
        {    
            string abLuaFilePath = assetRoot + luaFilePath;
            byte[] results = null;
            if (AssetLoader.instance.LoadLuaFile(abLuaFilePath, out results) == false)
            {
                sourceCode = null;
                return false;
            }

            sourceCode = results;
            return true;
        }
        // 加载prefab
//        public bool LoadPrefab(string prefabPath, out gameObject go)
//        {
//            return true
//        }
        // 同步常见对象
        //异步创建对象
        
        

    }
}