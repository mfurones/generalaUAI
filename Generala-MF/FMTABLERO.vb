Public Class FMTABLERO

    'variable sobre la cual el formulario guarda el juego para operar
    'lo declaro con eventos
    Dim WithEvents _GeneralaBLL As BLL.GENERALA
    'lista de puntajes temporales posibles de un jugador dentro de la tirada para luego ser asignada
    Dim _tempPuntaje As List(Of Integer)

    'Carga el formulario del Tablero.
    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargo el juego nuevo
        _GeneralaBLL = New BLL.GENERALA

        'tomo los usuarios de una nueva partida y los coloco en una lista de PLAYERS
        Dim PL As New List(Of BLL.PLAYER)
        For Each i In FMCONTENEDOR.liUSRPartida
            PL.Add(New BLL.PLAYER With {.usuarioBE = i})
        Next
        'le agrego la lista de players al juego
        _GeneralaBLL.agregarPlayers(PL)

        'pongo en 0 todos los datos de la GUI
        actualizarEstadoJuego()
        limpiaDados()
        cambiarEstadoBA(False)
        actualizarTempPuntaje(False)

    End Sub

#Region "Actualizar labels"
    'contiene todo lo que hay que refrescar por cada jugada
    Private Sub actualizarEstadoJuego()
        'genera el siguiente turno
        _GeneralaBLL.turnoNext()
        'muestra la tirada en curso
        LNumeroJugada.Text = _GeneralaBLL.generalaBE.rondas

        'actualiza label Jugador
        LTurnoJugador.Text = _GeneralaBLL.liPlayers.Item(_GeneralaBLL.generalaBE.turno).usuarioBE.usuario
        'actualiza el label de numero de tirada
        LNumeroTirada.Text = _GeneralaBLL.generalaBE.numeroJugada
        'actualiza la tabla de puntajes para cada jugador
        For i As Integer = 0 To (_GeneralaBLL.liPlayers.Count - 1)
            refreshScore(i)
        Next
    End Sub

    'se utiliza para realizar la actualizacion de los puntajes ya cargados.
    Private Sub refreshScore(jugador As Integer)
        Dim lb1 As String, lb2 As String
        'aca guardo el control a buscar
        Dim c As Control
        For i As Integer = 0 To 10
            lb1 = "SJ" & jugador + 1 & "A" & i
            For Each c In Me.Controls
                If c.Name = lb1 Then
                    c.Text = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorValor.Item(i)
                End If

            Next
        Next
        'armo un texto con el nombre del "label" que voy a buscar
        lb1 = "SJ" & jugador + 1 & "Resultado"
        lb2 = "LJugador" & jugador + 1
        'recorro todos los controles para encontrar el control del "label" que quiero buscar
        For Each c In Me.Controls
            'chequeo el nombre del "label" que busco
            If c.Name = lb1 Then
                'asigno el contenido de informacion que necesito al "label" encontrado
                c.Text = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.resultado
            End If
            If c.Name = lb2 Then
                c.Text = _GeneralaBLL.liPlayers.Item(jugador).usuarioBE.usuario
            End If

        Next
    End Sub

    'Actualiza los labels correspondientes al puntaje temporario
    Private Sub actualizarTempPuntaje(boo As Boolean)
        Dim lb As String
        Dim c As Control
        For i As Integer = 0 To 10
            lb = "LST" & i
            For Each c In Me.Controls
                If c.Name = lb Then
                    If boo Then
                        c.Text = _tempPuntaje.Item(i)
                    Else
                        c.Text = ""
                    End If
                End If
            Next
        Next
    End Sub

#End Region

#Region "Checkbox Dados"
    'Cambia el "enabled" de los checkers
    Private Sub EstadoCheckers(boo As Boolean)
        CBD1.Enabled = boo
        CBD2.Enabled = boo
        CBD3.Enabled = boo
        CBD4.Enabled = boo
        CBD5.Enabled = boo
    End Sub

    'Se utiliza para deschequear los dados, asi como tambien para limpiarlos
    Private Sub limpiaDados()
        CBD1.Checked = False
        CBD2.Checked = False
        CBD3.Checked = False
        CBD4.Checked = False
        CBD5.Checked = False

        EstadoCheckers(False)

        CBD1.Text = ""
        CBD2.Text = ""
        CBD3.Text = ""
        CBD4.Text = ""
        CBD5.Text = ""
    End Sub

    'actualiza los dados de un lanzamiento de un jugador
    Private Sub mostrarDados(j As Integer)
        CBD1.Text = (_GeneralaBLL.liPlayers.Item(j).liDados.Item(0).cara)
        CBD2.Text = (_GeneralaBLL.liPlayers.Item(j).liDados.Item(1).cara)
        CBD3.Text = (_GeneralaBLL.liPlayers.Item(j).liDados.Item(2).cara)
        CBD4.Text = (_GeneralaBLL.liPlayers.Item(j).liDados.Item(3).cara)
        CBD5.Text = (_GeneralaBLL.liPlayers.Item(j).liDados.Item(4).cara)
    End Sub

