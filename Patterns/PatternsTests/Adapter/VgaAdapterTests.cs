using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Norbit.Crm.Kiselev.Patterns.Adapter.Tests
{
    /// <summary>
    /// Тесты адаптера IVideo -> Monitor.
    /// </summary>
    [TestClass()]
    public class VgaAdapterTests
    {
        /// <summary>
        /// Проверка null-значений в конструкторе.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VgaAdapter_Null_ThrowsArgumentNullException()
        {
            var test = new VgaAdapter(null);
        }

        /// <summary>
        /// Проверка отсутствия исключений во время работы.
        /// </summary>
        [TestMethod()]
        [DataRow("")]
        [DataRow("test")]
        [DataRow(null)]
        public void ShowTest_DifferentText_CorrectWorks(string text)
        {
            var vga = new VgaAdapter(new Monitor());
            vga.Show(text);
        }
    }
}