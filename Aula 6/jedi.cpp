#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
   double horas;
   double dias;
   double semanas;
   double meses;
    cout<<"Olá jovem jedi, quantas horas dura o seu treinamento diário? "<<endl;
    cin>>horas;
    while(horas>24){
        cout<<"Não seja burro jovem jedi, um dia tem somente 24 horas. Por favor insira um valor válido."<<endl;
        cin>>horas;
    }
    dias = 1000/horas;
    semanas = dias/5;
    meses = semanas/4.5;
    cout<<"Para alcançar 1000 horas de treinamento, irá demorar em dias: "<< fixed << setprecision(1) << dias <<" dias"<<endl;
    cout<<"Para alcançar 1000 horas de treinamento, irá demorar semanas: "<< fixed << setprecision(1) << semanas <<" semanas"<<endl;
    cout<<"Para alcançar 1000 horas de treinamento, irá demorar em meses: "<< fixed << setprecision(1) << meses <<" meses"<<endl;
    return 0;
}