using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using System;
using todo_app.business.Abstract;
using todo_app.entity;
using todo_app.data.Abstract;
using System.Collections.Generic;

namespace todo_app.webui.Controllers
{
            public class HomeController:Controller
            {   
                private ITaskService _taskService;

                public HomeController(ITaskService taskService)
                {

                    this._taskService = taskService;
                }

               
                public IActionResult Index(Tasks ?T ,int Id =0)
                {
                 
                    if(T == null)
                    {
                        var tasks = _taskService.GetAll();
                        return View(tasks);

                    }
                    if(Id ==0 && T != null){
                               
                               
                                var tasks = _taskService.GetAll();
                                if(T.Name==null || T.Name == " "){
                                    return View(tasks);
                                }
                                if(tasks.Count >0 && tasks.Count <8){
                                    for(var index=0;index<tasks.Count;index++ ){
                                
                                    if(tasks[index].Name == T.Name)
                                            {
                                        
                                        return View(tasks);
                                    

                                          }
                                    }
                                    var newtask = new Tasks(){
                                        Name = T.Name
                                    };
                                    _taskService.Create(newtask);
                                    return RedirectToAction("");            
                                }
                                if(tasks.Count == 0){
                                   var newtask = new Tasks(){
                                        Name = T.Name
                                        };
                                    _taskService.Create(newtask);
                                    
                                        }
                                return RedirectToAction("");
                             }    
                   
                    else 
                    {
                       
                        var deletedtask = _taskService.GetById(Id);
                        _taskService.Delete(deletedtask);
                        var tasks = _taskService.GetAll();
                            return View(tasks);
                        
                    }
                
                }

            }


}