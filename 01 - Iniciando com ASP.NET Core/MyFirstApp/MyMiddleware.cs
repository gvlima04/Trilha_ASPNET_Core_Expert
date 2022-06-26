
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyFirstApp
{
    public class MyMiddleware
    {
        // Primeiro passo é uma RequestDelagate pois é que vai orientar a chamada do próximo middleware dentro do pipeline
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next) // O ASP.NET fará automaticamente a injeção de dependência
        {
            _next = next;
        }

        // Método InvokeAsync que é chamado sempre que o middleware é chamado
        public async Task InvokeAsync(HttpContext context) //Rerquisição atual
        {
            Console.WriteLine("\n_-_-_-_-_Before_-_-_-_-_");
            Console.WriteLine($"Request: {context.ToString()}\n");

            await _next(context); // Passagem do contexto para o processamento do próximo middleware

            Console.WriteLine("\n_-_-_-_-_After_-_-_-_-_");
            Console.WriteLine($"Request: {context.ToString()}\n");

        }
    }
}

