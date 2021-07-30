using System;
using XLua;
using UnityEngine;
using FrameWork.Game.AssetLoadManager;
// 
/**
 * 设计思想 1，使用Lazy(延迟初始化)，减少开销
 * 2,单例模式
 * 功能：
 * lua逻辑层控制UI相关接口调用
 */
 
namespace FrameWorks.Game.UI
{    
    public abstract class Singleton<T> where T : class, new()
    {
        private static Lazy<T> mLazyInstance = new Lazy<T>(false);

        public static T Instance => mLazyInstance.Value;// Lazy对象创建后，并不会立即创建对应的对象，只有在变量的Value属性被首次访问时才会真正的创建，同时会将其缓存到Value中，以便将来访问。

        public Singleton()
        {
            Init(false);
        }

        protected virtual void Init(bool aForced)
        {
        }
    }
    //  ui  管理类型 单例
    public class UIManager: Singleton<UIManager>
    {
        public static UIManager Ins
        {
            get { return Singleton<UIManager>.Instance; }
        }
        
        // lua层打开page
        public int OpenPanel(int pageId)
        {
            return 0;
        }

        public int OpenPanel(string panelPrefabPath)
        {
            return 0;
        }
    }
}