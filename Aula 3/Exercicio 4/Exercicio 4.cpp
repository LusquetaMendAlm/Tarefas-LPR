/*Exercício 4) Fazer um programa para ler o código de uma peça 1, o número de peças
1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o
valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

*/

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    int codigo1;
    int numero1;
    float valor1;
    int codigo2;
    int numero2;
    float valor2;
    float valorfinal;
    cin >> codigo1;
    cin >> numero1;
    cin >> valor1;
    cin >> codigo2;
    cin >> numero2;
    cin >> valor2;
    valorfinal = (numero1 * valor1) + (numero2 * valor2);
    cout << "Valor a pagar: R$" << fixed << setprecision(2) << valorfinal << endl;
}