using MODEL.Abstract.BaseEntities.Films;
using MODEL.Entities.OrderEntities;
using MODEL.Entities.SupplierEntities;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.FilmEntities
{
    public class Film : BaseFilmEntity
    {
        //Relation:Order Detail

        public List<OrderDetail> OrderDetails { get; set; }

        //Relation:Faulty Film

        public List<FaultyFilm> faultyFilms { get; set; }

        public List<UserFilmList> UserFilmList { get; set; }

        //Relation:CategoryFilm
        public List<CategoryFilm> categoryFilms { get; set; }
        //Relation Inventory
        public List<Inventory> Inventory { get; set; }
        //Relation : SpecialCategory
        public SpecialCategory? SpecialCategory { get; set; }
        //Relation: Rating
        public List<Rating> ratings { get; set; }

        //Relation : Comment
        public List<Comment> Comments { get; set; }
        //Relation : Award
        public List<Award> Awards { get; set; }

        //Relation : FilmArtist
        public List<FilmArtist> FilmArtist {  get; set; }
        //Relation : FilmDirector
        public List<FilmDirector> filmDirectors { get; set; }
        //Relation : UserWatchList

        public List<UserWatchList> userWatchLists { get; set; }

        //Relation : UserFilmRental
        public List<UserFilmRental> userFilmRental { get; set; }
        //Relation : SupplierFilm
        public List<SupplierFilm> supplierFilm { get; set; }
    }
}
