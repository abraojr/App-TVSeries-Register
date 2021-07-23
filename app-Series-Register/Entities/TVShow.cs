using System;

namespace app_Series_Register
{
    class TVShow : BaseEntity
    {
        //Attributes
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted { get; set; }


        //Methods
        public TVShow(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public override string ToString()
        {
            string callback = "";
            callback += "Genre: " + this.Genre + Environment.NewLine;
            callback += "Title: " + this.Title + Environment.NewLine;
            callback += "Description: " + this.Description + Environment.NewLine;
            callback += "Release Year: " + this.Year + Environment.NewLine;
            callback += "Deleted: " + this.Deleted;
            return callback;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public int getId()
        {
            return this.Id;
        }
        public bool getDeleted()
        {
            return this.Deleted;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
    }
}
