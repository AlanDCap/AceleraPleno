import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmmiterTwoComponent } from './emmiter-two.component';

describe('EmmiterTwoComponent', () => {
  let component: EmmiterTwoComponent;
  let fixture: ComponentFixture<EmmiterTwoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EmmiterTwoComponent]
    });
    fixture = TestBed.createComponent(EmmiterTwoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
