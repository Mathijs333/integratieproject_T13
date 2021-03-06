﻿using System.Collections.Generic;
using System.Linq;
using DAL;
using BL.Domain;
using DAL.EF;

namespace BL
{
    public class ItemManager
    {
        private ItemRepository itemRepository;

        public ItemManager()
        {
            itemRepository = new ItemRepository();
        }

        public List<Item> GetAllItemsFromPosts(List<SocialMediaPost> data)
        {
            Dictionary<int, Item> alteredItems = new Dictionary<int, Item>();
            foreach (var post in data)
            {
                List<Item> items = itemRepository.ReadItems(post);
                foreach (var item in items)
                {
                    //alteredItems.Add(item);
                    if (!alteredItems.ContainsKey(item.ItemId))
                    {
                        alteredItems.Add(item.ItemId, item);
                    }
                        
                }
            }
            return alteredItems.Values.ToList();
        }
    public Person ReadPerson(int id) {
      return itemRepository.ReadPerson(id);
    }
    public Organization ReadOrganization(int id) {
      return itemRepository.ReadOrganization(id);
    }
    public Theme ReadTheme(int id) {
      return itemRepository.ReadTheme(id);
    }

  }
}
