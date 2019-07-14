/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ApoliceAutomovelComponent } from './apolice-automovel.component';

describe('ApoliceAutomovelComponent', () => {
  let component: ApoliceAutomovelComponent;
  let fixture: ComponentFixture<ApoliceAutomovelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ApoliceAutomovelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ApoliceAutomovelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
