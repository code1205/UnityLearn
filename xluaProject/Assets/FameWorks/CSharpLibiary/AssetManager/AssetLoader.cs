using UnityEngine;
using System.IO;
using XLua;
// AssetLoader.cs 
namespace FrameWorks.AssetManager
{
    
    public class AssetLoader
    {
        private static AssetLoader _instance = null;
        public static AssetLoader instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AssetLoader();
                }
                return _instance;
            }
        }
        
        //加载lua文件 filePath 绝对路径
        public bool LoadLuaFile(string abFilePath, out byte[] sourceCode)
        {
            if (File.Exists(abFilePath))
            {
                sourceCode = File.ReadAllBytes(abFilePath);
                return true;
            }

            sourceCode = null;
            return false;
        }
        //加载prafab
        
        
    }
}