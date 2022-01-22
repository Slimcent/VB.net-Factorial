Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnumber.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        lblslimsoft.Left = lblslimsoft.Left + 5

        If lblslimsoft.Left > Me.Width Then
            lblslimsoft.Left = 0
        End If

    End Sub

    Private Sub btbFactorial_Click(sender As Object, e As EventArgs) Handles btbFactorial.Click

        Dim no, factorial As Integer

        no = Val(txtnumber.Text)

        factorial = 1

        For i = no To 1 Step -1
            On Error Resume Next

            factorial = factorial * i

        Next i

        lblresult.Text = factorial


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtnumber.Text = ""
        lblresult.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'to close the app

        Dim returndialogresult As System.Windows.Forms.DialogResult
        Dim title As String = "Sure to exit"
        Dim message As String = "Do you want to exit?"

        returndialogresult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If returndialogresult = Windows.Forms.DialogResult.Yes Then

            Me.Close()
        End If

    End Sub

    Private Sub txtnumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnumber.Validating

        Dim number As Integer

        Try
            number = Integer.Parse(txtnumber.Text)

            If txtnumber.Text = String.Empty Then

                'Cancel the event
                e.Cancel = True
                txtnumber.SelectAll()
                txtnumber.Focus()
                ErrorProvider.SetError(txtnumber, "Number must not be blank")

            End If

        Catch ex As Exception
            e.Cancel = True
            txtnumber.SelectAll()
            txtnumber.Focus()
            ErrorProvider.SetError(txtnumber, "Nunmer must be numeric")
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
