#region interfaces
internal interface IReadableFile
{
    void ReadFile(string filePath);
}

internal interface IWriteableFile
{
    void WriteFile(string filePath);
}

internal interface IDeleteableFile
{
    void DeleteFile(string filePath);
}

internal interface IMoveableFile
{
    void MoveFile(string sourceFilePath, string destinationFilePath);
}

internal interface ICopyableFile
{
    void CopyFile(string sourceFilePath, string destinationFilePath);
}
#endregion interfaces

#region classes
public class DeletingAndMovingSomething : IDeleteableFile, IMoveableFile
{
    public void DeleteFile(string filePath)
    {
        if(File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }

    public void MoveFile(string sourceFilePath, string destinationFilePath)
    {
        if(!File.Exists(destinationFilePath))
        {
            File.Move(sourceFilePath, destinationFilePath);
        }
    }
}
#endregion classes

