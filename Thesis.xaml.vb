Imports System.Diagnostics
Imports System.Windows.Navigation

Public Class Thesis

    Private Sub Hyperlink_RequestNavigate(sender As Object, e As RequestNavigateEventArgs)

        Process.Start(New ProcessStartInfo(e.Uri.AbsoluteUri) With {
                .UseShellExecute = True
            })

        e.Handled = True

    End Sub

End Class
