Public Class Form2
    Private Sub cmdDetails_Click(sender As Object, e As EventArgs) Handles cmdDetails.Click
        Dim name, streetName, houseNum, Town, postCode, CusDetails As String
        Dim creditCardNum As Long

        name = txtName.Text
        streetName = txtStreetNum.Text
        houseNum = txtHouseNum.Text
        Town = txtTown.Text
        postCode = txtPostcde.Text
        creditCardNum = txtCrdNum.Text

        ' data validation to ensure no field are empty'
        If name = "" Or streetName = "" Or postCode = "" Or houseNum = "" Or Town = "" Or creditCardNum.ToString = "" Then
            MsgBox("You need to complete the form ")

        Else
            'data validation to ensure the town/city name is between 2 and 25 characters in lenght'
            While Town.Length < 2 Or Town.Length > 25
                Town = InputBox("Town/City Name Must be between 2 and 25 Characters")
            End While


            While streetName.Length < 2 Or streetName.Length > 25
                streetName = InputBox("Street Name Characters Must be between 2 and 25")
            End While

            While postCode.Length <> 5
                postCode = InputBox("PostCode Must Have 5 Characters")

            End While

            While IsNumeric(creditCardNum) = False And creditCardNum.ToString.Length <> 16
                creditCardNum = InputBox("Has To Be 16 Digits")
            End While

            'Event code to store the details in appropriate variables'
            lblOutput.Text = SveCusDetails(name, streetName, houseNum, Town, postCode, creditCardNum)


        End If












    End Sub

    Private Function SveCusDetails(fn As String, sn As String, pc As String, pp As String, ff As String, cc As Long) As String
        Return "Customer Name: " & fn & vbCrLf & "Street Name: " & sn & vbCrLf & "House Number: " & pp & vbCrLf & "Town/city: " & ff & vbCrLf & "PostCode: " & pc & vbCrLf & "Credit Card: " & cc
    End Function
End Class