﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using VideoMenuBLL;
using VideoMenuEntity;

namespace VideoMenuUI
{
    class Program
    {
      static BLLFacade bllFacade = new BLLFacade();

        static void Main(string[] args)
        {
            var vid1 = new Video()
            {
                Name = "The Hobbit",
                Genre = "Adventure"
            };
            bllFacade.VideoService.Create(vid1);

            string[] menuItems =
            {
                "Show all vieos",
                "Add a video",
                "Edit a video",
                "Delete a video",
                "Search for a video",
                "Exit"
            };

            var selection = ShowMenu(menuItems);

            while (selection != 6)
            {
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        ListAllVideos();
                        Console.WriteLine($"All videos are shown\n");
                        break;
                    case 2:
                        Console.Clear();
                        AddVideos();
                        Console.WriteLine("Added a video\n");
                        break;
                    case 3:
                        Console.Clear();
                        EditVideo();
                        Console.WriteLine("Edited a video\n");
                        break;
                    case 4:
                        Console.Clear();
                        DeleteVideo();
                        Console.WriteLine("Deleted a video\n");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(FindVideoById().Name);
                        Console.WriteLine("Searched for a video\n");
                        break;
                    default:
                        Console.Clear();
                        break;

                }
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("Bye bye!");
            Console.ReadLine();
        }

        private static void DeleteVideo()
        {
            var videoFound = FindVideoById();
            if (videoFound != null)
            {
                bllFacade.VideoService.Delete(videoFound.Id);
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }

        private static Video FindVideoById()
        {
            Console.WriteLine("Insert video Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }
            
            return bllFacade.VideoService.Get(id);
        }

        public static void EditVideo()
        {
            var video = FindVideoById();
            if (video != null)
            {
                Console.WriteLine("Name: ");
                video.Name = Console.ReadLine();
                Console.WriteLine("Genre: ");
                video.Genre = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Customer not Found");
            }
        }

        public static void AddVideos()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Genre: ");
            var genre = Console.ReadLine();

            bllFacade.VideoService.Create(new Video()
            {
                Name = name,
                Genre = genre
            });
            Console.Clear();
        }

        public static void ListAllVideos()
        {
            foreach (var video in bllFacade.VideoService.GetAll())
            {
                Console.WriteLine($"Name: {video.Name}    Genre: {video.Genre}   ID: {video.Id}");
            }
            Console.WriteLine("\n");
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select what you want to do:\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                   || selection < 1
                   || selection > 6)
            {
                Console.WriteLine("Please select a number between 1-6\n");
            }
            return selection;
        }
    }
}