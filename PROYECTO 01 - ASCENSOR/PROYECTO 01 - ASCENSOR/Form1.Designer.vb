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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.manteEL1 = New System.Windows.Forms.RadioButton()
        Me.desdeEL1 = New System.Windows.Forms.NumericUpDown()
        Me.hastaEL1 = New System.Windows.Forms.NumericUpDown()
        Me.todosEL1 = New System.Windows.Forms.RadioButton()
        Me.inparesEL1 = New System.Windows.Forms.RadioButton()
        Me.paresEL1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.manteEL2 = New System.Windows.Forms.RadioButton()
        Me.TodosEL2 = New System.Windows.Forms.RadioButton()
        Me.inparesEL2 = New System.Windows.Forms.RadioButton()
        Me.paresEL2 = New System.Windows.Forms.RadioButton()
        Me.desdeEL2 = New System.Windows.Forms.NumericUpDown()
        Me.hastaEL2 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.desdeEL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hastaEL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.desdeEL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hastaEL2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.manteEL1)
        Me.GroupBox1.Controls.Add(Me.desdeEL1)
        Me.GroupBox1.Controls.Add(Me.hastaEL1)
        Me.GroupBox1.Controls.Add(Me.todosEL1)
        Me.GroupBox1.Controls.Add(Me.inparesEL1)
        Me.GroupBox1.Controls.Add(Me.paresEL1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(38, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 253)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controles elevador 1"
        '
        'manteEL1
        '
        Me.manteEL1.AutoSize = True
        Me.manteEL1.Location = New System.Drawing.Point(17, 220)
        Me.manteEL1.Name = "manteEL1"
        Me.manteEL1.Size = New System.Drawing.Size(131, 24)
        Me.manteEL1.TabIndex = 10
        Me.manteEL1.TabStop = True
        Me.manteEL1.Text = "Mantenimiento"
        Me.manteEL1.UseVisualStyleBackColor = True
        '
        'desdeEL1
        '
        Me.desdeEL1.Location = New System.Drawing.Point(87, 74)
        Me.desdeEL1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.desdeEL1.Name = "desdeEL1"
        Me.desdeEL1.Size = New System.Drawing.Size(74, 27)
        Me.desdeEL1.TabIndex = 9
        '
        'hastaEL1
        '
        Me.hastaEL1.Location = New System.Drawing.Point(87, 26)
        Me.hastaEL1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.hastaEL1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hastaEL1.Name = "hastaEL1"
        Me.hastaEL1.Size = New System.Drawing.Size(74, 27)
        Me.hastaEL1.TabIndex = 8
        Me.hastaEL1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'todosEL1
        '
        Me.todosEL1.AutoSize = True
        Me.todosEL1.Location = New System.Drawing.Point(18, 190)
        Me.todosEL1.Name = "todosEL1"
        Me.todosEL1.Size = New System.Drawing.Size(70, 24)
        Me.todosEL1.TabIndex = 7
        Me.todosEL1.TabStop = True
        Me.todosEL1.Text = "Todos"
        Me.todosEL1.UseVisualStyleBackColor = True
        '
        'inparesEL1
        '
        Me.inparesEL1.AutoSize = True
        Me.inparesEL1.Location = New System.Drawing.Point(18, 159)
        Me.inparesEL1.Name = "inparesEL1"
        Me.inparesEL1.Size = New System.Drawing.Size(120, 24)
        Me.inparesEL1.TabIndex = 6
        Me.inparesEL1.TabStop = True
        Me.inparesEL1.Text = "Pisos impares"
        Me.inparesEL1.UseVisualStyleBackColor = True
        '
        'paresEL1
        '
        Me.paresEL1.AutoSize = True
        Me.paresEL1.Location = New System.Drawing.Point(18, 129)
        Me.paresEL1.Name = "paresEL1"
        Me.paresEL1.Size = New System.Drawing.Size(103, 24)
        Me.paresEL1.TabIndex = 5
        Me.paresEL1.TabStop = True
        Me.paresEL1.Text = "Pisos pares"
        Me.paresEL1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.manteEL2)
        Me.GroupBox2.Controls.Add(Me.TodosEL2)
        Me.GroupBox2.Controls.Add(Me.inparesEL2)
        Me.GroupBox2.Controls.Add(Me.paresEL2)
        Me.GroupBox2.Controls.Add(Me.desdeEL2)
        Me.GroupBox2.Controls.Add(Me.hastaEL2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 248)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles elevador 2"
        '
        'manteEL2
        '
        Me.manteEL2.AutoSize = True
        Me.manteEL2.Location = New System.Drawing.Point(18, 214)
        Me.manteEL2.Name = "manteEL2"
        Me.manteEL2.Size = New System.Drawing.Size(131, 24)
        Me.manteEL2.TabIndex = 7
        Me.manteEL2.TabStop = True
        Me.manteEL2.Text = "Mantenimiento"
        Me.manteEL2.UseVisualStyleBackColor = True
        '
        'TodosEL2
        '
        Me.TodosEL2.AutoSize = True
        Me.TodosEL2.Location = New System.Drawing.Point(17, 183)
        Me.TodosEL2.Name = "TodosEL2"
        Me.TodosEL2.Size = New System.Drawing.Size(70, 24)
        Me.TodosEL2.TabIndex = 6
        Me.TodosEL2.TabStop = True
        Me.TodosEL2.Text = "Todos"
        Me.TodosEL2.UseVisualStyleBackColor = True
        '
        'inparesEL2
        '
        Me.inparesEL2.AutoSize = True
        Me.inparesEL2.Location = New System.Drawing.Point(18, 153)
        Me.inparesEL2.Name = "inparesEL2"
        Me.inparesEL2.Size = New System.Drawing.Size(120, 24)
        Me.inparesEL2.TabIndex = 5
        Me.inparesEL2.TabStop = True
        Me.inparesEL2.Text = "Pisos impares"
        Me.inparesEL2.UseVisualStyleBackColor = True
        '
        'paresEL2
        '
        Me.paresEL2.AutoSize = True
        Me.paresEL2.Location = New System.Drawing.Point(18, 122)
        Me.paresEL2.Name = "paresEL2"
        Me.paresEL2.Size = New System.Drawing.Size(103, 24)
        Me.paresEL2.TabIndex = 4
        Me.paresEL2.TabStop = True
        Me.paresEL2.Text = "Pisos pares"
        Me.paresEL2.UseVisualStyleBackColor = True
        '
        'desdeEL2
        '
        Me.desdeEL2.Location = New System.Drawing.Point(87, 81)
        Me.desdeEL2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.desdeEL2.Name = "desdeEL2"
        Me.desdeEL2.Size = New System.Drawing.Size(74, 27)
        Me.desdeEL2.TabIndex = 3
        '
        'hastaEL2
        '
        Me.hastaEL2.Location = New System.Drawing.Point(87, 47)
        Me.hastaEL2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.hastaEL2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hastaEL2.Name = "hastaEL2"
        Me.hastaEL2.Size = New System.Drawing.Size(74, 27)
        Me.hastaEL2.TabIndex = 2
        Me.hastaEL2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.desdeEL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hastaEL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.desdeEL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hastaEL2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents desdeEL1 As NumericUpDown
    Friend WithEvents hastaEL1 As NumericUpDown
    Friend WithEvents todosEL1 As RadioButton
    Friend WithEvents inparesEL1 As RadioButton
    Friend WithEvents paresEL1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TodosEL2 As RadioButton
    Friend WithEvents inparesEL2 As RadioButton
    Friend WithEvents paresEL2 As RadioButton
    Friend WithEvents desdeEL2 As NumericUpDown
    Friend WithEvents hastaEL2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents manteEL1 As RadioButton
    Friend WithEvents manteEL2 As RadioButton
    Friend WithEvents Timer2 As Timer
End Class
