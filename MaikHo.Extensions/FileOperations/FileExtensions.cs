using System;
using System.Collections.Generic;
using System.IO;

namespace MaikHo.Extensions.FileOperations
{
    public static class FileExtensions
    {
        // Extension Method: Lesen des Inhalts einer Textdatei
        public static string ReadTextFile(this string filePath)
        {
            return File.ReadAllText(filePath);
        }

        // Extension Method: Schreiben eines Texts in eine Textdatei
        public static void WriteTextFile(this string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        // Extension Method: Lesen des Inhalts einer Binärdatei
        public static byte[] ReadBinaryFile(this string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        // Extension Method: Schreiben von Binärdaten in eine Binärdatei
        public static void WriteBinaryFile(this string filePath, byte[] data)
        {
            File.WriteAllBytes(filePath, data);
        }

        // Extension Method: Kopieren einer Datei
        public static void CopyFile(this string sourceFilePath, string destFilePath, bool overwrite = false)
        {
            File.Copy(sourceFilePath, destFilePath, overwrite);
        }

        // Extension Method: Verschieben einer Datei
        public static void MoveFile(this string sourceFilePath, string destFilePath)
        {
            File.Move(sourceFilePath, destFilePath);
        }

        // Extension Method: Löschen einer Datei
        public static void DeleteFile(this string filePath)
        {
            File.Delete(filePath);
        }

        // Extension Method: Rekursives Löschen eines Verzeichnisses
        public static void DeleteDirectory(this string directoryPath, bool recursive = true)
        {
            Directory.Delete(directoryPath, recursive);
        }

        // Extension Method: Rekursives Erstellen eines Verzeichnisses
        public static void CreateDirectory(this string directoryPath)
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Extension Method: Überprüfen, ob eine Datei existiert
        public static bool FileExists(this string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
