using System;
using ProjetoBasicoRedeSocial.Entities;

namespace ExercicioResolvido {
    class Program {
        static void Main(string[] args) {
            Comment comentario1 = new Comment("Have a nice trip!");
            Comment comentario2 = new Comment("Wow that's awesome!");

            Post postagem1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), 
                "Traveling to New Zealand", 
                "I am going to visit this wonderful country!", 
                12);

            postagem1.AddComment(comentario1);
            postagem1.AddComment(comentario2);

            Comment comentario3 = new Comment("Good night");
            Comment comentario4 = new Comment("May the Force be with you");

            Post postagem2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            postagem2.AddComment(comentario3);
            postagem2.AddComment(comentario4);

            Console.WriteLine(postagem1);
            Console.WriteLine(postagem2);
        }
    }
}