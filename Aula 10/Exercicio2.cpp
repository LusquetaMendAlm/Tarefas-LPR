#include <iostream>
#include <list>
using namespace std;

int main()
{
	list<int> numeros;
	list<int> par;
	for (short i = 0; i < 10; i++)
	{
		numeros.push_back(rand() %1000);
	}
	numeros.sort();
	for (int numero : numeros) {
		cout << numero << endl;
	}
	cout << endl;
	for (auto numero : numeros) {
		if (numero % 2 == 0)
		{
			par.push_back(numero);
		}
	}
	for (auto numero : par) {
		numeros.remove(numero);
	}
	cout << "resposta:" << endl;
	for (int numero : numeros) {
		cout << numero << endl;
	}
}