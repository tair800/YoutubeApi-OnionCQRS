﻿using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Product.Exceptions
{
    public class ProductTitleMustNotBeSameException : BaseException
    {
        public ProductTitleMustNotBeSameException() : base("Urun bashligi artig movcuddur")
        {

        }
    }
}
