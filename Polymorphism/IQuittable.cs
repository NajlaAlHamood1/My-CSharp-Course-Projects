using System;   // 🌐 Standard import for basic .NET features.

namespace QuittableDemoApp  // 📦 Namespace keeps everything organized.
{
    // 🛑 IQuittable interface: promises that any implementing class
    // must provide its own Quit() behavior.
    public interface IQuittable
    {
        // 🚪 Quit(): a method with no return value.
        // 💬 The implementing class decides what "quit" means.
        void Quit();
    }
}
