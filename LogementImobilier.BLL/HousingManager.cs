﻿using LogementImobilier.BO;
using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{
    public class HousingManager
    {
        public HousingRepository housinRepository;

        public HousingManager()
        {
            housinRepository = new HousingRepository();
        }
        public void CreateHousing(Housing housing)
        {
            housinRepository.Add(housing);
        }
        public void EditHousing(Housing oldHousing , Housing newHousing)
        {
            housinRepository.Set(oldHousing, newHousing);
        }
        public void DeleteHousing(Housing housing)
        {
            housinRepository.Delete(housing);
        }
        public void GetAllHousing()
        {
            housinRepository.GetAll();
        }
        public decimal CalculSurface(decimal longs, decimal larg)
        {
            return (longs * larg );
        }

        public List<Housing> Search(string name, string location, int numberExibition, int numberKitchen, int numberRoom, int numberShower, bool parking, bool terasse, decimal price, float numberStars)
        {
            return housinRepository.FindByName(name,location,numberExibition,numberKitchen,numberRoom,
                                                numberShower,parking,terasse,price,numberStars);
        }




        public decimal CalculPrice(int numberRoom, int numberKitchens, int levelOfHousing, int numberExhibition, int numberShower, int duration,int level)
        {
            return ((numberRoom * 2000) + (numberShower * 3000) + (numberKitchens * 3000) + 
                    (levelOfHousing * 5000) + ((numberExhibition * 15000)) * duration+(level*1000));

        }

        public void Rending(Housing housing, Housing rentingHousing)
        {
            if (housing.Used == false)
                housing.Used = true;
            housinRepository.Set(housing, rentingHousing);
        }

        public void EndRending(Housing housing, Housing newHousing, DateTime endRendingDate)
        {
            if (housing.Used == true)
            {
                housing.Used = false;
                housinRepository.Set(housing, newHousing);
            }
        }
    }
}
