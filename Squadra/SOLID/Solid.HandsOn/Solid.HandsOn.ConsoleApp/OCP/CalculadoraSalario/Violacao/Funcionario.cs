﻿namespace Solid.HandsOn.ConsoleApp.OCP.CalculadoraSalario.Violacao
{
    public class Funcionario
    {
        public Funcionario(Cargo cargo, double salarioBase)
        {
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public Cargo Cargo { get; }
        public double SalarioBase { get; }
    }
}