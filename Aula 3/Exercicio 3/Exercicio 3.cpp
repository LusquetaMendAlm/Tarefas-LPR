/*Exercício 3) Fazer um programa que leia o número de um funcionário, seu número de
horas trabalhadas, o valor que recebe por hora e calcule o salário desse funcionário.
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
*/

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    int funcionario;
    float horas;
    float valor;
    float salario;
    cin >> funcionario;
    cin >> horas;
    cin >> valor;
    salario = horas * valor;
    cout << "Número funcionário: " << funcionario << endl;
    cout << "Salário: R$" << fixed << setprecision(2) << salario << endl;
}
