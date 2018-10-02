using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class AzureMobileService
    {

        public MobileServiceClient Client { get; private set; }
        private IMobileServiceSyncTable<TopNFLPlayers> playersTable;

        private async Task Initialize()
        {
            Client = new MobileServiceClient("https://dconfidentlymobile.azurewebsites.net");

            var path = Path.Combine(MobileServiceClient.DefaultDatabasePath, "DraftingDataAccounts.db3");

            var store = new MobileServiceSQLiteStore(path);

            store.DefineTable<TopNFLPlayers>();

            await Client.SyncContext.InitializeAsync(store);

            playersTable = Client.GetSyncTable<TopNFLPlayers>();
        }


        public async Task<IEnumerable<TopNFLPlayers>> GetTopPlayers()
        {
            //Initialize & Sync
            await Initialize();
            await SyncPlayer();

            return await playersTable.ToListAsync();

        }

        private async Task SyncPlayer()
        {
            await playersTable.PullAsync("allPlayers", playersTable.CreateQuery());
            await Client.SyncContext.PushAsync();
        }


        public async Task<List<TopNFLPlayers>> GetAllPlayers()
        {
            await Initialize();
            await SyncPlayer();
            return await playersTable.ToListAsync();
        }




        public async Task<bool> AddPlayer(TopNFLPlayers players)
        {

                await Initialize();  
                await playersTable.InsertAsync(players);
                await SyncPlayer();
                return true;
        }
    }
}
