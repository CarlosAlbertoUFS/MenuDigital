using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using MenuDigital.Domain;

namespace MenuDigital
{
    public class ItensAdapter : RecyclerView.Adapter
    {
        private readonly List<Item> itens;

        public ItensAdapter(List<Item> itens)
        {
            this.itens = itens;
        }

        public override int ItemCount => throw new System.NotImplementedException();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new System.NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new System.NotImplementedException();
        }
    }
}