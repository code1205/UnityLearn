using UnityEngine;
using XLua;
using FrameWork.AssetManager;
// LuaOperator.cs
namespace FrameWork.Game
{
    public class LuaOperator
    {
        private static string filePath ="/Res/scr/LuaApplication.lua";
        private static LuaOperator _instance = null;
        public static LuaOperator instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LuaOperator();
                }
                return _instance;
            }
        }
        public void start()
        {
            
        }
        
        public void init()
        {
            byte[] sourceCode;
            if (AssetLoader.instance.LoadLuaFile(filePath, out sourceCode) == false)
            {
                return;
            }
            LuaEnv luaenv = new LuaEnv();
            object[] returns = luaenv.DoString(sourceCode, filePath);
            LuaTable  mLuaAppTable = returns[0] as LuaTable;
            UnityEngine.Debug.Log(mLuaAppTable.ToString());
        }
        
        public void update()
        {
            
        }

        public void quite()
        {
            
        }

        public void destroy()
        {
            
        }

    }
}