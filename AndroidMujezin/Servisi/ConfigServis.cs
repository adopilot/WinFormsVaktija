using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Servisi
{
    public class ConfigServis
    {
        
        
        public ConfigServis() {
        }
        public Modeli.ConfigModel getModel ()
        {
            var model = new Modeli.ConfigModel();

            foreach (PropertyInfo prop in model.GetType().GetProperties())
            {
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                //if (type == typeof(string))
                //{





                if (prop.PropertyType == typeof(string))
                {

                    var value = Preferences.Default.Get(type.Name, string.Empty);
                    prop.SetValue(model, value.ToString());

                }
                else if (prop.PropertyType == typeof(bool))
                {
                    var value = Preferences.Default.Get(type.Name, false);
                    Preferences.Set(prop.Name, (bool)value);

                }
                else if (prop.PropertyType == typeof(int))
                {
                    var value = Preferences.Default.Get(type.Name, 0);
                    Preferences.Set(prop.Name, (int)value);
                }
                else if (prop.PropertyType == typeof(double))
                {
                    var value = Preferences.Default.Get(type.Name, 0);
                    Preferences.Set(prop.Name, (double)value);
                }
                else if (prop.PropertyType == typeof(float))
                {
                    var value = Preferences.Default.Get(type.Name, 0);
                    Preferences.Set(prop.Name, (float)value);
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    var value = Preferences.Default.Get(type.Name, DateTime.Now);
                    Preferences.Set(prop.Name, (DateTime)value);

                }
                else
                {
                    var value = Preferences.Default.Get(type.Name, string.Empty);
                    Preferences.Set(prop.Name, value?.ToString() ?? string.Empty);
                }


                //}
                //else if (type == typeof(bool))
                //{

                //}
            }
            return model;

        }
        public void setModel(Modeli.ConfigModel model) {

            if (model == null) { model = new Modeli.ConfigModel(); }

            foreach (PropertyInfo prop in model.GetType().GetProperties())
            {
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                //if (type == typeof(string))
                //{
                //var ado = Preferences.Default.Get(type.Name, string.Empty);

                var value = prop.GetValue(prop, null);

                if (prop.PropertyType == typeof(string))
                    Preferences.Set(prop.Name, value.ToString());
                else if (prop.PropertyType == typeof(bool))
                    Preferences.Set(prop.Name, (bool)value);
                else if (prop.PropertyType == typeof(int))
                    Preferences.Set(prop.Name, (int)value);
                else if (prop.PropertyType == typeof(double))
                    Preferences.Set(prop.Name, (double)value);
                else if (prop.PropertyType == typeof(float))
                    Preferences.Set(prop.Name, (float)value);
                else if (prop.PropertyType == typeof(DateTime))
                    Preferences.Set(prop.Name, (DateTime)value);
                else
                    Preferences.Set(prop.Name, value?.ToString() ?? string.Empty);
                    

                



                //}
                //else if (type == typeof(bool))
                //{

                //}
            }
        }
        
        }
}
