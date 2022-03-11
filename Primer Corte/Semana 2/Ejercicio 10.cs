 /*Largo, Ancho, Area, Precio, Descuento, Total*/
 
{
 float
print  "largo del terreno=" 
read largo
print  "ancho del terreno="
read ancho
print  "precio por metro cuadrado="
read precio
}
{area=largo*ancho;
      if(area>400,area<=500)
     {descuento=area*precio*0.10 }
else
     {if(area>500, area<=1000)
     {descuento=area*precio*0.17}
else
     {if(area>1000)
     {descuento=area*precio*0.25}}
     total=area*precio-descuento

print  "total del terreno ="  total
     }
void main ()
{ float Largo, Ancho, Area, Precio, Descuento, Total;
     cout <<"largo del terreno="; cin>>largo;
     cout <<"ancho del terreno="; cin>>ancho;
     cout <<"precio por metro cuadrado="; cin>>precio;

    cout <<"total del terreno =" <<total;
     getch();
    }}