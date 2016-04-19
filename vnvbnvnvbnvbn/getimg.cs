using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace vnvbnvnvbnvbn
{
    class getimg
    {

        public string Downloadimg(string url)
        {
            //C:\Windows\Temp\
            string localfile = @"C:\Windows\Temp\" + Path.GetRandomFileName() + ".png";
            new WebClient().DownloadFile(url, localfile);
            return localfile;
        }


    }
}
