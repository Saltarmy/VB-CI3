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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NPM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JURUSAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KELAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPM, Me.NAMA, Me.JURUSAN, Me.PRODI, Me.KELAS})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(788, 402)
        Me.DataGridView1.TabIndex = 0
        '
        'NPM
        '
        Me.NPM.HeaderText = "NPM"
        Me.NPM.Name = "NPM"
        '
        'NAMA
        '
        Me.NAMA.HeaderText = "NAMA"
        Me.NAMA.Name = "NAMA"
        '
        'JURUSAN
        '
        Me.JURUSAN.HeaderText = "JURUSAN"
        Me.JURUSAN.Name = "JURUSAN"
        '
        'PRODI
        '
        Me.PRODI.HeaderText = "PRODI"
        Me.PRODI.Name = "PRODI"
        '
        'KELAS
        '
        Me.KELAS.HeaderText = "KELAS"
        Me.KELAS.Name = "KELAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 426)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NPM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JURUSAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KELAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
