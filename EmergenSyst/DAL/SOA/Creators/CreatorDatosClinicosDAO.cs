using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class CreatorDatosClinicosDAO
    {
        public DatosClinicosDAO creator(DatosClinicos dc)
        {
            string tipo = dc.tipo;
            if (tipo.Equals("Alergias"))
            {
                CreatorAlergiasDAO alDAO = new CreatorAlergiasDAO();
                return alDAO.creator();
            }
            else if (tipo.Equals("Antecedentes"))
            {
                CreatorAntecedentesDAO alDAO = new CreatorAntecedentesDAO();
                return alDAO.creator();
            }
            else if (tipo.Equals("Cirugias"))
            {
                CreatorCirugiasDAO alDAO = new CreatorCirugiasDAO();
                return alDAO.creator();
            }
            else if (tipo.Equals("Enfermedades"))
            {
                CreatorEnfermedadesDAO alDAO = new CreatorEnfermedadesDAO();
                return alDAO.creator();
            }
            else if (tipo.Equals("Medicamentos"))
            {
                CreatorMedicamentosDAO alDAO = new CreatorMedicamentosDAO();
                return alDAO.creator();
            }
            else
            {
                return null;
            }
        }    
    }
}
