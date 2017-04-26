Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form_main

    '#####################################'
    '# Fonction API                      #'
    '#####################################'

    <DllImport("gdi32")> _
    Public Shared Function AddFontResource(ByVal lpFileName As String) As Integer
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As Integer, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Shared Function WriteProfileString(ByVal lpszSection As String, ByVal lpszKeyName As String, ByVal lpszString As String) As Integer
    End Function

    '#####################################'
    '# Déclaration variable              #'
    '#####################################'

    Dim name_Font As String
    Dim fonts As New InstalledFontCollection
    Dim font_f() As FontFamily = fonts.Families()
    Dim police As Object
    Dim restart As Boolean

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '# Initialisation
        ToolStripStatusLabel1.Text = ""
        save_IMG.Enabled = False
        restart = False
        '# Installation Fonts
        Installe_Fonts()
        '# Initialisation GroupBox
        GroupBox1.Enabled = False
        '# Initialisation TextBox
        texte_CB.Enabled = False
        texte_CB.Text = ""
        texte_CB.MaxLength = 36
        convert_CB.Text = ""

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles texte_CB.TextChanged

        ToolStripStatusLabel1.Text = ""
        If texte_CB.TextLength >= texte_CB.MaxLength Then
            ' STOP, trop grand
        Else
            If texte_CB.Text = "" Then
                ' Rien faire
                save_IMG.Enabled = False
            Else
                Create_IMG()
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles save_IMG.Click

        '# Sélection du répertoire d'enregistrement
        Try
            Dim folder_path As String
            ToolStripStatusLabel1.Text = ""
            If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                folder_path = FolderBrowserDialog1.SelectedPath + "\" + texte_CB.Text + ".jpg"
                PictureBox1.Image.Save(folder_path)
                ToolStripStatusLabel1.Text = "Picture saved successfully !"
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Error: picture not saved !"
        End Try

    End Sub

    Public Sub Installe_Fonts()

        '# Installation Fonts
        Dim Repertoire As String
        Dim name_File As String
        Dim objFSO, objDossier
        Dim trouve_Font As Boolean
        '# Process
        Try
            Repertoire = Application.StartupPath + "\Fonts\"
            objFSO = CreateObject("Scripting.FileSystemObject")
            objDossier = objFSO.GetFolder(Repertoire)
            If (objDossier.Files.Count > 0) Then
                For Each objFichier In objDossier.Files
                    name_File = objFichier.Name
                    For Each ft As FontFamily In font_f
                        name_Font = ft.Name + ".ttf"
                        If UCase(name_Font) = UCase(name_File) Then
                            trouve_Font = True
                            Exit For
                        Else
                            trouve_Font = False
                        End If
                    Next
                    If trouve_Font = True Then
                        ' Déjà installé
                    Else
                        ' Pas installé
                        Dim path As String
                        path = Environment.CurrentDirectory + "\Fonts\" + name_File
                        FileCopy(path, "C:\windows\fonts\" + name_File)
                        Dim Ret As Integer
                        'Dim Res As Integer
                        Dim FontPath As String
                        'Const WM_FONTCHANGE As Integer = &H1D
                        'Const HWND_BROADCAST As Integer = &HFFFF
                        Dim WinFontDir = "C:\windows\fonts"
                        Dim FontFileName = name_File
                        Dim monTab() = Split(name_File, ".")
                        Dim FontName = monTab(0)
                        FontPath = WinFontDir & "\" & FontFileName
                        Ret = AddFontResource(FontPath)
                        'Res = SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0)
                        Ret = WriteProfileString("fonts", FontName + " (TrueType)", FontFileName)
                        restart = True
                    End If
                Next
                '# Restart apply or change list of font
                If restart = True Then
                    MessageBox.Show("Installation of fonts finished successfully !")
                    Application.Restart()
                    Close()
                Else
                    If (objDossier.Files.Count > 0) Then
                        For Each objFichier In objDossier.Files
                            name_File = objFichier.Name
                            Dim monTab() = Split(name_File, ".")
                            Dim FontName = monTab(0)
                            Liste_Fonts.Items.Add(FontName)
                        Next
                    End If
                End If
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Error: install fonts (no font found)"
        End Try

    End Sub

    Private Sub Liste_Fonts_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Liste_Fonts.SelectedIndexChanged

        '#####################################'
        '# Sélection police de caractère     #'
        '#####################################'

        Dim name_font As String
        name_font = Liste_Fonts.SelectedItem.ToString
        police = New Font(name_font, 55)
        convert_CB.Font = police
        GroupBox1.Enabled = True
        Create_IMG()
        texte_CB.Enabled = True
        texte_CB.Focus()

    End Sub

    Public Sub Create_IMG()

        '####################'
        '# Création IMG     #'
        '####################'

        Dim mybitmap As Bitmap
        Dim largeur, hauteur As Integer
        Dim graph As Graphics

        For Each ft As FontFamily In font_f
            name_Font = ft.Name
            convert_CB.Text = texte_CB.Text
            largeur = PictureBox1.Width                                     ' Largeur de l'image
            hauteur = PictureBox1.Height                                    ' Hauteur de l'image
            mybitmap = New Bitmap(largeur, hauteur)                         ' Création bitmap
            graph = Graphics.FromImage(mybitmap)                            ' Création image
            graph.Clear(Color.White)                                        ' Affichage couleur de fond : blanc
            graph.DrawString(texte_CB.Text, police, Brushes.Black, 0, 0)    ' Ecriture texte
            PictureBox1.Image = mybitmap                                    ' Insertion image
            save_IMG.Enabled = True
            Exit For
        Next

    End Sub

End Class