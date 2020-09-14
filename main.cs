using System;

class MainClass {
  public static void Main (string[] args) {
   Pessoa dadosPessoa = new Pessoa();
   
   dadosPessoa.ColetaDados("Ana",20,60,1.62);
   dadosPessoa.Dados();
   

   dadosPessoa.Envelhecer(21); 
   dadosPessoa.Engordar(64);
   dadosPessoa.Dados();
   

   dadosPessoa.Emagrecer(62);
   dadosPessoa.Crescer(1.64);
   dadosPessoa.Dados();
   


  }
}