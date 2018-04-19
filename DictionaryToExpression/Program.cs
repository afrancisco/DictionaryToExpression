using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DictionaryToExpression
{
    class Program
    {
        static void Main(string[] args)
        {
                      List<Contato> Contatos = new List<Contato>();
            Contatos.Add(new Contato() { Nome = "Anderson", Email = "email@1.com.br", CPF = "12345678912" });
            Contatos.Add(new Contato() { Nome = "Joao", Email = "email@2.com.br", CPF = "12345678912" });
            Contatos.Add(new Contato() { Nome = "Pedro", Email = "email@3.com.br", CPF = "98765432198" });
            Contatos.Add(new Contato() { Nome = "Jonas", Email = "email@1.com.br", CPF = "14725836914" });

            var searchTerms = new Dictionary<string, string> { { "Nome", "Joao" },{"CPF","1234578912" } };
            var searchExpression = GetFilterExpression(searchTerms);
           // var result = Contatos.Where(searchExpression).toList();
        }

        Expression<Func<T, bool>> GetFilterExpression<T>(Dictionary<string, object> searchTerms)
        {

            foreach (var item in searchTerms)
            {
                var condition =
                 item.Key;
            }

        }
    }

  


}
