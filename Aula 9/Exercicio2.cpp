/******************************************************************************

Defina uma struct Livro com os seguintes
campos: Titulo, Autor, AnoPublicacao,
NumeroPaginas e Preco. Crie um
programa que permita ao usuário inserir
dados de 3 livros e, em seguida, calcule e
exiba o preço total dos livros cadastrados
e a média de páginas dos livros.


*******************************************************************************/
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

struct Livro {
 string Titulo;
 string Autor;
 short AnoPublicacao;
 short NumeroPaginas;
 double Preco;
};


int main()
{
    double media;
    double precototal;
    Livro l1; 
    cout << "Digite o nome do livro 1: ";
    cin >> l1.Titulo;
    cout << "Digite o número de páginas do livro 1: ";
    cin >> l1.NumeroPaginas;
    cout << "Digite o preço do livro 1: ";
    cin >> l1.Preco;

    Livro l2;
    cout << "Digite o nome do livro 2: ";
    cin >> l2.Titulo;
    cout << "Digite o número de páginas do livro 2: ";
    cin >> l2.NumeroPaginas;
    cout << "Digite o preço do livro 2: ";
    cin >> l2.Preco;

    Livro l3;
    cout << "Digite o nome do livro 3: ";
    cin >> l3.Titulo;
    cout << "Digite o número de páginas do livro 3: ";
    cin >> l3.NumeroPaginas;
    cout << "Digite o preço do livro 3: ";
    cin >> l3.Preco;
 
    precototal = l1.Preco + l2.Preco + l3.Preco;
    media = (l1.NumeroPaginas+l2.NumeroPaginas+l3.NumeroPaginas)/3;

    cout << "O preço total dos livros é " << fixed << setprecision(2) << precototal << "R$ e a média de páginas por livro é de " << media << endl;
    
    return 0;
}