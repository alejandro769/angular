using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSistema
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* Laravel milaravel = new Laravel();
             milaravel.Owner = this;

             milaravel.lbl_1.Content = "holamundo";
             milaravel.ShowDialog();*/
            Principal view_laravel = new Principal();
            view_laravel.Owner = this;

            view_laravel.lbl_1.Content = "Composer create.project laravel/laravel --Name Project--  =====> Create Project in Laravel";
            view_laravel.lbl_2.Content = "php artisan migrate =====> Migrate the database";
            view_laravel.lbl_3.Content = "php artisan make:model --name model-- -mcr  =====> Create model MVC";
            view_laravel.lbl_4.Content = "php artisan route:list  =====> Viewproject routes the project";
            view_laravel.lbl_5.Content = "php artisan storage:link  =====> Conexion with Storage ";
           
            view_laravel.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/R.47aa8decd7007701b1a7a3c7e3df050a?rik=PCZolxv6FmFyHg&pid=ImgRaw&r=0"));




            view_laravel.ShowDialog();
        }

        private void Button_Django(object sender, RoutedEventArgs e)
        {
            Principal view_Django = new Principal();
            view_Django.Owner = this;
            view_Django.lbl_1.Content = "pip install Django==3.2.8  =====> Install library Django";
            view_Django.lbl_2.Content = "django-admin startproject --name-- =====> Create project in Django";
            view_Django.lbl_3.Content = "python manage.py runserver  =====> Run Server";
            view_Django.lbl_4.Content = "python manage.py startapp --name--  =====> Viewproject routes the project";
            view_Django.lbl_5.Content = "python manage.py makemigrations  =====> View modify migrations ";
            view_Django.lbl_6.Content = "python manage.py migrate =====> migrates the database";
            view_Django.Ima.Source = new BitmapImage(new Uri(@"https://logodix.com/logo/1758841.png"));
            view_Django.ShowDialog();

        }

        private void Button_Node(object sender, RoutedEventArgs e)
        {
            Principal view_Node = new Principal();
            view_Node.Owner = this;
            view_Node.lbl_1.Content = "npm init =====> To create a package.json file";
            view_Node.lbl_2.Content = "npm install http =====> Create http web server without express";
            view_Node.lbl_3.Content = "npm install express  =====> Create http web server with express";
            view_Node.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/OIP.JRxYHRKxqnP5X_w5PIOk9gHaGb?pid=ImgDet&rs=1"));
            view_Node.ShowDialog();

        }

        private void Button_Python(object sender, RoutedEventArgs e)
        {
            Principal view_Python = new Principal();
            view_Python.Owner = this;
            view_Python.lbl_1.Content = "pip install matplotlib =====> Graph generator";
            view_Python.lbl_2.Content = "pip install numpy =====> Science computing";
            view_Python.lbl_3.Content = "npm install pandas  =====> Use of 3d and 2d data";
            view_Python.lbl_4.Content = "pip install numba  =====> Algorithms reduces compilation time";
            view_Python.lbl_5.Content = "pip install -U scikit-learn  =====> Use smart quina for logistic regression";
            view_Python.lbl_6.Content = "pip install tensorflow  =====> Machine learning";
            view_Python.lbl_7.Content = "pip install shap  =====> For use of neural networks";
            view_Python.lbl_8.Content = "pip install --user -U nltk  =====> Use of natural language";
            view_Python.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/OIP.sGVdeFkW3YY2sCstTEZ8egHaHa?pid=ImgDet&rs=1"));

            view_Python.ShowDialog();

        }

        private void Button_Linux(object sender, RoutedEventArgs e)
        {
            Principal view_Linux = new Principal();
            view_Linux.Owner = this;
            view_Linux.lbl_1.Content = "cd =====> Browse by file";
            view_Linux.lbl_2.Content = "ls =====> View the contents of a file";
            view_Linux.lbl_3.Content = "cp  =====> Copy files";
            view_Linux.lbl_4.Content = "mv  =====> move files";
            view_Linux.lbl_5.Content = "mkdir  =====> Create directory";
            view_Linux.lbl_6.Content = "sudo su  =====> Sign in as an administrator";
            view_Linux.lbl_7.Content = "chmod  =====> Change permissions";
            view_Linux.lbl_8.Content = "ping  =====> Internet connectivity";
            view_Linux.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/R.95d7d4b5717e137388996f5b4decacb1?rik=uPwOHTEh3tKlTw&pid=ImgRaw&r=0"));

            view_Linux.ShowDialog();

        }

        private void Button_Window(object sender, RoutedEventArgs e)
        {
            Principal view_Windows = new Principal();
            view_Windows.Owner = this;
            view_Windows.lbl_1.Content = "ipconfig  =====> Connection list";
            view_Windows.lbl_2.Content = "Windows + L =====> Lock computer";
            view_Windows.lbl_3.Content = "Windows + E.  =====> Enter file explorer";
            view_Windows.lbl_4.Content = "Windows + R. =====> Run an application";
            view_Windows.lbl_5.Content = "Windows + Tabulador  =====> Change window";
            view_Windows.lbl_6.Content = "Windows + Ctrl + D.  =====> Generate desktops";
            view_Windows.lbl_7.Content = "Ctrl + Shift + Esc.  =====> Open task manager";
            view_Windows.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/OIP.4ZD0kfumnxlWhVuzvKc-GAHaE8?pid=ImgDet&w=768&h=512&rs=1"));


            view_Windows.ShowDialog();

        }

        private void Button_Angular(object sender, RoutedEventArgs e)
        {
            Principal view_Angular = new Principal();
            view_Angular.Owner = this;
            view_Angular.lbl_1.Content = "npm install @angular/cli -g  =====> Install angular CLI";
            view_Angular.lbl_2.Content = "ng new my-app =====> Create project angular";
            view_Angular.lbl_3.Content = "ng serve  =====> Run Server";
            view_Angular.lbl_4.Content = "ng generate component new_component =====> Create a new component ";
            view_Angular.lbl_5.Content = "ng build  =====> Create a build";
            view_Angular.lbl_6.Content = "ng test  =====> Run test cases";
            view_Angular.lbl_7.Content = "ng generate class my-class  =====> Create a class";
            view_Angular.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/R.5baa0a00d84dd2a29f24823787f0c7a4?rik=jKh03ug4IQ94vw&pid=ImgRaw&r=0"));
            view_Angular.ShowDialog();

        }

        private void Button_Git(object sender, RoutedEventArgs e)
        {
            Principal view_Git = new Principal();
            view_Git.Owner = this;
            view_Git.lbl_1.Content = "git init  =====> Start local git";
            view_Git.lbl_2.Content = "git clone =====> Clone a repository";
            view_Git.lbl_3.Content = "git add*  =====> Add Modifications";
            view_Git.lbl_4.Content = "git status =====> View repository states";
            view_Git.lbl_5.Content = "git commit -m   =====> Save changes with a message";
            view_Git.lbl_6.Content = "git remote add origin  =====> Switch with current repository";
            view_Git.lbl_7.Content = "git push -u origin master  =====> Sync with repository";
            view_Git.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/OIP.qdSP64cjgExVDMXwwu0TmwHaFj?pid=ImgDet&rs=1"));
            view_Git.ShowDialog();

        }

        private void Button_Vuej(object sender, RoutedEventArgs e)
        {
            Principal view_Vuej = new Principal();
            view_Vuej.Owner = this;
            view_Vuej.lbl_1.Content = "npm install -g @vue/cli  =====> Install vuej.js";
            view_Vuej.lbl_2.Content = "vue create my-project =====> Create project vuej js";
            view_Vuej.lbl_3.Content = "npm run serve  =====> Run Server";
            view_Vuej.Ima.Source = new BitmapImage(new Uri(@"https://th.bing.com/th/id/OIP.7p4mCfsrt4sfH3_DPFnMiQHaHa?pid=ImgDet&rs=1"));
            view_Vuej.ShowDialog();

        }
    }
}
