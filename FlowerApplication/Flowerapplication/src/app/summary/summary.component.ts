import { Component, OnInit } from '@angular/core';
import { Flower } from '../models/flowers';
import { FlowerService } from '../services/flowerService';

@Component({
  selector: 'app-summary',
  templateUrl: './summary.component.html',
  styleUrls: ['./summary.component.css']
})
export class SummaryComponent implements OnInit {
  flower:Flower
  selectedFlower:Flower
  flowers:Flower[];
  tmpFlower:Flower;
  constructor(private flowerService:FlowerService) { 
    this.tmpFlower=new Flower();
    this.flower = new Flower();
    this.flowers = this.flowerService.getSummaryFlowers();
    this.selectedFlower = new Flower();
    
  }

  ngOnInit(): void {
  }
  getPrice(){
    //return  this.flowerService.getTotallSum()
       var total:number = 0;
       this.flowers.forEach(element => {
       total +=element.price*element.qty;
      
    });
    return total;
   }
   removeFlower(id:any){
     this.flowerService.removeFlower(id);
 }
}
