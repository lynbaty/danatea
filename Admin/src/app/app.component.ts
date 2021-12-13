import { Component, OnInit } from '@angular/core';
declare var $: any

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  ngOnInit(): void {
    $( document ).ready(function(){
      $('#eye').click(function(){
        if ($('#showpass').attr('type')==='text') {
            $('#showpass').attr('type','password');
        }else{
            $('#showpass').attr('type','text');
        }
     })
      $('#menubtn').click(function(){
        $('#navbar').toggleClass('hidden');
     })
    })
   }
  title = 'admin';
}
