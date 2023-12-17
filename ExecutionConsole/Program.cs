using BenchmarkDotNet.Running;
using ExecutionAPI;
using ExecutionConsole;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var summary = BenchmarkRunner.Run<BenchmarkExecution>();