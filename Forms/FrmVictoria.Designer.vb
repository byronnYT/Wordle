﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVictoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblTxtPuntuacion = New System.Windows.Forms.Label()
        Me.lblVictorias = New System.Windows.Forms.Label()
        Me.lblPuntuacion = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.btnVolverAJugar = New System.Windows.Forms.Button()
        Me.btnClasificacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¡HAS GANADO!"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(377, 246)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(109, 41)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblTxtPuntuacion
        '
        Me.lblTxtPuntuacion.AutoSize = True
        Me.lblTxtPuntuacion.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtPuntuacion.Location = New System.Drawing.Point(165, 105)
        Me.lblTxtPuntuacion.Name = "lblTxtPuntuacion"
        Me.lblTxtPuntuacion.Size = New System.Drawing.Size(139, 29)
        Me.lblTxtPuntuacion.TabIndex = 2
        Me.lblTxtPuntuacion.Text = "Puntuación : "
        '
        'lblVictorias
        '
        Me.lblVictorias.AutoSize = True
        Me.lblVictorias.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.lblVictorias.Location = New System.Drawing.Point(192, 160)
        Me.lblVictorias.Name = "lblVictorias"
        Me.lblVictorias.Size = New System.Drawing.Size(109, 29)
        Me.lblVictorias.TabIndex = 3
        Me.lblVictorias.Text = "Victorias: "
        '
        'lblPuntuacion
        '
        Me.lblPuntuacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPuntuacion.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntuacion.Location = New System.Drawing.Point(301, 105)
        Me.lblPuntuacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPuntuacion.Name = "lblPuntuacion"
        Me.lblPuntuacion.Size = New System.Drawing.Size(88, 30)
        Me.lblPuntuacion.TabIndex = 4
        '
        'lblWins
        '
        Me.lblWins.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblWins.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.Location = New System.Drawing.Point(301, 160)
        Me.lblWins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(88, 32)
        Me.lblWins.TabIndex = 5
        '
        'btnVolverAJugar
        '
        Me.btnVolverAJugar.Location = New System.Drawing.Point(126, 246)
        Me.btnVolverAJugar.Name = "btnVolverAJugar"
        Me.btnVolverAJugar.Size = New System.Drawing.Size(118, 46)
        Me.btnVolverAJugar.TabIndex = 6
        Me.btnVolverAJugar.Text = "Volver a jugar"
        Me.btnVolverAJugar.UseVisualStyleBackColor = True
        '
        'btnClasificacion
        '
        Me.btnClasificacion.Location = New System.Drawing.Point(261, 207)
        Me.btnClasificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClasificacion.Name = "btnClasificacion"
        Me.btnClasificacion.Size = New System.Drawing.Size(92, 28)
        Me.btnClasificacion.TabIndex = 7
        Me.btnClasificacion.Text = "Ver Clasificación"
        Me.btnClasificacion.UseVisualStyleBackColor = True
        '
        'FrmVictoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnClasificacion)
        Me.Controls.Add(Me.btnVolverAJugar)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.lblPuntuacion)
        Me.Controls.Add(Me.lblVictorias)
        Me.Controls.Add(Me.lblTxtPuntuacion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmVictoria"
        Me.Text = "Victoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTxtPuntuacion As Label
    Friend WithEvents lblVictorias As Label
    Friend WithEvents lblPuntuacion As Label
    Friend WithEvents lblWins As Label
    Friend WithEvents btnVolverAJugar As Button
    Friend WithEvents btnClasificacion As Button
End Class
