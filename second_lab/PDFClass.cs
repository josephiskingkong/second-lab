using System;
namespace second_lab
{
    public class PDF : Document
    {
        string OtherFileExtension = "Undefined";
        override public void InfoOut()
        {
            Console.WriteLine($"Name: {Name}, Author: {Author}, Key words: {KeyWords}, " +
                $"Theme: {Theme}, Path to the file: {PathToFile}, File extension: {FileExtension}, " +
                $"File extensions that can be opened: {OtherFileExtension}");
        }
        public PDF(string Name, string Author, string KeyWords, string Theme, string PathToFile, string FileExtension,
            string OtherFileExtension)
        {
            this.Name = Name;
            this.Author = Author;
            this.KeyWords = KeyWords;
            this.Theme = Theme;
            this.PathToFile = PathToFile;
            this.FileExtension = FileExtension;
            this.OtherFileExtension = OtherFileExtension;
        }
    }
}