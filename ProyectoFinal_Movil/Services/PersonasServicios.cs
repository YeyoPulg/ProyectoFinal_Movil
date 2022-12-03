using ProyectoFinal_Movil.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ProyectoFinal_Movil.Services
{
    public class PersonasServicios
    {
        public ObservableCollection<PersonasModel> personas { get; set; }

        public PersonasServicios()
        {
            if (personas==null)
            {
                personas = new ObservableCollection<PersonasModel>();
            }
        }

        public ObservableCollection<PersonasModel> Consultar()
        {
            return personas;
        } 

        public void Guardar(PersonasModel modelo)
        {
            personas.Add(modelo);
        }

        public void Modificar(PersonasModel modelo)
        {
            for (int i=0; i < personas.Count; i++)
            {
                if(personas[i].Id == modelo.Id)
                {
                    personas[i] = modelo;
                }
            }
        }

        public void Eliminar(string idPersona)
        {
            PersonasModel modelo =  personas.FirstOrDefault(p=>p.Id==idPersona);
            personas.Remove(modelo);
        }
    }
}
