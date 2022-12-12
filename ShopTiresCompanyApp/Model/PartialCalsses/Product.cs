using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using ShopTiresCompanyApp.Model;



namespace ShopTiresCompanyApp.Model
{
    Core db = new Core();
    public partial class Product
    {
        public string ImagePath
        {
            get
            {
                if (Image == null)
                {
                    return "/Assets/Images/picture.png";
                }
                else
                {
                    return "/Assets/Images" + Image;
                }
            }
        }

        public string MaterialList
        {
            get
            {
                string materials = "Материалы:  ";
                List<string> arrayMaterials = new List<string> { };
                List<ProductMaterial> arrayActiveProduct = db.context.ProductMaterial.Where(x => x.ProductID == ID).ToList();
                foreach (var item in arrayActiveProduct)
                {
                    arrayMaterials.Add(item.Material.Title.ToString());

                }
                materials += String.Join(",", arrayMaterials);
                return materials;
            }
        }
        public string ReadyCount
        {
            get
            {
               
            }
        }
    }
}