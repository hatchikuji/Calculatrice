Imports System.Data
Imports System.Linq.Expressions
Imports System.Text.RegularExpressions

Public Class Calculatrice
    Dim _chaine As String
    Private Sub Calculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _chaine = ""
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        _chaine += "0"
        ActualiseChaine()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _chaine += "1"
        ActualiseChaine()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _chaine += "2"
        ActualiseChaine()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _chaine += "3"
        ActualiseChaine()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        _chaine += "4"
        ActualiseChaine()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        _chaine += "5"
        ActualiseChaine()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _chaine += "6"
        ActualiseChaine()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        _chaine += "7"
        ActualiseChaine()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        _chaine += "8"
        ActualiseChaine()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        _chaine += "9"
        ActualiseChaine()
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        _chaine += "-"
        ActualiseChaine()
    End Sub

    Private Sub ButtonV_Click(sender As Object, e As EventArgs) Handles ButtonV.Click
        _chaine += "."
        ActualiseChaine()
    End Sub

    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click
        _chaine += "/"
        ActualiseChaine()
    End Sub

    Private Sub ButtonMU_Click(sender As Object, e As EventArgs) Handles ButtonMU.Click
        _chaine += "*"
        ActualiseChaine()
    End Sub

    Private Sub ButtonM_Click(sender As Object, e As EventArgs) Handles ButtonM.Click
        _chaine += "-"
        ActualiseChaine()
    End Sub

    Private Sub ButtonP_Click(sender As Object, e As EventArgs) Handles ButtonP.Click
        _chaine += "+"
        ActualiseChaine()
    End Sub

    Private Sub ButtonRESET_Click(sender As Object, e As EventArgs) Handles ButtonRESET.Click
        Reset()
        ActualiseChaine()
    End Sub

    Private Sub Reset()
        _chaine = ""
    End Sub

    Private Sub ActualiseChaine()
        ' Vérifie si l'écran affiche une erreur (NaN)
        If Ecran.Text = "NaN" Then
            ' Ne pas modifier l'écran s'il y a une erreur
            Return
        End If

        ' Logique normale pour actualiser l'écran
        Ecran.Text = _chaine
    End Sub


    Private Function Calcul(chaine As String) As Double
        Try
            ' Vérifie le contenu de la chaîne
            Console.WriteLine("Contenu de la chaîne : " & chaine)

            ' Évalue l'expression dans _chaine
            Dim result As Object = New DataTable().Compute(chaine, Nothing)

            ' Vérifie si le résultat est numérique
            If IsNumeric(result) Then
                Dim numericResult As Double = Convert.ToDouble(result)

                ' Vérifie si le résultat est Infini ou NaN
                If Double.IsInfinity(numericResult) OrElse Double.IsNaN(numericResult) Then
                    Throw New DivideByZeroException("Division par zéro détectée.")
                End If

                Return numericResult
            Else
                Throw New Exception("Le résultat n'est pas un nombre valide.")
            End If

        Catch ex As DivideByZeroException
            ' Affiche le message d'erreur dans la console
            Console.WriteLine("Erreur : " & ex.Message)
            ' Propager l'exception pour qu'elle soit capturée dans le bloc Try...Catch de l'appelant
            Throw
        Catch ex As Exception
            ' Affiche le message d'erreur dans la console
            Console.WriteLine("Erreur : " & ex.Message)
            ' Propager d'autres exceptions
            Throw
        End Try
    End Function

    
    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        Dim chaineTemp As String = ""
        For i = 0 To Len(_chaine) - 2
            chaineTemp &= _chaine(i)
        Next
        _chaine = chaineTemp
        ActualiseChaine()
    End Sub

    Private Sub ButtonE_Click(sender As Object, e As EventArgs) Handles ButtonE.Click
        ' Vérifie si l'écran affiche "NaN" pour réinitialiser la chaîne
        If Ecran.Text = "NaN" Then
            _chaine = ""
            Ecran.Text = ""
        End If

        Dim result As Double
        Try
            ' Appelle la fonction Calcul pour évaluer l'expression
            result = Calcul(_chaine)

            ' Convertit le résultat en chaîne pour l'assigner à _chaine
            _chaine = result.ToString()

            ' Affiche le résultat dans l'écran
            Ecran.Text = _chaine
        Catch ex As DivideByZeroException
            ' Si une division par zéro est détectée, affiche "NaN"
            Console.WriteLine("Division par zéro détectée. Affichage de NaN.")
            Ecran.Text = "NaN"
        Catch ex As Exception
            ' Affiche tout autre message d'erreur
            Console.WriteLine("Erreur : " & ex.Message)
            Ecran.Text = ex.Message
        End Try

        ' Actualise l'affichage de la chaîne
        ActualiseChaine()
    End Sub
End Class
