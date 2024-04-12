#include <iostream>
using namespace std;

int num;

void reverse()
{
    int numReverso;
    if(num >= 0 )
    {
        do {
            numReverso = num%10;
            cout<<numReverso;
            num /= 10;
        }while(num != 0);
    }
    else 
    {
        num *= -1;
        do{
            numReverso = num%10;
            cout<<numReverso;
            num /= 10;
        }while(num);
    }
}

int main()
{
    cout<<"Digite um número inteiro: ";
    cin>>num;
    cout<<"O reverso desse número é: ";
    reverse();

    return 0;
}