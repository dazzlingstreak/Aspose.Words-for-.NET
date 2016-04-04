' For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
' The path to the documents directory.
Dim dataDir As String = RunExamples.GetDataDir_WorkingWithHyperlink()
Dim NewUrl As String = "http://www.aspose.com"
Dim NewName As String = "Aspose - The .NET & Java Component Publisher"
Dim doc As New Document(dataDir & Convert.ToString("ReplaceHyperlinks.doc"))

' Hyperlinks in a Word documents are fields, select all field start nodes so we can find the hyperlinks.
Dim fieldStarts As NodeList = doc.SelectNodes("//FieldStart")
For Each fieldStart As FieldStart In fieldStarts
    If fieldStart.FieldType.Equals(FieldType.FieldHyperlink) Then
        ' The field is a hyperlink field, use the "facade" class to help to deal with the field.
        Dim hyperlink As New Hyperlink(fieldStart)

        ' Some hyperlinks can be local (links to bookmarks inside the document), ignore these.
        If hyperlink.IsLocal Then
            Continue For
        End If

        ' The Hyperlink class allows to set the target URL and the display name
        ' of the link easily by setting the properties.
        hyperlink.Target = NewUrl
        hyperlink.Name = NewName
    End If
Next
dataDir = dataDir & Convert.ToString("ReplaceHyperlinks_out_.doc")
doc.Save(dataDir)