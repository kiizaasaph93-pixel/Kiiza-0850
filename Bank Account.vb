Public Class BankAccount
    Private _balance As Decimal
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property

    Public Property amount As Decimal

    Public Sub Deposit(amount As Decimal)
        If amount < 0 Then
            Throw New Exception
            ArgumentException("Deposit amount can not be negative.")
        End If
        _balance += amount

    End Sub
    Public Sub withdraw(amaount As Decimal)
        If amaount < 0 Then
            Throw New Exception
            ArgumentException("withdraw amount cannot be negative.")
        End If
        If amaount > _balance Then
            Throw New Exception
            ArgumentException("overdraft is not allowed.")
        End If
        _balance -= amount
    End Sub

    Private Sub ArgumentException(v As String)
        Throw New NotImplementedException()
    End Sub
End Class
