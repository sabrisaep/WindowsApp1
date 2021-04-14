<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nudJumlahPelajar = New System.Windows.Forms.NumericUpDown()
        Me.BtnKira = New System.Windows.Forms.Button()
        Me.lblJumlahMakmal = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudJumlahPelajar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudJumlahPelajar
        '
        Me.nudJumlahPelajar.Location = New System.Drawing.Point(126, 64)
        Me.nudJumlahPelajar.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudJumlahPelajar.Name = "nudJumlahPelajar"
        Me.nudJumlahPelajar.Size = New System.Drawing.Size(120, 20)
        Me.nudJumlahPelajar.TabIndex = 0
        '
        'BtnKira
        '
        Me.BtnKira.Location = New System.Drawing.Point(128, 99)
        Me.BtnKira.Name = "BtnKira"
        Me.BtnKira.Size = New System.Drawing.Size(75, 23)
        Me.BtnKira.TabIndex = 1
        Me.BtnKira.Text = "Button1"
        Me.BtnKira.UseVisualStyleBackColor = True
        '
        'lblJumlahMakmal
        '
        Me.lblJumlahMakmal.AutoSize = True
        Me.lblJumlahMakmal.Location = New System.Drawing.Point(130, 141)
        Me.lblJumlahMakmal.Name = "lblJumlahMakmal"
        Me.lblJumlahMakmal.Size = New System.Drawing.Size(39, 13)
        Me.lblJumlahMakmal.TabIndex = 2
        Me.lblJumlahMakmal.Text = "Label1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(453, 72)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblJumlahMakmal)
        Me.Controls.Add(Me.BtnKira)
        Me.Controls.Add(Me.nudJumlahPelajar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudJumlahPelajar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudJumlahPelajar As NumericUpDown
    Friend WithEvents BtnKira As Button
    Friend WithEvents lblJumlahMakmal As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
