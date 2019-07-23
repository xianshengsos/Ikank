using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.Repoistory;

namespace Service
{
   public class SuggestService
    {
        private SuggestRepository _suggestRepository;
        public SuggestService()
        {
            _suggestRepository = new SuggestRepository();
        }
        public Suggest Publish(string title,string body,int authorId)
        {
            Suggest suggest = new Suggest
            {
                Author = new UserRepository().GetById(authorId),
                Body = body,
                Title = title,
            };
            suggest.Publish();
            return _suggestRepository.Save(suggest);
        }
    }
}
