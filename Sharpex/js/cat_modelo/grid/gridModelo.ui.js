/*
 * File: gridModelo.ui.js
 * Date: Mon Aug 27 2012 21:44:35 GMT-0600 (Hora verano, Montañas (México))
 * 
 * This file was generated by Ext Designer version 1.1.2.
 * http://www.sencha.com/products/designer/
 *
 * This file will be auto-generated each and everytime you export.
 *
 * Do NOT hand edit this file.
 */

gridModeloUi = Ext.extend(Ext.grid.GridPanel, {
    title: 'Listado',
    store: 'stoModelo',
    width: 592,
    height: 600,
    autoExpandColumn: '',
    initComponent: function() {
        this.tbar = {
            xtype: 'toolbar',
            items: [
                {
                    xtype: 'button',
                    text: 'Nuevo',
                    iconCls: 'btnNuevoIcon',
                    itemId: 'btnNuevo',
                    scale: 'medium',
                    iconAlign: 'top',
                    ref: '../btnNuevo'
                },
                {
                    xtype: 'button',
                    text: 'Ver',
                    iconAlign: 'top',
                    scale: 'medium',
                    iconCls: 'btnVer',
                    ref: '../btnVer'
                },
                {
                    xtype: 'button',
                    text: 'Editar',
                    iconCls: 'btnEditarIcon',
                    scale: 'medium',
                    iconAlign: 'top',
                    ref: '../btnEditar'
                },
                {
                    xtype: 'button',
                    text: 'Eliminar',
                    iconCls: 'btnEliminarIcon',
                    scale: 'medium',
                    iconAlign: 'top',
                    ref: '../btnEliminar'
                },
                {
                    xtype: 'tbseparator'
                },
                {
                    xtype: 'tbfill'
                },
                {
                    xtype: 'trigger',
                    itemId: 'txtSearch',
                    cls: '',
                    triggerClass: 'x-form-search-trigger',
                    ref: '../txtSearch'
                }
            ]
        };
        this.bbar = {
            xtype: 'paging',
            store: 'stoModelo',
            displayInfo: true,
            pageSize: 5
        };
        this.columns = [
            {
                xtype: 'gridcolumn',
                header: 'Codigo Regimen',
                dataIndex: 'CodigoRegimen',
                sortable: true,
                width: 100
            },
            {
                xtype: 'gridcolumn',
                header: 'Nombre Regimen',
                dataIndex: 'NombreRegimen',
                sortable: true,
                width: 100
            },
            {
                xtype: 'gridcolumn',
                header: 'Pide CURP',
                sortable: true,
                width: 100,
                dataIndex: 'PideCURP'
            },
            {
                xtype: 'gridcolumn',
                header: 'Activo',
                dataIndex: 'Activo',
                sortable: true,
                width: 100,
                id: ''
            }
        ];
        gridModeloUi.superclass.initComponent.call(this);
    }
});
