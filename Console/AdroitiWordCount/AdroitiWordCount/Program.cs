using AdroitiWordCount.Services;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Today we gonna count words and characters");

//var FileService = new FileService();
//var WordCountService = new WordCountService();

//var AllText = FileService.ReadFile();
//WordCountService.CountWordsAndPrint(AllText);

var services = new ServiceCollection();

static void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IFileService, FileService>();
    services.AddTransient<WordCountService>();
}

ConfigureServices(services);

var serviceProvider = services.BuildServiceProvider();

var wordCountService = serviceProvider.GetService<WordCountService>();

wordCountService.CountWordsAndPrint();