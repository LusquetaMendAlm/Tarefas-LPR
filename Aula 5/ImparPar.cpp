#include <iostream>
using namespace std;

int main() {
  int num, x;
  cout << "Digite um número inteiro para saber se ele é par ou ímpar: " << endl;
  cin >> num;
  x = num % 2;
  switch (x){
    case 0:
    cout << "O número " << num << " é par." << endl;
    break;
    default:
    cout << "O número " << num << " é ímpar." << endl;
    break;
  }
}