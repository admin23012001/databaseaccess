<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MySqlConnecting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpId = New System.Windows.Forms.TextBox()
        Me.tbpPrice = New System.Windows.Forms.TextBox()
        Me.tbpQty = New System.Windows.Forms.TextBox()
        Me.tbpName = New System.Windows.Forms.TextBox()
        Me.cbopType = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະຫັດສິນຄ້າ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ປະເພດສິນຄ້າ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ຊື່ສິນຄ້າ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ລາຄາ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ຈຳນວນ"
        '
        'tbpId
        '
        Me.tbpId.Location = New System.Drawing.Point(135, 25)
        Me.tbpId.Name = "tbpId"
        Me.tbpId.Size = New System.Drawing.Size(199, 20)
        Me.tbpId.TabIndex = 5
        '
        'tbpPrice
        '
        Me.tbpPrice.Location = New System.Drawing.Point(135, 132)
        Me.tbpPrice.Name = "tbpPrice"
        Me.tbpPrice.Size = New System.Drawing.Size(199, 20)
        Me.tbpPrice.TabIndex = 6
        '
        'tbpQty
        '
        Me.tbpQty.Location = New System.Drawing.Point(135, 171)
        Me.tbpQty.Name = "tbpQty"
        Me.tbpQty.Size = New System.Drawing.Size(199, 20)
        Me.tbpQty.TabIndex = 7
        '
        'tbpName
        '
        Me.tbpName.Location = New System.Drawing.Point(135, 92)
        Me.tbpName.Name = "tbpName"
        Me.tbpName.Size = New System.Drawing.Size(199, 20)
        Me.tbpName.TabIndex = 8
        '
        'cbopType
        '
        Me.cbopType.FormattingEnabled = True
        Me.cbopType.Location = New System.Drawing.Point(135, 60)
        Me.cbopType.Name = "cbopType"
        Me.cbopType.Size = New System.Drawing.Size(199, 21)
        Me.cbopType.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(71, 223)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 42)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "ເພີ່ມ"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(162, 223)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 42)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "ແກ້ໄຂ"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(259, 223)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 42)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "ລົບ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(378, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(604, 456)
        Me.DataGridView1.TabIndex = 13
        '
        'MySqlConnecting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 521)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cbopType)
        Me.Controls.Add(Me.tbpName)
        Me.Controls.Add(Me.tbpQty)
        Me.Controls.Add(Me.tbpPrice)
        Me.Controls.Add(Me.tbpId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MySqlConnecting"
        Me.Text = "MySqlConnecting"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbpId As TextBox
    Friend WithEvents tbpPrice As TextBox
    Friend WithEvents tbpQty As TextBox
    Friend WithEvents tbpName As TextBox
    Friend WithEvents cbopType As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
