Imports System.Text.RegularExpressions

Public Class Form1
    Dim version As String = "0.2.1"
    Dim localConfig() As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updateStatus("Loading")
        rawDataBox.Text = ""
        If IO.File.Exists("C:\Users\" + Environment.UserName + "\AppData\LocalLow\Innersloth\Among Us\playerPrefs") Then
            ' The config file exists
            localConfig = IO.File.ReadAllText("C:\Users\" + Environment.UserName + "\AppData\LocalLow\Innersloth\Among Us\playerPrefs").Split(New Char() {","c})
            For Each var In localConfig
                Debug.WriteLine(var)
                rawDataBox.AppendText(var + Environment.NewLine)
            Next
            rawDataBox.Text = rawDataBox.Text.TrimEnd
            nameBox.Text = localConfig(0)
            cN.Value = localConfig(2)
            hatBox.Text = localConfig(10)
            skinBox.Text = localConfig(15)
            Dim selectedPet As Integer = Int16.Parse(localConfig(16).ToString)
            ComboBox1.SelectedIndex = selectedPet
        End If
        updateStatus("Loaded.")
    End Sub
    Public Sub Save()
        updateStatus("Saving")
        ' Set new data
        localConfig.SetValue(nameBox.Text, 0)
        localConfig.SetValue(cN.Value.ToString, 2)
        localConfig.SetValue(hatBox.Text, 10)
        localConfig.SetValue(skinBox.Text, 15)
        localConfig.SetValue(ComboBox1.SelectedIndex.ToString, 16)
        Dim saveData As String = String.Join(",", localConfig)
        If saveData.Last = "," Then
            saveData = saveData.Remove(saveData.Length - 1)
        End If

        Debug.WriteLine("C:\Users\" + Environment.UserName + "\AppData\LocalLow\Innersloth\Among Us\playerPrefs")
        IO.File.WriteAllText("C:\Users\" + Environment.UserName + "\AppData\LocalLow\Innersloth\Among Us\playerPrefs", saveData)
        Debug.WriteLine("Saving data : ")
        Debug.WriteLine(String.Join(",", localConfig))
        Debug.WriteLine("Done.")
        updateStatus("Saved.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Save()
    End Sub
    Private Sub changeColor(ByRef colorCode As Integer)

    End Sub

    Private Sub cN_ValueChanged(sender As Object, e As EventArgs) Handles cN.ValueChanged
        If cN.Value = 0 Then ' Red
            cN.BackColor = Color.Red
        End If
        If cN.Value = 1 Then ' Blue
            cN.BackColor = Color.Blue
        End If
        If cN.Value = 2 Then ' Green
            cN.BackColor = Color.Green
        End If
        If cN.Value = 3 Then  ' Pink
            cN.BackColor = Color.Magenta
        End If
        If cN.Value = 4 Then ' Orange
            cN.BackColor = Color.Orange
        End If
        If cN.Value = 5 Then ' Yellow
            cN.BackColor = Color.Yellow
        End If
        If cN.Value = 6 Then ' Black
            cN.BackColor = Color.DarkGreen
        End If
        If cN.Value = 7 Then ' White
            cN.BackColor = Color.White
        End If
        If cN.Value = 8 Then ' Purple
            cN.BackColor = Color.Purple
        End If
        If cN.Value = 9 Then ' Brown
            cN.BackColor = Color.Brown
        End If
        If cN.Value = 10 Then ' Cyan
            cN.BackColor = Color.Cyan
        End If
        If cN.Value = 11 Then ' Lime
            cN.BackColor = Color.Lime
        End If
        If cN.Value = 12 Then ' Glitch
            cN.BackColor = Color.DarkGreen
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub updateStatus(ByVal status As String)
        statusLabel.Text = status
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        updateStatus("Saving RAW")
        ' Set new data
        Dim saveData As String = String.Join(",", rawDataBox.Lines)
        If saveData.Last = "," Then
            saveData = saveData.Remove(saveData.Length - 1)
        End If
        Debug.WriteLine("C:\Users\" + Environment.UserName + "\AppData\LocalLow\Innersloth\Among Us\playerPrefs")
        IO.File.WriteAllText("C:\Users\" + Environment.UserName + "\AppData\LocalLow\Innersloth\Among Us\playerPrefs", saveData)
        Debug.WriteLine("Saving data : ")
        Debug.WriteLine("Done.")
        updateStatus("Saved RAW.")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        updateStatus("Loading RAW to GUI")
        Dim rawdatastr As String = ""
        For Each line In rawDataBox.Lines
            rawdatastr = rawdatastr + line + ","
        Next
        rawDataBox.Text = ""
        localConfig = rawdatastr.Split(New Char() {","c})
        For Each var In localConfig
            Debug.WriteLine(var)
            rawDataBox.AppendText(var + Environment.NewLine)
        Next
        rawDataBox.Text = rawDataBox.Text.TrimEnd
        nameBox.Text = localConfig(0)
        cN.Value = localConfig(2)
        hatBox.Text = localConfig(10)
        skinBox.Text = localConfig(15)
        Dim selectedPet As Integer = Int16.Parse(localConfig(16).ToString)
        ComboBox1.SelectedIndex = selectedPet
        updateStatus("Loaded RAW to GUI.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        updateStatus("Loading GUI to RAW")
        rawDataBox.Text = ""
        localConfig.SetValue(nameBox.Text, 0)
        localConfig.SetValue(cN.Value.ToString, 2)
        localConfig.SetValue(hatBox.Text, 10)
        localConfig.SetValue(skinBox.Text, 15)
        localConfig.SetValue(ComboBox1.SelectedIndex.ToString, 16)
        For Each var In localConfig
            Debug.WriteLine(var)
            rawDataBox.AppendText(var + Environment.NewLine)
        Next
        rawDataBox.Text = rawDataBox.Text.TrimEnd
        updateStatus("Loaded GUI to RAW.")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        versionTxt.Text = version
    End Sub
End Class
