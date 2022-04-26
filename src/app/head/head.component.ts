import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-head',
  templateUrl: './head.component.html',
  styleUrls: ['./head.component.css']
})
export class HeadComponent implements OnInit {
  

  Laravel : Array<string>;
  Django : Array<string>;
  Git : Array<string>;
  Windows  : Array<string>;
  Linux : Array<string>;
  Node : Array<string>;
  Python : Array<string>;
  Angular : Array<string>;
  Vuej : Array<string>;
  
  
  



  constructor() {
  
    this.Laravel =['Laravel',
    'Composer create-project laravel/laravel (project name)',
    'php artisan make:model (model name) -mcr',
    'php artisan route:list',
    'php artisan storage:link',
    'composer require laravel/ui',
    'assets/img/laravel.png',
    'https://laravel.com/'
  ] 

  this.Django =['Django',
    'pip3 install Django==3.2.8',
    'django-admin startproject (project name)',
    'python manage.py runserver',
    'python manage.py startapp',
    'assets/img/django.jpg',
    'https://www.djangoproject.com/'
  ] 

  this.Git =['Git',
  'git init',
  'git clone',
  'git add (name)',
  'git status',
  'git config',
  'git commit (change)',
  'git checkout',
  'git branch (branch)',
  'git merge',
  'git push',
  'git pull',
  'git remote',
  'assets/img/git.jpg',
  'https://git-scm.com/'
] 
this.Windows =['Windows',
'ipconfig', 
'Windows + L',
'Windows + E',
'Windows + R',
'Windows + Tabulador',
'Windows + Ctrl + D',
'Ctrl + Shift + Esc',
'assets/img/windows.png',
'https://www.microsoft.com/es-bo/'
] 
this.Linux =['Linux',
'cd',
'ls',
'cp',
'mv',
'mkdir',
'sudo su',
'chmod',
'ping',
'assets/img/linux.jpg',
'https://www.linux.org/'
] 
this.Node =['Node.js',
'npm init',
'npm install http',
'npm install express',
'assets/img/node.png',
'https://nodejs.org/en/'
] 
this.Python =['Python',
'pip install matplotlib',
'pip install numpy',
'npm install pandas',
'pip install numba ',
'pip install -U scikit-learn',
'pip install tensorflow',
'pip install shap ',
'pip install --user -U nltk',
'assets/img/python.jpg',
'https://www.python.org/'
] 

this.Angular =['Angular',
'npm install @angular/cli -g',
'ng new my-app',
'ng serve',
'ng generate component new_component',
'ng build',
'ng test ',
'ng generate class my-class',
'assets/img/angular.png',
'https://angular.io/'
] 

this.Vuej =['Vuej.js',
'npm install -g @vue/cli',
'vue create my-project',
'npm run serve',
'assets/img/vuej.jpg',
'https://vuejs.org/?msclkid=0c25b7d3c3e511ec96acc21fd7039cd5'
] 
    

  }

  ngOnInit(): void {
  }

}
