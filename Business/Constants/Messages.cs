﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed= "Ürünler Listelendi";
        public static string ProductCountOfCategoryError= "Bir Kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde ürün zaten başka ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied ="Yetkiniz yok";
    }
}
