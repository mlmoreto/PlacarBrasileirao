using PlacarBrasileirao.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlacarBrasileirao.Repository
{
    class PlacarDatabase
    {
        readonly SQLiteAsyncConnection database;

        public PlacarDatabase(String dbPath)
        {
            //conecta com a base
            database = new SQLiteAsyncConnection(dbPath);
            //Se nao existir tabela Placar, ele cria.
            database.CreateTableAsync<Placar>().Wait();
        }

        public Task<List<Placar>> GetItemsAsync()
        {
            return database.Table<Placar>().ToListAsync();
        }

        public Task<Placar> GetItemAsync(uint id)
        {
            return database.Table<Placar>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Placar item)
        {
            if (item.ID == 0 || item.ID.Equals(null))
            {
                return database.InsertAsync(item);
                //Toast.MakeText(this, 'Sucesso!', ToastLength.Long).Show();
            }

            return database.UpdateAsync(item);
            //await DisplayAlert("Sucesso", "Placar Atualizado com Sucesso!", "Ok");            
            
        }

        public Task<int> DeleteItemAsync(Placar item)
        {
            return database.DeleteAsync(item);
        }

    }

    
}
