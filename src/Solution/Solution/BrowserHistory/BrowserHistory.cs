using System;
using System.Collections.Generic;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; }
        public Halaman Next { get; set; }

        public Halaman(string url)
        {
            URL = url;
            Next = null;
        }
    }

    public class HistoryManager
    {
        private Halaman top;
        private Stack<string> historyStack;

        public HistoryManager()
        {
            top = null;
            historyStack = new Stack<string>();
        }

        public void KunjungiHalaman(string url)
        {
            if (top != null)
            {
                historyStack.Push(top.URL);
            }
            Halaman newPage = new Halaman(url);
            newPage.Next = top;
            top = newPage;
        }

        public string Kembali()
        {
            if (historyStack.Count == 0)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            string previousPage = historyStack.Pop();
            top = new Halaman(previousPage);
            return previousPage;
        }

        public string LihatHalamanSaatIni()
        {
            return top != null ? top.URL : "History kosong.";
        }

        public void TampilkanHistory()
        {
            Stack<string> tempStack = new Stack<string>(historyStack);
            foreach (var url in tempStack)
            {
                Console.WriteLine(url);
            }
            if (top != null)
            {
                Console.WriteLine(top.URL);
            }
        }
    }

}
