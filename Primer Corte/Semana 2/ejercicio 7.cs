using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.collections.Generic;

namespace frase usuario
{
    public class Program
    {
        static void Main(String [] Args)
        {
          void contar(char frase[100]);
        main()
        {
        char frase[100];
          int a=0,e=0,i=0,o=0,u=0,z=0;

            
            printf("ESCRIBA UNA FRASE");
            gets(frase);
            printf("\n La frase escrita es:%s",frase);
            printf("\n VOCAL   \t   Repite");
            printf("\n  A      \t    %d",a);
            printf("\n  E      \t    %d",e);
            printf("\n  I      \t    %d",i);
            printf("\n  O      \t    %d",o);
            printf("\n  U      \t    %d",u);
            getch();
            }
            void contar(char frase[100])
{
             int a=0,e=0,i=0,o=0,u=0;
                for(int x=0;x<100;x++){
	                switch(frase[x]){
		            case 'a': a++; break;
		            case 'e': e++; break;
		            case 'i': i++; break;
		            case 'o': o++; break;
		            case 'u': u++; break;
 
	 }
}
}