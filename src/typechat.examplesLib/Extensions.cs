﻿// Copyright (c) Microsoft. All rights reserved.

using Microsoft.TypeChat.Schema;

namespace Microsoft.TypeChat;

public static class Extensions
{
    public static string? GetOrNull(this string[] args, int index)
    {
        if (args == null ||
            index >= args.Length)
        {
            return null;
        }
        return args[index];
    }

    public static void Print(this TypeChatException ex)
    {
        Console.WriteLine($"## TypeChatException");
        Console.WriteLine(ex.ToString());
    }

    public static void PrintNotTranslated(this Program program)
    {
        if (program != null && program.HasNotTranslated)
        {
            Console.WriteLine("I could not translate the following:");
            ConsoleApp.WriteLines(program.NotTranslated);
            Console.WriteLine();
        }
    }

    public static void Print(this Program program, string apiType)
    {
        if (program == null)
        {
            return;
        }
        program.PrintNotTranslated();
        if (program.HasSteps && program.HasNotTranslated)
        {
            Console.WriteLine("Suggested program that may include suggested APIs:");
        }
        new ProgramWriter(Console.Out).Write(program, apiType);
    }

}
