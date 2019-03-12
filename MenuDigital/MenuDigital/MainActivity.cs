using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using MenuDigital.Repository;

namespace MenuDigital
{
    [Activity(Label = "MenuDigital", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            var repository = new Repositorio();
            var itens = repository.GetItens();
            var itensRV = FindViewById<RecyclerView>(Resource.Id.itensRV);
            itensRV.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
            itensRV.SetAdapter(new ItensAdapter(itens));

        }
    }
}

