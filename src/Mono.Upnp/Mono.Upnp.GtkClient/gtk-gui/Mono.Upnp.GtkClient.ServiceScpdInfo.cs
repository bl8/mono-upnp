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
    
    
    public partial class ServiceScpdInfo {
        
        private Gtk.HBox hbox1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView actions;
        
        private Gtk.ScrolledWindow GtkScrolledWindow1;
        
        private Gtk.TreeView stateVariables;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Mono.Upnp.GtkClient.ServiceScpdInfo
            Stetic.BinContainer.Attach(this);
            this.Name = "Mono.Upnp.GtkClient.ServiceScpdInfo";
            // Container child Mono.Upnp.GtkClient.ServiceScpdInfo.Gtk.Container+ContainerChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.actions = new Gtk.TreeView();
            this.actions.CanFocus = true;
            this.actions.Name = "actions";
            this.GtkScrolledWindow.Add(this.actions);
            this.hbox1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow]));
            w2.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow1 = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
            this.GtkScrolledWindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
            this.stateVariables = new Gtk.TreeView();
            this.stateVariables.CanFocus = true;
            this.stateVariables.Name = "stateVariables";
            this.GtkScrolledWindow1.Add(this.stateVariables);
            this.hbox1.Add(this.GtkScrolledWindow1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow1]));
            w4.Position = 1;
            this.Add(this.hbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.actions.RowActivated += new Gtk.RowActivatedHandler(this.OnActionsRowActivated);
        }
    }
}
