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
    }
}
