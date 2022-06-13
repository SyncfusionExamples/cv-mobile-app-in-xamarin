using System;
using System.Collections.Generic;
using CvMobileApp.Models;

namespace CvMobileApp.ViewModels
{
    public class CVViewModel
    {
        private List<Education> educationCollection = new List<Education>();
        private List<Skills> skillsCollection = new List<Skills>();

        public CVViewModel()
        {
            //Education
            educationCollection.Add(new Education("logo1", "Purwadhika Startup and Coding School", "UI/UX Connector Program", "2020-2021"));
            educationCollection.Add(new Education("logo1", "Purwadhika Startup and Coding School", "Bachelor of Arquitecture", "2014-2018"));

            //Skills
            skillsCollection.Add(new Skills("Figma", "Figma", 0.5));
            skillsCollection.Add(new Skills("CorelDraw", "Corel Draw", 1));
            skillsCollection.Add(new Skills("AdobePhotoshop", "Adobe Photoshop", 0.8));
            skillsCollection.Add(new Skills("AdobeInDesign", "Adobe InDesign", 1));
        }

        public List<Education> EducationCollection
        {
            get { return educationCollection; }
            set { educationCollection = value; }
        }

        public List<Skills> SkillsCollection
        {
            get { return skillsCollection; }
            set { skillsCollection = value; }
        }
    }
}
