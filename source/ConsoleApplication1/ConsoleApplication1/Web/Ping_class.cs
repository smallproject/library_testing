using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace ConsoleApplication1.Web
{
    class Ping_class
    {
        public virtual ISite Site { get; set; }
        public void Main()
        {
            Site = Site;
            Console.WriteLine("Component: " + Site.Component);
            Console.WriteLine("Container: " + Site.Container);
            Console.WriteLine("Design mode: " + Site.DesignMode);
            Console.WriteLine("Name: " + Site.Name);

        }
    }

    class ISBNSite : ISite
    {
        private IComponent m_curComponent;
        private IContainer m_curContainer;
        private bool m_bDesignmode;
        private string m_ISBNCmpName;

        public ISBNSite(IContainer actvCntr, IComponent prntCmpnt)
        {
            m_curComponent = prntCmpnt;
            m_curContainer = actvCntr;
            m_bDesignmode = false;
            m_ISBNCmpName = null;
        }

        public virtual IComponent Component
        {
            get { return m_curComponent; }
        }

        public virtual IContainer Container
        {
            get { return m_curContainer; }
        }

        public virtual bool DesignMode
        {
            get { return m_bDesignmode; }
        }

        public virtual string Name
        {
            get { return m_ISBNCmpName; }
            set { m_ISBNCmpName = value; }
        }

        public virtual object GetService(Type serviceType)
        {
            return null;
        }
    }

    class BookComponent : IComponent
    {
        public event EventHandler Disposed;
        private ISite m_curISBNSite;
        private string m_bookTitle;
        private string m_bookAuthor;

        public BookComponent(string Title, string Author)
        {
            m_curISBNSite = null;
            Disposed = null;
            m_bookTitle = Title;
            m_bookAuthor = Author;
        }

        public string Title
        {
            get { return m_bookTitle; }
        }

        public string Author
        {
            get { return m_bookAuthor; }
        }

        public virtual ISite Site
        {
            get { return m_curISBNSite; }
            set { m_curISBNSite = value; }
        }

        public override bool Equals(object cmp)
        {
            BookComponent cmpObj = (BookComponent) cmp;
            if (this.Title.Equals(cmpObj.Title) && this.Author.Equals(cmpObj.Author))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
