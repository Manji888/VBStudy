Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("名前を入力してください")
        'Dim name As String = Console.ReadLine()

        'Console.WriteLine("あなたの年齢を入力してください")
        'Dim age As Integer = Integer.Parse(Console.ReadLine())

        'Console.WriteLine("こんにちは" & name & "さん!")
        'Console.WriteLine(age & "歳ですね！")

        ' Dim age As Integer = 28
        'Dim job As String = "エンジニア"

        'age = 29
        'Dim number As Integer

        'Console.WriteLine(number)
        'Console.WriteLine(age)
        'Console.WriteLine(job)

        '実習①
        '複数行一括コメントアウト　→　ctrl + K + C
        '複数行一括コメントアウト解除　→　ctrl + K + U
        'Console.WriteLine("年齢を入力してください")
        'Dim age As Integer = Integer.Parse(Console.ReadLine())

        'If age < 20 Then
        'Console.WriteLine("未成年です")

        'Else
        'Console.WriteLine("成人です")
        'End If

        '実習②
        'Console.WriteLine("点数を入力してください")
        'Dim score As Integer = Integer.Parse(Console.ReadLine())

        'If score >= 95 Then
        '    Console.WriteLine("Sランク")

        'ElseIf score >= 80 Then

        '    Console.WriteLine("Aランク")

        'ElseIf score >= 70 Then

        '    Console.WriteLine("Bランク")

        'Else
        '    Console.WriteLine("Cランク")

        'End If

        '実習③
        Console.WriteLine("ユーザー名を入力してください")
        Dim name As String = Console.ReadLine()

        If name = "" Then
            Console.WriteLine("名前を入力してください")

        Else
            Console.WriteLine("ようこそ" & name & "さん！")
        End If


    End Sub
End Module
