Imports System
Module actividad_empresarial
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim actividades(9) As String
        Dim descripciones(9) As String
        Dim responsables(9) As String
        Dim departamentos(9) As String
        Dim fechasInicio(9) As String
        Dim fechasFinalizacion(9) As String
        Dim prioridades(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------//
        '--|menu_principal_actividad_empresarial|--//
        '------------------------------------------//
        Do
            Console.WriteLine("menu principal de actividad empresarial")
            Console.WriteLine("1) Registrar actividad")
            Console.WriteLine("2) Editar actividad")
            Console.WriteLine("3) Listar actividades")
            Console.WriteLine("4) Buscar actividad")
            Console.WriteLine("5) Eliminar actividad")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-------------------------//
                '--|registrar_actividad|--//
                '-------------------------//
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas actividades.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("registro de actividad")
                        Console.Write("Actividad: ")
                        actividades(cantidad) = Console.ReadLine()
                        Console.Write("Descripcion: ")
                        descripciones(cantidad) = Console.ReadLine()
                        Console.Write("Responsable: ")
                        responsables(cantidad) = Console.ReadLine()
                        Console.Write("Departamento: ")
                        departamentos(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de inicio: ")
                        fechasInicio(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de finalizacion: ")
                        fechasFinalizacion(cantidad) = Console.ReadLine()
                        Console.Write("Prioridad: ")
                        prioridades(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observaciones: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Actividad registrada correctamente.")
                    End If
                '----------------------//
                '--|editar_actividad|--//
                '----------------------//
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen actividades registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Actividad: " & actividades(i) & " | Descripcion: " & descripciones(i) & " | Responsable: " & responsables(i) & " | Departamento: " & departamentos(i) & " | Inicio: " & fechasInicio(i) & " | Finalizacion: " & fechasFinalizacion(i) & " | Prioridad: " & prioridades(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la actividad a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nueva actividad: ")
                            actividades(posicion) = Console.ReadLine()
                            Console.Write("Nueva descripcion: ")
                            descripciones(posicion) = Console.ReadLine()
                            Console.Write("Nuevo responsable: ")
                            responsables(posicion) = Console.ReadLine()
                            Console.Write("Nuevo departamento: ")
                            departamentos(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de inicio: ")
                            fechasInicio(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de finalizacion: ")
                            fechasFinalizacion(posicion) = Console.ReadLine()
                            Console.Write("Nueva prioridad: ")
                            prioridades(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nuevas observaciones: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Actividad actualizada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------//
                '--|listar_actividades|--//
                '------------------------//
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen actividades registradas.")
                    Else
                        Console.WriteLine("lista de actividades")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Actividad: " & actividades(i) & " | Descripcion: " & descripciones(i) & " | Responsable: " & responsables(i) & " | Departamento: " & departamentos(i) & " | Inicio: " & fechasInicio(i) & " | Finalizacion: " & fechasFinalizacion(i) & " | Prioridad: " & prioridades(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                    End If
                '----------------------//
                '--|buscar_actividad|--//
                '----------------------//
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen actividades registradas.")
                    Else
                        Console.Write("Ingrese el ID de la actividad a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("actividad encontrada")
                            Console.WriteLine("ID: " & ids(posicion) & " | Actividad: " & actividades(posicion) & " | Descripcion: " & descripciones(posicion) & " | Responsable: " & responsables(posicion) & " | Departamento: " & departamentos(posicion) & " | Inicio: " & fechasInicio(posicion) & " | Finalizacion: " & fechasFinalizacion(posicion) & " | Prioridad: " & prioridades(posicion) & " | Estado: " & estados(posicion) & " | Observaciones: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------//
                '--|eliminar_actividad|--//
                '------------------------//
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen actividades registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Actividad: " & actividades(i) & " | Descripcion: " & descripciones(i) & " | Responsable: " & responsables(i) & " | Departamento: " & departamentos(i) & " | Inicio: " & fechasInicio(i) & " | Finalizacion: " & fechasFinalizacion(i) & " | Prioridad: " & prioridades(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la actividad a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                actividades(i) = actividades(i + 1)
                                descripciones(i) = descripciones(i + 1)
                                responsables(i) = responsables(i + 1)
                                departamentos(i) = departamentos(i + 1)
                                fechasInicio(i) = fechasInicio(i + 1)
                                fechasFinalizacion(i) = fechasFinalizacion(i + 1)
                                prioridades(i) = prioridades(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Actividad eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------//
                '--|mostrar_resumen|--//
                '---------------------//
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen actividades registradas.")
                    Else
                        Dim pendientes As Integer = 0
                        Dim enProceso As Integer = 0
                        Dim completadas As Integer = 0
                        Dim canceladas As Integer = 0
                        Dim prioridadBaja As Integer = 0
                        Dim prioridadMedia As Integer = 0
                        Dim prioridadAlta As Integer = 0
                        Dim prioridadUrgente As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i).ToLower() = "pendiente" Then
                                pendientes += 1
                            ElseIf estados(i).ToLower() = "en proceso" Then
                                enProceso += 1
                            ElseIf estados(i).ToLower() = "completada" Then
                                completadas += 1
                            ElseIf estados(i).ToLower() = "cancelada" Then
                                canceladas += 1
                            End If
                            If prioridades(i).ToLower() = "baja" Then
                                prioridadBaja += 1
                            ElseIf prioridades(i).ToLower() = "media" Then
                                prioridadMedia += 1
                            ElseIf prioridades(i).ToLower() = "alta" Then
                                prioridadAlta += 1
                            ElseIf prioridades(i).ToLower() = "urgente" Then
                                prioridadUrgente += 1
                            End If
                        Next
                        Console.WriteLine("resumen de actividad empresarial")
                        Console.WriteLine("Actividades registradas: " & cantidad & " | Pendientes: " & pendientes & " | En proceso: " & enProceso & " | Completadas: " & completadas & " | Canceladas: " & canceladas & " | Prioridad baja: " & prioridadBaja & " | Prioridad media: " & prioridadMedia & " | Prioridad alta: " & prioridadAlta & " | Prioridad urgente: " & prioridadUrgente)
                    End If
                '------------------------------//
                '--|salir_del_menu_principal|--//
                '------------------------------//
                Case 7
                    Console.WriteLine("Gracias por utilizar Actividad Empresarial.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module