<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Ext
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        #main{
	    margin:0 !important;
	    padding:0 !important;	    
        }
        #footer 
        {
            padding:0 !important;
        }
    </style>
    <div >
        <link rel="stylesheet" type="text/css" href="http://localhost/ext-3.4.0/resources/css/ext-all.css"/>
    <script type="text/javascript" src="http://localhost/ext-3.4.0/adapter/ext/ext-base.js"></script>
    <script type="text/javascript" src="http://localhost/ext-3.4.0/ext-all-debug.js"></script>
	
	<!-- Cargador de catálogos -->
	<script type="text/javascript" src="/js/componentes_y_comportamientos/tab_manager/comportamiento_tab_manager.js"></script>
    <script type="text/javascript" src="/js/componentes_y_comportamientos/tab_manager/tabPanel.ui.js"></script>
    <script type="text/javascript" src="/js/componentes_y_comportamientos/tab_manager/tabPanel.js"></script>
	<!-- Comportamientos 	  -->	
	<link rel="stylesheet" type="text/css" href="/css/icrud_styles.css"/>
	<script type="text/javascript" src="/js/componentes_y_comportamientos/comportamiento_grid.js"></script>
    <script type="text/javascript" src="/js/componentes_y_comportamientos/comportamiento_formulario.js"></script>
	<!-- Para el modo de desarrollo, generar un comprimido por catalogo -->
	
	<!-- Paginacion  -->
	<script type="text/javascript" src="/js/cat_modelo/grid/stoModelo.js"></script>
	<script type="text/javascript" src="/js/cat_modelo/grid/gridModelo.ui.js"></script>
    <script type="text/javascript" src="/js/cat_modelo/grid/gridModelo.js"></script>
	<!-- Formulario  -->
	<script type="text/javascript" src="/js/cat_modelo/edicion/frmModelo.ui.js"></script>
    <script type="text/javascript" src="/js/cat_modelo/edicion/frmModelo.js"></script>

    <script type="text/javascript" >
        //Implementar ICrud


        Ext.onReady(function () {
            function getAltoPagina() {
                return '400px';
            }

            Ext.QuickTips.init();
            tabManager = new tabPanel(
                {
                    renderTo: 'los_tabs',
                    width: '100%'
                    // ,height:900
                }
             );
                tabManager.add({ xtype: 'gridModelo' });
            
        });

        
</script>	
        
        <div id="los_tabs" class="los_tabs"></div>
    </div>
    
    


</asp:Content>
