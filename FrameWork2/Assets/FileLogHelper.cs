using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GameFramework;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Tutorial
{
    public class FileLogHelper : DefaultLogHelper
    {
        private readonly string CurrentLogPath = Utility.Path.GetRegularPath(Path.Combine(Application.persistentDataPath, "current.log"));

        private readonly string PreviewLogPath =
            Utility.Path.GetRegularPath(Path.Combine(Application.persistentDataPath, "previous.log"));

        public FileLogHelper()
        {
            Application.logMessageReceived += OnLogMessageReceived;
        }

        private void OnLogMessageReceived(string logMessage, string stackTrace, LogType logType)
        {
            string log = Utility.Text.Format("[{0}][{1}] {2}{4}{3}{4}",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), logType.ToString(), logMessage ?? "<Empty Message>",
                stackTrace ?? "<Empty StackTrace>", Environment.NewLine);
            try
            {
                File.AppendAllText(CurrentLogPath, log, Encoding.UTF8);
                Debug.LogError(CurrentLogPath);
            }
            catch
            {
                
            }
        }

    }
    
}