#End Region

#Region "Botones de asignacion de resultados"

    'Se usa para habilitar o deshabilitar los botones que ingresan los puntos
    Private Sub cambiarEstadoBA(boo As Boolean)
        BAD1.Enabled = boo
        BAD2.Enabled = boo
        BAD3.Enabled = boo
        BAD4.Enabled = boo
        BAD5.Enabled = boo
        BAD6.Enabled = boo
        BAEscalera.Enabled = boo
        BAFull.Enabled = boo
        BAPoker.Enabled = boo
        BAGenerala.Enabled = boo
        BAGeneralaD.Enabled = boo
    End Sub

    'activa los botones segun el jugador indicado
    Private Sub activarEstadoBA(jugador As Integer)
        BAD1.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(1)
        BAD2.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(2)
        BAD3.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(3)
        BAD4.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(4)
        BAD5.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(5)
        BAD6.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(6)
        BAEscalera.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(7)
        BAFull.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(8)
        BAPoker.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(9)
        BAGenerala.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(10)
        BAGeneralaD.Enabled = _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(0)
    End Sub

    'carga los valores conseguido en el juego a un jugador
    Private Sub cargarPuntaje(jugador As Integer, pos As Integer)
        _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorValor.Item(pos) = _tempPuntaje.Item(pos)
        _GeneralaBLL.liPlayers.Item(jugador).planillaBLL.planillaBE.anotadorEstado.Item(pos) = False
    End Sub

    'Simplemente agrupo acciones en un solo metodo comunes a todos los botones
    Private Sub agrupadorMedtodosBA()

        '#######################
        '### Pre-Condiciones ###
        '#######################



        '###########################
        '### Ejecucion del juego ###
        '###########################


        '########################
        '### Post-Condiciones ###
        '########################

        'Se utiliza para deschequear los dados, asi como tambien para limpiarlos
        limpiaDados()
        'Se usa para habilitar o deshabilitar los botones que ingresan los puntos
        cambiarEstadoBA(False)
        'Habilito el boton de lanzamiento de dados
        BLanzaDado.Enabled = True
        'Reinicio el numero de jugadas para el Jugador
        _GeneralaBLL.generalaBE.numeroJugada = 0
        'contiene todo lo que hay que refrescar por cada jugada
        actualizarEstadoJuego()
        'limpio los resultados temporales una ves asignados
        _tempPuntaje = Nothing
        actualizarTempPuntaje(False)
    End Sub


#Region "botones"
    Private Sub BAD1_Click(sender As Object, e As EventArgs) Handles BAD1.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 1)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAD2_Click(sender As Object, e As EventArgs) Handles BAD2.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 2)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAD3_Click(sender As Object, e As EventArgs) Handles BAD3.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 3)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAD4_Click(sender As Object, e As EventArgs) Handles BAD4.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 4)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAD5_Click(sender As Object, e As EventArgs) Handles BAD5.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 5)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAD6_Click(sender As Object, e As EventArgs) Handles BAD6.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 6)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAEscalera_Click(sender As Object, e As EventArgs) Handles BAEscalera.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 7)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAFull_Click(sender As Object, e As EventArgs) Handles BAFull.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 8)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAPoker_Click(sender As Object, e As EventArgs) Handles BAPoker.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 9)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAGenerala_Click(sender As Object, e As EventArgs) Handles BAGenerala.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 10)
        agrupadorMedtodosBA()

    End Sub

    Private Sub BAGeneralaD_Click(sender As Object, e As EventArgs) Handles BAGeneralaD.Click
        cargarPuntaje(_GeneralaBLL.generalaBE.turno, 0)
        agrupadorMedtodosBA()

    End Sub
#End Region

#End Region

