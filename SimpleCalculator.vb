'Brayden Peck
'RCET0265
'Spring 2021
'Simple Calculator
'https://github.com/PeckBray/SimpleCalculator

Option Strict On
Option Explicit On
Option Compare Binary

Module SimpleCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim operation As Integer
        Dim result As Integer

        Console.WriteLine("Please enter the first number")
        firstNumber = CInt(Console.ReadLine())

        Console.WriteLine("Please enter the second number")
        secondNumber = CInt(Console.ReadLine())

        Console.WriteLine("Please enter an operation. 1 = sum 2 = product")
        operation = CInt(Console.ReadLine())

        If operation = 1 Then
            result = firstNumber + secondNumber
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}")
        ElseIf operation = 2 Then
            result = firstNumber * secondNumber
            Console.WriteLine(($"{firstNumber} * {secondNumber} = {result}"))
        Else
            Console.WriteLine("An unexpected input has been detected. Please try again")
        End If
        Console.ReadLine()
    End Sub

End Module
