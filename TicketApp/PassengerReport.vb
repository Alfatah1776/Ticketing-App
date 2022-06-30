Imports MySql.Data.MySqlClient

Public Class PassengerReport

    Dim DS As DataSet
    Dim ReportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim Adapter As MySqlDataAdapter

    Private Sub PassengerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionReport()
        Me.WindowState = FormWindowState.Maximized
        data = "SELECT * FROM passenger"
        ReportDoc = New PassengerCrystalReport
        Adapter = New MySqlDataAdapter(data, conn)
        DS = New DataSet
        Adapter.Fill(DS, "Passenger Report")
        DS.WriteXmlSchema(Application.StartupPath & "PassengerReport.xsd")
        ReportDoc.SetDataSource(DS)
        CRVPassenger.ReportSource = ReportDoc
    End Sub
End Class