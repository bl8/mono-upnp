// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Mono.Upnp.GtkClient {
    
    
    public partial class LazyServiceInfo {
        
        private Gtk.Alignment alignment;
        
        private Gtk.Label loading;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Mono.Upnp.GtkClient.LazyServiceInfo
            Stetic.BinContainer.Attach(this);
            this.Name = "Mono.Upnp.GtkClient.LazyServiceInfo";
            // Container child Mono.Upnp.GtkClient.LazyServiceInfo.Gtk.Container+ContainerChild
            this.alignment = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment.Name = "alignment";
            // Container child alignment.Gtk.Container+ContainerChild
            this.loading = new Gtk.Label();
            this.loading.Name = "loading";
            this.loading.LabelProp = Mono.Unix.Catalog.GetString("Loading");
            this.alignment.Add(this.loading);
            this.Add(this.alignment);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.Mapped += new System.EventHandler(this.OnMapped);
        }
    }
}