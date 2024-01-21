using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF.DataTemplate
{
    public class ItemSelector : DataTemplateSelector
    {
        public override System.Windows.DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Student? student = item as Student;
            FrameworkElement frameworkElement = container as FrameworkElement;

            return (System.Windows.DataTemplate)frameworkElement.FindResource(
                student?.Gender == "여자"
                    ? "Woman"
                    : "Man");
        }
    }
}
