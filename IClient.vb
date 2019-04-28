Imports DeQma.WebDav.JSON

Public Interface IClient


    Function Copy(SourceFilesFoldersPathFull As String, DestinationFilesFoldersPathFull As String, Optional Overwrite As Boolean = True, Optional token As Threading.CancellationToken = Nothing) As Task(Of JSONCopyMove)
    Function CopyAndRename(SourceFilesFoldersPathFull As String, DestinationFoldersPathFull As String, NewFileName As String, Optional Overwrite As Boolean = True, Optional token As Threading.CancellationToken = Nothing) As Task(Of JSONCopyMove)
    Function Move(SourceFilesFoldersPathFull As String, DestinationFilesFoldersPathFull As String, Optional Overwrite As Boolean = True, Optional token As Threading.CancellationToken = Nothing) As Task(Of JSONCopyMove)
    Function MoveAndRename(SourceFilesFoldersPathFull As String, DestinationFoldersPathFull As String, NewFileName As String, Optional Overwrite As Boolean = True, Optional token As Threading.CancellationToken = Nothing) As Task(Of JSONCopyMove)
    Function List(FolderPathFull As String, Optional _Depth As Integer = 1, Optional token As Threading.CancellationToken = Nothing) As Task(Of List(Of Item))
    Function Delete(FilePathFull As String, Optional token As Threading.CancellationToken = Nothing) As Task(Of Boolean)
    Function CreateNewFolder(DestinationFolderPathFull As String, NewFolderName As String, Optional token As Threading.CancellationToken = Nothing) As Task(Of Boolean)
    Function RenameFile(FilesPathFull As String, NewFileName As String, Optional token As Threading.CancellationToken = Nothing) As Task(Of Boolean)
    Function RenameFolder(FolderPathFull As String, NewFolderName As String, Optional token As Threading.CancellationToken = Nothing) As Task(Of Boolean)
    Function DownloadFile(FilePathFull As String, FileSavePath As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task
    Function DownloadFileAsStream(FilePathFull As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task(Of IO.Stream)
    Function DownloadFileAsString(FilePathFull As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task(Of String)
    Function UploadFile(UploadToFolderPathFull As String, LocalFilePath As String, UploadType As WClient.UploadTypes, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional token As Threading.CancellationToken = Nothing) As Task

End Interface
