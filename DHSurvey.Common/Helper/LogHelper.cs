using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading;

namespace DHSurvey.Common.Helper
{
    /// <summary>
    /// 错误日志类
    /// </summary>
    public class LogHelper
    {
        private static object locker = new object();
        /// <summary>
        /// 构造函数
        /// </summary>
        private LogHelper()
        {
        }

        //private static ErrorLog log = new ErrorLog();
        //private static ErrorLog log2 = new ErrorLog();


        static Dictionary<string, LogHelper> m_ErrorList = new Dictionary<string, LogHelper>();

        /// <summary>
        /// 返回日志实例
        /// </summary>
        /// <returns></returns>
        public static LogHelper GetInstance(string logFile = "")
        {

            string errorLogFile = string.Empty;
            string errorLogFolder = string.Empty;
            LogHelper m_ErrorLog = null;

            lock (locker)
            {

                errorLogFolder = ConfigurationManager.AppSettings["LogFolder"];
                if (errorLogFolder != null)
                {
                    if (logFile != string.Empty)
                        errorLogFolder = errorLogFolder + logFile + "\\\\";
                    try
                    {
                        if (!Directory.Exists(errorLogFolder))
                            Directory.CreateDirectory(errorLogFolder);
                    }
                    catch (Exception exp)
                    {
                        Console.Write(exp.ToString());
                    }
                }

                string str = DateTime.Now.ToString("yyyy-MM-dd");
                errorLogFile = errorLogFolder + str + ".txt";

                try
                {
                    if (File.Exists(errorLogFile) == false)
                    {
                        FileStream stream = File.Create(errorLogFile);
                        stream.Close();
                    }

                }
                catch (Exception exp)
                {
                    Console.Write(exp.ToString());
                }



                if (m_ErrorList.ContainsKey(errorLogFolder))
                {
                    m_ErrorLog = m_ErrorList[errorLogFolder];
                    m_ErrorLog.ErrorLogFile = errorLogFile;
                }
                else
                {
                    m_ErrorLog = new LogHelper();
                    m_ErrorLog.LogFolder = errorLogFolder;
                    m_ErrorLog.ErrorLogFile = errorLogFile;
                    m_ErrorList.Add(errorLogFolder, m_ErrorLog);
                }
            }
            return m_ErrorLog;

        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        private void WriteLog(string message, int type = 0)
        {
            lock (errorLogFile)
            {
                StreamWriter writer = null;
                try
                {
                    StringBuilder sb = new StringBuilder(500);

                    if (type == 0)
                    {
                        writer = new StreamWriter(errorLogFile, true, System.Text.Encoding.Default);
                        sb.Append(DateTime.Now.ToString()).Append(DateTime.Now.Ticks.ToString()).Append("\r\n");
                        sb.Append(message).Append("\r\n");
                        sb.Append("---------------------------------------").Append("\r\n");
                    }
                    else
                    {
                        writer = new StreamWriter(errorLogCK, true, System.Text.Encoding.Default);
                        sb.Append(message).Append("\r\n");
                    }


                    writer.Write(sb.ToString());
                }
                catch (IOException ioe)
                {
                    Console.WriteLine(ioe.ToString());
                }
                catch
                { }
                finally
                {
                    try
                    {
                        if (writer != null)
                            writer.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// 线程池写错误日志
        /// </summary>
        /// <param name="message"></param>
        public void Write(string message, int type = 0)
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    WriteLog(message, type);
                }
                catch { }
            });
        }

        private string errorLogFolder = ConfigurationManager.AppSettings["LogFolder"];
        private string errorLogFile;

        //private string errorLogCheck = ConfigCenterManager.LogFolder;
        private string errorLogCK;
        /// <summary>
        /// 错误日志文件夹
        /// </summary>
        public string LogFolder
        {
            get { return errorLogFolder; }
            set { errorLogFolder = value; }
        }
        /// <summary>
        /// 错误日志文件
        /// </summary>
        public string ErrorLogFile
        {
            get { return errorLogFile; }
            set { errorLogFile = value; }
        }

        //public string ErrorLogCheck
        //{
        //    get { return errorLogCheck; }
        //    set { errorLogCheck = value; }
        //}

        public string ErrorLogCK
        {
            get { return errorLogCK; }
            set { errorLogCK = value; }
        }
    }
}
