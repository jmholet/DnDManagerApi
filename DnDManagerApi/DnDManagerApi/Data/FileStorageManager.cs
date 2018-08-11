using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDManagerApi.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace DnDManagerApi.Data
{
    public class FileStorageManager
    {
        public static IConfiguration Configuration { get; set; }

        public void WriteFile(FileTypeEnum fileType, IFile fileToSave)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            string pathToWrite = string.Empty;
            string serializedFile = string.Empty;
            switch (fileType)
            {
                case FileTypeEnum.Location:
                    pathToWrite = $"{Configuration["LocationPath"]}";
                    serializedFile = JsonConvert.SerializeObject((Location)fileToSave);
                    break;
                case FileTypeEnum.Npc:
                    pathToWrite = $"{Configuration["NpcPath"]}";
                    serializedFile = JsonConvert.SerializeObject((Npc)fileToSave);
                    break;
                case FileTypeEnum.Player:
                    pathToWrite = $"{Configuration["PlayerPath"]}";
                    serializedFile = JsonConvert.SerializeObject((Player)fileToSave);
                    break;
                case FileTypeEnum.Party:
                    pathToWrite = $"{Configuration["PartyPath"]}";
                    serializedFile = JsonConvert.SerializeObject((Party)fileToSave);
                    break;
            }

            System.IO.File.WriteAllText(pathToWrite, serializedFile);
        }
    }
}
