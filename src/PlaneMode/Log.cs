﻿namespace PlaneMode
{
    internal static class Log
    {
        // ReSharper disable once MemberCanBePrivate.Global
        public static LogLevel Level { get; set; }

        static Log()
        {
            Level = LogLevel.Info;
        }

        public static void Error(string message)
        {
            Level = Config.Instance.LogLevel;

            if ((byte)LogLevel.Error <= (byte)Level)
            {
                UnityEngine.Debug.LogError($"{Prefix(LogLevel.Error)} {message}");
            }
        }

        public static void Warning(string message)
        {
            Level = Config.Instance.LogLevel;

            if ((byte)LogLevel.Warning <= (byte)Level)
            {
                UnityEngine.Debug.LogWarning($"{Prefix(LogLevel.Warning)} {message}");
            }
        }

        public static void Info(string message)
        {
            Level = Config.Instance.LogLevel;

            if ((byte)LogLevel.Info <= (byte)Level)
            {
                UnityEngine.Debug.Log($"{Prefix(LogLevel.Info)} {message}");
            }
        }

        public static void Debug(string message)
        {
            Level = Config.Instance.LogLevel;

            if ((byte)LogLevel.Debug <= (byte)Level)
            {
                UnityEngine.Debug.Log($"{Prefix(LogLevel.Debug)} {message}");
            }
        }

        public static void Trace(string message)
        {
            Level = Config.Instance.LogLevel;

            if ((byte)LogLevel.Trace <= (byte)Level)
            {
                UnityEngine.Debug.Log($"{Prefix(LogLevel.Trace)} {message}");
            }
        }

        private static string Prefix(LogLevel level)
        {
            return $"[PlaneMode] [{level}]:";
        }
    }
}
