using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using JeanLuis_AP1_P2.Model;
using JeanLuis_AP1_P2.DAL;
using System.Linq.Expressions;
namespace JeanLuis_AP1_P2.BLL
{
    public class CostoBLL
    {
        private Contexto contexto;

        public CostoBLL(Contexto _contexto)
        {
            contexto = _contexto;
        }
         Costos costos = new Costos();
        
        /*  Productospaquete productospaquete = new Productospaquete(); */
        public bool insertar(Costos inseta)
        {
            bool paso = false;
            try
            {
                
                    contexto.Costos.Add(inseta);

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

      
        public List<Costos> GetListCosto(Expression<Func<Costos, bool>> criterio)
        {

            List<Costos> lista = new List<Costos>();
            try
            {
                lista = contexto.Costos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
          public List<Costosdetalle> GetListdCostodetalle(Expression<Func<Costosdetalle, bool>> criterio)
           {
               List<Costosdetalle> lista = new List<Costosdetalle>();
               try
               {
                   lista = contexto.Costosdetalles.Where(criterio).ToList();
               }
               catch (Exception)
               {
                   throw;
               }

               return lista;
           } 
         
        public List<Costos> GeListaCosto()
        {

            return contexto.Costos.ToList();



        }
          public List<Costosdetalle> GeListadCostodetalle()
         {

             return contexto.Costosdetalles.ToList();



         } 





           public List<Clientes> GetListClientes(Expression<Func<Clientes, bool>> criterio)
        {

            List<Clientes> lista = new List<Clientes>();
            try
            {
                lista = contexto.Clientes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
          public List<Ventas> GetListdVentas(Expression<Func<Ventas, bool>> criterio)
           {
               List<Ventas> lista = new List<Ventas>();
               try
               {
                   lista = contexto.Ventas.Where(criterio).ToList();
               }
               catch (Exception)
               {
                   throw;
               }

               return lista;
           } 

          public List<Ventas> GeListaVenta()
        {

            return contexto.Ventas.ToList();



        }
          public List<Clientes> GeListadClientes()
         {

             return contexto.Clientes.ToList();



         } 
        





    }
        
        
    
        

}