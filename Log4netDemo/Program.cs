using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4netDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LoggerHelper.WriteLog("Main1");
                throw new Exception(message: "this is test message");
            }
            catch (Exception ex)
            {
                LoggerHelper.WriteError("",ex);
            }

            try
            {
                LoggerHelper.WriteLog("Main2");
                throw new Exception(message: "this is test message1");
            }
            catch (Exception ex)
            {
                LoggerHelper.WriteError("", ex);
            }
            Console.Read();
        }
    }
}
