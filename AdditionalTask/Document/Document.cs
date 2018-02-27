using System;
namespace AdditionalTask
{
    class Document
    {
        Part title = null;
        Part body = null;
        Part footer = null;

        void InitializeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }
        public Document(string title)
        {
            this.InitializeDocument();
            this.title.Content = title;
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;    
            }
        }

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        virtual public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }
}
