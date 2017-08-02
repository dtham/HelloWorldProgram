using System;
using HelloWorldProgram.Interfaces;

namespace HelloWorldProgram.Infrastructure
{
    public class HelloWorldRepository : IHelloWorld
    {
        private string helloWorld = "Hello World";

        public string CreateHelloWorld()
        {
           return helloWorld;
        }
    }
}