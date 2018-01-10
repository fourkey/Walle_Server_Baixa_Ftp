<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Inicio))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Progress_Arq = New System.Windows.Forms.ProgressBar()
        Me.Progress_Inicio = New System.Windows.Forms.ProgressBar()
        Me.Lb_Conexao = New System.Windows.Forms.Label()
        Me.Lb_Arquivos = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer_Loop = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(315, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Iniciar Processo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Progress_Arq
        '
        Me.Progress_Arq.Location = New System.Drawing.Point(12, 111)
        Me.Progress_Arq.Name = "Progress_Arq"
        Me.Progress_Arq.Size = New System.Drawing.Size(434, 23)
        Me.Progress_Arq.TabIndex = 1
        '
        'Progress_Inicio
        '
        Me.Progress_Inicio.Location = New System.Drawing.Point(12, 49)
        Me.Progress_Inicio.Maximum = 10
        Me.Progress_Inicio.Name = "Progress_Inicio"
        Me.Progress_Inicio.Size = New System.Drawing.Size(434, 23)
        Me.Progress_Inicio.TabIndex = 2
        '
        'Lb_Conexao
        '
        Me.Lb_Conexao.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Conexao.Location = New System.Drawing.Point(12, 23)
        Me.Lb_Conexao.Name = "Lb_Conexao"
        Me.Lb_Conexao.Size = New System.Drawing.Size(434, 23)
        Me.Lb_Conexao.TabIndex = 3
        Me.Lb_Conexao.Text = "Aguardando..."
        Me.Lb_Conexao.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Lb_Arquivos
        '
        Me.Lb_Arquivos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Arquivos.Location = New System.Drawing.Point(12, 85)
        Me.Lb_Arquivos.Name = "Lb_Arquivos"
        Me.Lb_Arquivos.Size = New System.Drawing.Size(434, 23)
        Me.Lb_Arquivos.TabIndex = 4
        Me.Lb_Arquivos.Text = "Aguardando..."
        Me.Lb_Arquivos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(12, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar Processo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer_Loop
        '
        Me.Timer_Loop.Interval = 30000
        '
        'Frm_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(458, 184)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Lb_Arquivos)
        Me.Controls.Add(Me.Lb_Conexao)
        Me.Controls.Add(Me.Progress_Inicio)
        Me.Controls.Add(Me.Progress_Arq)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Walle Service Data"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Progress_Arq As ProgressBar
    Friend WithEvents Progress_Inicio As ProgressBar
    Friend WithEvents Lb_Conexao As Label
    Friend WithEvents Lb_Arquivos As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer_Loop As Timer
End Class
