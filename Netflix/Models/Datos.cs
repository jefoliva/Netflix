using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstructurasDeDatos.Lista;
using EstructurasDeDatos.Cola;
using EstructurasDeDatos.Pila;
using Newtonsoft.Json;
using System.IO;

namespace Netflix.Models
{
    public class Datos
    {
        public static Lista<Genero> Generos = new Lista<Genero>
        {
            new Genero() { Id = 0, GeneroNombre = "TV para niños" },
            new Genero() { Id = 1, GeneroNombre = "Drama" },
            new Genero() { Id = 2, GeneroNombre = "Accion y aventuras" },

        };

        public static ListaDoble<Pelicula> peliculas = new ListaDoble<Pelicula>
        {
               new Pelicula { Id = 1, Nombre = "Alvin y las Ardillas", Director = "Tim Hill", Calificacion = 4,
                 GeneroId = 0, AñoDeLanzamiento = "2007",  Duracion = "1h 32 m",
                 PortadaURL = "/img/1-portada.jpg", FondoURL = "/img/1-fondo.jpg",
                 Descripcion = "Después de probar suerte con un desesperanzado compositor, tres ardillas muy peculiares, Alvin, Simon y Theodore, deciden convencer a Dave de que pueden cantar." },

                 new Pelicula { Id = 2, Nombre = "Bob Esponja", Director = "Stephen Hillenburg, Mark Osborne", Calificacion = 5,
                 GeneroId = 0, AñoDeLanzamiento = "2004",  Duracion = "1h 27m",
                 PortadaURL = "/img/2-portada.jpg", FondoURL = "/img/2-fondo.jpg",
                 Descripcion = "Bob Esponja y Patrick viajan a ciudad Shell para recuperar la corona de Neptuno y salvar la vida del Sr. Krabs." },

                 new Pelicula { Id = 3, Nombre = "El Rey Leon", Director = "Roger Allers, Rob Minkoff", Calificacion = 4,
                 GeneroId = 0, AñoDeLanzamiento = "1994",  Duracion = "1h 29m",
                 PortadaURL = "/img/3-portada.jpg", FondoURL = "/img/3-fondo.jpg",
                 Descripcion = "Tras la muerte de su padre, Simba vuelve a enfrentar a su malvado tío, Scar, y reclamar el trono de rey." },

                 new Pelicula { Id = 4, Nombre = "Frozen", Director = "Jennifer Lee, Chris Buck", Calificacion = 3,
                 GeneroId = 0, AñoDeLanzamiento = "2013",  Duracion = "1h 49m",
                 PortadaURL = "/img/4-portada.jpg", FondoURL = "/img/4-fondo.jpg",
                 Descripcion = "Una profecía condena al reino de Arandelle a vivir en un invierno eterno. La joven Anna, el temerario montañero Kristoff y el reno Sven deben emprender un viaje épico y lleno de aventuras en busca de Elsa, la hermana de Anna y Reina de las Nieves. Ella es la única que puede poner fin al gélido hechizo." },

                 new Pelicula { Id = 5, Nombre = "Locos Por El Surf", Director = "Chris Buck, Ash Brannon", Calificacion = 3,
                 GeneroId = 0, AñoDeLanzamiento = "2007",  Duracion = "1h 25m",
                 PortadaURL = "/img/5-portada.jpg", FondoURL = "/img/5-fondo.jpg",
                 Descripcion = "El surfeo significa todo para el pingüino adolescente Cody Maverick. Él es seguido por un equipo de filmación durante su viaje a la Isla Pen Gu en la Antártica, sede de una competencia internacional de surfeo. Cody quiere ser respetado y admirado, y cree que ganando la competencia logrará lo que desean." },

                 new Pelicula { Id = 6, Nombre = "Monster Inc", Director = "Pete Docter", Calificacion = 4,
                 GeneroId = 0, AñoDeLanzamiento = "2001",  Duracion = "1h 50m",
                 PortadaURL = "/img/6-portada.jpg", FondoURL = "/img/6-fondo.jpg",
                 Descripcion = "Monsters, Incorporated es la fábrica de sustos más grande en el mundo de los monstruos y James P. Sullivan es uno de sus mejores asustadores. Sullivan es un monstruo grande e intimidante de piel azul, grandes manchas color púrpura y cuernos. Su asistente, mejor amigo y compañero de cuarto es Mike." },

                 new Pelicula { Id = 7, Nombre = "Ratatouille", Director = "Brad Brid ", Calificacion = 4,
                 GeneroId = 0, AñoDeLanzamiento = "2007",  Duracion = "1h 30m",
                 PortadaURL = "/img/7-portada.jpg", FondoURL = "/img/7-fondo.jpg",
                 Descripcion = "Remy, un residente de París aprecia la buena comida y tiene un paladar bastante sofisticado. Él desea convertirse en un chef para crear y disfrutar de diversas obras de arte culinarias. El único problema es que Remy es una rata. Y cuando termina en las alcantarillas debajo de uno de los restaurantes más finos de París, el roedor se siente en el lugar perfecto para convertir su sueño en una realidad." },

                 new Pelicula { Id = 8, Nombre = "Sherk", Director = "Andrew Adamson, Vicky Jenson", Calificacion = 4,
                 GeneroId = 0, AñoDeLanzamiento = "2001",  Duracion = "1h 35m",
                 PortadaURL = "/img/8-portada.jpg", FondoURL = "/img/8-fondo.jpg",
                 Descripcion = "Había una vez, en un pantano muy lejano, vivía un ogro llamado Shrek (Mike Myers) cuya preciosa soledad se ve súbitamente interrumpida por la invasión de los ruidosos personajes de los cuentos de hadas. Todos fueron expulsados de sus reinos por el malvado Lord Farquaad (John Lithgow). Decidido a salvar su casa, Shrek hace un trato con Farquaad y se prepara para rescatar a la princesa Fiona (Cameron Diaz) para que sea la novia de Farquaad." },

                 new Pelicula { Id = 9, Nombre = "UP Una Aventura De Altura", Director = "Pete Docter", Calificacion = 4,
                 GeneroId = 0, AñoDeLanzamiento = "2009",  Duracion = "1h 36m",
                 PortadaURL = "/img/9-portada.jpg", FondoURL = "/img/9-fondo.jpg",
                 Descripcion = "Carl Fredricksen es un vendedor de globos de 78 años de edad dispuesto a cumplir su sueño: atar miles de globos a su casa y volar a Sudamérica. Sin embargo, descubre demasiado tarde a un joven e inesperado polizón. Lo que en principio será recelo, acabará por tornarse simpatía hacia el muchacho mientras juntos pasan fascinantes aventuras en exóticos lugares." },

                 new Pelicula { Id = 10, Nombre = "MOANA", Director = "Ron Clements, John Musker", Calificacion = 4,
                 GeneroId = 0, AñoDeLanzamiento = "2016",  Duracion = "1h 53m",
                 PortadaURL = "/img/10-portada.jpg", FondoURL = "/img/10-fondo.jpg",
                 Descripcion = "MOANA Waialiki es una joven entusiasta del mar y la única hija de un jefe marinero. Cuando los marineros de su aldea no pueden pescar ningún pez y todas las cosechas fallan, Vaiana descubre que el semidiós Maui causó el infortunio después de robar el corazón de la diosa Te Fiti. La única manera de salvar el destino de la isla es persuadiendo a Maui para que le devuelva el corazón a Te Fiti. Entonces, Vaiana emprende una arriesgada aventura para salvar a su aldea junto al semidiós Maui." },

                 new Pelicula { Id = 11, Nombre = "SIEMPRE A TU LADO", Director = "Lasse Hallström", Calificacion = 4,
                 GeneroId = 1, AñoDeLanzamiento = "2009",  Duracion = "1h 33m",
                 PortadaURL = "/img/11-portada.jpg", FondoURL = "/img/11-fondo.jpg",
                 Descripcion = "Un perro fiel llamado Hachiko acompaña cada mañana a su amo a la estación de tren y regresa cada tarde para darle la bienvenida después del trabajo. Sin embargo, esta rutina se ve rota por una desgracia." },

                 new Pelicula { Id = 12, Nombre = "LO MEJOR DE MI", Director = "Michael Hoffman", Calificacion = 3,
                 GeneroId = 1, AñoDeLanzamiento = "2014",  Duracion = "1h 58m",
                 PortadaURL = "/img/12-portada.jpg", FondoURL = "/img/12-fondo.jpg",
                 Descripcion = "El funeral de un amigo cercano reúne a dos enamorados de la escuela secundaria, quienes descubren que se aman después de 20 años de estar separados." },

                 new Pelicula { Id = 13, Nombre = "TITANIC", Director = "James Cameron", Calificacion = 4,
                 GeneroId = 1, AñoDeLanzamiento = "1997",  Duracion = "3h 15m",
                 PortadaURL = "/img/13-portada.jpg", FondoURL = "/img/13-fondo.jpg",
                 Descripcion = "Una joven de la alta sociedad abandona a su arrogante pretendiente por un artista humilde en el trasatlántico que se hundió durante su viaje inaugural." },

                 new Pelicula { Id = 14, Nombre = "BAJO LA MISMA ESTRELLA", Director = "Josh Boone", Calificacion = 4,
                 GeneroId = 1, AñoDeLanzamiento = "2014",  Duracion = "2h 13m",
                 PortadaURL = "/img/14-portada.jpg", FondoURL = "/img/14-fondo.jpg",
                 Descripcion = "Dos adolescentes pacientes de cáncer inician un viaje para reafirmar sus vidas y visitar a un escritor solitario en Ámsterdam." },

                 new Pelicula { Id = 15, Nombre = "CAMINO", Director = "Javier Fesser", Calificacion = 3,
                 GeneroId = 1, AñoDeLanzamiento = "2008",  Duracion = "2h 23m",
                 PortadaURL = "/img/15-portada.jpg", FondoURL = "/img/15-fondo.jpg",
                 Descripcion = "Camino, una niña de once años muy religiosa, se enfrenta al mismo tiempo a dos acontecimientos que son completamente nuevos para ella: enamorarse y morir.. El tumor que amenaza su vida hace que su familia, perteneciente al Opus Dei, la animen a encontrar fuerzas a través de la fe." },

                 new Pelicula { Id = 16, Nombre = "RECUERDAME", Director = "Allen Coulter", Calificacion = 3,
                 GeneroId = 1, AñoDeLanzamiento = "2010",  Duracion = "2h 08m",
                 PortadaURL = "/img/16-portada.jpg", FondoURL = "/img/16-fondo.jpg",
                 Descripcion = "Historia sobre el poder del amor, la fuerza de la familia y la importancia de  vivir apasionadamente y saber apreciar cada momento de tu vida." },

                 new Pelicula { Id = 17, Nombre = "LA ESPIA ROJA", Director = "Trevor Nunn", Calificacion = 4,
                 GeneroId = 1, AñoDeLanzamiento = "2019",  Duracion = "1h 43m",
                 PortadaURL = "/img/17-portada.jpg", FondoURL = "/img/17-fondo.jpg",
                 Descripcion = "Es el año 2000 y Joan Stanley (Judi Dench) disfruta de su retiro en un barrio residencial durante el cambio de milenio. Su apacible vida se ve súbitamente trastornada cuando es arrestada por el MI5, el Servicio de Inteligencia británico, acusada de proporcionar información a la Rusia comunista, y por ser la espía más longeva del KGB en territorio británico." },

                 new Pelicula { Id = 18, Nombre = "LA FORMA DEL AGUA", Director = "Guillermo del Toro", Calificacion = 3,
                 GeneroId = 1, AñoDeLanzamiento = "2018",  Duracion = "2h 03m",
                 PortadaURL = "/img/18-portada.jpg", FondoURL = "/img/18-fondo.jpg",
                 Descripcion = "Elisa es una joven muda que se enamora de un hombre anfibio que está recluido en un acuario en un laboratorio secreto, propiedad del Gobierno, en el que ella trabaja limpiando. Llevada por el amor, Elisa trama un plan para liberar al mutante." },

                 new Pelicula { Id = 19, Nombre = "YO ANTES DE TI ", Director = "Thea Sharrock", Calificacion = 4,
                 GeneroId = 1, AñoDeLanzamiento = "2016",  Duracion = "1h 51m",
                 PortadaURL = "/img/19-portada.jpg", FondoURL = "/img/19-fondo.jpg",
                 Descripcion = "La vida de Louisa Clark, una chica alegre y alocada, que va empalmando un trabajo con otro para ayudar a su familia a subsistir, cambia por completo cuando comienza a trabajar como cuidadora de un joven millonario, quien quedó paralítico tras un accidente. Poco a poco, se va estableciendo entre ellos una conexión cada vez más íntima." },

                 new Pelicula { Id = 20, Nombre = "EL RENACIDO", Director = "Alejandro González Iñárritu", Calificacion = 4,
                 GeneroId = 1, AñoDeLanzamiento = "2016",  Duracion = "2h 36m",
                 PortadaURL = "/img/20-portada.jpg", FondoURL = "/img/20-fondo.jpg",
                 Descripcion = "El trampero Hugh Glass intenta vengarse de sus compañeros, quienes lo abandonaronherido en el bosque después de que lo atacó un oso, pensando que moriría, víctima de las lesiones y de la crudeza del entorno y del invierno. Sin embargo, el rencor que siente es más fuerte que cualquier adversidad, y Glass no permitirá que nada ni nadie le prive de saciar su odio." },

                 new Pelicula { Id = 21, Nombre = "ANT-MAN", Director = "Peyton Reed", Calificacion = 4,
                 GeneroId = 2, AñoDeLanzamiento = "2015",  Duracion = "1h 58m",
                 PortadaURL = "/img/21-portada.jpg", FondoURL = "/img/21-fondo.jpg",
                 Descripcion = "Con la habilidad de encogerse de tamaño, pero crecer en fuerza, un estafador debe ayudar a su mentor a proteger el secreto de su traje de hombre hormiga y enfrentar un atraco que salvará al mundo." },

                 new Pelicula { Id = 22, Nombre = "EL MECANICO", Director = "Simon West", Calificacion = 3,
                 GeneroId = 2, AñoDeLanzamiento = "2011",  Duracion = "1h 33m",
                 PortadaURL = "/img/22-portada.jpg", FondoURL = "/img/22-fondo.jpg",
                 Descripcion = "Bishop es un asesino a sueldo de élite con un estricto código de honor. Tras la muerte de su amigo Harry, Bishop toma como aprendiz al hijo de este, Steve." },

                 new Pelicula { Id = 23, Nombre = "EL RESCATE", Director = "Marc Forster", Calificacion = 4,
                 GeneroId = 2, AñoDeLanzamiento = "2011",  Duracion = "2h 09m",
                 PortadaURL = "/img/23-portada.jpg", FondoURL = "/img/23-fondo.jpg",
                 Descripcion = "Sam Childers, un exmotociclista, viaja a África para establecer un orfanato para víctimas jóvenes de la guerra." },

                 new Pelicula { Id = 24, Nombre = "EL EXTRANJERO", Director = "Martin Campbell", Calificacion = 3,
                 GeneroId = 2, AñoDeLanzamiento = "2017",  Duracion = "2h 56m",
                 PortadaURL = "/img/24-portada.jpg", FondoURL = "/img/24-fondo.jpg",
                 Descripcion = "Una bomba colocada por terroristas del IRA asesina a la hija del dueño de un restaurante chino en Londres. El padre, antiguo miembro de las fuerzas especiales chinas, decide no esperar a las autoridades y vengar a su hija por su propia cuenta. Durante su misión entra en contacto con un oficial británico." },

                 new Pelicula { Id = 25, Nombre = "LA GRAN MURALLA", Director = "Zhang Yimou", Calificacion = 3,
                 GeneroId = 2, AñoDeLanzamiento = "2016",  Duracion = "2h 00m",
                 PortadaURL = "/img/25-portada.jpg", FondoURL = "/img/25-fondo.jpg",
                 Descripcion = "Encarcelado dentro de la gran muralla de China, un guerrero mercenario une fuerzas con un ejército de élite para luchar contra un ataque de monstruos saqueadores." },

                 new Pelicula { Id = 26, Nombre = "LA ULTIMA OLA", Director = "Roar Uthaug", Calificacion = 4,
                 GeneroId = 2, AñoDeLanzamiento = "2015",  Duracion = "1h 45m",
                 PortadaURL = "/img/26-portada.jpg", FondoURL = "/img/26-fondo.jpg",
                 Descripcion = "Un geólogo noruego y su familia luchan por sobrevivir cuando un deslizamiento de tierra masivo provoca una ola de casi 80 metros de altura." },

                 new Pelicula { Id = 27, Nombre = "NIEVE NEGRA", Director = "Martín Hodara", Calificacion = 3,
                 GeneroId = 2, AñoDeLanzamiento = "2017",  Duracion = "1h 30m",
                 PortadaURL = "/img/27-portada.jpg", FondoURL = "/img/27-fondo.jpg",
                 Descripcion = "Un hombre vive en un lugar aislado desde que fue acusado de matar accidentalmente a su hermano. Un día recibe la inesperada visita de su otro hermano y de su cuñada para tratar el tema de una herencia." },

                 new Pelicula { Id = 28, Nombre = "OPERACION SOMBRA", Director = "Kenneth Branagh", Calificacion = 2,
                 GeneroId = 2, AñoDeLanzamiento = "2014",  Duracion = "1h 45m",
                 PortadaURL = "/img/28-portada.jpg", FondoURL = "/img/28-fondo.jpg",
                 Descripcion = "El analista de la CIA, Jack Ryan descubre un plan ruso para dañar a la economía de Estados Unidos con un ataque terrorista." },

                 new Pelicula { Id = 29, Nombre = "PANTERA NEGRA", Director = "Ryan Coogler", Calificacion = 4,
                 GeneroId = 2, AñoDeLanzamiento = "2018",  Duracion = "2h 15m",
                 PortadaURL = "/img/29-portada.jpg", FondoURL = "/img/29-fondo.jpg",
                 Descripcion = "Después de morir su padre, T'Challa regresa a su nación, Wakanda. Una vez allí, descubre que tiene un nuevo y terrible enemigo, y T'Challa asume la personalidad de Pantera Negra para salvar no solo al reino de Wakanda, sino a toda la humanidad." },

                 new Pelicula { Id = 30, Nombre = "PROYECTO RAMPAGE", Director = "Brad Peyton", Calificacion = 4,
                 GeneroId = 2, AñoDeLanzamiento = "2018",  Duracion = "1h 55m",
                 PortadaURL = "/img/30-portada.jpg", FondoURL = "/img/30-fondo.jpg",
                 Descripcion = "Un gorila, un lobo y una serpiente sufren una mutación genética y se convierten en seres gigantescos y violentos. El primatólogo que cuidaba del gorila y una experta en genética tratan de detenerlos y, al mismo tiempo, evitar que sufran daños." }

        };

        public static ListaDoble<Pelicula> tvniños = Datos.FiltarPorGeneroId(0, peliculas);
        public static ListaDoble<Pelicula> drama = Datos.FiltarPorGeneroId(1, peliculas);
        public static ListaDoble<Pelicula> accionyaventuras = Datos.FiltarPorGeneroId(2, peliculas);
        public static Cola<Pelicula> miLista = new Cola<Pelicula>();
        public static Pila<Pelicula> continuarViendo = new Pila<Pelicula>();

        public static ListaDoble<Pelicula> FiltarPorGeneroId(int id, ListaDoble<Pelicula> lista)
        {
            ListaDoble<Pelicula> resultado = new ListaDoble<Pelicula>();

            foreach(var pelicula in lista)
            {
                if (pelicula.GeneroId == id)
                    resultado.Agregar(pelicula);
            }

            return resultado;
        }
        
        public static ListaDoble<Pelicula> GetData()
        {

            string file = File.ReadAllText(@"..\Data\data.json");
            return JsonConvert.DeserializeObject<ListaDoble<Pelicula>>(file);
        }
    }
}