Imports MySql.Data.MySqlClient

Public Class PassengerForm
    Dim flightfee, classFee, discountFee, preTotalFee, finalFee As Double

    Private Sub PassengerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
    End Sub

    Private Sub BtnPassengerCheck_Click(sender As Object, e As EventArgs) Handles BtnPassengerCheck.Click
        'Dim flightfee As Double
        If TxtOrigin.Text = "Berlin" And TxtDestination.Text = "Philadelphia" Then
            flightfee = 1000
        ElseIf TxtOrigin.Text = "Berlin" And TxtDestination.Text = "Hiroshima" Then
            flightfee = 2000
        ElseIf TxtOrigin.Text = "Philadelphia" And TxtDestination.Text = "Hiroshima" Then
            flightfee = 1500
        End If


        'Dim classFee As Double
        If TxtClass.Text = "First Class" Then
            classFee = 500
        ElseIf TxtClass.Text = "Business Class" Then
            classFee = 250
        ElseIf TxtClass.Text = "Economy Class" Then
            classFee = 100
        End If


        'Dim discountFee, totalFee, finalFee As Double
        preTotalFee = flightfee + classFee
        If TxtDiscount.Text = "Ukrainian Citizenship - 75% Discount" Or
           TxtDiscount.Text = "People With Disability - 75% Discount" Or
           TxtDiscount.Text = "Single Parent Family - 75% Discount" Then
            discountFee = preTotalFee * 0.75
            finalFee = preTotalFee - discountFee
        Else
            discountFee = preTotalFee * 0
            finalFee = preTotalFee - discountFee
        End If


        Me.DetailName.Text = TxtName.Text
        Me.DetailNationality.Text = TxtNationality.Text
        Me.DetailGender.Text = TxtGender.Text
        Me.DetailOrigin.Text = TxtOrigin.Text
        Me.DetailDestination.Text = TxtDestination.Text
        Me.DetailClass.Text = TxtClass.Text
        Me.DetailDiscount.Text = TxtDiscount.Text
        Me.DetailClassFees.Text = Format(classFee, "US$ ###,###")
        Me.DetailFlightFees.Text = Format(flightfee, "US$ ###,###")
        Me.DetailTotalFees.Text = Format(preTotalFee, "US$ ###,###")
        Me.DetailDiscountFees.Text = Format(discountFee, "US$ ###,###")
        Me.DetailFinalFees.Text = Format(finalFee, "US$ ###,###")
        Me.TxtPassengerFinalFee.Text = Format(finalFee, "US$ ###,###")
    End Sub

    Private Sub BtnPassengerClear_Click(sender As Object, e As EventArgs) Handles BtnPassengerClear.Click
        TxtName.Text = ""
        TxtNationality.Text = ""
        TxtGender.Text = ""
        TxtOrigin.Text = ""
        TxtDestination.Text = ""
        TxtClass.Text = ""
        TxtClass.Text = ""
        TxtDiscount.Text = ""

        DetailName.Text = "-"
        DetailNationality.Text = "-"
        DetailGender.Text = "-"
        DetailOrigin.Text = "-"
        DetailDestination.Text = "-"
        DetailClass.Text = "-"
        DetailDiscount.Text = "-"
        DetailClassFees.Text = "-"
        DetailFlightFees.Text = "-"
        DetailTotalFees.Text = "-"
        DetailDiscountFees.Text = "-"
        DetailFinalFees.Text = "-"
        TxtPassengerFinalFee.Text = "-"
    End Sub

    Private Sub BtnPassengerBook_Click(sender As Object, e As EventArgs) Handles BtnPassengerBook.Click
        If MsgBox("Are you sure want to book this ticket?", vbYesNo) = vbYes Then
            cmd = New MySqlCommand
            cmd.Connection = conn

            query = "INSERT INTO passenger VALUES ('','" & DetailName.Text & "', '" & DetailNationality.Text & "', '" & DetailGender.Text & "',
            '" & DetailOrigin.Text & "', '" & DetailDestination.Text & "', '" & DetailClass.Text & "', '" & classFee & "', '" & flightfee & "',
            '" & DetailDiscount.Text & "', '" & discountFee & "', '" & preTotalFee & "', '" & finalFee & "')"

            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            MsgBox("Ticket Successfully Purchased!", vbInformation, "Notification")

            TxtName.Text = ""
            TxtNationality.Text = ""
            TxtGender.Text = ""
            TxtOrigin.Text = ""
            TxtDestination.Text = ""
            TxtClass.Text = ""
            TxtClass.Text = ""
            TxtDiscount.Text = ""

            DetailName.Text = "-"
            DetailNationality.Text = "-"
            DetailGender.Text = "-"
            DetailOrigin.Text = "-"
            DetailDestination.Text = "-"
            DetailClass.Text = "-"
            DetailDiscount.Text = "-"
            DetailClassFees.Text = "-"
            DetailFlightFees.Text = "-"
            DetailTotalFees.Text = "-"
            DetailDiscountFees.Text = "-"
            DetailFinalFees.Text = "-"
            TxtPassengerFinalFee.Text = "-"
        End If
    End Sub

End Class