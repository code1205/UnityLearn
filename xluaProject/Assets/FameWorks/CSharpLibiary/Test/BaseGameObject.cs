using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
//BaseGameObject.cs
namespace FrameWorks.Test
{
    public class MyClass
    {
        public string name;
    }

    public interface ImyInterface
    {
        void printName();
    }
    // 结构体
    public struct MyStruct: ImyInterface
    {
        public string name;

        public void printName()
        {
//            print(name);  报错真心不知道为什么？？？？
        }

    }
    
    public class shap
    {
        public virtual string printInfo()
        {
            return "this is shap class";
        }
    }

    public class sunShap1: shap
    {
        public override string printInfo()
        {
            return "this is shap sunShap1";
        }
    }
    
    public class sunShap2: shap
    {
        public override string printInfo()
        {
            return "this is shap sunShap2";
        }
    }
    
    
    public class BaseGameObject : MonoBehaviour
    {
        private enum MyEnum
        {
            name,
            old
        }
        
//        public enum MyEnum1 :int
//        {
//            name = 5,
//            age = 6
//        }

        public void pintInfo()
        {
//            print("this is BaseGameObject !!!");
//            testEnum();
            testVirtualFun();
        }

        public void testEnum()
        {
            int x = (int)MyEnum.name;
            print(x);
        }

        public void testStruct()
        {
            MyStruct s1 = new MyStruct();
            s1.name = "tang";
            MyStruct s2 = s1;
            s2.name = "tangtang";
            print(s1.name);// tang
            s2.printName();
            
            MyClass c1 = new MyClass();
            c1.name = "tang";
            MyClass c2 = c1;
            c2.name = "tangtang";
            print(c1.name);// tangtang
        }
        
        //虚函数动态多态性
        public void testVirtualFun()
        {
            shap s1 = new sunShap1();
            shap s2 = new sunShap2();
            print(s1.printInfo());//sunShap1
            print(s2.printInfo());//sunShap2

        }
    }

}