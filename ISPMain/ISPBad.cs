using System;

#region interfaces
internal interface IFileOperation
{
    void ReadFile(string filePath);
    void WriteFile(string filePath);
    void DeleteFile(string filePath);
    void MoveFile(string sourceFilePath, string destinationFilePath);
    void CopyFile(string sourceFilePath, string destinationFilePath);
}
#endregion interfaces
#region classes
public class DoSomething : IFileOperation
{
    public void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        throw new NotImplementedException();
    }

    public void DeleteFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }

    public void MoveFile(string sourceFilePath, string destinationFilePath)
    {
        if (!File.Exists(destinationFilePath))
        {
            File.Move(sourceFilePath, destinationFilePath);
        }
    }

    public void ReadFile(string filePath)
    {
        throw new NotImplementedException();
    }

    public void WriteFile(string filePath)
    {
        throw new NotImplementedException();
    }
}
#endregion classes
