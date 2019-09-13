<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SymboltabelleLadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProDiagLadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextersetzungenLadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gbSymbole = New System.Windows.Forms.GroupBox()
        Me.dgvSymbole = New System.Windows.Forms.DataGridView()
        Me.btnSymbolLoad = New System.Windows.Forms.Button()
        Me.MainMenu.SuspendLayout()
        Me.gbSymbole.SuspendLayout()
        CType(Me.dgvSymbole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1008, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SymboltabelleLadenToolStripMenuItem, Me.ProDiagLadenToolStripMenuItem, Me.TextersetzungenLadenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'SymboltabelleLadenToolStripMenuItem
        '
        Me.SymboltabelleLadenToolStripMenuItem.Name = "SymboltabelleLadenToolStripMenuItem"
        Me.SymboltabelleLadenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SymboltabelleLadenToolStripMenuItem.Text = "Symboltabelle laden"
        '
        'ProDiagLadenToolStripMenuItem
        '
        Me.ProDiagLadenToolStripMenuItem.Name = "ProDiagLadenToolStripMenuItem"
        Me.ProDiagLadenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ProDiagLadenToolStripMenuItem.Text = "ProDiag laden"
        '
        'TextersetzungenLadenToolStripMenuItem
        '
        Me.TextersetzungenLadenToolStripMenuItem.Name = "TextersetzungenLadenToolStripMenuItem"
        Me.TextersetzungenLadenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.TextersetzungenLadenToolStripMenuItem.Text = "Textersetzungen laden"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'gbSymbole
        '
        Me.gbSymbole.Controls.Add(Me.btnSymbolLoad)
        Me.gbSymbole.Controls.Add(Me.dgvSymbole)
        Me.gbSymbole.Location = New System.Drawing.Point(12, 37)
        Me.gbSymbole.Name = "gbSymbole"
        Me.gbSymbole.Size = New System.Drawing.Size(984, 223)
        Me.gbSymbole.TabIndex = 1
        Me.gbSymbole.TabStop = False
        Me.gbSymbole.Text = "Symbole"
        '
        'dgvSymbole
        '
        Me.dgvSymbole.AllowUserToAddRows = False
        Me.dgvSymbole.AllowUserToDeleteRows = False
        Me.dgvSymbole.AllowUserToOrderColumns = True
        Me.dgvSymbole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSymbole.Location = New System.Drawing.Point(6, 19)
        Me.dgvSymbole.Name = "dgvSymbole"
        Me.dgvSymbole.ReadOnly = True
        Me.dgvSymbole.Size = New System.Drawing.Size(882, 198)
        Me.dgvSymbole.TabIndex = 0
        '
        'btnSymboleLoad
        '
        Me.btnSymbolLoad.Location = New System.Drawing.Point(894, 19)
        Me.btnSymbolLoad.Name = "btnSymboleLoad"
        Me.btnSymbolLoad.Size = New System.Drawing.Size(84, 45)
        Me.btnSymbolLoad.TabIndex = 1
        Me.btnSymbolLoad.Text = "Laden"
        Me.btnSymbolLoad.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.gbSymbole)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "FormMain"
        Me.Text = "ProDiagTool"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.gbSymbole.ResumeLayout(False)
        CType(Me.dgvSymbole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SymboltabelleLadenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProDiagLadenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextersetzungenLadenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents gbSymbole As GroupBox
    Friend WithEvents btnSymbolLoad As Button
    Friend WithEvents dgvSymbole As DataGridView
End Class
