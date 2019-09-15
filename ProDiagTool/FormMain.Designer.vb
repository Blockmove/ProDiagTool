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
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gbSymbole = New System.Windows.Forms.GroupBox()
        Me.btnSymbolLoad = New System.Windows.Forms.Button()
        Me.dgvSymbol = New System.Windows.Forms.DataGridView()
        Me.gbProDiag = New System.Windows.Forms.GroupBox()
        Me.btnSymbolsMap = New System.Windows.Forms.Button()
        Me.btnProDiagSave = New System.Windows.Forms.Button()
        Me.btnProDiagLoad = New System.Windows.Forms.Button()
        Me.dgvProDiag = New System.Windows.Forms.DataGridView()
        Me.gbReplace = New System.Windows.Forms.GroupBox()
        Me.btnReplacementsLoad = New System.Windows.Forms.Button()
        Me.dgvReplacements = New System.Windows.Forms.DataGridView()
        Me.MainMenu.SuspendLayout()
        Me.gbSymbole.SuspendLayout()
        CType(Me.dgvSymbol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProDiag.SuspendLayout()
        CType(Me.dgvProDiag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReplace.SuspendLayout()
        CType(Me.dgvReplacements, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'gbSymbole
        '
        Me.gbSymbole.Controls.Add(Me.btnSymbolLoad)
        Me.gbSymbole.Controls.Add(Me.dgvSymbol)
        Me.gbSymbole.Location = New System.Drawing.Point(12, 37)
        Me.gbSymbole.Name = "gbSymbole"
        Me.gbSymbole.Size = New System.Drawing.Size(984, 199)
        Me.gbSymbole.TabIndex = 1
        Me.gbSymbole.TabStop = False
        Me.gbSymbole.Text = "Symbole"
        '
        'btnSymbolLoad
        '
        Me.btnSymbolLoad.Location = New System.Drawing.Point(894, 19)
        Me.btnSymbolLoad.Name = "btnSymbolLoad"
        Me.btnSymbolLoad.Size = New System.Drawing.Size(84, 28)
        Me.btnSymbolLoad.TabIndex = 1
        Me.btnSymbolLoad.Text = "Laden"
        Me.btnSymbolLoad.UseVisualStyleBackColor = True
        '
        'dgvSymbol
        '
        Me.dgvSymbol.AllowUserToAddRows = False
        Me.dgvSymbol.AllowUserToDeleteRows = False
        Me.dgvSymbol.AllowUserToOrderColumns = True
        Me.dgvSymbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSymbol.Location = New System.Drawing.Point(6, 19)
        Me.dgvSymbol.Name = "dgvSymbol"
        Me.dgvSymbol.ReadOnly = True
        Me.dgvSymbol.Size = New System.Drawing.Size(882, 166)
        Me.dgvSymbol.TabIndex = 0
        '
        'gbProDiag
        '
        Me.gbProDiag.Controls.Add(Me.btnSymbolsMap)
        Me.gbProDiag.Controls.Add(Me.btnProDiagSave)
        Me.gbProDiag.Controls.Add(Me.btnProDiagLoad)
        Me.gbProDiag.Controls.Add(Me.dgvProDiag)
        Me.gbProDiag.Location = New System.Drawing.Point(12, 242)
        Me.gbProDiag.Name = "gbProDiag"
        Me.gbProDiag.Size = New System.Drawing.Size(984, 188)
        Me.gbProDiag.TabIndex = 2
        Me.gbProDiag.TabStop = False
        Me.gbProDiag.Text = "ProDiag"
        '
        'btnSymbolSearch
        '
        Me.btnSymbolsMap.Location = New System.Drawing.Point(894, 53)
        Me.btnSymbolsMap.Name = "btnSymbolSearch"
        Me.btnSymbolsMap.Size = New System.Drawing.Size(84, 36)
        Me.btnSymbolsMap.TabIndex = 3
        Me.btnSymbolsMap.Text = "Symbole" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "suchen"
        Me.btnSymbolsMap.UseVisualStyleBackColor = True
        '
        'btnProDiagSave
        '
        Me.btnProDiagSave.Location = New System.Drawing.Point(894, 147)
        Me.btnProDiagSave.Name = "btnProDiagSave"
        Me.btnProDiagSave.Size = New System.Drawing.Size(84, 28)
        Me.btnProDiagSave.TabIndex = 2
        Me.btnProDiagSave.Text = "Speichern"
        Me.btnProDiagSave.UseVisualStyleBackColor = True
        '
        'btnProDiagLoad
        '
        Me.btnProDiagLoad.Location = New System.Drawing.Point(894, 19)
        Me.btnProDiagLoad.Name = "btnProDiagLoad"
        Me.btnProDiagLoad.Size = New System.Drawing.Size(84, 28)
        Me.btnProDiagLoad.TabIndex = 1
        Me.btnProDiagLoad.Text = "Laden"
        Me.btnProDiagLoad.UseVisualStyleBackColor = True
        '
        'dgvProDiag
        '
        Me.dgvProDiag.AllowUserToAddRows = False
        Me.dgvProDiag.AllowUserToDeleteRows = False
        Me.dgvProDiag.AllowUserToOrderColumns = True
        Me.dgvProDiag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProDiag.Location = New System.Drawing.Point(6, 19)
        Me.dgvProDiag.Name = "dgvProDiag"
        Me.dgvProDiag.ReadOnly = True
        Me.dgvProDiag.Size = New System.Drawing.Size(882, 156)
        Me.dgvProDiag.TabIndex = 0
        '
        'gbReplace
        '
        Me.gbReplace.Controls.Add(Me.btnReplacementsLoad)
        Me.gbReplace.Controls.Add(Me.dgvReplacements)
        Me.gbReplace.Location = New System.Drawing.Point(12, 436)
        Me.gbReplace.Name = "gbReplace"
        Me.gbReplace.Size = New System.Drawing.Size(984, 188)
        Me.gbReplace.TabIndex = 3
        Me.gbReplace.TabStop = False
        Me.gbReplace.Text = "Textersetzungen"
        '
        'btnReplacementsLoad
        '
        Me.btnReplacementsLoad.Location = New System.Drawing.Point(894, 19)
        Me.btnReplacementsLoad.Name = "btnReplacementsLoad"
        Me.btnReplacementsLoad.Size = New System.Drawing.Size(84, 28)
        Me.btnReplacementsLoad.TabIndex = 1
        Me.btnReplacementsLoad.Text = "Laden"
        Me.btnReplacementsLoad.UseVisualStyleBackColor = True
        '
        'dgvReplacements
        '
        Me.dgvReplacements.AllowUserToAddRows = False
        Me.dgvReplacements.AllowUserToDeleteRows = False
        Me.dgvReplacements.AllowUserToOrderColumns = True
        Me.dgvReplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReplacements.Location = New System.Drawing.Point(6, 19)
        Me.dgvReplacements.Name = "dgvReplacements"
        Me.dgvReplacements.ReadOnly = True
        Me.dgvReplacements.Size = New System.Drawing.Size(882, 156)
        Me.dgvReplacements.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.gbReplace)
        Me.Controls.Add(Me.gbProDiag)
        Me.Controls.Add(Me.gbSymbole)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "FormMain"
        Me.Text = "ProDiagTool"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.gbSymbole.ResumeLayout(False)
        CType(Me.dgvSymbol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProDiag.ResumeLayout(False)
        CType(Me.dgvProDiag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReplace.ResumeLayout(False)
        CType(Me.dgvReplacements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents gbSymbole As GroupBox
    Friend WithEvents btnSymbolLoad As Button
    Friend WithEvents dgvSymbol As DataGridView
    Friend WithEvents gbProDiag As GroupBox
    Friend WithEvents btnProDiagLoad As Button
    Friend WithEvents dgvProDiag As DataGridView
    Friend WithEvents gbReplace As GroupBox
    Friend WithEvents btnReplacementsLoad As Button
    Friend WithEvents dgvReplacements As DataGridView
    Friend WithEvents btnProDiagSave As Button
    Friend WithEvents btnSymbolsMap As Button
End Class
