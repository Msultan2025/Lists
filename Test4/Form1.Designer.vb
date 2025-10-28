<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        ClockToolStripMenuItem = New ToolStripMenuItem()
        DataToolStripMenuItem = New ToolStripMenuItem()
        TimeToolStripMenuItem = New ToolStripMenuItem()
        DateAndTimeToolStripMenuItem = New ToolStripMenuItem()
        YearToolStripMenuItem = New ToolStripMenuItem()
        WeekdayToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Timer1 = New Timer(components)
        MonthToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClockToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(473, 31)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ClockToolStripMenuItem
        ' 
        ClockToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataToolStripMenuItem, TimeToolStripMenuItem})
        ClockToolStripMenuItem.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClockToolStripMenuItem.Name = "ClockToolStripMenuItem"
        ClockToolStripMenuItem.Size = New Size(65, 27)
        ClockToolStripMenuItem.Text = "Clock"
        ' 
        ' DataToolStripMenuItem
        ' 
        DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        DataToolStripMenuItem.Size = New Size(224, 28)
        DataToolStripMenuItem.Text = "&Date"
        ' 
        ' TimeToolStripMenuItem
        ' 
        TimeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DateAndTimeToolStripMenuItem, YearToolStripMenuItem, WeekdayToolStripMenuItem, MonthToolStripMenuItem})
        TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        TimeToolStripMenuItem.Size = New Size(224, 28)
        TimeToolStripMenuItem.Text = "&Time"
        ' 
        ' DateAndTimeToolStripMenuItem
        ' 
        DateAndTimeToolStripMenuItem.Name = "DateAndTimeToolStripMenuItem"
        DateAndTimeToolStripMenuItem.Size = New Size(224, 28)
        DateAndTimeToolStripMenuItem.Text = "&Date and Time"
        ' 
        ' YearToolStripMenuItem
        ' 
        YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        YearToolStripMenuItem.Size = New Size(224, 28)
        YearToolStripMenuItem.Text = "&Year"
        ' 
        ' WeekdayToolStripMenuItem
        ' 
        WeekdayToolStripMenuItem.Name = "WeekdayToolStripMenuItem"
        WeekdayToolStripMenuItem.Size = New Size(224, 28)
        WeekdayToolStripMenuItem.Text = "&Hour"
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(107, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 93)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' MonthToolStripMenuItem
        ' 
        MonthToolStripMenuItem.Name = "MonthToolStripMenuItem"
        MonthToolStripMenuItem.Size = New Size(224, 28)
        MonthToolStripMenuItem.Text = "&Month"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(473, 376)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateAndTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeekdayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthToolStripMenuItem As ToolStripMenuItem

End Class
