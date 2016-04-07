using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example3
{
    /// <summary>
    /// http://www.dofactory.com/net/factory-method-design-pattern
    /// </summary>
    public abstract class Page
    {
        public string PageType
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }

    public class SkillsPage : Page { }   

    public class EducationalPage : Page { }

    public class ExperiencePage : Page { }

    public class IntroductionPage : Page { }

    public class ResultsPage : Page { }

    public class ConclusionPage : Page { }

    public class SummaryPage : Page { }

    public class BibliographyPage : Page { }


    public abstract class Document
    {
        private List<Page> pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get
            {
                return this.pages;
            }
            
        }
        protected abstract void CreatePages();

        public void PrintPages()
        {
            this.Pages.ForEach(x => Console.WriteLine(x.PageType));
        }
    }

    public class Resume : Document
    {
        protected override void CreatePages()
        {
            this.Pages.Add(new SkillsPage());
            this.Pages.Add(new EducationalPage());
            this.Pages.Add(new ExperiencePage());
        }
    }

    public class Report : Document
    {
        protected override void CreatePages()
        {
            this.Pages.Add(new IntroductionPage());
            this.Pages.Add(new ResultsPage());
            this.Pages.Add(new ConclusionPage());
            this.Pages.Add(new SummaryPage());
            this.Pages.Add(new BibliographyPage());
        }
    }

}
