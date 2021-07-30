using UnityEngine;
using XLua;
using FrameWork.Game.AssetLoadManager;
// LuaOperator.cs
namespace FrameWorks.Game
{
    public class LuaOperator
    {
        private static string filePath ="/Res/scr/LuaApplication.lua";
        private static LuaOperator _instance = null;
        public LuaEnv luaEnv { get; private set; }
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
            if (AssetLoadManager.instance.LoadLuaFile(filePath, out sourceCode) == false)
            {
                return;
            }

            object[] returns = null;
            luaEnv = new LuaEnv();
            try
            {
                returns = luaEnv.DoString(sourceCode, filePath);
            }
            catch (LuaException e)
            {
                System.Console.WriteLine(e);
                throw;
            }
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