﻿using Djaka.Api.Models;
using Nancy;
using Nancy.ModelBinding;

namespace Djaka.Api.Controllers
{
    public class PromotionController : BaseController
    {
        public PromotionController() : base("promotions")
        {
            Get("{id}", args => this.PromotionManager.GetPromotion(args.id));

            Post("", _ => PromotionManager.CreatePromotion(this.Bind<Promotion>()));
        }
    }
}
