using UnityEngine;
using System.IO;
using XLua;
// AssetLoader.cs 
namespace FrameWork.AssetManager
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

        public bool LoadLuaFile(ref string filePath, out byte[] sourceCode)
        {
            string abFilePath = Application.dataPath + filePath;
            if (File.Exists(abFilePath))
            {
                sourceCode = File.ReadAllBytes(abFilePath);
                return true;
            }

            sourceCode = null;
            return false;
        }
    }
}