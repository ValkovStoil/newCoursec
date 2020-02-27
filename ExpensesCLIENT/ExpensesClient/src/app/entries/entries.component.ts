import { Component, OnInit } from '@angular/core';
import { EntryService } from '../entry.service';

@Component({
  selector: 'app-entries',
  templateUrl: './entries.component.html',
  styleUrls: ['./entries.component.css']
})
export class EntriesComponent implements OnInit {

  constructor(private service:EntryService) { }

  ngOnInit(): void {
    this.service.getAll().subscribe((data) => {
      console.log('Result - ', data);
    })
  }

}
