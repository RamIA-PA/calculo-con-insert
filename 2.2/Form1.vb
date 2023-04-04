Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click, Label16.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ejercicio2DataSet1.costovariable' Puede moverla o quitarla según sea necesario.
        Me.CostovariableTableAdapter1.Fill(Me.Ejercicio2DataSet1.costovariable)
        'TODO: esta línea de código carga datos en la tabla 'Ejercicio2DataSet1.costofijo' Puede moverla o quitarla según sea necesario.
        Me.CostofijoTableAdapter1.Fill(Me.Ejercicio2DataSet1.costofijo)
        'TODO: esta línea de código carga datos en la tabla 'Ejercicio2DataSet1.ordendepedidos' Puede moverla o quitarla según sea necesario.
        Me.OrdendepedidosTableAdapter1.Fill(Me.Ejercicio2DataSet1.ordendepedidos)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles orden.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles agregar.Click

        Try

            Me.OrdendepedidosTableAdapter.Insert(orden.Text, fecha.Text, observacion.Text, atendidopor.Text)

            Me.CostofijoTableAdapter.Insert(idorden:=orden.Text, costofijos.Text, costofijo.Text, cantidadfija.Text, totalfijo.Text)
            Me.CostovariableTableAdapter.Insert(idordenvar:=orden.Text, castovava.Text, costovas.Text, cantidadva.Text, totalva.Text)


            Dim suma = Me.CostofijoTableAdapter.sumatotalfijo()
            subtotalfijo.Text = suma

            Dim suma2 = Me.CostovariableTableAdapter.subtotalva()
            subtotalvariable.Text = suma2


            totaltotal.Text = suma + suma2


            Me.CostofijoTableAdapter.Fill(Me.Ejercicio2DataSet.costofijo)
            Me.CostovariableTableAdapter.Fill(Me.Ejercicio2DataSet.costovariable)
            Me.OrdendepedidosTableAdapter.Fill(Me.Ejercicio2DataSet.ordendepedidos)

        Catch ex As Exception
            MsgBox("rellene todos los campos o escriba la fecha de manera correcta 
ejemplo 1-1-1")



        End Try




    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles subtotalfijo.TextChanged

    End Sub

    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        Me.CostofijoTableAdapter.Fill(Me.Ejercicio2DataSet.costofijo)
        Me.CostovariableTableAdapter.Fill(Me.Ejercicio2DataSet.costovariable)
        Me.OrdendepedidosTableAdapter.Fill(Me.Ejercicio2DataSet.ordendepedidos)

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub
End Class