#Region "boton lanzar dados"

    'lanza dados sobre los elementos no chequeados
    Private Sub ejecutarDados(j As Integer)
        If Not CBD1.Checked Then
            _GeneralaBLL.liPlayers.Item(j).liDados.Item(0) = _GeneralaBLL.dadoBLL.lanzarDado
        End If
        If Not CBD2.Checked Then
            _GeneralaBLL.liPlayers.Item(j).liDados.Item(1) = _GeneralaBLL.dadoBLL.lanzarDado
        End If
        If Not CBD3.Checked Then
            _GeneralaBLL.liPlayers.Item(j).liDados.Item(2) = _GeneralaBLL.dadoBLL.lanzarDado
        End If
        If Not CBD4.Checked Then
            _GeneralaBLL.liPlayers.Item(j).liDados.Item(3) = _GeneralaBLL.dadoBLL.lanzarDado
        End If
        If Not CBD5.Checked Then
            _GeneralaBLL.liPlayers.Item(j).liDados.Item(4) = _GeneralaBLL.dadoBLL.lanzarDado
        End If




    End Sub

    'Boton que se encarga de lanzar los dados y actualizar algunos estados.
    Private Sub BLanzaDado_Click(sender As Object, e As EventArgs) Handles BLanzaDado.Click

        'guardo temporalmente turno (jugador correspondiente) para una escritura mas legible
        Dim jugador As Integer = _GeneralaBLL.generalaBE.turno

        '#######################
        '### Pre-Condiciones ###
        '#######################

        'limpio el puntaje para iniciar una nueva carga
        _tempPuntaje = Nothing
        'activa los botones segun el jugador indicado
        activarEstadoBA(jugador)
        'Cambia el "enabled" de los checkers
        EstadoCheckers(True)

        '###########################
        '### Ejecucion del juego ###
        '###########################

        'lanza dados sobre los elementos no chequeados
        ejecutarDados(jugador)
        'actualiza los dados de un lanzamiento de un jugador
        mostrarDados(jugador)

        'guardo el puntaje temporal segun cada tirada de dados.
        _tempPuntaje = _GeneralaBLL.chequear(jugador, _GeneralaBLL.generalaBE.numeroJugada)
        'Actualiza los labels correspondientes al puntaje temporario
        actualizarTempPuntaje(True)

        '########################
        '### Post-Condiciones ###
        '########################

        'cuenta la cantidad de tiradas de un jugador
        _GeneralaBLL.TiradaNext()
        'Muestra la jugada en curso
        LNumeroTirada.Text = _GeneralaBLL.generalaBE.numeroJugada

        'deshabilita el boton de lanzar dados una vez superado los 3 lanzamientos.
        If _GeneralaBLL.generalaBE.numeroJugada >= 3 Then
            BLanzaDado.Enabled = False
            'Cambia el "enabled" de los checkers
        End If

    End Sub

#End Region

#Region "handle de eventos"

    'capta el evento cuando se produce una generala servida y registra al jugador
    Private Sub vicGS(ByVal jugador As BE.USUARIO) Handles _GeneralaBLL.generalaServida
        ganador(jugador)
    End Sub

    'cuando se termina un juego, capta el evento, busca a quien tiene mayor puntaje y lo registra.
    Private Sub vicPuntos() Handles _GeneralaBLL.finJuego
        'hago una busqueda del jugador que mas puntos sumo
        Dim puntos As Integer = -1
        Dim jugador As BE.USUARIO = Nothing
        For Each i In _GeneralaBLL.liPlayers
            If i.planillaBLL.resultado > puntos Then
                puntos = i.planillaBLL.resultado
                jugador = i.usuarioBE
            End If
        Next
        ganador(jugador)
    End Sub

    'contiene todas la rutina en comun para los eventos de victoria
    Private Sub ganador(usr As BE.USUARIO)
        'deshabilito el tablero para obligarlo a generar una nueva partida si quiere seguir jugando.
        Me.Enabled = False

        'muestra un cartel de quien fue el ganador
        MsgBox("El jugador " & usr.usuario & " ha ganado el juego!")
        'actualizo las victolias en la lista de jugadores logueados
        '(para no tener que volver a buscar en la DB
        For Each jug In FMCONTENEDOR.liUSRLogin
            If jug.usuario = usr.usuario Then
                jug.victorias += 1
                'guarda en la DB la victoria del jugador
                _GeneralaBLL.guardarVictoria(usr)
            End If
        Next

        For Each jug In FMCONTENEDOR.liUSRPartida
            For Each jl In FMCONTENEDOR.liUSRLogin
                If jug.usuario = jl.usuario Then
                    jl.partidos += 1
                    _GeneralaBLL.guardarPartidos(jl)
                End If
            Next
        Next
    End Sub

#End Region

End Class
