using System;
namespace second_lab
{
    public class HTML : Document
    {
        string FriendlyLanguages = "Undefined";
        override public void InfoOut()
        {
            Console.WriteLine($"Name: {Name}, Author: {Author}, Key words: {KeyWords}, " +
                $"Theme: {Theme}, Path to the file: {PathToFile}, File extension: {FileExtension}, " +
                $"Friendly code languages: {FriendlyLanguages}");
        }
        public HTML(string Name, string Author, string KeyWords, string Theme, string PathToFile, string FileExtension,
            string FriendlyLanguages)
        {
            this.Name = Name;
            this.Author = Author;
            this.KeyWords = KeyWords;
            this.Theme = Theme;
            this.PathToFile = PathToFile;
            this.FileExtension = FileExtension;
            this.FriendlyLanguages = FriendlyLanguages;
        }
    }
}