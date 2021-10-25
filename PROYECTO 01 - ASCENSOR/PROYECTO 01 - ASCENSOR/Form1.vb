Public Class Form1
    Private floors As Integer = 11
    Private ElevatorCount As Integer = 2
    Dim indexNextE1 As Integer = 0
    Dim indexNextE2 As Integer = 0
    Dim obj_Elevator1 As New Ascensor()
    Dim obj_Elevator2 As New Ascensor()
    Dim Index As Integer = 0
    Dim Index2 As Integer = 0
    Dim floors_list As List(Of floors) = New List(Of floors)()
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hastaEL1.Value = 10
        hastaEL2.Value = 10
        todosEL1.Checked = True
        TodosEL2.Checked = True
        Create_Building()
    End Sub

    'funcion para crear el edificio'
    Private Sub Create_Building()
        Dim xyLeft As Integer = 450
        Dim xyTop As Integer = 10

        Dim width As Integer = 40
        Dim height As Integer = 40


        For i As Integer = floors - 1 To 0 Step -1
            Dim createFloor = New floors()
            If i <> 10 Then
                'agregando boton para subir'
                Dim btnUp As New Button
                btnUp.AccessibleName = xyTop.ToString
                btnUp.Left = xyLeft
                btnUp.Top = xyTop
                btnUp.Text = "^"
                btnUp.Height = height
                btnUp.Width = width
                btnUp.Visible = True
                btnUp.FlatStyle = FlatStyle.Flat
                btnUp.FlatAppearance.BorderColor = Color.Gray
                AddHandler btnUp.Click, AddressOf OnBtnUp_click
                createFloor.SetbtnUp(btnUp)
                Me.Controls.Add(createFloor.GetbtnUp)
            End If

            'agregando Número de piso'
            Dim txtFloor As New Label
            txtFloor.Text = i.ToString
            txtFloor.Left = xyLeft + 50
            txtFloor.Top = xyTop + 10
            txtFloor.Width = 20
            txtFloor.Visible = True
            createFloor.name_value = i.ToString()
            createFloor.Xvalue = xyLeft
            createFloor.Yvalue = xyTop
            floors_list.Add(createFloor)
            Me.Controls.Add(txtFloor)

            If i <> 0 Then
                'agregando boton para bajar'
                Dim btnDown As New Button
                btnDown.Text = "v"

                btnDown.Height = height
                btnDown.Width = width
                btnDown.Left = xyLeft + 70
                btnDown.Top = xyTop
                btnDown.Visible = True
                btnDown.FlatStyle = FlatStyle.Flat
                btnDown.FlatAppearance.BorderColor = Color.Gray
                AddHandler btnDown.Click, AddressOf OnBtnDown_click
                createFloor.SetbtnDown(btnDown)
                Me.Controls.Add(createFloor.GetbtnDown)
            End If

            xyTop += 45
        Next
        Dim btnElevator1 As New Button
        btnElevator1.Text = "0"
        btnElevator1.Height = height
        btnElevator1.Width = width
        btnElevator1.Left = xyLeft + 120
        btnElevator1.Top = xyTop - 45
        btnElevator1.Visible = True
        btnElevator1.BackColor = Color.Yellow
        btnElevator1.FlatStyle = FlatStyle.Flat

        Dim btnElevator2 As New Button
        btnElevator2.Text = "0"
        btnElevator2.Height = height
        btnElevator2.Width = width
        btnElevator2.Left = xyLeft + 170
        btnElevator2.Top = xyTop - 45
        btnElevator2.Visible = True
        btnElevator2.BackColor = Color.Yellow
        btnElevator2.FlatStyle = FlatStyle.Flat

        obj_Elevator1.SetElevator(btnElevator1)
        obj_Elevator2.SetElevator(btnElevator2)
        Me.Controls.Add(obj_Elevator1.GetElevator())
        Me.Controls.Add(obj_Elevator2.GetElevator())
    End Sub
    'evento de subir'
    Private Sub OnBtnUp_click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btn = CType(sender, Button)
        Dim btnElevatorE1 = CType(obj_Elevator1.GetElevator(), Button)
        Dim btnElevatorE2 = CType(obj_Elevator2.GetElevator(), Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderColor = Color.Blue

        Dim numfloor As Integer

        For Each floor As floors In floors_list
            If btn.Location.Y = floor.Yvalue Then
                floor.UP_value = True
                numfloor = floor.name_value
            End If
        Next
        Dim distanceE1 = Math.Abs(numfloor - btnElevatorE1.Text)
        Dim distanceE2 = Math.Abs(numfloor - btnElevatorE2.Text)

        Timer1.Start()
    End Sub
    'evento de bajar'
    Private Sub OnBtnDown_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn = CType(sender, Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderColor = Color.Blue

        Dim numfloor As Integer

        For Each floor As floors In floors_list
            If btn.Location.Y = floor.Yvalue Then
                floor.Down_value = True
                numfloor = floor.name_value
            End If
        Next

        Timer2.Start()
    End Sub
    'Timer elevador 1'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (floors_list.Count > Index) Then
            Dim floor As floors = floors_list(Index)
            Dim checkMotion As Boolean = obj_Elevator1.CheckElevator(floor.name_value)
            If (checkMotion) Then
                If (floor.UP_value) Then
                    If ValidateE2FloorTomove(floor, 1) Then
                        obj_Elevator1.MotionToFloor = floor.name_value
                        obj_Elevator1.MotionDirection = 1
                        MotionElevator(floor, obj_Elevator1, 1)
                        indexNextE1 = nextIndexup(Index)
                    Else
                        Index += 1
                    End If
                ElseIf (floor.Down_value) Then
                    If ValidateE2FloorTomove(floor, 2) Then
                        obj_Elevator1.MotionToFloor = floor.name_value
                        obj_Elevator1.MotionDirection = 2
                        MotionElevator(floor, obj_Elevator1, 2)

                    Else
                        Index += 1
                    End If
                Else
                    If indexNextE1 <> 0 Then
                        Index = indexNextE1
                        indexNextE1 = 0
                    Else
                        Index += 1
                    End If
                End If
            Else
                Index += 1
            End If
        Else
            Index = 0
            'Timer1.Stop()'
        End If

    End Sub
    'timer elevador 2'
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If (floors_list.Count > Index2) Then
            Dim floor As floors = floors_list(Index2)
            Dim checkMotion As Boolean = obj_Elevator2.CheckElevator(floor.name_value)
            If (checkMotion) Then
                If (floor.UP_value) Then
                    If ValidateE1FloorTomove(floor, 1) Then
                        obj_Elevator2.MotionToFloor = floor.name_value
                        obj_Elevator2.MotionDirection = 1
                        MotionElevator(floor, obj_Elevator2, 1)
                        indexNextE2 = nextIndexup(Index2)
                    Else
                        Index2 += 1
                    End If
                ElseIf (floor.Down_value) Then
                    If ValidateE1FloorTomove(floor, 2) Then
                        obj_Elevator2.MotionToFloor = floor.name_value
                        obj_Elevator2.MotionDirection = 2
                        MotionElevator(floor, obj_Elevator2, 2)
                    Else
                        Index2 += 1
                    End If
                Else
                    If indexNextE2 <> 0 Then
                        Index2 = indexNextE2
                        indexNextE2 = 0
                    Else
                        Index2 += 1
                    End If
                End If
            Else
                Index2 += 1
                'Timer2.Stop()'
            End If
        Else
            Index2 = 0
            'Timer1.Stop()'
        End If
    End Sub
    'buscar siguiente piso en la misma direccion'
    Private Function nextIndexup(index As Integer)
        Dim resultindex As Integer = 0
        For i As Integer = index - 1 To 0 Step -1

            If (floors_list(i).UP_value = True) Then
                resultindex = i
                Exit For
            End If
        Next
        Return resultindex
    End Function
    'valido si el elevado esta en moviento en la misma direccion del piso para evitar tomarlo'
    Private Function ValidateE2FloorTomove(floor As floors, direction As Integer) As Boolean
        Dim result As Boolean = True
        If obj_Elevator2.MotionDirection = direction Then
            result = False
        End If
        Return result
    End Function
    Private Function ValidateE1FloorTomove(floor As floors, direction As Integer) As Boolean
        Dim result As Boolean = True
        If obj_Elevator1.MotionDirection = direction Then
            result = False
        End If
        Return result
    End Function
    'funcion para hacer los movimientos de los elevadores'
    Private Sub MotionElevator(floor As floors, elevator As Ascensor, direction As Integer)
        Dim jump As Integer = 5
        If floor.Yvalue > elevator.Y Then
            jump = 5
        ElseIf floor.Yvalue < elevator.Y Then
            jump = -5
        End If

        If elevator.Y = floor.Yvalue Then
            resetState(floor, elevator, direction)
        Else
            elevator.SetPosition(jump)
            For Each floorcheck As floors In floors_list
                If elevator.Y = floorcheck.Yvalue Then
                    If elevator.Y = floor.Yvalue Then
                        resetState(floor, elevator, direction)
                        Exit For
                    End If
                    elevator.SetText(floorcheck.name_value)
                Else
                    Dim btn As Button = CType(elevator.GetElevator, Button)
                    btn.BackColor = Color.LightGreen
                    If direction = 1 Then
                        btn.FlatAppearance.BorderColor = Color.Red
                    ElseIf direction = 2 Then
                        btn.FlatAppearance.BorderColor = Color.Blue
                    End If
                End If
            Next
        End If
    End Sub
    'funcion para resetear un elavador, cuando llega al piso y espere 3 segundo'
    Private Sub resetState(floor As floors, elevator As Ascensor, direction As Integer)
        If (floor.UP_value) Then
            floor.UP_value = False
        ElseIf floor.Down_value Then
            floor.Down_value = False
        End If

        elevator.SetText(floor.name_value)
        Dim btn As Button
        If direction = 1 Then
            btn = CType(floor.GetbtnUp, Button)
            btn.FlatAppearance.BorderColor = Color.Gray
        ElseIf direction = 2 Then
            btn = CType(floor.GetbtnDown, Button)
            btn.FlatAppearance.BorderColor = Color.Gray
        End If

        Dim btnelevator As Button = CType(elevator.GetElevator, Button)
        btnelevator.BackColor = Color.Yellow
        btnelevator.FlatAppearance.BorderColor = Color.Gray
        elevator.MotionDirection = 0
        elevator.MotionToFloor = 0
        Sleep(3)
    End Sub

    '#eventos'
    'eventos de panel de control elavador 1'
    Private Sub hastaEL1_ValueChanged(sender As Object, e As EventArgs) Handles hastaEL1.ValueChanged
        Dim hasta = CType(sender, NumericUpDown)
        obj_Elevator1.Hastavalue = hasta.Value
    End Sub

    Private Sub desdeEL1_ValueChanged(sender As Object, e As EventArgs) Handles desdeEL1.ValueChanged
        Dim desde = CType(sender, NumericUpDown)
        obj_Elevator1.Desdevalue = desde.Value
    End Sub

    Private Sub paresEL1_CheckedChanged(sender As Object, e As EventArgs) Handles paresEL1.CheckedChanged
        Dim pares = CType(sender, RadioButton)
        obj_Elevator1.Parvalue = pares.Checked
    End Sub

    Private Sub inparesEL1_CheckedChanged(sender As Object, e As EventArgs) Handles inparesEL1.CheckedChanged
        Dim impar = CType(sender, RadioButton)
        obj_Elevator1.Imparvalue = impar.Checked
    End Sub

    Private Sub todosEL1_CheckedChanged(sender As Object, e As EventArgs) Handles todosEL1.CheckedChanged
        Dim todos = CType(sender, RadioButton)
        obj_Elevator1.Todosvalue = todos.Checked
    End Sub

    Private Sub manteEL1_CheckedChanged(sender As Object, e As EventArgs) Handles manteEL1.CheckedChanged
        Dim mante = CType(sender, RadioButton)
        obj_Elevator1.Mantevalue = mante.Checked
        Dim btn As Button = CType(obj_Elevator1.GetElevator, Button)
        If (mante.Checked) Then
            btn.BackColor = Color.Red
        Else
            btn.BackColor = Color.Yellow
        End If
    End Sub
    'eventos de panel de control elavador 2'
    Private Sub hastaEL2_ValueChanged(sender As Object, e As EventArgs) Handles hastaEL2.ValueChanged
        Dim hasta = CType(sender, NumericUpDown)
        obj_Elevator2.Hastavalue = hasta.Value
    End Sub

    Private Sub desdeEL2_ValueChanged(sender As Object, e As EventArgs) Handles desdeEL2.ValueChanged
        Dim desde = CType(sender, NumericUpDown)
        obj_Elevator2.Desdevalue = desde.Value
    End Sub

    Private Sub paresEL2_CheckedChanged(sender As Object, e As EventArgs) Handles paresEL2.CheckedChanged
        Dim pares = CType(sender, RadioButton)
        obj_Elevator2.Parvalue = pares.Checked
    End Sub

    Private Sub inparesEL2_CheckedChanged(sender As Object, e As EventArgs) Handles inparesEL2.CheckedChanged
        Dim impar = CType(sender, RadioButton)
        obj_Elevator2.Imparvalue = impar.Checked
    End Sub

    Private Sub todosEL2_CheckedChanged(sender As Object, e As EventArgs) Handles TodosEL2.CheckedChanged
        Dim todos = CType(sender, RadioButton)
        obj_Elevator2.Todosvalue = todos.Checked
    End Sub

    Private Sub manteEL2_CheckedChanged(sender As Object, e As EventArgs) Handles manteEL2.CheckedChanged
        Dim mante = CType(sender, RadioButton)
        obj_Elevator2.Mantevalue = mante.Checked
        Dim btn As Button = CType(obj_Elevator2.GetElevator, Button)
        If (mante.Checked) Then
            btn.BackColor = Color.Red
        Else
            btn.BackColor = Color.Yellow
        End If

    End Sub
End Class
