

import {Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator, MatSort, MatTableDataSource} from '@angular/material';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {
  displayedColumns: string[] = ['state','size', 'name', 'creator name', 'type'];
  dataSource = new MatTableDataSource<ListOfDocuments>(ELEMENT);

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
}

export interface ListOfDocuments {
  name: string;
  size: number;
  creatorName: string;
  type: string;
}

const ELEMENT: ListOfDocuments[] = [
  {size: 1, name: 'Hydrogen', creatorName: 'Hydrogen', type: 'H'},
  {size: 2, name: 'Helium', creatorName: 'Hydrogen', type: 'He'},
  {size: 3, name: 'Lithium', creatorName: 'Hydrogen', type: 'Li'},
  {size: 4, name: 'Beryllium', creatorName: 'Hydrogen', type: 'Be'},
  {size: 5, name: 'Boron', creatorName: 'Hydrogen', type: 'B'},
  {size: 6, name: 'Carbon', creatorName: 'Hydrogen', type: 'C'},
  {size: 7, name: 'Nitrogen', creatorName: 'Hydrogen', type: 'N'},
  {size: 8, name: 'Oxygen', creatorName: 'Hydrogen', type: 'O'},
  {size: 9, name: 'Fluorine', creatorName: 'Hydrogen', type: 'F'},
  {size: 10, name: 'Neon', creatorName: 'Hydrogen', type: 'Ne'},
  {size: 11, name: 'Sodium', creatorName: 'Hydrogen', type: 'Na'},
  {size: 12, name: 'Magnesium', creatorName: 'Hydrogen', type: 'Mg'},
  {size: 13, name: 'Aluminum', creatorName: 'Hydrogen', type: 'Al'},
  {size: 14, name: 'Silicon', creatorName:'Hydrogen', type: 'Si'},
  {size: 15, name: 'Phosphorus', creatorName:'Hydrogen', type: 'P'},
  {size: 16, name: 'Sulfur', creatorName: 'Hydrogen', type: 'S'},
  {size: 17, name: 'Chlorine', creatorName: 'Hydrogen', type: 'Cl'},
  {size: 18, name: 'Argon', creatorName: 'Hydrogen', type: 'Ar'},
  {size: 19, name: 'Potassium', creatorName: 'Hydrogen', type: 'K'},
  {size: 20, name: 'Calcium', creatorName: 'Hydrogen', type: 'Ca'},
];