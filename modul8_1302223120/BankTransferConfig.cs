using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302223120
{
    internal class BankTransferConfig
    {
        string CONFIG1 = "en";
        int CONFIG2 = 25000000;
        int CONFIG3 = 6500;
        int CONFIG4 = 15000;
        string[] CONFIG5 = { "RTO", "SKN", "RTGS", "BI-FAST" };
        string CONFIG6 = "yes";
        string CONFIG7 = "ya";

        public void menuUtama(string bhs)
        {
            if (bhs == "id")
            {
                CONFIG1 = "id";
                Console.Write("Masukkan jumlah uang yang akan di-transfer:");
            }
            else
            {
                Console.Write("Please insert the amount of money to transfer:");
            }
        }
        public void total(int transfer)
        {
            int fee = 0;
            if (CONFIG1 == "en")
            {
                if (transfer > CONFIG2)
                {
                    fee = CONFIG4;
                    Console.WriteLine("Transfer fee: Rp." + fee);
                    Console.WriteLine("Total amount: Rp." + (transfer + fee));
                }
                else if (transfer <= CONFIG2)
                {
                    fee = CONFIG3;
                    Console.WriteLine("Transfer fee: Rp." + fee);
                    Console.WriteLine("Total amount: Rp." + (transfer + fee));
                }
            }
            else
            {
                if (transfer > CONFIG2)
                {
                    fee = CONFIG4;
                    Console.WriteLine("Transfer fee: Rp." + fee);
                    Console.WriteLine("Total amount: Rp." + (transfer + fee));
                }
                else if (transfer <= CONFIG2)
                {
                    fee = CONFIG3;
                    Console.WriteLine("Biaya Transfer: Rp." + fee);
                    Console.WriteLine("Total Biaya: Rp." + (transfer + fee));
                }
            }
        }
        public void transferMethod()
        {
            for (int i = 1; i < 5;)
            {
                Console.WriteLine(i + "." + CONFIG5[i]);
            }
        }
        public void confirm()
        {
            if (CONFIG1 == "id")
            {
                Console.WriteLine("Ketik '"+CONFIG7+"' untuk mengonfirmasi transaksi");
                string confirm = Console.ReadLine();
                if (confirm == CONFIG7)
                {
                    Console.WriteLine("Proses Transfer Berhasil");
                }
                else
                {
                    Console.WriteLine("Proses Transfer Gagal");
                }
            } else if (CONFIG1 == "en")
            {
                Console.WriteLine("Please Type '" + CONFIG6 + "' to confirm the trnsaction");
                string confirm = Console.ReadLine();
                if (confirm == CONFIG6)
                {
                    Console.WriteLine("The Transfer is Completed");
                }
                else
                {
                    Console.WriteLine("Transfer is Cancelled");
                }
            }
        }
    }
}
