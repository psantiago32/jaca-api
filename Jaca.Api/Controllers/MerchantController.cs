﻿using Jaca.Api.Models;
using Nancy.ModelBinding;

namespace Jaca.Api.Controllers
{
    public class MerchantController : BaseController
    {
        public MerchantController() : base("merchants")
        {
            Get("{id}", args => this.MerchantManager.GetMerchant(args.id));

            Get("{id}/promotions", args => this.PromotionManager.GetPromotions(args.id));

            Post("", _ => this.MerchantManager.CreateMerchant(this.Bind<Merchant>()));

            Get("", _ => this.MerchantManager.GetAllMerchants());
        }
    }
}
