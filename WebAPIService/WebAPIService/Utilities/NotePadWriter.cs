using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebAPIService.Utilities
{
    public sealed class NotePadWriter
    {
        private static TextWriter writerInstance = null;
        private static readonly object padlock = new object();
        private static string filePath = "c:\\logs\\payments_details.txt";

        private NotePadWriter()
        {
        }

        /// <summary>
        /// Generates single instance of file writer.
        /// </summary>
        public static TextWriter Instance
        {
            get
            {
                lock (padlock)
                {
                    if (writerInstance == null)
                    {
                        writerInstance = new StreamWriter(filePath, true);
                    }
                    return writerInstance;
                }
            }
        }
    }
}