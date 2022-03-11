/*Area de un Triangulo y un Circulo*/

{
while  terminado  ==  Falso :
    
    print  "Con que figura desea comenzar T o C:"
    elección  =  str (entrada())
     
    if  eleccion  == 'T':
        print  'Deme la base del triangulo:'
        base = flotante (entrada())
        print  'Deme la altura del triangulo:'
        altura = float (entrada())
        en = ( base * altura ) / 2
        print  'El area del triangulo es: %s' %  str ( at )
    elif  eleccion == 'C':
        print  'Deme la radio del circulo: '
        radio = flotar (entrada())
        ca = 3.14 * ( radio ** 2 )
        print  'el area del circulo es: %s' %  str ( ac )

    print  'Para proceder a terminar pulsa 0, en caso que no pulsa 1'
    opción  =  str (entrada())
    si  opcion  ==  0 :
    
        terminado  =  Verdadero
}