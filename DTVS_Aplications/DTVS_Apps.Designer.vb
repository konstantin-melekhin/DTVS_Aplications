<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DTVS_Apps
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DG_Applications = New System.Windows.Forms.DataGridView()
        CType(Me.DG_Applications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_Applications
        '
        Me.DG_Applications.AllowUserToAddRows = False
        Me.DG_Applications.AllowUserToDeleteRows = False
        Me.DG_Applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Applications.Location = New System.Drawing.Point(21, 46)
        Me.DG_Applications.Name = "DG_Applications"
        Me.DG_Applications.ReadOnly = True
        Me.DG_Applications.Size = New System.Drawing.Size(1031, 546)
        Me.DG_Applications.TabIndex = 0
        '
        'DTVS_Apps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 696)
        Me.Controls.Add(Me.DG_Applications)
        Me.Name = "DTVS_Apps"
        Me.Text = "DTVS Aplications"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_Applications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DG_Applications As DataGridView
End Class
