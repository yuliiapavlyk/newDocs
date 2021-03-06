

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
  {size: 134, name: 'Math rules', creatorName: 'Olena', type: 'txt'},
  {size: 2234, name: 'Programming', creatorName: 'Andrew', type: 'txt'},
  {size: 32, name: 'CV', creatorName: 'Oleg', type: 'txt'},
  {size: 432, name: 'Rules', creatorName: 'Vitalii', type: 'txt'},
  {size: 522, name: 'Law', creatorName: 'Solomia', type: 'txt'},
  {size: 6223, name: 'CV2', creatorName: 'Sofia', type: 'pdf'},
  {size: 722, name: 'Nitrogen', creatorName: 'Taras', type: 'txt'},
  {size: 821, name: 'Oxygen', creatorName: 'Ivan', type: 'txt'},
  {size: 921, name: 'Fluorine', creatorName: 'Jon', type: 'txt'},
  {size: 10123, name: 'Neon', creatorName: 'Petro', type: 'pdf'},
  {size: 111, name: 'Sodium', creatorName: 'Vadym', type: 'pdf'},
  {size: 121, name: 'Magnesium', creatorName: 'Oleg', type: 'txt'},
  {size: 1313, name: 'Aluminum', creatorName: 'Ivan', type: 'txt'},
  {size: 142, name: 'Silicon', creatorName:'Ivan', type: 'txt'},
  {size: 151, name: 'Phosphorus', creatorName:'Oleg', type: 'txt'},
  {size: 161, name: 'Sulfur', creatorName: 'Orest', type: 'txt'},
  {size: 172, name: 'Chlorine', creatorName: 'Oleg', type: 'pdf'},
  {size: 181, name: 'Argon', creatorName: 'Ivan', type: 'pdf'},
  {size: 191, name: 'Potassium', creatorName: 'Yulia', type: 'txt'},
  {size: 205, name: 'Calcium', creatorName: 'Oleg', type: 'pdf'},
];