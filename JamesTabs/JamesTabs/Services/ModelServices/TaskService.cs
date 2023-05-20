using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using JamesTabs.Models;
using MySqlConnector;

namespace JamesTabs.Services.ModelServices
{
    public static class TaskService
    {
        public static void AddTask(Task task)
        {
            using(var cmd = new MySqlCommand("Insert Into task (title, deadline, description) values (@title, @deadline, @description)", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@title", task.title);
                cmd.Parameters.AddWithValue("@deadline", task.deadline);
                cmd.Parameters.AddWithValue("@description", task.description);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }

        public static List<Task> GetAllTask()
        {
            List<Task> tasks = new List<Task>();
            using (var cmd = new MySqlCommand("Select * from task;", DatabaseHelper.Instance.Connection))
            {
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task newTask = new Task
                            {
                                id = reader.GetInt32(0),
                                title = reader.GetString(1),
                                deadline = reader.GetDateTime(2),
                                description = reader.GetString(3),
                            };

                            tasks.Add(newTask);
                        }
                    }
                    
                }
                catch (Exception)
                {

                }
            }
            return tasks;
        }

        public static Task GetTaskById(int id)
        {
            Task task = new Task();
            using (var cmd = new MySqlCommand("Select * from task where id = @id;", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Task newTask = new Task
                            {
                                id = reader.GetInt32(0),
                                title = reader.GetString(1),
                                deadline = reader.GetDateTime(2),
                                description = reader.GetString(3),
                            };
                            return newTask;
                        }
                    }

                }
                catch (Exception)
                {

                }
            }
            return null;
        }

        public static void UpdateTask(Task task) 
        {
            using (var cmd = new MySqlCommand("Update task set title = @title, deadline = @deadline, description = @description where id = @id;", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", task.id);
                cmd.Parameters.AddWithValue("@title", task.title);
                cmd.Parameters.AddWithValue("@deadline", task.deadline);
                cmd.Parameters.AddWithValue("@description", task.description);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }

        public static void DeleteTask(int id) 
        {
            using (var cmd = new MySqlCommand("Delete from task where id = @id;", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
