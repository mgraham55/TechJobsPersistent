using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }

        public int EmployerId { get; set; }

        public List<SelectListItem> Employer { get; set; }

        public List<Skill> Skills { get; set; }

        public int SkillId { get; set; }


        public AddJobViewModel(List<Employer> employers, List<Skill> possibleSkills)
        {
            Employer = new List<SelectListItem>();

            foreach(var employer in employers)
            {
                Employer.Add(new SelectListItem
                    { 
                        Value = employer.Id.ToString(),
                        Text = employer.Name             
                    });
            }
            Skills = possibleSkills;
        }

        public AddJobViewModel()
        {
        }
    }
}
