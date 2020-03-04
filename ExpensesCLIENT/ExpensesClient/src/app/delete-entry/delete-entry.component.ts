import { Component, OnInit } from '@angular/core';
import { Route } from '@angular/compiler/src/core';
import { ActivatedRoute } from '@angular/router';
import { EntryService } from '../entry.service';

@Component({
  selector: 'app-delete-entry',
  templateUrl: './delete-entry.component.html',
  styleUrls: ['./delete-entry.component.css']
})
export class DeleteEntryComponent implements OnInit {

  entry = {
    description: '',
    value: 0,
    isExpense: false
  }
  id;

  constructor(private route: ActivatedRoute,
              private service: EntryService) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    this.service.getEntry(this.id).subscribe((data:any) => {
      console.log(data);
      this.entry.description = data.Description;
      this.entry.isExpense = data.IsExpense;
      this.entry.value = data.Value;
    })
  }

  cancel() {
    console.log("Cansel button was clicked");
  }

  confirm() {
    console.log("Confirm button was clicked");
  }
}
