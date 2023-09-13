<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGoToErr = New Button()
        Label1 = New Label()
        txtnumber = New TextBox()
        SuspendLayout()
        ' 
        ' btnGoToErr
        ' 
        btnGoToErr.Location = New Point(344, 252)
        btnGoToErr.Name = "btnGoToErr"
        btnGoToErr.Size = New Size(112, 34)
        btnGoToErr.TabIndex = 0
        btnGoToErr.Text = "Go To Error"
        btnGoToErr.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter your number"
        ' 
        ' txtnumber
        ' 
        txtnumber.Location = New Point(341, 93)
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(150, 31)
        txtnumber.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtnumber)
        Controls.Add(Label1)
        Controls.Add(btnGoToErr)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGoToErr As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumber As TextBox
End Class
