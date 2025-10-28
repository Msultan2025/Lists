Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        Timer1.Enabled = False
        Label1.Text = DateString
    End Sub

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Timer1.Interval = 1000
        Timer1.Enabled = True



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now.ToString
    End Sub

    Private Sub ClockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockToolStripMenuItem.Click

    End Sub

    Private Sub DateAndTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateAndTimeToolStripMenuItem.Click

        Label1.Text = Now.ToString()
    End Sub

    Private Sub YearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem.Click
        Timer1.Enabled = False
        Label1.Text = Year(Now).ToString()
    End Sub

    Private Sub WeekdayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeekdayToolStripMenuItem.Click
        Timer1.Enabled = False
        Label1.Text = Hour(Now).ToString()

    End Sub

    Private Sub MonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthToolStripMenuItem.Click
        Timer1.Enabled = False
        Label1.Text = Month(Now).ToString()
    End Sub
End Class
