/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Calculadora {
  static void Main() {
    
    
        int n1,n2,resultado,menu;
        
        Console.WriteLine ("Digite o primeiro numero: \t");
        n1 = int.Parse(Console.ReadLine());
        
    
         
        Console.WriteLine ("Digite o segundo numero: \t");
        n2 = int.Parse(Console.ReadLine());
        
         
        Console.WriteLine ("Que tipo de conta deseja efetuar?\t\n(0)saida\n(1)adicao\n(2)subtracao\n(3)multiplicacao\n(4)divisao\n");
        menu = int.Parse(Console.ReadLine());
        
           switch (menu){
            default: Console.WriteLine ("Programa finalizado"); break;
            menu = int.Parse(Console.ReadLine());
            
            case 1: resultado=n1+n2;
            Console.WriteLine("Valor da adicao eh:\t {0}",resultado); break;
            
            case 2: resultado=n1-n2;
            Console.WriteLine("Valor da subtracao eh:\t {0}", resultado); break;
            
            case 3: resultado=n1*n2;
            Console.WriteLine("Valor da multiplicacao eh:\t {0}", resultado); break;
            
            case 4: resultado=n1/n2;
            Console.WriteLine("Valor da divisao eh:\t {0}", resultado); break;
                    }
                    
              
          }
}