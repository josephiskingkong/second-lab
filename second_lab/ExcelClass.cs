using System;
namespace second_lab
{
    public class Excel : Document
    {
        int RowCount;
        int ColumnCount;
        override public void InfoOut()
        {
            Console.WriteLine($"Name: {Name}, Author: {Author}, Key words: {KeyWords}, " +
                $"Theme: {Theme}, Path to the file: {PathToFile}, File extension: {FileExtension}, " +
                $"Count of rows: {RowCount}, " +
                $"Count of columns: {ColumnCount}");
        }
        public Excel(string Name, string Author, string KeyWords, string Theme, string PathToFile, string FileExtension,
            int RowCount, int ColumnCount)
        {
            this.Name = Name;
            this.Author = Author;
            this.KeyWords = KeyWords;
            this.Theme = Theme;
            this.PathToFile = PathToFile;
            this.FileExtension = FileExtension;
            this.RowCount = RowCount;
            this.ColumnCount = ColumnCount;
        }
    }
}
