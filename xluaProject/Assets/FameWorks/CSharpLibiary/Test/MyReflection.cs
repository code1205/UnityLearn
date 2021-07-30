// tsl
//20201-7-29
// MyReflection.cs  对于反射的理解

using System;
/*反射（Reflection）的用途
反射（Reflection）有下列用途：

它允许在运行时查看特性（attribute）信息。
它允许审查集合中的各种类型，以及实例化这些类型。
它允许延迟绑定的方法和属性（property）。
它允许在运行时创建新类型，然后使用这些类型执行一些任务。
*/
namespace FrameWorks.Test
{
    //声明一个自定义特性类  派生自System.Attribute
    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute: Attribute
    {
        
    }
    
    public class MyReflection
    {
        
    }
}