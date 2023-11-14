using System;
using System.IO;


namespace ConAssignmentFileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

                while (true)
                {
                    Console.WriteLine("Choose an operation:");
                    Console.WriteLine("1. Create File");
                    Console.WriteLine("2. Read File");
                    Console.WriteLine("3. Append to File");
                    Console.WriteLine("4. Delete File");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice (1-5): ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter file name: ");
                            string createFileName = Console.ReadLine();
                            Console.Write("Enter content: ");
                            string createFileContent = Console.ReadLine();
                            CreateFile(createFileName, createFileContent);
                            break;

                        case "2":
                            Console.Write("Enter file name: ");
                            string readFileName = Console.ReadLine();
                            ReadFile(readFileName);
                            break;

                        case "3":
                            Console.Write("Enter file name: ");
                            string appendFileName = Console.ReadLine();
                            Console.Write("Enter content to append: ");
                            string appendContent = Console.ReadLine();
                            AppendToFile(appendFileName, appendContent);
                            break;

                        case "4":
                            Console.Write("Enter file name: ");
                            string deleteFileName = Console.ReadLine();
                            DeleteFile(deleteFileName);
                            break;

                        case "5":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static void CreateFile(string fileName, string content)
            {
                try
                {
                    File.WriteAllText(fileName, content);
                    Console.WriteLine($"File '{fileName}' created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating file: {ex.Message}");
                }
            }

            static void ReadFile(string fileName)
            {
                try
                {
                    string content = File.ReadAllText(fileName);
                    Console.WriteLine($"Content of '{fileName}':\n{content}");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File '{fileName}' not found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }

            static void AppendToFile(string fileName, string content)
            {
                try
                {
                    File.AppendAllText(fileName, content);
                    Console.WriteLine($"Content appended to '{fileName}' successfully.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File '{fileName}' not found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error appending to file: {ex.Message}");
                }
            }

            static void DeleteFile(string fileName)
            {
                try
                {
                    File.Delete(fileName);
                    Console.WriteLine($"File '{fileName}' deleted successfully.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File '{fileName}' not found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting file: {ex.Message}");
                }
            }
        }

    }

