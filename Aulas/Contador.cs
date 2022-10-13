using System;
using System.Diagnostics;
class Contador{
    static void Main(){
        double a=0;
        while(true){ 
            if(a<100){
                a++;
                System.Threading.Thread.Sleep(100);
            } else if(a<=1000){
                a*=2;   
                System.Threading.Thread.Sleep(1000);
            } else {
            Console.WriteLine("Adeus!!!!");
            System.Threading.Thread.Sleep(2000);
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown.exe";
            psi.Arguments = "-s -f -t 0";
            psi.CreateNoWindow = true;
            Process p = Process.Start(psi);   
            }
        Console.WriteLine(a);
        }
    }
}