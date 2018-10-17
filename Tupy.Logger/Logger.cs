﻿using System.Runtime.InteropServices;

namespace Tupy.Logger
{
    public static class Logger
    {
        public static bool WriteEntry(EventEntry entry)
        {
            bool result = LoggerOrchestrator.ProviderManager.WriteEntry(entry);
            return result;
        }

        public static bool WriteEntry(string source, string message)
        {
            return WriteEntry(source, message, EventEntryTypes.Information);
        }

        public static bool WriteEntry(string source, string message, EventEntryTypes type)
        {
            return WriteEntry(source, message, type, null);
        }
        public static bool WriteEntry(string source, string message, EventEntryTypes type, string data)
        {
            return WriteEntry(source, message, type, data, category: null);
        }

        public static bool WriteEntry(string source, string message, EventEntryTypes type, string data, [Optional] string category, [Optional] string userName, [Optional] string machineName)
        {
            var entry = new EventEntry()
            {
                Source = source,
                Message = message,
                EntryType = type,
                Data = data,
                Category = category,
                UserName = userName,
                MachineName = machineName
            };

            return WriteEntry(entry);
        }
    }
}
