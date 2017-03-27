using Microsoft.VisualStudio.TestTools.UnitTesting;
using PpcAzure.Domain.Dto;
using PpcAzure.Domain.Managers;
using System.Collections.Generic;

namespace PpcAzure.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tarea = ClientesManagers.GetAllList();
            tarea.Wait();

            List<ClienteDto> listado = tarea.Result;
            Assert.IsTrue(listado.Count > 0);
        }
    }
}
