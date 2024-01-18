import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmmiterOneComponent } from './emmiter-one.component';

describe('EmmiterOneComponent', () => {
  let component: EmmiterOneComponent;
  let fixture: ComponentFixture<EmmiterOneComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EmmiterOneComponent]
    });
    fixture = TestBed.createComponent(EmmiterOneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
