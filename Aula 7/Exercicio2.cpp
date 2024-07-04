#include <iostream>
using namespace std;

void media()
{
    int QantPar = 0;
    int contador = 0;
    double media;
    int n;
    int nums;
    double soma = 0;
    cout << "Quantos números você irá digitar?"<<endl;
    cin >> nums;
    while (nums > contador)
    {
        cout << "Digite os números, lembrando que números ímpares não farão parte da média: " << endl;
        cin >> n;
        if (n % 2 == 0)
        {
            soma = n + soma;
            QantPar++;
        }
        contador++;
        }
    media = soma / QantPar;
    cout << "Descontando os números ímpares, a média dessa sequência é: " << media << endl;
}

void multiplos()
{
    int soma=0;
    for (int i = 51; i<= 500; i=i+6)
    {
        soma = soma + i;
    }
    cout << "A soma dos múltiplos de 3 ímpares até 500 é de: " << soma << endl;
}

void soma()
{
    int n;
    int quadrado;
    int nums;
    int soma=0;
    cout<<"Digite um número natural: "<<endl;
    cin>>n;
    quadrado = n*n;
    while(quadrado>=1){
        nums = quadrado % 10;
        soma = soma + nums;
        quadrado = quadrado / 10;
    }
    cout<<"A soma dos digitos do quadrado desse número é de: "<<soma<<endl;
}

int main()
{
    int func;
    cout<<"Olá, qual função você quer usar?" << endl;
    cout<<"1) Função de fazer a média de números pares." << endl;
    cout<<"2) Função para mostrar os múltiplos de 3 entre 50 e 500." << endl;
    cout<<"3) Função para calcular a soma dos dígitos do quadrado desse número." << endl;
    cin >> func;
    switch (func)
    {
        case 1:
            media();
        break;
        case 2:
            multiplos();
        break;
        case 3:
            soma();
        break;
        default:
            cout << "Erro: Esse número não representa nenhuma das funções citadas." << endl;
    }
    

    return 0;
}
