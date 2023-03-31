using System;
using System.IO;
public class Program {
    public static void Main (string[] args) {
        Pole [,] plansza=new Pole[3,3];
        int gracz=1,Kordx=0,Kordy=0;
        Kolko tic= new Kolko();
        Krzyzyk tac=new Krzyzyk();
        
        void wybierz_pole () {
            Console.WriteLine("wybierz puste pole");
            string pozycja = Console.ReadLine();
            pozycja.ToUpper();
            Kordx=pozycja[0]-64;
            Kordy=pozycja[1]-1;
        }
            
        void sprawdz(int x, int y) {
        if (plansza[x,y].Zajete==true) {
            Console.WriteLine("Wybrano pełne pole");
            wybierz_pole();
        }
        else if (gracz==1) {
            plansza[x,y].uzupelnij_kolko(tic);
            gracz--;
        }
        else plansza[x,y].uzupelnij_krzyzyk(tac);
        gracz++;
        }
        
        void wyswietl() {
            for (int i=0;i<3;i++) {
                for (int j=0;j<3;j++) { 
                    Console.WriteLine(plansza[i,j].Znak+"\t");
                }
                Console.WriteLine();
            }
        }
        
        void wygrana (int x,int y,string s) {
            for(int i = 0; i < 3; i++){
                if(plansza[x,i].Znak != s) //col
                break;
            if(i == 2){
                Console.WriteLine("Gratulacje graczu "+gracz);
                return;
            }
        }
            for(int i = 0; i < 3; i++){
                if(plansza[i,y].Znak != s) //row
                break;
            if(i == 2){
                Console.WriteLine("Gratulacje graczu "+gracz);
                return;
            }
        }
           for(int i = 0; i < 3; i++){
                if(plansza[i,i].Znak != s) //diag
                break;
            if(i == 2){
                Console.WriteLine("Gratulacje graczu "+gracz);
                return;
            }
        }
        for(int i = 0; i < 3; i++){
                if(plansza[i,2-i].Znak != s) // anti diag
                break;
            if(i == 2){
                Console.WriteLine("Gratulacje graczu "+gracz);
                return;
            }
            wyswietl();
        }
        }


        for(int i=0;i<9;i++) {
            wybierz_pole();
            sprawdz(Kordx,Kordy);
            if (i>=2) {
                if (gracz==1) {
                wygrana(Kordx,Kordy,tac.znak);
            }
            else wygrana(Kordx,Kordy,tic.znak);
            }
            Console.WriteLine("Tura gracza "+gracz);
            
        }
        


    }
}