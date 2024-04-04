#include <iostream>
using namespace std;

int main()
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

    return 0;
}