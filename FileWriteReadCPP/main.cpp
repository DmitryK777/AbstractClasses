#include <iostream>
#include <fstream>
#include <string>

//#define WRITE_TO_FILE
//#define READ_FROM_FILE
//#define FILE_201_READY
#define FILE_201_DHCPD

using std::cin;
using std::cout;
using std::endl;
using std::string;

void main()
{
	setlocale(LC_ALL, "");

#if defined WRITE_TO_FILE
	std::ofstream fout; // Создаём поток
	fout.open("File.txt", std::ios_base::app); // Открываем поток, std::ios_base::app - новую запись добавляет а не перезаписывает
	fout << "Hello, world!" << endl; // Пишем в поток
	fout.close(); // Закрываем поток

	system("notepad File.txt"); // Открыть блокнот с файлом при запуске программы
#endif


#if defined READ_FROM_FILE
	//cout << strlen(R"(<meta name="scope" content="Windows, Desktop" /><meta name="github_feedback_content_git_url" content="https://github.com/MicrosoftDocs/sdk-api/blob/docs/sdk-api-src/content/fileapi/nf-fileapi-readfile.md" /><link href="https://learn.microsoft.com/en-us/windows/win32/api/fileapi/nf-fileapi-readfile" rel="canonical"><title>ReadFile function (fileapi.h) - Win32 apps | Microsoft Learn</title><link rel="stylesheet" href="/static/assets/0.4.028055824/styles/site-ltr.css">)") << endl;
	//system("PAUSE");

	std::ifstream fin("File.txt"); // Открытие потока (можно совместить с созданием потока)
	if (fin.is_open())
	{
		while (!fin.eof())
		{
			const int SIZE = 1536; // 1536 = 256 * 6
			char sz_buffer[SIZE]{};
			//fin >> sz_buffer; // вывод в поток до пробела так же как и для cin
			fin.getline(sz_buffer, SIZE); // чтобы в поток выводились и пробелы
			cout << sz_buffer << endl;
		}
		fin.close();
	}
	else
	{
		std::cerr << "Error: file not found" << endl;
	}
#endif


#if defined FILE_201_READY
	string input_file = "201 RAW.txt";
	string output_file = "201 READY.txt";

	std::ifstream fin(input_file);
	
	if (fin.is_open())
	{
		std::ofstream fout;
		fout.open(output_file); // std::ios_base::app

		
		string textLine;
		while (getline(fin, textLine))
		{
			string ip = (textLine.size() > 1) ? textLine.substr(0, 14) : " ";
			string mac = (textLine.size() >1) ? textLine.substr(22, 17) : " ";
			
			cout << mac << "\t" << ip << endl;
			fout << mac << "\t" << ip << endl;
		}
		

		/*
		while (!fin.eof())
		{
			const int BUFFER_SIZE = 40;
			const int IP_SIZE = 14;
			const int MAC_SIZE = 17;
			
			char sz_buffer[BUFFER_SIZE]{};
			fin.getline(sz_buffer, BUFFER_SIZE);
			
			char ip[IP_SIZE]{};
			for (int i = 0; i < IP_SIZE; i++) ip[i] = sz_buffer[i];
			
			char mac[MAC_SIZE]{};
			for (int i = (BUFFER_SIZE - MAC_SIZE); i < BUFFER_SIZE; i++) mac[i-(BUFFER_SIZE - MAC_SIZE)] = sz_buffer[i];
			
			cout << mac << "\t" << ip << endl;;
			fout << mac << "\t" << ip  << endl;
		}
		*/

		fin.close();
		fout.close();

		system(("notepad " + output_file).c_str());
	}
	else
	{
		std::cerr << "Error: file " + input_file + " not found!" << endl;
	}
#endif



#if defined FILE_201_DHCPD
	string input_file = "201 RAW.txt";
	string output_file = "201.dhcpd.txt";

	std::ifstream fin(input_file);

	if (fin.is_open())
	{
		std::ofstream fout;
		fout.open(output_file); // std::ios_base::app

		string textLine;
		unsigned int count = 1;
		while (getline(fin, textLine))
		{
			string ip = (textLine.size() > 1) ? textLine.substr(0, 14) : " ";
			string mac = (textLine.size() > 1) ? textLine.substr(22, 17) : " ";

			if (ip != " " && mac != " ")
			{
				string output = "host-" + std::to_string(count) + "\n" +
					"{" + "\n" +
					"\t" + "hardware ethernet" + "\t" + mac + ";" + "\n" +
					"\t" + "fixed address" + "\t\t" + ip + ";" + "\n" +
					"}" + "\n" +
					"\n";

				cout << output;
				fout << output;

				count++;
			}
		}
		fin.close();
		fout.close();

		system(("notepad " + output_file).c_str());
	}
	else
	{
		std::cerr << "Error: file " + input_file + " not found!" << endl;
	}
#endif

}