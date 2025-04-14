import { Component } from '@angular/core';
import { NewservService } from '../../service/newserv.service';

@Component({
  selector: 'app-get-all',
  templateUrl: './get-all.component.html',
  styleUrl: './get-all.component.css'
})
export class GetAllComponent {
  constructor(private myser: NewservService) { }


  ngOnInit() {


    this.getall();
  }

  gets: any



  getall() {


    this.myser.getAllProducts().subscribe((data) => {

      this.gets = data;

    })

  }




}
