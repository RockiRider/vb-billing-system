Public Class Help

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Node0" Then
            RichTextBox1.Text = "Friends, Romans, countrymen, lend me your ears,I come to bury Caesar, not to praise him"
        End If
        If e.Node.Name = "Node1" Then
            RichTextBox1.Text = "Opinion is the medium between knowledge and ignorance."
        End If
        If e.Node.Name = "Node2" Then
            RichTextBox1.Text = "Astronomy compels the soul to look upwards and leads us from this world to another."
        End If
        If e.Node.Name = "Node3" Then
            RichTextBox1.Text = "By all means, marry. If you get a good wife, you'll become happy; if you get a bad one, you'll become a philosopher."
        End If
        If e.Node.Name = "Node4" Then
            RichTextBox1.Text = "The greatest way to live with honor in this world is to be what we pretend to be."
        End If
        If e.Node.Name = "Node5" Then
            RichTextBox1.Text = "Showing off is the fool's idea of glory."
        End If
        If e.Node.Name = "Node6" Then
            Me.Hide()
        End If
    End Sub
End Class