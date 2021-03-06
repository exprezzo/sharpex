/*
 * File: stoModelo.js
 * Date: Mon Aug 27 2012 21:44:35 GMT-0600 (Hora verano, Montañas (México))
 * 
 * This file was generated by Ext Designer version 1.1.2.
 * http://www.sencha.com/products/designer/
 *
 * This file will be auto-generated each and everytime you export.
 *
 * Do NOT hand edit this file.
 */

stoModelo = Ext.extend(Ext.data.JsonStore, {
    constructor: function(cfg) {
        cfg = cfg || {};
        stoModelo.superclass.constructor.call(this, Ext.apply({
            storeId: 'stoModelo',
            root: 'datos',
            messageProperty: 'msg',
            api: {
                read: '/Home/listar',
                create: '/Home/crear',
                update: '/Home/guardar',
                destroy: '/Home/eliminar'
            },
            fields: [
                {
                    name: 'CodigoRegimen'
                },
                {
                    name: 'NombreRegimen'
                },
                {
                    name: 'Activo'
                },
                {
                    name: 'PideCURP'
                }
            ]
        }, cfg));
    }
});
Ext.reg('stoModelo', stoModelo);new stoModelo();