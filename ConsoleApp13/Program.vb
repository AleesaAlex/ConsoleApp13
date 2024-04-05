Imports System

Public Class Employee
    Public Property Name As String
    Public Property EmployeeID As Integer
    Public Property Salary As Decimal

    Public Sub New(ByVal name As String, ByVal employeeID As Integer, ByVal salary As Decimal)
        Me.Name = name
        Me.EmployeeID = employeeID
        Me.Salary = salary
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Name: {Name}")
        Console.WriteLine($"Employee ID: {EmployeeID}")
        Console.WriteLine($"Salary: {Salary}")
    End Sub
End Class

Module Program
    Sub Main()
        Dim emp1 As Employee

        Console.WriteLine("Enter employee details:")
        emp1 = New Employee(GetInput("Name"), GetIntegerInput("Employee ID"), GetDecimalInput("Salary"))

        Do
            DisplayMenu()
            Select Case GetUserChoice()
                Case 1
                    Console.WriteLine("Employee Information:")
                    emp1.DisplayInfo()
                Case 2
                    Console.WriteLine("Enter new details:")
                    emp1 = New Employee(GetInput("Name"), GetIntegerInput("Employee ID"), GetDecimalInput("Salary"))
                    Console.WriteLine("Employee information updated successfully.")
                Case 3
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid choice. Please enter a valid option.")
            End Select
        Loop

        Console.WriteLine("Exiting...")
    End Sub

    Private Sub DisplayMenu()
        Console.WriteLine("Menu:")
        Console.WriteLine("1. Display Employee Information")
        Console.WriteLine("2. Update Employee Information")
        Console.WriteLine("3. Exit")
    End Sub

    Private Function GetUserChoice() As Integer
        Console.Write("Enter your choice: ")
        Return Integer.Parse(Console.ReadLine())
    End Function

    Private Function GetInput(ByVal prompt As String) As String
        Console.Write($"{prompt}: ")
        Return Console.ReadLine()
    End Function

    Private Function GetIntegerInput(ByVal prompt As String) As Integer
        Return Integer.Parse(GetInput(prompt))
    End Function

    Private Function GetDecimalInput(ByVal prompt As String) As Decimal
        Return Decimal.Parse(GetInput(prompt))
    End Function
End Module