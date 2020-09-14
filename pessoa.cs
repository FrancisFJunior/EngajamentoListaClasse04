using System;

/*Classe Pessoa: Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.*/

class Pessoa{

private string nome;
private int idade;
private double peso, altura;

public void ColetaDados(string n, int i, double p,double a){
  nome = n;
  idade = i;
  peso = p;
  altura = a;
  
}

public void Dados(){
  Console.WriteLine("Nome: {0}, idade: {1}, peso: {2}, altura: {3}", nome, idade, peso, altura);
}


public void Envelhecer(int atual){
  if (((atual - idade) > 0) && (idade < 21)){
    for (int i = atual - idade; i>0; i--){
      Crescer(0.05);
    }
  }
  if (idade < atual){
    idade = atual; //idade atualizada
  }
  Console.WriteLine("Idade atual : {0}",atual);
}

public void Engordar(double engordou){

  if(engordou >= peso){
    Console.WriteLine("Engordou : {0} Kg", engordou - peso);
    peso = engordou;
    Console.WriteLine("Peso atual : {0} Kg",peso);
  }else{
    Console.WriteLine("Não engordou!");
  }
}

public void Emagrecer(double emagreceu){
  if(emagreceu < peso){
    Console.WriteLine("Emagreceu : {0} Kg", peso - emagreceu);
    peso = emagreceu;
    Console.WriteLine("Peso atual : {0} Kg",peso);
  }else{
    Console.WriteLine("Não emagreceu!");
  }
}


public void Crescer(double altura2){
  if (altura2 == 0.05){
      altura = altura + altura2;
    } else {
      altura = altura2;
  
} 

}

}