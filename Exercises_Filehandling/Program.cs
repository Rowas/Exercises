using System.IO;

string directory = Path.Combine("D:", "School_Files");

Console.WriteLine(directory);

Directory.SetCurrentDirectory(directory);

Console.WriteLine($"Directory.GetCurrentDirectory() => {Directory.GetCurrentDirectory()}");

string[] files = Directory.GetFiles(directory);

foreach (var bytefiles in files)
{
    Console.WriteLine(bytefiles);
}

Console.WriteLine("Pick a file from the above options to open: ");
string file = Console.ReadLine();
Console.WriteLine();

try
{
    using (FileStream stream = File.OpenRead(file))
    {
        byte[] fileData = new byte[50];
        stream.Read(fileData);


        if (fileData[0].ToString("X2") == "42" && fileData[1].ToString("X2") == "4D")
        {
            Console.WriteLine("Image is of type BMP.");
            int width = BitConverter.ToInt32(fileData, 18);
            int height = BitConverter.ToInt32(fileData, 22);
            Console.WriteLine($"Image size = {width} x {height}");
        }
        else if (fileData[0] == 137 && fileData[1] == 80 && fileData[2] == 78 && fileData[3] == 71 && fileData[4] == 13 && fileData[5] == 10 && fileData[6] == 26 && fileData[7] == 10)
        {
            Console.WriteLine("Image is of type PNG");
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(fileData);
            }
            int width = BitConverter.ToInt32(fileData, 26);
            int height = BitConverter.ToInt32(fileData, 30);
            Console.WriteLine($"Resolution: {width} x {height}");
        }
        else
        {
            Console.WriteLine("File is not a valid BMP or PNG file.");
        }

    }
}

catch (System.IO.FileNotFoundException)
{
    Console.WriteLine("File not found.");
}