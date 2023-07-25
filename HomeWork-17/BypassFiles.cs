using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17
{
    public class BypassFiles
    {
        public delegate void EventHandler(object sender, FileArgs e);

        public event EventHandler FileFound;

        public int FoundResult = 0;

        public string dirPath { get; set; }
        public int Check = 0;
        public BypassFiles(string _dirPath)
        {
            dirPath = _dirPath;
            this.FileFound += FileEventHandler;
        }


        public void FileEventHandler(object sender, FileArgs e)
        {

            Console.WriteLine($"File found {e.FileName}");
            if (e.FileName.Contains("exe"))
            {
                Console.WriteLine("One file *.exe");
                FoundResult = 1;
            }

        }


        public void GetFile()
        {
            string[] files = Directory.GetFiles(dirPath);

            foreach (string s in files)
            {
                if (s != null)
                {
                    FileFound?.Invoke(this, new FileArgs(s));

                }
                if (FoundResult == 1)
                {
                    this.FileFound -= FileEventHandler;
                    break;
                }
            }
        }

    }
}
