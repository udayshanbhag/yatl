
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using todoapi.Models;
using System.Linq;


namespace todoapi.Repository
{
    public class TodoRepository {

        ITodoDatabaseSettings _settings ;
        public TodoRepository( ITodoDatabaseSettings settings)
        {
            _settings = settings;
        }
        public List<Todo> GetAll()
        {
             var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("TodoDb");
            var todos = db.GetCollection<Todo>("Todos", null);
            return todos.Find( t => true).ToList(); 
        }
        

        public void Add(Todo item)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("TodoDb");
            var todos = db.GetCollection<Todo>("Todos", null);
            todos.InsertOne(item);
        }

        
    }
}