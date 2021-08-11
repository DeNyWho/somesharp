using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static void follower_list(string jsonPath)
        {
            using StreamReader reader = File.OpenText(jsonPath);
            var jToken = JToken.ReadFrom(new JsonTextReader(reader));

            var values =
                jToken["relationships_followers"].Select(j =>
                        j["string_list_data"][0]["value"].ToObject<string>())
                .ToArray();
            File.WriteAllLines("123", values);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // смотрим все названия файлов и записываем их в отдельный массив
            var files = Directory.GetFiles(@"c:\something\bloger\").Select(fn => Path.GetFileName(fn)).ToArray();
            File.WriteAllLines("result", files);
            Console.WriteLine(files.Length);
            for (int i = 0; i < files.Length; i++)
                follower_list("c:\\something\\bloger\\" + files[i]);
            static void follower_list(string jsonPath)
            {
                using StreamReader reader = File.OpenText(jsonPath);
                var jToken = JToken.ReadFrom(new JsonTextReader(reader));
                // Вытаскиваем json данные в строковый массив
                var values =
                    jToken["relationships_followers"].Select(j =>
                            j["string_list_data"][0]["value"].ToObject<string>())
                    .ToArray();
                // вывод в файл
                for (int i = 0; i < values.Length; i++)
                    output_to_file(values[i]);
            }
            static void output_to_file(string value)
            {
                // имя файла
                string filePath = @"C:\something\bloger\result.txt";
                // текст запишем в файл
                string text = "Hello!";
                FileStream fileStream = null;
                // проверяем существует ли файл файл
                if (!File.Exists(filePath))
                    fileStream = File.Create(filePath); // создаем файл
                else
                    fileStream = File.Open(filePath, FileMode.Append); // открываем файл и в конец будут добавлены данные
                StreamWriter output = new StreamWriter(fileStream);
                output.Write($"{value}\n");
                output.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("C:\\something\\client\\result.txt");
            var disctinctLines = lines.Distinct();
            File.WriteAllLines("C:\\something\\client\\result.txt", disctinctLines);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] linesFirst = System.IO.File.ReadAllLines("C:\\something\\result\\result_posle.txt");
            string[] linesSecond = System.IO.File.ReadAllLines("C:\\something\\result\\result_do.txt");
            var intersection = linesFirst.Intersect<string>(linesSecond);
            System.IO.File.WriteAllLines("C:\\something\\result\\result_final.txt", intersection);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                // смотрим все названия файлов и записываем их в отдельный массив
                var files = Directory.GetFiles(@"c:\something\client\").Select(fn => Path.GetFileName(fn)).ToArray();
                File.WriteAllLines("result", files);
                Console.WriteLine(files.Length);
                for (int i = 0; i < files.Length; i++)
                    follower_list("c:\\something\\client\\" + files[i]);
            static void follower_list(string jsonPath)
            {
                using StreamReader reader = File.OpenText(jsonPath);
                var jToken = JToken.ReadFrom(new JsonTextReader(reader));
                // Вытаскиваем json данные в строковый массив
                var values =
                    jToken["relationships_followers"].Select(j =>
                            j["string_list_data"][0]["value"].ToObject<string>())
                    .ToArray();
                // вывод в файл
                for (int i = 0; i < values.Length; i++)
                    output_to_file(values[i]);
            }
            static void output_to_file(string value)
            {
                // имя файла
                string filePath = @"C:\something\client\result.txt";
                // текст запишем в файл
                string text = "Hello!";
                FileStream fileStream = null;
                // проверяем существует ли файл файл
                if (!File.Exists(filePath))
                    fileStream = File.Create(filePath); // создаем файл
                else
                    fileStream = File.Open(filePath, FileMode.Append); // открываем файл и в конец будут добавлены данные
                StreamWriter output = new StreamWriter(fileStream);
                output.Write($"{value}\n");
                output.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
                // смотрим все названия файлов и записываем их в отдельный массив
                var files = Directory.GetFiles(@"c:\something\bloger\after\").Select(fn => Path.GetFileName(fn)).ToArray();
                File.WriteAllLines("result", files);
                Console.WriteLine(files.Length);
                for (int i = 0; i < files.Length; i++)
                    follower_list("c:\\something\\bloger\\after\\" + files[i]);
            static void follower_list(string jsonPath)
            {
                using StreamReader reader = File.OpenText(jsonPath);
                var jToken = JToken.ReadFrom(new JsonTextReader(reader));
                // Вытаскиваем json данные в строковый массив
                var values =
                    jToken["relationships_followers"].Select(j =>
                            j["string_list_data"][0]["value"].ToObject<string>())
                    .ToArray();
                // вывод в файл
                for (int i = 0; i < values.Length; i++)
                    output_to_file(values[i]);
            }
            static void output_to_file(string value)
            {
                // имя файла
                string filePath = @"c:\something\bloger\after\result.txt";
                // текст запишем в файл
                string text = "Hello!";
                FileStream fileStream = null;
                // проверяем существует ли файл файл
                if (!File.Exists(filePath))
                    fileStream = File.Create(filePath); // создаем файл
                else
                    fileStream = File.Open(filePath, FileMode.Append); // открываем файл и в конец будут добавлены данные
                StreamWriter output = new StreamWriter(fileStream);
                output.Write($"{value}\n");
                output.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
                // смотрим все названия файлов и записываем их в отдельный массив
                var files = Directory.GetFiles("C\\something\\client\\after\\").Select(fn => Path.GetFileName(fn)).ToArray();
                File.WriteAllLines("result", files);
                Console.WriteLine(files.Length);
                for (int i = 0; i < files.Length; i++)
                    follower_list("C\\something\\client\\after\\" + files[i]);
            static void follower_list(string jsonPath)
            {
                using StreamReader reader = File.OpenText(jsonPath);
                var jToken = JToken.ReadFrom(new JsonTextReader(reader));
                // Вытаскиваем json данные в строковый массив
                var values =
                    jToken["relationships_followers"].Select(j =>
                            j["string_list_data"][0]["value"].ToObject<string>())
                    .ToArray();
                // вывод в файл
                for (int i = 0; i < values.Length; i++)
                    output_to_file(values[i]);
            }
            static void output_to_file(string value)
            {
                // имя файла
                string filePath = @"C\something\client\after\result.txt";
                // текст запишем в файл
                string text = "Hello!";
                FileStream fileStream = null;
                // проверяем существует ли файл файл
                if (!File.Exists(filePath))
                    fileStream = File.Create(filePath); // создаем файл
                else
                    fileStream = File.Open(filePath, FileMode.Append); // открываем файл и в конец будут добавлены данные
                StreamWriter output = new StreamWriter(fileStream);
                output.Write($"{value}\n");
                output.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("C:\\something\\client\\after\\result.txt");
            var disctinctLines = lines.Distinct();
            File.WriteAllLines("C:\\something\\client\\after\\result.txt", disctinctLines);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] linesFirst = System.IO.File.ReadAllLines("C:\\something\\bloger\\result.txt");
            string[] linesSecond = System.IO.File.ReadAllLines("C:\\something\\client\\result.txt");
            var intersection = linesFirst.Intersect<string>(linesSecond);
            System.IO.File.WriteAllLines("C:\\something\\result\\result_do.txt", intersection);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] linesFirst = System.IO.File.ReadAllLines("C\\something\\client\\after\\result.txt");
            string[] linesSecond = System.IO.File.ReadAllLines("c:\\something\\bloger\\after\\result.txt");
            var intersection = linesFirst.Intersect<string>(linesSecond);
            System.IO.File.WriteAllLines("C:\\something\\result\\result_posle.txt", intersection);
        }
    }
}
