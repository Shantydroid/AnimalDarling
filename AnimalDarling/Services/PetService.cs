using AnimalDarling.Enums;
using AnimalDarling.Models;

namespace AnimalDarling.Services
{
    public static class PetService
    {
        static string maleIcon;
        static string femaleIcon;

        public static List<Razes> GetRazesList()
        {
            maleIcon = char.ConvertFromUtf32(int.Parse("f222", NumberStyles.HexNumber));
            femaleIcon = char.ConvertFromUtf32(int.Parse("f221", NumberStyles.HexNumber));

            return new List<Razes>
            {
                new Razes { Id = 1, Image = "mallorquin.svg", Text = "Pastor mallorquín", IsSelected = true },
                new Razes { Id = 2, Image = "catalan.svg", Text = "Pastor Catalán" },
                new Razes { Id = 3, Image = "mastin.svg", Text = "Mastín español" },
                new Razes { Id = 4, Image = "pirineo.svg", Text = "Mastín del pirineo" },
                new Razes { Id = 5, Image = "dogomallorquin.svg", Text = "Dogo mallorquín" },
                new Razes { Id = 6, Image = "presacanario.svg", Text = "Presa Canario" }
            };
        }

        public static List<RazesDetail> GetRazesDetailList(RazesEnum race)
        {

            switch (race)
            {
                case RazesEnum.Mallorcan:
                    return GetMallorcanPets();
                    break;
                case RazesEnum.Catalan:
                    return GetCatalanPets();
                    break;
                case RazesEnum.SpanishMastin:
                    return GetSpanishMastinPets();
                    break;
                case RazesEnum.PirineumMastin:
                    return GetPirineumMastinPets();
                    break;
                case RazesEnum.MallorcanDogo:
                    return GetMallorcanDogoPets();
                    break;
                case RazesEnum.CanarianHunter:
                    return GetCanarianHunterPets();
                    break;
                default:
                    return new List<RazesDetail>();
                    break;
            }

        }

        static List<RazesDetail> GetMallorcanPets()
        {
            var data = new List<RazesDetail>();

            var listPastorMallorquin = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar1.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/CA_BESTIAR-cuerpo.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar.jpg"))
            };

            data.Add(new RazesDetail { Name = "Cherry", Images = listPastorMallorquin, Title = "Zaragoza", Age = "2 años", Gender = "Macho", GenderIcon = maleIcon, Race = "Pastor mallorquín" });

            var listPastorMallorquin1 = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/7/7c/Ca_de_Bestiar.JPG")),
                ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/8/80/Ca_de_bestiar.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar.jpg"))
            };

            data.Add(new RazesDetail { Name = "Pety", Images = listPastorMallorquin1, Title = "Castellón", Age = "1 año", Gender = "Hembra", GenderIcon = femaleIcon, Race = "Pastor mallorquín" });

            var listPastorMallorquin2 = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.petclic.es/wikipets/wp-content/uploads/sites/default/files/library/ca_de_bestiar.jpg")),
                ImageSource.FromUri(new Uri("https://i0.wp.com/www.mascotadomestica.com/wp-content/uploads/2012/03/pastor-mallorquin.jpg?resize=350%2C219&ssl=1")),
                ImageSource.FromUri(new Uri("https://media.graphassets.com/output=format:webp/k12vRR6T26eGy34ItDCC?width=1280"))
            };

            data.Add(new RazesDetail { Name = "Puppy", Images = listPastorMallorquin2, Title = "Tudela", Age = "4 meses", Gender = "Hembra", GenderIcon = femaleIcon, Race = "Pastor mallorquín" });

            var listPastorMallorquin3 = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.perros.com/content/perros_com/imagenes/galerias/thumbs6/thor.JPG")),
                ImageSource.FromUri(new Uri("https://img.over-blog-kiwi.com/0/89/44/95/20140116/ob_aa742c_duque-solo-02-agosto-1995.jpg")),
                ImageSource.FromUri(new Uri("https://razasdeperros.page/wp-content/uploads/2020/01/pastor-mallorquin.jpg"))
            };

            data.Add(new RazesDetail { Name = "Bobby", Images = listPastorMallorquin3, Title = "Logroño", Age = "1 mes", Gender = "Macho", GenderIcon = maleIcon, Race = "Pastor mallorquín" });

            return data;
        }

        static List<RazesDetail> GetCatalanPets()
        {
            var data = new List<RazesDetail>();

            var listPastorCatalan = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/GOS_DATURA-cuerpo.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Gos-datura1.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Gos-datura.jpg"))
            };

            data.Add(new RazesDetail { Name = "Pep", Images = listPastorCatalan, Title = "Andorra", Age = "1 mes", Gender = "Macho", GenderIcon = maleIcon, Race = "Pastor Catalán" });

            return data;
        }

        static List<RazesDetail> GetSpanishMastinPets()
        {
            var data = new List<RazesDetail>();

            var listMastinEspañol = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/MASTIN_ESPANYOL-cuerpo.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-espanyol1.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-espanyol.jpg"))
            };

            data.Add(new RazesDetail { Name = "Luke", Images = listMastinEspañol, Title = "Legazpi", Age = "2 años", Gender = "Macho", GenderIcon = maleIcon, Race = "Mastín español" });

            return data;
        }

        static List<RazesDetail> GetPirineumMastinPets()
        {
            var data = new List<RazesDetail>();

            var listMastinPirineo = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/MASTIN_PIRINEO-cuerpo.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-Pirineo.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-Pirineo1.jpg"))
            };

            data.Add(new RazesDetail { Name = "Ronan", Images = listMastinPirineo, Title = "León", Age = "7 años", Gender = "Macho", GenderIcon = maleIcon, Race = "Mastín del pirineo" });

            return data;
        }

        static List<RazesDetail> GetMallorcanDogoPets()
        {
            var data = new List<RazesDetail>();

            var listDogoMallorquin = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/CA_BOU-cuerpo.jpg"))
            };

            data.Add(new RazesDetail { Name = "Rocky", Images = listDogoMallorquin, Title = "Santa Cruz de Tenerife", Age = "3 años", Gender = "Macho", GenderIcon = maleIcon, Race = "Dogo mallorquín" });

            return data;
        }

        static List<RazesDetail> GetCanarianHunterPets()
        {
            var data = new List<RazesDetail>();

            var listPresaCanario = new List<ImageSource>
            {
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/PRESA_CANARIO-cuerpo.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Presa-Canario.jpg")),
                ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Presa-canario1.jpg"))
            };

            data.Add(new RazesDetail { Name = "Luca", Images = listPresaCanario, Title = "Sevilla", Age = "10 meses", Gender = "Hembra", GenderIcon = femaleIcon, Race = "Presa Canario" });

            return data;
        }
    }
}
