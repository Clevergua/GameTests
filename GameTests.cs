using System;
using Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void 创建地牢()
        {
            var dungeon = new Dungeon();
            dungeon.Update(0.1f);
        }
        [TestMethod]
        public void 临时测试()
        {
            var b = new Stone() as Block;
            System.Console.WriteLine(b.GetType());
        }
    }
}
