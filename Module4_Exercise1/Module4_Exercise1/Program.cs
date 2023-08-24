using System.Threading.Tasks;
using Module4_Exercise1.ReqresApiExample;

namespace Module4_Exercise1;

internal class Program
{
    internal static async Task Main(string[] args)
    {
        await GoogleHttpExample.GooglePageExampleAsync();

        //await ReqresApi.ReqresModelsExampleAsync();

        //await ReqresApi.ReqresPostExampleAsync();

        //await ReqresApi.ReqresSingleUserAsync();

        //await ReqresApi.ReqresSingleUserNotFoundAsync();

        //await ReqresApi.ReqresListResourceAsync();

        //await ReqresApi.ReqresSingleResourceAsync();

        //await ReqresApi.ReqresSingleResourceNotFoundAsync();

        //await ReqresApi.ReqresPostCreateAsync();

        //await ReqresApi.ReqresPutAsync();

        //await ReqresApi.ReqresPatchAsync();

        //await ReqresApi.ReqresDeleteAsync();

        //await ReqresApi.ReqresRegisterSuccessfulAsync();

        //await ReqresApi.ReqresRegisterUnsuccessfulAsync();

        //await ReqresApi.ReqresLoginUnsuccessfulAsync();

        //await ReqresApi.ReqresDelayAsync();

        //await DogsApi.DownloadDogAsync();
    }
}
