Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim destination(2), month(2), lengh(2) As String
        Dim cost(26) As Decimal

        destination(0) = "Gothenburg"
        destination(1) = "Malmö"
        destination(2) = "Stockholm"

        month(0) = "June"
        month(1) = "July"
        month(2) = "August"

        lengh(0) = "3 days"
        lengh(1) = "6 days"
        lengh(2) = "10 days"

        cost(0) = "2900 " 'Gothenburg June 3 days
        cost(1) = "5500"  'Gothenburg June 6 days
        cost(2) = "9000"  'Gothenburg June 10 days
        cost(3) = "3900"  'Gothenburg July 3 days
        cost(4) = "6500"  'Gothenburg July 6 days
        cost(5) = "10000" 'Gothenburg July 10 days
        cost(6) = "3400"  'Gothenburg August 3 days
        cost(7) = "5900"  'Gothenburg August 6 days
        cost(8) = "9400"  'Gothenburg August 10 days
        cost(9) = "2400"  'Malmö June 3 days
        cost(10) = "500"  'Malmö June 6 days
        cost(11) = "8500" 'Malmö June 10 days
        cost(12) = "3400" 'Malmö July 3 days
        cost(13) = "6000" 'Malmö July 6 days
        cost(14) = "95000" 'Malmö July 10 days
        cost(15) = "2900" 'Malmö August 3 days
        cost(16) = "5500" 'Malmö August 6 days
        cost(17) = "9000" 'Malmö August 10 days
        cost(18) = "3400" 'Stockholm June 3 days
        cost(19) = "6000" 'Stockholm June 6 days
        cost(20) = "10000" 'Stockholm June 10 days
        cost(21) = "4500" 'Stockholm July 3 days
        cost(22) = "7000" 'Stockholm July 6 days
        cost(23) = "11000" 'Stockholm July 10 days
        cost(24) = "3900" 'Stockholm August 3 days
        cost(25) = "6400" 'Stockholm August 6 days
        cost(26) = "10500" 'Stockholm August 10 days

        'Declaration of variable for additional package'
        Dim EBikeHire = 650, Mealpack = 490

        'Setting up the form controls'
        optGothenburg.Text = destination(0)

        For k = 0 To 2
            cmblenght.Items.Add(lengh(k))
            cmbMonth.Items.Add(month(k))
        Next

        chkEbike.Text = "Electric bike hire"
        chkMeal.Text = "Meal package"

        'Default value for form tools'
        optGothenburg.Checked = True
        cmbMonth.Text = "July"
        cmblenght.Text = "3 days"



    End Sub

    Private Sub cmdQuote_Click(sender As Object, e As EventArgs) Handles cmdQuote.Click
        'Calculation for Total cost'
        Dim Destinationchoice, MonthChoice, LenghtChoice,Lenght, FinalAmount As String
        Dim total, additionalChoice As Decimal

        'Gothenburg'

        'June'
        If optGothenburg.Checked = True Then
            If cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "June"
                LenghtChoice = "3 days"
                total = total + 2900

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "June"
                LenghtChoice = "6 days"
                total = total + 5500

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"


            ElseIf cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "10 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "June"
                LenghtChoice = "10 days"
                total = total + 9000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"
            End If
        End If
        'July'

        If optGothenburg.Checked = True Then
            If cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "July"
                LenghtChoice = "3 days"
                total = total + 3900

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "July"
                LenghtChoice = "6 days"
                total = total + 6500

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "10 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "July"
                LenghtChoice = "10 days"
                total = total + 10000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            End If

        End If
        'August'
        If optGothenburg.Checked = True Then
            If cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "August"
                LenghtChoice = "3 days"
                total = total + 3400

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "August"
                LenghtChoice = "6 days"
                total = total + 5900

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"


            ElseIf cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Gothenburg"
                MonthChoice = "August"
                LenghtChoice = "10 days"
                total = total + 9400

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"



            End If

        End If

        ' Malmo '

        'June'

        If optMalmo.Checked = True Then
            If cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "June"
                LenghtChoice = "3 days"
                total = total + 2400

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"


            ElseIf cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "June"
                LenghtChoice = "6 days"
                total = total + 500

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "10 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "June"
                LenghtChoice = "10 days"
                total = total + 8500

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            End If
        End If
        'July
        If optMalmo.Checked = True Then
            If cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "July"
                LenghtChoice = "3 days"
                total = total + 3400

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "July"
                LenghtChoice = "6 days"
                total = total + 6000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "10 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "July"
                LenghtChoice = "10 days"
                total = total + 95000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            End If

        End If

        'August'
        If optMalmo.Checked = True Then
            If cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "August"
                LenghtChoice = "3 days"
                total = total + 2900

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Malmo"
                MonthChoice = "August"
                LenghtChoice = "6 days"
                total = total + 5500

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"


            ElseIf cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "10 days" Then

                Destinationchoice = "Malmo"
                MonthChoice = "August"
                LenghtChoice = "10 days"
                total = total + 9000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            End If

        End If

        'Stockholm'

        'June'

        If optStockholm.Checked = True Then
            If cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "June"
                LenghtChoice = "3 days"
                total = total + 3400

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"


            ElseIf cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "June"
                LenghtChoice = "6 days"
                total = total + 6000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "June" And cmblenght.SelectedItem = "10 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "June"
                LenghtChoice = "10 days"
                total = total + 10000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"
            End If
        End If
        'July
        If optStockholm.Checked = True Then
            If cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "July"
                LenghtChoice = "3 days"
                total = total + 4500

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "July"
                LenghtChoice = "6 days"
                total = total + 7000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "July" And cmblenght.SelectedItem = "10 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "July"
                LenghtChoice = "10 days"
                total = total + 11000

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            End If

        End If

        'August'
        If optStockholm.Checked = True Then
            If cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "3 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "August"
                LenghtChoice = "3 days"
                total = total + 3900

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "6 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "August"
                LenghtChoice = "6 days"
                total = total + 6400

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destinatiom: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            ElseIf cmbMonth.SelectedItem = "August" And cmblenght.SelectedItem = "10 days" Then
                Destinationchoice = "Stockholm"
                MonthChoice = "August"
                LenghtChoice = "10 days"
                total = total + 10500

                lblDisplay.Text = lblDisplay.Text & vbCrLf & "Destination: " & Destinationchoice & vbCrLf & "Month: " & MonthChoice & vbCrLf & "For " & LenghtChoice & vbCrLf & "Total: " & total & " SEK"

            End If

        End If


        'for the additional cost
        If chkEbike.Checked = True And cmblenght.SelectedItem = "3 days" Then
            LenghtChoice = 3
            additionalChoice = 650 * LenghtChoice
            FinalAmount = vbCrLf & "       +" & vbCrLf & FinalAmount & vbCrLf & "Electric Bike Hire: " & LenghtChoice & " x 650 = " & additionalChoice


        ElseIf chkEbike.Checked = True And cmblenght.SelectedItem = "6 days" Then
            LenghtChoice = 6
            additionalChoice = 650 * LenghtChoice
            FinalAmount = vbCrLf & "       +" & vbCrLf & FinalAmount & vbCrLf & "Electric Bike Hire: " & LenghtChoice & " x 650 = " & additionalChoice

        ElseIf chkEbike.Checked = True And cmblenght.SelectedItem = "10 days" Then
            LenghtChoice = 10
            additionalChoice = 650 * LenghtChoice
            FinalAmount = vbCrLf & "       +" & vbCrLf & FinalAmount & vbCrLf & "Electric Bike Hire: " & LenghtChoice & " x 650 = " & additionalChoice

        End If

        If chkMeal.Checked = True And cmblenght.SelectedItem = "3 days" Then
            LenghtChoice = 3
            additionalChoice = 490 * LenghtChoice
            FinalAmount = vbCrLf & "       +" & vbCrLf & FinalAmount & vbCrLf & "Meal package: " & LenghtChoice & " x 490 = " & additionalChoice


        ElseIf chkMeal.Checked = True And cmblenght.SelectedItem = "6 days" Then
            LenghtChoice = 6
            additionalChoice = 490 * LenghtChoice
            FinalAmount = vbCrLf & "       +" & vbCrLf & FinalAmount & vbCrLf & "Meal package: " & LenghtChoice & " x 490 = " & additionalChoice

        ElseIf chkMeal.Checked = True And cmblenght.SelectedItem = "10 days" Then
            LenghtChoice = 10
            additionalChoice = 490 * LenghtChoice
            FinalAmount = vbCrLf & "       +" & vbCrLf & FinalAmount & vbCrLf & "Meal package: " & LenghtChoice & " x 490 = " & additionalChoice

        End If
        lblDisplay.Text = lblDisplay.Text & vbCrLf & FinalAmount & vbCrLf & vbCrLf & "=================" & vbCrLf & "Final Amount: " & (additionalChoice + total) & " SEK" & vbCrLf & "=================" & vbCrLf
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim Value As StreamWriter
        Value = File.CreateText(" alright")
        Value.WriteLine(lblDisplay.Text)
        Value.Close()

        Me.Hide()
        Form2.Show()
    End Sub
End Class
