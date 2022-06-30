Imports MySql.Data.MySqlClient

Public Class AdminForm
    Dim id, flightfee, classFee, discountFee, preTotalFee, finalFee As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        ShowData()
    End Sub

    Sub ShowData()
        DS = New DataSet
        query = "SELECT * FROM passenger"
        DA = New MySqlDataAdapter(query, conn)
        DA.Fill(DS)

        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        'Dim flightfee As Double
        If TxtOrigin.Text = "Berlin" And TxtDestination.Text = "Philadelphia" Then
            flightfee = 1000
        ElseIf TxtOrigin.Text = "Berlin" And TxtDestination.Text = "Hiroshima" Then
            flightfee = 2000
        ElseIf TxtOrigin.Text = "Philadelphia" And TxtDestination.Text = "Hiroshima" Then
            flightfee = 1500
        End If


        'Dim classFee As Double
        If TxtTravelClass.Text = "First Class" Then
            classFee = 500
        ElseIf TxtTravelClass.Text = "Business Class" Then
            classFee = 250
        ElseIf TxtTravelClass.Text = "Economy Class" Then
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


        TxtTotalFees.Text = Format(finalFee, "US$ ###,###")
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        cmd = New MySqlCommand
        cmd.Connection = conn

        query = "INSERT INTO passenger VALUES ('','" & TxtName.Text & "', '" & TxtNationality.Text & "', '" & TxtGender.Text & "', '" & TxtOrigin.Text & "',
        '" & TxtDestination.Text & "', '" & TxtTravelClass.Text & "', '" & classFee & "', '" & flightfee & "', '" & TxtDiscount.Text & "', '" & discountFee & "', 
        '" & preTotalFee & "', '" & finalFee & "')"

        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MsgBox("Insert success", vbInformation, "Notification")

        TxtName.Text = ""
        TxtNationality.Text = ""
        TxtGender.Text = ""
        TxtOrigin.Text = ""
        TxtDestination.Text = ""
        TxtTravelClass.Text = ""
        TxtDiscount.Text = ""
        TxtTotalFees.Text = ""

        ShowData()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If MsgBox("Are you sure want to save the changes?", vbYesNo) = vbYes Then
            cmd = New MySqlCommand
            cmd.Connection = conn

            query = "UPDATE passenger Set Name='" & TxtName.Text & "', Nationality='" & TxtNationality.Text & "', Gender='" & TxtGender.Text & "', Origin='" & TxtOrigin.Text & "', 
            Destination='" & TxtDestination.Text & "', `Travel Class`='" & TxtTravelClass.Text & "', `Class Fees`='" & classFee & "', `Flight Fees`='" & flightfee & "',
            Discount='" & TxtDiscount.Text & "', `Discount Fees`='" & discountFee & "', `Pre Total`='" & preTotalFee & "', `Total Fees`='" & finalFee & "' WHERE ID='" & id & "'"

            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            MsgBox("Edit successful", vbInformation, "Notification")

            TxtName.Text = ""
            TxtNationality.Text = ""
            TxtGender.Text = ""
            TxtOrigin.Text = ""
            TxtDestination.Text = ""
            TxtTravelClass.Text = ""
            TxtDiscount.Text = ""
            TxtTotalFees.Text = ""

            ShowData()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        id = DataGridView1.Item(0, i).Value
        TxtName.Text = DataGridView1.Item(1, i).Value
        TxtNationality.Text = DataGridView1.Item(2, i).Value
        TxtGender.Text = DataGridView1.Item(3, i).Value
        TxtOrigin.Text = DataGridView1.Item(4, i).Value
        TxtDestination.Text = DataGridView1.Item(5, i).Value
        TxtTravelClass.Text = DataGridView1.Item(6, i).Value
        TxtDiscount.Text = DataGridView1.Item(9, i).Value
        TxtTotalFees.Text = DataGridView1.Item(12, i).Value
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MsgBox("Are you sure want to remove this passenger?", vbYesNo) = vbYes Then
            cmd = New MySqlCommand
            cmd.Connection = conn

            query = "DELETE FROM passenger WHERE id = '" & id & "'"

            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            MsgBox("Passenger successfuly deleted", vbInformation, "Notification")

            TxtName.Text = ""
            TxtNationality.Text = ""
            TxtGender.Text = ""
            TxtOrigin.Text = ""
            TxtDestination.Text = ""
            TxtTravelClass.Text = ""
            TxtDiscount.Text = ""
            TxtTotalFees.Text = ""

            ShowData()
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        TxtName.Text = ""
        TxtNationality.Text = ""
        TxtGender.Text = ""
        TxtOrigin.Text = ""
        TxtDestination.Text = ""
        TxtTravelClass.Text = ""
        TxtDiscount.Text = ""
        TxtTotalFees.Text = ""

        ShowData()
    End Sub

    'Do Not Try This
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Restart()
    End Sub
End Class
