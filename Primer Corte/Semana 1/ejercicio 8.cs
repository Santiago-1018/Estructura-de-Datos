/* Vocal Letra */

int main()
{
    char letra;

    printf( "\n  Seleccione una letra " );
    scanf( "%c", &letra );

    if ( letra == 'c' || letra == 'C' ||
         letra == 'e' || letra == 'E' ||
         letra == 'i' || letra == 'I' ||
         letra == 'o' || letra == 'O' ||
         letra == 'a' || letra == 'A' )
        printf( "\n   ES UNA VOCAL" );
    else
        printf( "\n   NO ES UNA VOCAL" );

    getch(); /* Pausa */

    return 0;
}